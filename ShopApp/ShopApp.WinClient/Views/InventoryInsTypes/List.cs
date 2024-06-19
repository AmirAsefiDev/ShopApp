using ShopApp.Framework;
using ShopApp.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClient.Views.InventoryInsTypes
{
    public partial class List : ViewBase
    {
        GridControl<Entities.InventoryInsType> grid;

        IInventoryInsTypesRepository typesRepo;

        public List(IInventoryInsTypesRepository typesRepo)
        {
            InitializeComponent();
            this.typesRepo = typesRepo;

            AddAction("جدید",btn =>
            {
                var view = ViewEngine.ViewInForm<Editor>(null, true);

                if (view.DialogResult == DialogResult.OK)
                {
                    typesRepo.Add(view.Entity);
                    grid.AddItem(view.Entity);
                    grid.ResetBindings();
                }
            });

            AddAction("ویرایش", btn =>
            {
                var view = ViewEngine.ViewInForm<Editor>(v =>
                {
                    v.Entity = grid.CurrentItem;
                }, true);

                if (view.DialogResult == DialogResult.OK)
                {
                    typesRepo.Update(view.Entity);
                    grid.ResetBindings();
                }
            });

            AddAction("حذف", btn =>
            {
                if(MessageBox.Show("آیا حذف آیتم را تایید می کنید؟","حذف نوع رسید",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    typesRepo.Remove(grid.CurrentItem);
                    grid.RemoveCurrent();
                    grid.ResetBindings();
                }
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Entities.InventoryInsType>(this);
            grid.AddTextBoxColumn(type => type.Title, "عنوان");
            grid.SetDataSource(typesRepo.All());
            base.OnLoad(e);
        }

        public override string ViewTitle => "مدیریت انواع رسید";
    }
}
