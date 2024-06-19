using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public class ViewEngine
    {
        private TabControl tabControl;
        private Registry typesRegistray;

        public ViewEngine(TabControl tabControl, StructureMap.Registry registry)
        {
            this.tabControl = tabControl;
            this.typesRegistray = registry;
        }

        private Dictionary<string, TabPage> openTabs = new Dictionary<string, TabPage>();
        private Dictionary<string, Form> openForms = new Dictionary<string, Form>();

        public T ViewInTab<T>(Action<T> initializer = null) where T : ViewBase
        {
            var container = new StructureMap.Container(typesRegistray);
            var viewInstance = container.GetInstance<T>();
            viewInstance.ViewEngine = this;
            if (initializer != null)
                initializer(viewInstance);
            if (openTabs.ContainsKey(viewInstance.ViewIdentifier))
            {
                var currentTabs = openTabs[viewInstance.ViewIdentifier];
                tabControl.SelectedTab = currentTabs;
                return currentTabs.Controls.OfType<T>().First();
            }
                TabPage tabPage = new TabPage();
                tabPage.Text = viewInstance.ViewTitle;
                tabPage.Controls.Add(viewInstance);
                viewInstance.Dock = DockStyle.Fill; 
                tabControl.TabPages.Add(tabPage);
            openTabs.Add(viewInstance.ViewIdentifier, tabPage);
            return (T)viewInstance;
        }

        public void CloseViewTab(TabPage selectedTab)
        {
            var currentView = selectedTab.Controls.OfType<ViewBase>().FirstOrDefault();
            if (currentView != null)
            {
                var ViewIdentifier = currentView.ViewIdentifier;
                if (openTabs.ContainsKey(ViewIdentifier))
                {
                    openTabs.Remove(ViewIdentifier);
                }
            }
                tabControl.TabPages.Remove(selectedTab);
        }

        internal void CloseView(ViewBase viewBase, DialogResult? dialogResult = null)
        {
            if (openForms.ContainsKey(viewBase.ViewIdentifier))
            {
                if (dialogResult.HasValue)
                {
                    openForms[viewBase.ViewIdentifier].DialogResult = dialogResult.Value;
                    viewBase.DialogResult = dialogResult.Value;
                    if (!openForms[viewBase.ViewIdentifier].Modal)
                        openForms[viewBase.ViewIdentifier].Close();
                }
                else
                    openForms[viewBase.ViewIdentifier].Close();
                openForms.Remove(viewBase.ViewIdentifier);
            }
            else if (openTabs.ContainsKey(viewBase.ViewIdentifier))
            {
                tabControl.TabPages.Remove(openTabs[viewBase.ViewIdentifier]);
                openTabs.Remove(viewBase.ViewIdentifier);
            }
        }

        public T ViewInForm<T>(Action<T> Initializer = null , bool displayAsDialog = false) where T : ViewBase
        {
            var container = new StructureMap.Container(typesRegistray);
            var viewInstance = container.GetInstance<T>();
            viewInstance.ViewEngine = this;
            if(Initializer != null)
                Initializer(viewInstance);
            if (openForms.ContainsKey(viewInstance.ViewIdentifier))
            {
                var currentForm = openForms[viewInstance.ViewIdentifier];
                currentForm.Activate();
                return (T)currentForm.Controls.OfType<ViewBase>().First();
            }
            var form = new Form();
            form.Width = 850;
            form.Height = 600;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.RightToLeft = RightToLeft.Yes;
            form.Text = viewInstance.ViewTitle;
            form.Controls.Add(viewInstance);
            form.FormBorderStyle = FormBorderStyle.Sizable;
            viewInstance.Dock = DockStyle.Fill;
            openForms.Add(viewInstance.ViewIdentifier, form);
            form.FormClosed += (obj, e) =>
            {
                openForms.Remove(viewInstance.ViewIdentifier);
            };
            if (displayAsDialog)    
                form.ShowDialog(); 
            else
            {
                form.Show();
            }

            return (T)viewInstance;
        }
    }
}
