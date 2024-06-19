using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public partial class DateTimePicker : UserControl
    {
        public event EventHandler OnSelectedDateChanged;
        public event EventHandler OnDateDoubleClick;

        int currentYear = 0;
        int currentMonth = 0;
        public DateTime SelectedDate { get; set; }

        public DateTimePicker()
        {
            InitializeComponent();
            CalendarDataGridView.CurrentCellChanged += CalendarDataGridView_CurrentCellChanged;
            CalendarDataGridView.DoubleClick += CalendarDataGridView_DoubleClick;
            SelectedDate = DateTime.Now;
        }

        private void CalendarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (OnDateDoubleClick != null)
                OnDateDoubleClick(this, new EventArgs());
        }

        private void CalendarDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (CalendarDataGridView.CurrentCell != null && CalendarDataGridView.CurrentCell.Tag != null)
            {
                SelectedDate = ((DateTime)CalendarDataGridView.CurrentCell.Tag);
                SelectedDatelabel.Text = ((DateTime)CalendarDataGridView.CurrentCell.Tag).ToString("dd MMM yyyy");
                OnSelectedDateChanged?.Invoke(this, new EventArgs());
            }

        }

        private void FillGridDays(int year, int month)
        {
            CalendarDataGridView.Rows.Clear();

            currentYear = year;
            currentMonth = month;
            var calendar = new PersianCalendar();

            CurrentCalendarLabel.Text = new DateTime(year , month ,1,calendar).ToString("MMM yyyy ");

            var ToDayMonthDay = calendar.GetDayOfMonth(DateTime.Now);
            var todayYear = calendar.GetYear(DateTime.Now);
            var todayMonth = calendar.GetMonth(DateTime.Now);   

            var lastMonthDays = month == 1 ? calendar.GetDaysInMonth(year - 1, 12) : calendar.GetDaysInMonth(year, month - 1);
            var currentMonthDays = calendar.GetDaysInMonth(year, month);
            var firstDayOfWeek = calendar.GetDayOfWeek(new DateTime(year, month, 1, calendar));
            var firstDayOfWeekIndex = 0;
            if (firstDayOfWeek == DayOfWeek.Saturday)
                firstDayOfWeekIndex = 0;
            else
                firstDayOfWeekIndex = (int)firstDayOfWeek + 1;

            var rowIndex = 0;
            var cellIndex = 0;
            CalendarDataGridView.Rows.Add(1);

            var lastMonthStartDate = (lastMonthDays - firstDayOfWeekIndex) + 1;

            for (int dayIndex = lastMonthStartDate; dayIndex <= lastMonthDays; dayIndex++)
            {
                CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Tag = new DateTime(month == 1 ? year - 1 : year, month == 1 ? 12 : month - 1, dayIndex, calendar);
                CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Value = dayIndex;
                CalendarDataGridView.Rows[rowIndex].Cells[cellIndex++].Style.ForeColor = Color.Gainsboro;
            }
            bool selectedDateExists = false;
            for (int dayIndex = 1; dayIndex <= currentMonthDays; dayIndex++)
            {
                CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Value = dayIndex;
                CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Tag = new DateTime(year, month, dayIndex, calendar);
                var currentCellDate = new DateTime(year, month, dayIndex, calendar);
                if (dayIndex == ToDayMonthDay && month == todayMonth && year == todayYear)
                {
                    CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.DarkGreen;
                    CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Style.ForeColor = Color.White;
                }

                if (currentCellDate.Year == SelectedDate.Year && currentCellDate.Month == SelectedDate.Month && currentCellDate.Day == SelectedDate.Day)
                {
                    OnSelectedDateChanged?.Invoke(this, new EventArgs());
                    CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Selected = selectedDateExists = true;
                }
                cellIndex++;
                if (cellIndex > 6)
                {
                    cellIndex = 0;
                    rowIndex++;
                    CalendarDataGridView.Rows.Add(1);
                }
            }

            var nextMonthDay = 1;
                if(cellIndex > 0) {
                    for (int dayIndex = cellIndex; dayIndex <= 6; dayIndex++)
                    {
                        CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Tag = new DateTime(month == 12 ? year + 1 : year, month == 12 ? 1 : month + 1, dayIndex, calendar);
                        CalendarDataGridView.Rows[rowIndex].Cells[cellIndex].Value = nextMonthDay++;
                        CalendarDataGridView.Rows[rowIndex].Cells[cellIndex++].Style.ForeColor = Color.Gainsboro;
                    }
                }
                foreach (var row in CalendarDataGridView.Rows.OfType<DataGridViewRow>())
                {
                    row.Height = 26;
                }
                if (!selectedDateExists)
                    CalendarDataGridView.CurrentCell = null;
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            var calendar = new PersianCalendar();
            FillGridDays(calendar.GetYear(SelectedDate), calendar.GetMonth(SelectedDate));
            Height = 300;
        }

        private void NextYearButton_Click(object sender, EventArgs e)
        {
            FillGridDays(currentYear + 1, currentMonth);
        }

        private void LastYearButton_Click(object sender, EventArgs e)
        {
            FillGridDays(currentYear - 1, currentMonth);
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            FillGridDays(currentMonth == 12 ? currentYear + 1 : currentYear, currentMonth == 12 ? 1 : currentMonth + 1);
        }

        private void LastMonthButton_Click(object sender, EventArgs e)
        {
            FillGridDays(currentMonth == 1 ? currentYear - 1 : currentYear,currentMonth == 1 ? 12 : currentMonth - 1);
        }

        private void GotoSelectedDateButton_Click(object sender, EventArgs e)
        {
            var calendar = new PersianCalendar();
            FillGridDays(calendar.GetYear(SelectedDate), calendar.GetMonth(SelectedDate));
        }

        private void GotoTodayButton_Click(object sender, EventArgs e)
        {
            var calendar = new PersianCalendar();
            FillGridDays(calendar.GetYear(DateTime.Now), calendar.GetMonth(DateTime.Now));
        }
    }
}
