using ShopApp.Entities;
using ShopApp.Framework;
using ShopApp.Framework.ExtensionMethods;
using ShopApp.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ShopApp.WinClient.Views.InventoryIns
{
    public partial class Editor : ViewBase
    {
        public InventoryInsHeader InvHeader { get; set; }

        IInventoriesRepository invRepo;
        IInventoryInsTypesRepository typesRepo;

        IInventoryInsHeaderRepository insRepo;
        IInventoryInsDetailsRepository detailsRepo;

        GridControl<Entities.InventoryInsDetail> grid;

        List<InventoryInsDetail> details = new List<InventoryInsDetail>();

        public Editor(IInventoriesRepository invRepo, IInventoryInsTypesRepository typesRepo, IInventoryInsHeaderRepository insRepo, IInventoryInsDetailsRepository detailsRepo)
        {
            this.invRepo = invRepo;
            this.typesRepo = typesRepo;

            this.insRepo = insRepo;
            this.detailsRepo = detailsRepo;
            InitializeComponent();

            InventoriesComboBox.DataSource = this.invRepo.All();
            InventoriesComboBox.DisplayMember = "Title";
            InventoriesComboBox.ValueMember = "Id";

            InsTypeComboBox.DataSource = this.typesRepo.All();
            InsTypeComboBox.DisplayMember = "Title";
            InsTypeComboBox.ValueMember = "Id";

            AddAction("تائید", btn =>
            {
                if (InvHeader.Id == 0)
                    insRepo.Add(InvHeader);
                else
                        insRepo.Update(InvHeader);



                var oldItems = detailsRepo.GetByInventoryInsHeaderId(InvHeader.Id);

                foreach (var item in oldItems)
                {
                    details.Remove(item);
                }

                foreach (var item in details)
                {
                    item.InventoryInsHeaderId = InvHeader.Id;
                    //grid.CurrentItem.ProductId = item.ProductId;

                    //if (grid.CurrentItem.ProductId != item.ProductId)
                    detailsRepo.Add(item);
                    //else
                    //    MessageBox.Show("محصول دیگری را انتخاب کنید شما این محصول قبلا انتخاب کرده اید");
                }
                CloseView(DialogResult.OK);
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            if (InvHeader == null)
                InvHeader = new Entities.InventoryInsHeader { Date = DateTime.Now };

            InventoriesComboBox.DataBindings.Add("SelectedValue", InvHeader, "InventoryId");
            InsTypeComboBox.DataBindings.Add("SelectedValue", InvHeader, "TypeId");
            TitleTextBox.DataBindings.Add("Text", InvHeader, "Title");
            DescriptionTextBox.DataBindings.Add("Text", InvHeader, "Description");

            Expression<Func<Entities.InventoryInsHeader, DateTime>> selector = header => header.Date;
            var propertyName = new ExpressionHandler().GetPropertyName(selector);
            DateDropdown.Value = selector.Compile()(InvHeader).ToString("yyyy/MM/dd");
            DateDropdown.InputMask = "0000/00/00";
            DateDropdown.RightToLeft = RightToLeft.No;
            DateDropdown.Tag = selector.Compile()(InvHeader);
            DateDropdown.OnValueChanged += (obj, args) =>
            {
                DateDropdown.Tag = DateDropdown.Value.ConvertToDate();
                InvHeader.GetType().GetProperty(propertyName).SetValue(InvHeader, DateDropdown.Tag);
            };
            DateDropdown.GetDropdownControl += () =>
            {
                var picker = new Framework.DateTimePicker();
                picker.OnDateDoubleClick += (obj, args) =>
                {
                    DateDropdown.CloseDropdown();
                };

                if (DateDropdown.Tag != null)
                {
                    picker.SelectedDate = (DateTime)DateDropdown.Tag;
                }
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    DateDropdown.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    DateDropdown.Tag = picker.SelectedDate;
                    InvHeader.GetType().GetProperty(propertyName).SetValue(InvHeader, DateDropdown.Tag);
                };
                return picker;
            };
            grid = new GridControl<Entities.InventoryInsDetail>(GridContainerPanel);
            grid.AddTextBoxColumn(detail => detail.ProductId, "شناسه محصول");
            grid.AddButtonColumn("انتخاب", row =>
            {
                var view = ViewEngine.ViewInForm<Views.Products.List>(v =>
                {
                    v.SelectorMode = true;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    row.Cells[0].Value = view.SelectedProduct.Id;
                }
            });
            grid.AddTextBoxColumn(detail => detail.Amount, "مقدار");
            grid.AddTextBoxColumn(detail => detail.TotalPrice, "قیمت");

            grid.AllowAddRows = true;
            grid.AllowDeleteRows = true;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;

            grid.SetDataSource(details);
            base.OnLoad(e);
        }
    }
}
