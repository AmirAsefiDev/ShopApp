﻿using ShopApp.Framework;
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

namespace ShopApp.WinClient.Views.ProductCategories
{
    public partial class Parameters : ViewBase
    {
        public int ProductCategoryId { get; set; }
        public IProductParametersRepository paramsRepo;
        GridControl<Entities.ProductParameter> parametersGrid;

        public Parameters(IProductParametersRepository paramsRepo)
        {
            this.paramsRepo = paramsRepo;
            InitializeComponent();
            AddAction("جدید",btn => 
            {
                var view = ViewEngine.ViewInForm<ParameterEditor>(null,true);
                if(view.DialogResult == DialogResult.OK)
                {
                    view.Entity.ProductCategoryId = ProductCategoryId;
                    paramsRepo.Add(view.Entity);
                    parametersGrid.AddItem(view.Entity);
                    parametersGrid.ResetBindings();
                }
            });
            AddAction("ویرایش",btn => 
            {
                var view = ViewEngine.ViewInForm<ParameterEditor>(editor =>
                {
                    editor.Entity = parametersGrid.CurrentItem;
                },true );
                if(view.DialogResult == DialogResult.OK)
                {
                    paramsRepo.Update(view.Entity);
                    parametersGrid.ResetBindings();
                }
            });
            AddAction("حذف",btn => 
            {
                if(MessageBox.Show("آیا حذف را تائید می کنید؟","حذف پارامتر",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    parametersGrid.CurrentItem.Deleted = true;
                    parametersGrid.CurrentItem.DeletedDate = DateTime.Now;
                    paramsRepo.Update(parametersGrid.CurrentItem);
                    parametersGrid.RemoveCurrent();
                }
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            parametersGrid = new GridControl<Entities.ProductParameter>(this);
            parametersGrid.AddTextBoxColumn(p => p.Title, "عنوان");
            parametersGrid.AddTextBoxColumn(p => p.Key, "کلید");
            parametersGrid.SetDataSource(paramsRepo.GetByProductCategoryId(ProductCategoryId).Where(p => !p.Deleted));

            base.OnLoad(e);
        }

        public override string ViewTitle => "مدیریت پارامتر ها";
    }
}
