using ShopApp.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClient.Views.Inventories
{
    public partial class Editor : EntityEditor<Entities.Inventory>
    {
        RepositoryAbstracts.ICorporationsRepository CorpsRepo;

        public Editor(RepositoryAbstracts.ICorporationsRepository CorpsRepo)
        {
            this.CorpsRepo = CorpsRepo; 
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ComboBox(inv => inv.CorporationId, "شرکت/سازمان", CorpsRepo.All(), corp => corp.Title, corp => corp.Id);
            TextBox(inv => inv.Title,"عنوان انبار");
            TextBox(inv => inv.Description, "توضیحات",true);
            AdjustControls();
            base.OnLoad(e);
        }
    }
}
