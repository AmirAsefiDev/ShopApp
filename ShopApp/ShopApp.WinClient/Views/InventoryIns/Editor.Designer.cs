namespace ShopApp.WinClient.Views.InventoryIns
{
    partial class Editor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridContainerPanel = new System.Windows.Forms.Panel();
            this.ControlsContainerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateDropdown = new ShopApp.Framework.Dropdown();
            this.InsTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InventoriesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.ControlsContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridContainerPanel);
            this.panel1.Controls.Add(this.ControlsContainerPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 500);
            this.panel1.TabIndex = 1;
            // 
            // GridContainerPanel
            // 
            this.GridContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridContainerPanel.Location = new System.Drawing.Point(0, 136);
            this.GridContainerPanel.Name = "GridContainerPanel";
            this.GridContainerPanel.Size = new System.Drawing.Size(899, 364);
            this.GridContainerPanel.TabIndex = 3;
            // 
            // ControlsContainerPanel
            // 
            this.ControlsContainerPanel.Controls.Add(this.label2);
            this.ControlsContainerPanel.Controls.Add(this.label5);
            this.ControlsContainerPanel.Controls.Add(this.DescriptionTextBox);
            this.ControlsContainerPanel.Controls.Add(this.label4);
            this.ControlsContainerPanel.Controls.Add(this.TitleTextBox);
            this.ControlsContainerPanel.Controls.Add(this.label3);
            this.ControlsContainerPanel.Controls.Add(this.DateDropdown);
            this.ControlsContainerPanel.Controls.Add(this.InsTypeComboBox);
            this.ControlsContainerPanel.Controls.Add(this.label1);
            this.ControlsContainerPanel.Controls.Add(this.InventoriesComboBox);
            this.ControlsContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsContainerPanel.Name = "ControlsContainerPanel";
            this.ControlsContainerPanel.Size = new System.Drawing.Size(899, 136);
            this.ControlsContainerPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "نوع رسید";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "توضیحات";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(19, 70);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(811, 60);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "عنوان رسید";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(19, 38);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(811, 23);
            this.TitleTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاریخ";
            // 
            // DateDropdown
            // 
            this.DateDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDropdown.InputMask = "";
            this.DateDropdown.Location = new System.Drawing.Point(18, 3);
            this.DateDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateDropdown.Name = "DateDropdown";
            this.DateDropdown.Size = new System.Drawing.Size(381, 29);
            this.DateDropdown.TabIndex = 4;
            this.DateDropdown.Value = "";
            // 
            // InsTypeComboBox
            // 
            this.InsTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InsTypeComboBox.FormattingEnabled = true;
            this.InsTypeComboBox.Location = new System.Drawing.Point(456, 8);
            this.InsTypeComboBox.Name = "InsTypeComboBox";
            this.InsTypeComboBox.Size = new System.Drawing.Size(155, 23);
            this.InsTypeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(834, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "انتخاب انبار";
            // 
            // InventoriesComboBox
            // 
            this.InventoriesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InventoriesComboBox.FormattingEnabled = true;
            this.InventoriesComboBox.Location = new System.Drawing.Point(675, 8);
            this.InventoriesComboBox.Name = "InventoriesComboBox";
            this.InventoriesComboBox.Size = new System.Drawing.Size(155, 23);
            this.InventoriesComboBox.TabIndex = 0;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Editor";
            this.Size = new System.Drawing.Size(899, 539);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ControlsContainerPanel.ResumeLayout(false);
            this.ControlsContainerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel GridContainerPanel;
        private System.Windows.Forms.Panel ControlsContainerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label3;
        private Framework.Dropdown DateDropdown;
        private System.Windows.Forms.ComboBox InsTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InventoriesComboBox;
    }
}
