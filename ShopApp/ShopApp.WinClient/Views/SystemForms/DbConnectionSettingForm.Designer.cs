namespace ShopApp.WinClient.Views.SystemForms
{
    partial class DbConnectionSettingForm
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DataBaseLabel = new System.Windows.Forms.Label();
            this.UserIdCheckBox = new System.Windows.Forms.CheckBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.WaitingProgressBar = new System.Windows.Forms.ProgressBar();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsPanel.Controls.Add(this.WaitingProgressBar);
            this.ButtonsPanel.Controls.Add(this.CancelButton);
            this.ButtonsPanel.Controls.Add(this.AcceptButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 143);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(612, 57);
            this.ButtonsPanel.TabIndex = 8;
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(12, 12);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataSourceTextBox.Size = new System.Drawing.Size(446, 23);
            this.DataSourceTextBox.TabIndex = 1;
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.Location = new System.Drawing.Point(464, 12);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(124, 20);
            this.DataSourceLabel.TabIndex = 0;
            this.DataSourceLabel.Text = "نام سرور (Data Source)";
            this.DataSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 70);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(446, 23);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(12, 41);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserIdTextBox.Size = new System.Drawing.Size(446, 23);
            this.UserIdTextBox.TabIndex = 3;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(12, 99);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(446, 23);
            this.DatabaseTextBox.TabIndex = 7;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(464, 70);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(62, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "کلمه عبور";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBaseLabel
            // 
            this.DataBaseLabel.Location = new System.Drawing.Point(464, 99);
            this.DataBaseLabel.Name = "DataBaseLabel";
            this.DataBaseLabel.Size = new System.Drawing.Size(81, 20);
            this.DataBaseLabel.TabIndex = 6;
            this.DataBaseLabel.Text = "بانک اطلاعاتی";
            this.DataBaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.Location = new System.Drawing.Point(464, 41);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(93, 19);
            this.UserIdCheckBox.TabIndex = 2;
            this.UserIdCheckBox.Text = "شناسه کاربری";
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            this.UserIdCheckBox.CheckedChanged += new System.EventHandler(this.UserIdCheckBox_CheckedChanged);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 10);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(83, 36);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "تائید";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(100, 10);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 36);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "صرفنظر";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // WaitingProgressBar
            // 
            this.WaitingProgressBar.Location = new System.Drawing.Point(189, 16);
            this.WaitingProgressBar.Name = "WaitingProgressBar";
            this.WaitingProgressBar.Size = new System.Drawing.Size(410, 25);
            this.WaitingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.WaitingProgressBar.TabIndex = 2;
            // 
            // DbConnectionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 200);
            this.Controls.Add(this.UserIdCheckBox);
            this.Controls.Add(this.DataBaseLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.DataSourceLabel);
            this.Controls.Add(this.DataSourceTextBox);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbConnectionSettingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات ارتباط با بانک اطلاعاتی";
            this.Load += new System.EventHandler(this.DbConnectionSettingForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label DataBaseLabel;
        private System.Windows.Forms.CheckBox UserIdCheckBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.ProgressBar WaitingProgressBar;
    }
}