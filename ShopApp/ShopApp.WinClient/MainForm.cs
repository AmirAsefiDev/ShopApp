using System;

namespace ShopApp.WinClient
{
    public partial class MainForm : Framework.MainFormBase
    {
        public MainForm()
        {

            InitializeComponent(); 
            Text = "مدیریت انبار و فروش";
            TypesRegistery = new IoC.TypesRegistry();
            var baseInfo = AddMenu("اطلاعات پایه");
            baseInfo.AddMenu("شرکت ها", null, (s, e) =>
            {
                ViewEngine.ViewInTab<Views.Corps.List>();
            });
            baseInfo.AddMenu("سال های مالی", null , (s, e) =>
            {
                ViewEngine.ViewInTab<Views.FinancialYears.List>();
            });
            baseInfo.AddMenu("واحد های اندازه گیری", null, (s, e) =>
            {
                ViewEngine.ViewInTab<Views.ProductUnits.List>();
            });
            baseInfo.AddSeparator();
            baseInfo.AddMenu("انبار ها",null,(s, e) => ViewEngine.ViewInTab<Views.Inventories.List>());
            baseInfo.AddMenu("دسته بندی محصولات",null, (s , e) => ViewEngine.ViewInTab<Views.ProductCategories.List>());
            baseInfo.AddMenu("محصولات",null,(s,e) => ViewEngine.ViewInTab<Views.Products.List>());
            baseInfo.AddMenu("انواع رسید",null,(s,e)=>ViewEngine.ViewInTab<Views.InventoryInsTypes.List>());

            var inventoryMenu = AddMenu("انبار");

            inventoryMenu.AddMenu("رسید ها", null, (s, e) =>
            {
                ViewEngine.ViewInTab<Views.InventoryIns.List>();
            });
        }


    }
}
