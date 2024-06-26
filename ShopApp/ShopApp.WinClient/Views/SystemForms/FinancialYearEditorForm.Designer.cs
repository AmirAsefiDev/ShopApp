﻿namespace ShopApp.WinClient.Views.SystemForms
{
    partial class FinancialYearEditorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.StartDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.FinishDateLabel = new System.Windows.Forms.Label();
            this.FinishDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.AcceptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 49);
            this.panel1.TabIndex = 8;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(93, 10);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 27);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "صرفنظر";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 10);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 27);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "تائید";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(438, 23);
            this.TitleTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(456, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(86, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "عنوان سال مالی";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(456, 44);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(54, 15);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "توضیحات";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 41);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(438, 92);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // StartDateMaskedTextBox
            // 
            this.StartDateMaskedTextBox.Location = new System.Drawing.Point(12, 139);
            this.StartDateMaskedTextBox.Mask = "0000/00/00";
            this.StartDateMaskedTextBox.Name = "StartDateMaskedTextBox";
            this.StartDateMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDateMaskedTextBox.Size = new System.Drawing.Size(438, 23);
            this.StartDateMaskedTextBox.TabIndex = 5;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(456, 142);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(60, 15);
            this.StartDateLabel.TabIndex = 4;
            this.StartDateLabel.Text = "تاریخ شروع";
            // 
            // FinishDateLabel
            // 
            this.FinishDateLabel.AutoSize = true;
            this.FinishDateLabel.Location = new System.Drawing.Point(456, 171);
            this.FinishDateLabel.Name = "FinishDateLabel";
            this.FinishDateLabel.Size = new System.Drawing.Size(56, 15);
            this.FinishDateLabel.TabIndex = 6;
            this.FinishDateLabel.Text = "تاریخ پایان";
            // 
            // FinishDateMaskedTextBox
            // 
            this.FinishDateMaskedTextBox.Location = new System.Drawing.Point(12, 168);
            this.FinishDateMaskedTextBox.Mask = "0000/00/00";
            this.FinishDateMaskedTextBox.Name = "FinishDateMaskedTextBox";
            this.FinishDateMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FinishDateMaskedTextBox.Size = new System.Drawing.Size(438, 23);
            this.FinishDateMaskedTextBox.TabIndex = 7;
            // 
            // FinancialYearEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(548, 273);
            this.Controls.Add(this.FinishDateLabel);
            this.Controls.Add(this.FinishDateMaskedTextBox);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.StartDateMaskedTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinancialYearEditorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinancialYearEditorForm";
            this.Load += new System.EventHandler(this.FinancialYearEditorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.MaskedTextBox StartDateMaskedTextBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FinishDateLabel;
        private System.Windows.Forms.MaskedTextBox FinishDateMaskedTextBox;
    }
}