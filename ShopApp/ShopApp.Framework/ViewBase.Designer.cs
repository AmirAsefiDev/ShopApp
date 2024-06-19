namespace ShopApp.Framework
{
    partial class ViewBase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonsBarPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ButtonsBarPanel
            // 
            this.ButtonsBarPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonsBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsBarPanel.Location = new System.Drawing.Point(0, 350);
            this.ButtonsBarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonsBarPanel.Name = "ButtonsBarPanel";
            this.ButtonsBarPanel.Size = new System.Drawing.Size(662, 39);
            this.ButtonsBarPanel.TabIndex = 0;
            this.ButtonsBarPanel.Visible = false;
            // 
            // ViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonsBarPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewBase";
            this.Size = new System.Drawing.Size(662, 389);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsBarPanel;
    }
}
