namespace ShopApp.Framework
{
    partial class Dropdown
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
            this.ShowDropdownButton = new System.Windows.Forms.Button();
            this.DropDownInputMaskedEdit = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ShowDropdownButton
            // 
            this.ShowDropdownButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDropdownButton.Location = new System.Drawing.Point(0, 1);
            this.ShowDropdownButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowDropdownButton.Name = "ShowDropdownButton";
            this.ShowDropdownButton.Size = new System.Drawing.Size(73, 29);
            this.ShowDropdownButton.TabIndex = 0;
            this.ShowDropdownButton.Text = "▼";
            this.ShowDropdownButton.UseVisualStyleBackColor = true;
            this.ShowDropdownButton.Click += new System.EventHandler(this.ShowDropdownButton_Click);
            // 
            // DropDownInputMaskedEdit
            // 
            this.DropDownInputMaskedEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownInputMaskedEdit.Location = new System.Drawing.Point(72, 4);
            this.DropDownInputMaskedEdit.Name = "DropDownInputMaskedEdit";
            this.DropDownInputMaskedEdit.Size = new System.Drawing.Size(279, 23);
            this.DropDownInputMaskedEdit.TabIndex = 2;
            // 
            // Dropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DropDownInputMaskedEdit);
            this.Controls.Add(this.ShowDropdownButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dropdown";
            this.Size = new System.Drawing.Size(351, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowDropdownButton;
        private System.Windows.Forms.MaskedTextBox DropDownInputMaskedEdit;
    }
}
