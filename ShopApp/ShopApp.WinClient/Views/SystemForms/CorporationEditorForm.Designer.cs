namespace ShopApp.WinClient.Views.SystemForms
{
    partial class CorporationEditorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.FaxTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.FaxLabel = new System.Windows.Forms.Label();
            this.ButtonsBarPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ButtonsBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(22, 12);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(409, 25);
            this.TitleTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(434, 15);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(59, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "نام سازمان";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(21, 8);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(88, 32);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "تائید ";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(22, 43);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(409, 107);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(434, 48);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(54, 15);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "توضیحات";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(22, 156);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(409, 101);
            this.AddressTextBox.TabIndex = 5;
            // 
            // Addresslabel
            // 
            this.Addresslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Location = new System.Drawing.Point(434, 162);
            this.Addresslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(34, 15);
            this.Addresslabel.TabIndex = 4;
            this.Addresslabel.Text = "آدرس";
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TelephoneTextBox.Location = new System.Drawing.Point(22, 264);
            this.TelephoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TelephoneTextBox.Multiline = true;
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TelephoneTextBox.Size = new System.Drawing.Size(409, 29);
            this.TelephoneTextBox.TabIndex = 7;
            // 
            // FaxTextBox
            // 
            this.FaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FaxTextBox.Location = new System.Drawing.Point(22, 297);
            this.FaxTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FaxTextBox.Multiline = true;
            this.FaxTextBox.Name = "FaxTextBox";
            this.FaxTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FaxTextBox.Size = new System.Drawing.Size(409, 29);
            this.FaxTextBox.TabIndex = 9;
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Location = new System.Drawing.Point(434, 269);
            this.TelephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(68, 15);
            this.TelephoneLabel.TabIndex = 6;
            this.TelephoneLabel.Text = "شماره تماس";
            // 
            // FaxLabel
            // 
            this.FaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FaxLabel.AutoSize = true;
            this.FaxLabel.Location = new System.Drawing.Point(434, 302);
            this.FaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FaxLabel.Name = "FaxLabel";
            this.FaxLabel.Size = new System.Drawing.Size(33, 15);
            this.FaxLabel.TabIndex = 8;
            this.FaxLabel.Text = "فکس";
            // 
            // ButtonsBarPanel
            // 
            this.ButtonsBarPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsBarPanel.Controls.Add(this.CancelButton);
            this.ButtonsBarPanel.Controls.Add(this.AcceptButton);
            this.ButtonsBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsBarPanel.Location = new System.Drawing.Point(0, 343);
            this.ButtonsBarPanel.Name = "ButtonsBarPanel";
            this.ButtonsBarPanel.Size = new System.Drawing.Size(516, 50);
            this.ButtonsBarPanel.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(117, 8);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 32);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "صرفنظر";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CorporationEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 393);
            this.Controls.Add(this.ButtonsBarPanel);
            this.Controls.Add(this.FaxLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.FaxTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CorporationEditorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شرکت/سازمان";
            this.Load += new System.EventHandler(this.CorporationEditorForm_Load);
            this.ButtonsBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox FaxTextBox;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label FaxLabel;
        private System.Windows.Forms.Panel ButtonsBarPanel;
        private System.Windows.Forms.Button CancelButton;
    }
}