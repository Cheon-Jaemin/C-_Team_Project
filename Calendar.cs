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
        private bool isDragging = false;
        private Panel dragStartPanel = null;
        private Panel dragEndPanel = null;
        private List<Panel> selectedPanels = new List<Panel>();
        private DateTime? startDate = null;
        private DateTime? endDate = null;
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
                    panel.MouseDown += Panel_MouseDown;
                    panel.MouseMove += Panel_MouseMove;
                    panel.MouseUp += Panel_MouseUp;

                    Label label = panel.Controls.OfType<Label>().FirstOrDefault();
                    if (label != null)
                    {
                        label.Click += Day_Click;
                        label.Tag = panel;
                    }
                }

            }

            foreach (Control ctrl in CalendarWeekTable.Controls)
            {
                if(ctrl is Panel panel)
                {
                    panel.MouseDown += Panel_MouseDown;
                    panel.MouseMove += Panel_MouseMove;
                    panel.MouseUp += Panel_MouseUp;

                    panel.Click += WeekDay_Click;
                    panel.Tag = panel;

                    Label label = panel.Controls.OfType<Label>().FirstOrDefault();
                    if (label != null)
                    {
                        label.Click += WeekDay_Click;
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

        public void WeekDay_Click(object sender, EventArgs e)
        {
            Panel clickPanel = null;

            if(sender is Panel p)
            {
                clickPanel = p;
            }
            else if (sender is Label label && label.Tag is Panel taggedPanel)
            {
                clickPanel = taggedPanel;
            }

            if(clickPanel == null || clickPanel.Controls.Count == 0)
            {
                return;
            }

            Label dateLabel = clickPanel.Controls[0] as Label;

            if(string.IsNullOrEmpty(dateLabel?.Text))
            {
                return;
            }

            if(selectedDay != null)
            {
                selectedDay.BackColor = Color.White;
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

                ShowWeek(startOfWeek);
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
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Panel panel)
            {
                isDragging = true;
                dragStartPanel = panel;

                panel.Capture = true;

                if (selectedDay != null)
                {
                    selectedDay.BackColor = Color.White;
                    selectedDay = null;
                }

                ClearSelectedPanels();

                selectedPanels.Add(panel);
                panel.BackColor = Color.LightBlue;

                // 날짜 저장
                Label label = panel.Controls[0] as Label;
                if (label != null && int.TryParse(label.Text, out int day))
                {
                    startDate = new DateTime(currentYear, currentMonth, day);                   
                }
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Panel currentPanel = null;

                if (sender is Panel panel)
                {
                    currentPanel = panel;
                }
                else if (sender is Label label && label.Tag is Panel taggedPanel)
                {
                    currentPanel = taggedPanel;
                }

                if (currentPanel != null)
                {
                    SelectPanelsInRange(dragStartPanel, currentPanel);
                }
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

            Panel panel = null;

            if (sender is Panel p)
                panel = p;
            else if (sender is Label label && label.Tag is Panel taggedPanel)
                panel = taggedPanel;

            if (panel != null)
            {
                dragEndPanel = panel;

                Label label = panel.Controls[0] as Label;
                if (label != null && int.TryParse(label.Text, out int day))
                {
                    endDate = new DateTime(currentYear, currentMonth, day);
                }
            }
            if (dragStartPanel != null)
                dragStartPanel.Capture = false;

            MessageBox.Show($"드래그 범위: {startDate} ~ {endDate}");
            dragStartPanel = null;
        }
        private void SelectPanelsInRange(Panel startPanel, Panel endPanel)
        {
            // 먼저 이전 선택 해제
            ClearSelectedPanels();

            // CalendarTable.Controls는 42개(6주 * 7일) 패널로 가정

            int startIndex = CalendarTable.Controls.IndexOf(startPanel);
            int endIndex = CalendarTable.Controls.IndexOf(endPanel);

            if (startIndex < 0 || endIndex < 0)
                return;

            int min = Math.Min(startIndex, endIndex);
            int max = Math.Max(startIndex, endIndex);

            for (int i = min; i <= max; i++)
            {
                Panel panel = CalendarTable.Controls[i] as Panel;
                if (panel != null && panel.Controls.Count > 0)
                {
                    Label label = panel.Controls[0] as Label;
                    if (label != null && !string.IsNullOrEmpty(label.Text))
                    {
                        panel.BackColor = Color.LightBlue;
                        selectedPanels.Add(panel);
                    }
                }
            }
        }
        private void ClearSelectedPanels()
        {
            foreach (var panel in selectedPanels)
            {
                if (panel.Controls.Count > 0)
                {
                    Label label = panel.Controls[0] as Label;
                    if (label != null && !string.IsNullOrEmpty(label.Text))
                    {
                        panel.BackColor = Color.White;
                    }
                }
            }
            selectedPanels.Clear();
        }

    }
}
