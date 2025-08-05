using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace C_TeamProject
{

    public partial class Calendar : Form
    {
        public int currentYear;
        public int currentMonth;
        bool isWeekView = false; //
        DateTime currentWeekStart = DateTime.Today; //
        Panel selectedDay = null;

        Dictionary<DateTime, string> holidays = new Dictionary<DateTime, string>();

        public void AddHolidays(int year) // 공휴일 추가 메소드
        {
            holidays.Clear();

            // 양력 공휴일 (공휴일 이름 끝의 공백 제거)
            holidays[new DateTime(year, 1, 1)] = "신정";
            holidays[new DateTime(year, 3, 1)] = "삼일절";
            holidays[new DateTime(year, 5, 5)] = "어린이날";
            holidays[new DateTime(year, 6, 6)] = "현충일";
            holidays[new DateTime(year, 8, 15)] = "광복절";
            holidays[new DateTime(year, 10, 3)] = "개천절";
            holidays[new DateTime(year, 10, 9)] = "한글날";
            holidays[new DateTime(year, 12, 25)] = "성탄절";

            KoreanLunisolarCalendar klc = new KoreanLunisolarCalendar();

            // 설날 (음력 1월 1일)
            DateTime Seol = klc.ToDateTime(year, 1, 1, 0, 0, 0, 0, KoreanLunisolarCalendar.CurrentEra);
            holidays[Seol.Date] = "설날";
            holidays[Seol.AddDays(-1).Date] = "설날 연휴";
            holidays[Seol.AddDays(1).Date] = "설날 연휴";

            // 추석 (음력 8월 15일)
            DateTime Chuseok;
            if (year == 2025)
            {
                Chuseok = new DateTime(2025, 10, 6);
            }
            else
            {
                Chuseok = klc.ToDateTime(year, 8, 15, 0, 0, 0, 0, KoreanLunisolarCalendar.CurrentEra);
            }
            holidays[Chuseok.Date] = "추석";
            holidays[Chuseok.AddDays(-1).Date] = "추석 연휴";
            holidays[Chuseok.AddDays(1).Date] = "추석 연휴";

            // 부처님오신날 (음력 4월 8일)
            DateTime Buddha = klc.ToDateTime(year, 4, 8, 0, 0, 0, 0, KoreanLunisolarCalendar.CurrentEra);
            holidays[Buddha.Date] = "부처님오신날";
        }

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

            foreach (Control ctrl in CalendarWeekTable.Controls)
            {
                if (ctrl is Panel panel)
                {
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

            if (sender is Panel p)
            {
                clickPanel = p;
            }
            else if (sender is Label label && label.Tag is Panel taggedPanel)
            {
                clickPanel = taggedPanel;
            }

            if (clickPanel == null || clickPanel.Controls.Count == 0)
            {
                return;
            }

            Label dateLabel = clickPanel.Controls[0] as Label;

            if (string.IsNullOrEmpty(dateLabel?.Text))
            {
                return;
            }

            if (selectedDay != null)
            {
                selectedDay.BackColor = Color.White;
            }

            clickPanel.BackColor = Color.LightBlue;
            selectedDay = clickPanel;
        }

        public void Fill(int year, int month)
        {
            AddHolidays(year); // 공휴일 추가 메소드

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
                        DateTime thisDate = new DateTime(year, month, day).Date;
                        label.Text = day.ToString(); // 날짜 먼저 설정

                        if (holidays.ContainsKey(thisDate))
                        {
                            label.ForeColor = Color.Red;
                            label.Text += "\n" + holidays[thisDate]; // 줄 바꿈 후 공휴일 이름 추가
                        }
                        else
                        {
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
            else
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
            else
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

                    if (label != null && !string.IsNullOrWhiteSpace(label.Text))
                    {
                        // 날짜 숫자 부분만 안전하게 추출
                        string[] split = label.Text.Split(new[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (split.Length > 0 && int.TryParse(split[0], out int labelDay) && labelDay == today)
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
        }
        public void ShowWeek(DateTime selectDay)
        {
            DateTime startWeek = selectDay.AddDays(-(int)selectDay.DayOfWeek);
            currentWeekStart = startWeek;
            isWeekView = true;

            // 해당 연도의 공휴일 정보를 미리 로드
            AddHolidays(startWeek.Year);

            // 주간 달력의 상단 헤더 텍스트를 "YYYY년 MM월" 형식으로 표시
            lbYearMonth.Text = $"{startWeek.Year}년 {startWeek.Month}월";

            for (int i = 0; i < 7; i++)
            {
                DateTime day = startWeek.AddDays(i);
                // Controls[i] 대신 Controls[6 - i]를 사용하여 올바른 요일 패널에 매핑
                Panel panel = CalendarWeekTable.Controls[6 - i] as Panel;

                if (panel != null && panel.Controls.Count > 0 && panel.Controls[0] is Label label)
                {
                    // 날짜만 표시 (MM/dd 형식)
                    label.Text = $"{day:MM/dd}";

                    // 공휴일인 경우, 날짜 뒤에 줄 바꿈 후 공휴일 이름을 추가
                    if (holidays.ContainsKey(day.Date))
                    {
                        label.Text += "\n" + holidays[day.Date];
                        label.ForeColor = Color.Red;
                    }
                    else // 공휴일이 아닌 경우, 요일에 따라 색상 지정
                    {
                        label.ForeColor = (i == 0) ? Color.Red : (i == 6) ? Color.Blue : Color.Black;
                    }
                }
            }

            CalendarTable.Visible = false;
            tableLayoutPanel1.Visible = false;

            tableLayoutPanel3.Visible = true;
            CalendarWeekTable.Visible = true;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            if (selectedDay != null && selectedDay.Controls[0] is Label label)
            {
                // 공휴일 텍스트가 포함될 수 있으므로 첫 번째 줄 또는 첫 번째 공백까지의 숫자만 파싱
                string datePart = label.Text.Split(new[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                if (int.TryParse(datePart, out int day))
                {
                    DateTime selectedDate = new DateTime(currentYear, currentMonth, day);
                    ShowWeek(selectedDate);
                }
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