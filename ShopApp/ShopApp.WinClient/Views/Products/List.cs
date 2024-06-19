using ShopApp.Entities;
using ShopApp.RepositoryAbstracts;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShopApp.WinClient.Views.Products
{
    public partial class List : Framework.ViewBase
    {
        IProductsRepository productsRepo;
        IProductParametersRepository paramsRepo;
        IProductParametersValuesRepository paramsValuesRepo;

        public int? ProductCategoryId { get; set; }

        public bool SelectorMode { get; set; }

        public Product SelectedProduct { get; set; }

        Framework.GridControl<Entities.Product> productsGrid;

        public List(IProductsRepository productsRepo, IProductParametersRepository paramsRepo, IProductParametersValuesRepository paramsValuesRepo)
        {
            InitializeComponent();
            this.productsRepo = productsRepo;
            this.paramsRepo = paramsRepo;
            this.paramsValuesRepo = paramsValuesRepo;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!SelectorMode)
            {

                AddAction("جدید", btn =>
                {
                    var view = ViewEngine.ViewInForm<Editor>(null, true);
                    if (view.DialogResult == DialogResult.OK)
                    {
                        productsRepo.Add(view.Entity);
                        productsGrid.AddItem(view.Entity);
                        productsGrid.ResetBindings();
                    }
                });
                AddAction("ویرایش", btn =>
                {
                    var view = ViewEngine.ViewInForm<Editor>(editor =>
                    {
                        editor.Entity = productsGrid.CurrentItem;
                    }, true);
                    if (view.DialogResult == DialogResult.OK)
                    {
                        productsRepo.Update(view.Entity);
                        var oldParameters = paramsValuesRepo.GetByProductId(view.Entity.Id);

                        foreach (var param in oldParameters)
                        {
                            paramsValuesRepo.Remove(param);
                        }

                        foreach (var param in view.ParametersControls)
                        {
                            paramsValuesRepo.Add(new Entities.ProductParametersValue
                            {
                                ProductId = view.Entity.Id,
                                ProductParameterId = param.Key.Id,
                                Value = param.Value.Text
                            });

                        }
                        productsGrid.ResetBindings();
                    }
                });
                AddAction("حذف", btn =>
                {
                    if (MessageBox.Show("آیا حذف را تائید؟", "حذف محصول", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        productsRepo.Remove(productsGrid.CurrentItem);
                        productsGrid.RemoveCurrent();
                        productsGrid.ResetBindings();
                    }
                });

            }
            else
            {
                AddAction("انتخاب", btn =>
                {
                    SelectedProduct = productsGrid.CurrentItem;
                    CloseView(DialogResult.OK);
                });
                AddAction("صرفنظر", btn =>
                {
                    CloseView(DialogResult.Cancel);
                });    
            }

            productsGrid = new Framework.GridControl<Entities.Product>(this);
            productsGrid.AddTextBoxColumn(p => p.ProductCategoryId, "دسته بندی");
            productsGrid.AddTextBoxColumn(p => p.Title, "عنوان محصول");
            if (ProductCategoryId.HasValue)
                productsGrid.SetDataSource(productsRepo.GetByProductCategoryId(ProductCategoryId.Value));
            else
                productsGrid.SetDataSource(productsRepo.All());
            base.OnLoad(e);
        }
        public override string ViewTitle
        {
            get { return SelectorMode ? "انتخاب محصول" : "مدیریت محصولات"; }
        }
    }
}
