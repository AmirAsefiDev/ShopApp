using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{

    public partial class ViewBase : UserControl
    {
        public ViewBase()
        {
            InitializeComponent();
        }

        public DialogResult DialogResult { get; set; }

        public virtual string ViewTitle { get; }

        public virtual string ViewIdentifier 
        { 
            get { return this.GetType().FullName; }
        }

        protected void CloseView(DialogResult? dialogResult = null)
        {
            ViewEngine.CloseView(this,dialogResult);
        }

        protected Button AddAction(string title,Action<Button> onClick)
        {
            if(!ButtonsBarPanel.Visible)
                ButtonsBarPanel.Visible = true;
            var button = new Button();
            button.Text = title;
            button.Click += (obj, e) =>
            {
                onClick(button);
            };
            var totalButtons = ButtonsBarPanel.Controls.Count;
            var left = ((totalButtons + 1) * 5) + (totalButtons * 85);
            button.Location = new Point( left , 6 );
            button.Size = new Size(85, 25);
            ButtonsBarPanel.Controls.Add(button);
            return button;
        }

        public ViewEngine ViewEngine
        {
            get;
            internal set;
        }
    }
}
