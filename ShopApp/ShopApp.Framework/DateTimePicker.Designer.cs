﻿namespace ShopApp.Framework
{
    partial class DateTimePicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentCalendarLabel = new System.Windows.Forms.Label();
            this.LastYearButton = new System.Windows.Forms.Button();
            this.LastMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.GotoTodayButton = new System.Windows.Forms.Button();
            this.GotoSelectedDateButton = new System.Windows.Forms.Button();
            this.SelectedDatelabel = new System.Windows.Forms.Label();
            this.CalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.Day1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.CurrentCalendarLabel);
            this.TopPanel.Controls.Add(this.LastYearButton);
            this.TopPanel.Controls.Add(this.LastMonthButton);
            this.TopPanel.Controls.Add(this.NextMonthButton);
            this.TopPanel.Controls.Add(this.NextYearButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(500, 52);
            this.TopPanel.TabIndex = 0;
            // 
            // CurrentCalendarLabel
            // 
            this.CurrentCalendarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCalendarLabel.Location = new System.Drawing.Point(206, 12);
            this.CurrentCalendarLabel.Name = "CurrentCalendarLabel";
            this.CurrentCalendarLabel.Size = new System.Drawing.Size(89, 30);
            this.CurrentCalendarLabel.TabIndex = 4;
            this.CurrentCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastYearButton
            // 
            this.LastYearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastYearButton.Location = new System.Drawing.Point(398, 11);
            this.LastYearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastYearButton.Name = "LastYearButton";
            this.LastYearButton.Size = new System.Drawing.Size(88, 27);
            this.LastYearButton.TabIndex = 3;
            this.LastYearButton.Text = "سال قبل";
            this.LastYearButton.UseVisualStyleBackColor = true;
            this.LastYearButton.Click += new System.EventHandler(this.LastYearButton_Click);
            // 
            // LastMonthButton
            // 
            this.LastMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastMonthButton.Location = new System.Drawing.Point(302, 11);
            this.LastMonthButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastMonthButton.Name = "LastMonthButton";
            this.LastMonthButton.Size = new System.Drawing.Size(88, 27);
            this.LastMonthButton.TabIndex = 2;
            this.LastMonthButton.Text = "ماه قبل";
            this.LastMonthButton.UseVisualStyleBackColor = true;
            this.LastMonthButton.Click += new System.EventHandler(this.LastMonthButton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Location = new System.Drawing.Point(111, 11);
            this.NextMonthButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(88, 27);
            this.NextMonthButton.TabIndex = 1;
            this.NextMonthButton.Text = "ماه بعد";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // NextYearButton
            // 
            this.NextYearButton.Location = new System.Drawing.Point(15, 11);
            this.NextYearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(88, 27);
            this.NextYearButton.TabIndex = 0;
            this.NextYearButton.Text = "سال بعد";
            this.NextYearButton.UseVisualStyleBackColor = true;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.GotoTodayButton);
            this.BottomPanel.Controls.Add(this.GotoSelectedDateButton);
            this.BottomPanel.Controls.Add(this.SelectedDatelabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 326);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(500, 56);
            this.BottomPanel.TabIndex = 1;
            // 
            // GotoTodayButton
            // 
            this.GotoTodayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GotoTodayButton.Location = new System.Drawing.Point(398, 13);
            this.GotoTodayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GotoTodayButton.Name = "GotoTodayButton";
            this.GotoTodayButton.Size = new System.Drawing.Size(88, 27);
            this.GotoTodayButton.TabIndex = 7;
            this.GotoTodayButton.Text = "تاریخ امروز";
            this.GotoTodayButton.UseVisualStyleBackColor = true;
            this.GotoTodayButton.Click += new System.EventHandler(this.GotoTodayButton_Click);
            // 
            // GotoSelectedDateButton
            // 
            this.GotoSelectedDateButton.Location = new System.Drawing.Point(15, 13);
            this.GotoSelectedDateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GotoSelectedDateButton.Name = "GotoSelectedDateButton";
            this.GotoSelectedDateButton.Size = new System.Drawing.Size(88, 27);
            this.GotoSelectedDateButton.TabIndex = 6;
            this.GotoSelectedDateButton.Text = "تاریخ انتخابی";
            this.GotoSelectedDateButton.UseVisualStyleBackColor = true;
            this.GotoSelectedDateButton.Click += new System.EventHandler(this.GotoSelectedDateButton_Click);
            // 
            // SelectedDatelabel
            // 
            this.SelectedDatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedDatelabel.Location = new System.Drawing.Point(147, 11);
            this.SelectedDatelabel.Name = "SelectedDatelabel";
            this.SelectedDatelabel.Size = new System.Drawing.Size(210, 30);
            this.SelectedDatelabel.TabIndex = 5;
            this.SelectedDatelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarDataGridView
            // 
            this.CalendarDataGridView.AllowUserToAddRows = false;
            this.CalendarDataGridView.AllowUserToDeleteRows = false;
            this.CalendarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day1Column,
            this.Day2Column,
            this.Day3Column,
            this.Day4Column,
            this.Day5Column,
            this.Day6Column,
            this.Day7Column});
            this.CalendarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarDataGridView.Location = new System.Drawing.Point(0, 52);
            this.CalendarDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CalendarDataGridView.MultiSelect = false;
            this.CalendarDataGridView.Name = "CalendarDataGridView";
            this.CalendarDataGridView.ReadOnly = true;
            this.CalendarDataGridView.RowHeadersVisible = false;
            this.CalendarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CalendarDataGridView.Size = new System.Drawing.Size(500, 274);
            this.CalendarDataGridView.TabIndex = 2;
            // 
            // Day1Column
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day1Column.DefaultCellStyle = dataGridViewCellStyle1;
            this.Day1Column.HeaderText = "ش";
            this.Day1Column.Name = "Day1Column";
            this.Day1Column.ReadOnly = true;
            // 
            // Day2Column
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day2Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.Day2Column.HeaderText = "ی";
            this.Day2Column.Name = "Day2Column";
            this.Day2Column.ReadOnly = true;
            // 
            // Day3Column
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day3Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.Day3Column.HeaderText = "د";
            this.Day3Column.Name = "Day3Column";
            this.Day3Column.ReadOnly = true;
            // 
            // Day4Column
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day4Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.Day4Column.HeaderText = "س";
            this.Day4Column.Name = "Day4Column";
            this.Day4Column.ReadOnly = true;
            // 
            // Day5Column
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day5Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.Day5Column.HeaderText = "چ";
            this.Day5Column.Name = "Day5Column";
            this.Day5Column.ReadOnly = true;
            // 
            // Day6Column
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day6Column.DefaultCellStyle = dataGridViewCellStyle6;
            this.Day6Column.HeaderText = "پ";
            this.Day6Column.Name = "Day6Column";
            this.Day6Column.ReadOnly = true;
            // 
            // Day7Column
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day7Column.DefaultCellStyle = dataGridViewCellStyle7;
            this.Day7Column.HeaderText = "ج";
            this.Day7Column.Name = "Day7Column";
            this.Day7Column.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalendarDataGridView);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DateTimePicker";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(500, 382);
            this.Load += new System.EventHandler(this.DateTimePicker_Load);
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView CalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7Column;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button LastYearButton;
        private System.Windows.Forms.Button LastMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Label CurrentCalendarLabel;
        private System.Windows.Forms.Label SelectedDatelabel;
        private System.Windows.Forms.Button GotoTodayButton;
        private System.Windows.Forms.Button GotoSelectedDateButton;
    }
}
