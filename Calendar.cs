using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_TeamProject
{

    public partial class Calendar : Form
    {
        public int currentYear;
        public int currentMonth;
        bool isWeekView = false; //
        DateTime currentWeekStart = DateTime.Today; //
        Panel selectedDay = null;

        public Calendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;
            Fill(currentYear, currentMonth);

            foreach (Control ctrl in CalendarTable.Controls)
            {
                if (ctrl is Panel panel)
                {
                    panel.Click += Day_Click;
                    panel.Tag = panel;

                    Label label = panel.Controls.OfType<Label>().FirstOrDefault();
                    if (label != null)
                    {
                        label.Click += Day_Click;
                        label.Tag = panel;
                    }
                }
            }
        }

        public void Day_Click(object sender, EventArgs e)
        {
            Panel clickPanel = null;

            if (sender is Panel p)
            {
                clickPanel = p;
            }
            else if (sender is Label label && label.Tag is Panel taggedPanel)
            {
                clickPanel = taggedPanel;
            }

            if (clickPanel == null || (clickPanel.Controls.Count == 0 || string.IsNullOrEmpty((clickPanel.Controls[0] as Label)?.Text)))
            {
                return;
            }

            if (selectedDay != null)
            {
                Label oldLabel = selectedDay.Controls[0] as Label;
                if (oldLabel != null && !string.IsNullOrEmpty(oldLabel.Text))
                {
                    selectedDay.BackColor = Color.White;
                }
            }

            clickPanel.BackColor = Color.LightBlue;
            selectedDay = clickPanel;

        }

        public void Fill(int year, int month)
        {
            lbYearMonth.Text = $"{year}년 {month}월";

            DateTime firstDay = new DateTime(year, month, 1);
            int DaysInMonth = DateTime.DaysInMonth(year, month);
            int index = (int)firstDay.DayOfWeek;

            int day = 1;

            for (int i = 0; i < CalendarTable.Controls.Count; i++)
            {
                Panel panel = CalendarTable.Controls[i] as Panel;

                if (panel != null && panel.Controls.Count > 0)
                {
                    Label label = panel.Controls[0] as Label;

                    if (i >= index && day <= DaysInMonth)
                    {
                        label.Text = day.ToString();

                        int dayOfWeek = (i % 7);

                        if (dayOfWeek == 0)
                        {
                            label.ForeColor = Color.Red;
                        }
                        else if (dayOfWeek == 6)
                        {
                            label.ForeColor = Color.Blue;
                        }
                        else
                        {
                            label.ForeColor = Color.Black;
                        }

                        panel.Visible = true;
                        panel.BackColor = Color.White;
                        day++;
                    }
                    else
                    {
                        label.Text = "";
                        panel.BackColor = Color.Gainsboro;
                    }
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (isWeekView)
            {
                currentWeekStart = currentWeekStart.AddDays(-7);
                ShowWeek(currentWeekStart);
            }
            else//
            {
                currentMonth--;
                if (currentMonth == 0)
                {
                    currentMonth = 12;
                    currentYear--;
                }
                Fill(currentYear, currentMonth);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isWeekView)
            {
                currentWeekStart = currentWeekStart.AddDays(7);
                ShowWeek(currentWeekStart);
            }
            else//
            {
                currentMonth++;
                if (currentMonth == 13)
                {
                    currentMonth = 1;
                    currentYear++;
                }
                Fill(currentYear, currentMonth);
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;
            Fill(currentYear, currentMonth);

            if (isWeekView)
            {
                currentWeekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                ShowWeek(currentWeekStart);
                return;
            }

            int today = DateTime.Now.Day;
            foreach (Control ctrl in CalendarTable.Controls)
            {
                if (ctrl is Panel panel && panel.Controls.Count > 0)
                {
                    Label label = panel.Controls[0] as Label;

                    if (label != null && label.Text == today.ToString())
                    {
                        if (selectedDay != null)
                        {
                            Label oldLabel = selectedDay.Controls[0] as Label;
                            if (oldLabel != null && !string.IsNullOrEmpty(oldLabel.Text))
                            {
                                selectedDay.BackColor = Color.White;
                            }
                        }

                        panel.BackColor = Color.LightBlue;
                        selectedDay = panel;
                        break;
                    }
                }
            }
        }
        public void ShowWeek(DateTime selectDay)
        {
            DateTime startWeek = selectDay.AddDays(-(int)selectDay.DayOfWeek);
            currentWeekStart = startWeek;
            isWeekView = true;

            lbYearMonth.Text = $"{startWeek.Year}년 {startWeek.Month}월";

            for (int i = 0; i < 7; i++)
            {
                DateTime day = startWeek.AddDays(i);
                Panel panel = CalendarWeekTable.Controls[CalendarWeekTable.Controls.Count - 1 - i] as Panel;
                if (panel != null && panel.Controls.Count > 0 && panel.Controls[0] is Label label)
                {
                    label.Text = $"{day:MM/dd}";
                    label.ForeColor = (i == 0) ? Color.Red : (i == 6) ? Color.Blue : Color.Black;
                }
            }

            CalendarTable.Visible = false;
            tableLayoutPanel1.Visible = false;

            tableLayoutPanel3.Visible = true;
            CalendarWeekTable.Visible = true;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            if (selectedDay != null && selectedDay.Controls[0] is Label label && int.TryParse(label.Text, out int day))
            {
                DateTime selectedDate = new DateTime(currentYear, currentMonth, day);
                ShowWeek(selectedDate);
            }
            else
            {
                // 현재 월의 첫째 날 기준으로 주간 표시
                DateTime firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
                DateTime startOfWeek = firstDayOfMonth.AddDays(-(int)firstDayOfMonth.DayOfWeek);

                if (startOfWeek.Month != currentMonth)
                {
                    startOfWeek = startOfWeek.AddDays(7);
                }

                ShowWeek(firstDayOfMonth);
            }
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            isWeekView = false;

            currentYear = currentWeekStart.Year;
            currentMonth = currentWeekStart.Month;

            Fill(currentYear, currentMonth);

            CalendarTable.Visible = true;
            tableLayoutPanel1.Visible = true;

            CalendarWeekTable.Visible = false;
            tableLayoutPanel3.Visible = false;
        }
    }
}
