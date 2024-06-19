using ShopApp.Entities;
using ShopApp.Framework;
using ShopApp.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopApp.WinClient.Views.ProductCategories
{
    public partial class List : ViewBase
    {
        IProductCategoriesRepository catRepo;
        TreeControl<ProductCategory> treeControl;

        public List(IProductCategoriesRepository catRepo)
        {       

            InitializeComponent();
            this.catRepo = catRepo;
            AddAction("جدید ریشه", btn =>
            {
                var view = ViewEngine.ViewInForm<Editor>(editor => {},true);
                if(view.DialogResult == DialogResult.OK)
                {
                    catRepo.Add(view.Entity);
                    treeControl.InitRoots();
                }
            });
            AddAction("جدید",btn =>
            {
                var view = ViewEngine.ViewInForm<Editor>(editor =>
                {
                    editor.ParentCategory = treeControl.SelectedObject;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    catRepo.Add(view.Entity);
                    treeControl.InitRoots();
                }
            });
            AddAction("ویرایش", btn =>
            {
                var view = ViewEngine.ViewInForm<Editor>(editor =>
                {
                    editor.Entity = treeControl.SelectedObject;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    catRepo.Update(view.Entity);
                    treeControl.InitRoots();
                }
            });
            AddAction("حذف",btn => 
            {
                if (MessageBox.Show($"را تائید می کنید؟ {treeControl.SelectedObject.Title} آیا حذف ", "حذف محصول ",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    treeControl.SelectedObject.Deleted = true;
                    treeControl.SelectedObject.DeletedDate = DateTime.Now;
                    catRepo.Update(treeControl.SelectedObject);
                    treeControl.InitRoots();
                }
            });
            AddAction("پارامتر ها", btn => 
            {
                if (treeControl.SelectedObject == null)
                    return;
                ViewEngine.ViewInForm<Parameters>(view =>
                {
                    view.ProductCategoryId = treeControl.SelectedObject.Id;
                },true);
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            treeControl = new TreeControl<ProductCategory>(this);
            treeControl.OnGetNodes += TreeControl_OnGetNodes;
            treeControl.InitRoots();
            base.OnLoad(e);
        }

        private IEnumerable<TreeControlNode<ProductCategory>> TreeControl_OnGetNodes(TreeNode parent, ProductCategory obj)
        {
            List<TreeControlNode<ProductCategory>> nodes = new List<TreeControlNode<ProductCategory>>();
            if (parent == null)
            {
                var rootCategories = catRepo.GetByParentCategoryId(null);
                return rootCategories.Where(cat => !cat.Deleted).Select(cat => new TreeControlNode<ProductCategory>()
                {
                    Text = cat.Title,
                    Object = cat
                });
            }
            else
            {
                var parentCategory = obj;
                var rootCateGories = catRepo.GetByParentCategoryId(parentCategory.Id);
                return rootCateGories.Where(cat => !cat.Deleted).Select(cat => new TreeControlNode<ProductCategory>()
                {                    
                    Text = cat.Title,
                    Object = cat
                });
            }
        }

        public override string ViewTitle => "مدیریت دسته بندی محصولات";
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
    }
}
