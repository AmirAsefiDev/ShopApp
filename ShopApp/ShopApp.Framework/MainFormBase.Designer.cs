﻿namespace ShopApp.Framework
{
    partial class MainFormBase
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
            this.components = new System.ComponentModel.Container();
            this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CloseCurrentTab = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBarStrip
            // 
            this.StatusBarStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBarStrip.Location = new System.Drawing.Point(0, 415);
            this.StatusBarStrip.Name = "StatusBarStrip";
            this.StatusBarStrip.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            this.StatusBarStrip.Size = new System.Drawing.Size(593, 22);
            this.StatusBarStrip.TabIndex = 0;
            this.StatusBarStrip.Text = "StatusStrip";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(593, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Interval = 1000;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "صفحه نخست";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // CloseCurrentTab
            // 
            this.CloseCurrentTab.AutoSize = true;
            this.CloseCurrentTab.Location = new System.Drawing.Point(6, 28);
            this.CloseCurrentTab.Name = "CloseCurrentTab";
            this.CloseCurrentTab.Size = new System.Drawing.Size(14, 15);
            this.CloseCurrentTab.TabIndex = 3;
            this.CloseCurrentTab.TabStop = true;
            this.CloseCurrentTab.Text = "X";
            this.CloseCurrentTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseCurrentTab_LinkClicked);
            // 
            // MainFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 437);
            this.Controls.Add(this.CloseCurrentTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusBarStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainFormBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی برنامه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBarStrip;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.LinkLabel CloseCurrentTab;
    }
}