using ShopApp.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShopApp.WinClient.Views.InventoryIns
{
    public partial class List : ViewBase
    {
        GridControl<Entities.InventoryInsHeader> grid;

        IInventoryInsHeaderRepository headersRepo;
        IInventoryInsDetailsRepository detailsRepo;

        List<InventoryInsDetail> details = new List<InventoryInsDetail>();

        public List(IInventoryInsHeaderRepository headersRepo, IInventoryInsDetailsRepository detailsRepo)
        {
            InitializeComponent();
            this.headersRepo = headersRepo;
            this.detailsRepo = detailsRepo;

            AddAction("جدید",btn =>
            {
                var view = ViewEngine.ViewInForm<Editor>(null,true);
                grid.SetDataSource(headersRepo.All());
                grid.ResetBindings();
            });
            AddAction("ویرایش", btn =>
            {

                var view = ViewEngine.ViewInForm<Editor>(editor =>
                {
                    editor.InvHeader = grid.CurrentItem;
                }, true);
                if(view.DialogResult == DialogResult.OK)
                {                    
                    headersRepo.Update(view.InvHeader);
                    grid.ResetBindings();
                }

            });
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Entities.InventoryInsHeader>(this);
            grid.AddTextBoxColumn(ins => ins.Title, "عنوان");
            grid.AddTextBoxColumn(ins => ins.Date,"تاریخ");
            grid.SetDataSource(headersRepo.All());

            base.OnLoad(e);
        }

        public override string ViewTitle => "مدیریت رسید ها";
    }
}
