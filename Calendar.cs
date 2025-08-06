using Calendar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public int currentDay;
        bool isWeekView = false; //
        DateTime currentWeekStart = DateTime.Today; //
        Panel selectedDay = null;
        static public DateTime cursorDatetime;
        EventMaker eventMaker = new EventMaker();

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

        private void Calendar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.KeyPreview = true;
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
            cursorDatetime = DateTime.Now;
            ShowEventList();
        }
        private void draw_blue(int currentDay, int currentMonth)
        {
            Fill(currentYear, currentMonth); // 월간 보기 초기화
            ShowWeek(cursorDatetime);
            currentDay = cursorDatetime.Day;
            currentMonth = cursorDatetime.Month;

            TableLayoutPanel targetTable = isWeekView ? CalendarWeekTable : CalendarTable;

            foreach (Control ctrl in targetTable.Controls)
            {
                if (ctrl is Panel panel && panel.Controls.Count > 0)
                {
                    Label lbl = panel.Controls[0] as Label;
                    if (lbl == null || string.IsNullOrWhiteSpace(lbl.Text))
                        continue;

                    // 라벨 텍스트에서 날짜 숫자만 추출합니다.
                    string datePart = lbl.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();

                    if (datePart != null && int.TryParse(datePart, out int dayOnly) && dayOnly == currentDay)
                    {
                        panel.BackColor = Color.LightBlue;
                        return;
                    }

                    // 이 부분은 주간 보기용 코드입니다.
                    if (lbl.Text.Contains("-"))
                    {
                        string[] parts = lbl.Text.Split('-');
                        if (parts.Length == 2 &&
                            int.TryParse(parts[0], out int parsedMonth) &&
                            int.TryParse(parts[1], out int parsedDay))
                        {
                            if (parsedMonth == currentMonth && parsedDay == currentDay)
                            {
                                panel.BackColor = Color.LightBlue;
                                return;
                            }
                        }
                    }
                }
            }

        }
        
        public void Day_Click(object sender, EventArgs e)
        {
            // eventMaker 폼이 이미 생성되었는지 확인합니다.
            if (eventMaker == null || eventMaker.IsDisposed)
            {
                // 폼이 생성되지 않았거나 이미 닫혔다면 새로 생성합니다.
                eventMaker = new EventMaker();
            }

    
                
            

            //Panel clickPanel = null;

            //if (sender is Panel p)
            //{
            //    clickPanel = p;
            //}
            //else if (sender is Label label && label.Tag is Panel taggedPanel)
            //{
            //    clickPanel = taggedPanel;
            //}

            //if (clickPanel == null || (clickPanel.Controls.Count == 0 || string.IsNullOrEmpty((clickPanel.Controls[0] as Label)?.Text)))
            //{
            //    return;
            //}

            //Label selectedLabel = clickPanel.Controls[0] as Label;
            //if (selectedLabel == null || string.IsNullOrEmpty(selectedLabel.Text))
            //{
            //    return;
            //}

            //if (selectedDay != null)
            //{
            //    Label oldLabel = selectedDay.Controls[0] as Label;
            //    if (oldLabel != null && !string.IsNullOrEmpty(oldLabel.Text))
            //    {
            //        selectedDay.BackColor = Color.White;
            //    }
            //}

            //clickPanel.BackColor = Color.LightBlue;
            //selectedDay = clickPanel;

            //string datePart = selectedLabel.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();

            ////소현섭 코드
            //if (datePart != null && int.TryParse(datePart, out int day))
            //{
            //    cursorDatetime = new DateTime(currentYear, currentMonth, day);
            //    //tbEventStart.Text = cursorDatetime.ToString();                        //tbEventStart는 임의로 표시간 이벤트 시작일 표시 텍스트박스
            //    //tbEventEnd.Text = cursorDatetime.ToString();                          // 오나지

            //}
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

            //if (selectedDay != null)
            //{
            //    Label oldLabel = selectedDay.Controls[0] as Label;
            //    if (oldLabel != null && !string.IsNullOrEmpty(oldLabel.Text))
            //    {
            //        selectedDay.BackColor = Color.White;
            //    }
            //}

            //clickPanel.BackColor = Color.LightBlue;
            selectedDay = clickPanel;

            Label selectedLabel = clickPanel.Controls[0] as Label;
            if (selectedLabel != null)
            {
                string text = selectedLabel.Text;

                if (int.TryParse(text, out int day))
                {
                    cursorDatetime = new DateTime(currentYear, currentMonth, day);
                    
                }
                else if (text.Contains("-"))
                {
                    string[] parts = text.Split('-');
                    if (parts.Length == 2 &&
                        int.TryParse(parts[0], out int month) &&
                        int.TryParse(parts[1], out int day2))
                    {
                        cursorDatetime = new DateTime(currentYear, month, day2);
                        
                    }
                }
                else
                {
                    string datePart = selectedLabel.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
                    if (datePart != null && int.TryParse(datePart, out int day2))
                    {
                       
                       
                        cursorDatetime = new DateTime(currentYear, currentMonth, day2);
                        //tbEventStart.Text = cursorDatetime.ToString();                        //tbEventStart는 임의로 표시간 이벤트 시작일 표시 텍스트박스
                        //tbEventEnd.Text = cursorDatetime.ToString();                          // 오나지
                        currentDay = day2;
                        

                    }
                }
                if (cursorDatetime != null)
                {
                    eventMaker.Show();
                }
                else
                {
                    MessageBox.Show("");
                }

                    // 폼을 보이게 합니다.
                    
            }
            draw_blue(currentDay, currentMonth);
            
        }

        public void WeekDay_Click(object sender, EventArgs e)
        {
            //Panel clickPanel = null;

            //if (sender is Panel p)
            //{
            //    clickPanel = p;
            //}
            //else if (sender is Label label && label.Tag is Panel taggedPanel)
            //{
            //    clickPanel = taggedPanel;
            //}

            //if (clickPanel == null || clickPanel.Controls.Count == 0)
            //{
            //    return;
            //}

            //Label dateLabel = clickPanel.Controls[0] as Label;

            //if (string.IsNullOrEmpty(dateLabel?.Text))
            //{
            //    return;
            //}

            //if (selectedDay != null)
            //{
            //    selectedDay.BackColor = Color.White;
            //}

            //clickPanel.BackColor = Color.LightBlue;
            //selectedDay = clickPanel;

            //int dayIndex = -1;
            //for (int i = 0; i < CalendarWeekTable.Controls.Count; i++)
            //{
            //    // CalendarWeekTable.Controls는 역순으로 채워져 있으므로 인덱스를 조정합니다.
            //    if (CalendarWeekTable.Controls[6 - i] == clickPanel)
            //    {
            //        dayIndex = i;
            //        break;
            //    }
            //}

            //// 인덱스를 찾았을 경우, currentWeekStart를 기준으로 날짜를 계산하여 cursorDatetime을 업데이트합니다.
            //if (dayIndex != -1)
            //{
            //    cursorDatetime = currentWeekStart.AddDays(dayIndex);
            //}
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

                int dayIndex = -1;
                for (int i = 0; i < CalendarWeekTable.Controls.Count; i++)
                {
                    // CalendarWeekTable.Controls는 역순으로 채워져 있으므로 인덱스를 조정합니다.
                    if (CalendarWeekTable.Controls[6 - i] == clickPanel)
                    {
                        dayIndex = i;
                        break;
                    }
                }

                // 인덱스를 찾았을 경우, currentWeekStart를 기준으로 날짜를 계산하여 cursorDatetime을 업데이트합니다.
                if (dayIndex != -1)
                {
                    cursorDatetime = currentWeekStart.AddDays(dayIndex);
                    currentMonth = cursorDatetime.Month;
                    currentDay= cursorDatetime.Day;
                }
            }
            // eventMaker 폼이 이미 생성되었는지 확인합니다.
            if (eventMaker == null || eventMaker.IsDisposed)
            {
                // 폼이 생성되지 않았거나 이미 닫혔다면 새로 생성합니다.
                eventMaker = new EventMaker();
            }
            if (cursorDatetime != null)
            {
                eventMaker.Show();
            }
            else
            {
                MessageBox.Show("");
            }
            draw_blue(currentDay,currentMonth);

        }

        public void Fill(int year, int month)
        {
            //// 1. 기존에 표시된 일정(이벤트) 라벨들을 모두 삭제합니다.
            //foreach (Control ctrl in CalendarTable.Controls)
            //{
            //    if (ctrl is Panel panel)
            //    {
            //        // Panel의 모든 컨트롤을 역순으로 순회하며 삭제
            //        // 첫 번째 컨트롤(날짜 라벨)은 제외
            //        for (int i = panel.Controls.Count - 1; i > 0; i--)
            //        {
            //            panel.Controls.RemoveAt(i);
            //        }
            //    }
            //}

            //AddHolidays(year);
            //lbYearMonth.Text = $"{year}년 {month}월";

            //DateTime firstDay = new DateTime(year, month, 1);
            //int DaysInMonth = DateTime.DaysInMonth(year, month);
            //int index = (int)firstDay.DayOfWeek;

            //int day = 1;

            //for (int i = 0; i < CalendarTable.Controls.Count; i++)
            //{
            //    Panel panel = CalendarTable.Controls[i] as Panel;

            //    if (panel != null && panel.Controls.Count > 0)
            //    {
            //        Label label = panel.Controls[0] as Label;

            //        if (i >= index && day <= DaysInMonth)
            //        {
            //            DateTime thisDate = new DateTime(year, month, day).Date;
            //            label.Text = day.ToString();

            //            if (holidays.ContainsKey(thisDate))
            //            {
            //                label.ForeColor = Color.Red;
            //                label.Text += "\n" + holidays[thisDate];
            //            }
            //            else
            //            {
            //                int dayOfWeek = (i % 7);
            //                if (dayOfWeek == 0)
            //                {
            //                    label.ForeColor = Color.Red;
            //                }
            //                else if (dayOfWeek == 6)
            //                {
            //                    label.ForeColor = Color.Blue;
            //                }
            //                else
            //                {
            //                    label.ForeColor = Color.Black;
            //                }
            //            }
            //            panel.Visible = true;
            //            panel.BackColor = Color.White;
            //            day++;
            //        }
            //        else
            //        {
            //            label.Text = "";
            //            panel.BackColor = Color.Gainsboro;
            //        }
            //    }
            //}

            //// 2. 새로운 달의 일정을 다시 로드합니다.
            //cursorDatetime = new DateTime(year, month, 1);
            //ShowEventList();
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (isWeekView)//
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
            DateTime today = DateTime.Today;
            cursorDatetime = today;

            if (isWeekView)
            {
                // 주간 보기일 경우, 오늘이 포함된 주를 표시합니다.
                ShowWeek(today);
            }
            else // 월간 보기일 경우
            {
                // 1. 월간 달력을 오늘 날짜가 포함된 월로 다시 그립니다.
                currentYear = today.Year;
                currentMonth = today.Month;
                Fill(currentYear, currentMonth);

                // 2. 그려진 달력에서 오늘 날짜 패널을 찾아서 하이라이트합니다.
                foreach (Control ctrl in CalendarTable.Controls)
                {
                    if (ctrl is Panel panel && panel.Controls.Count > 0)
                    {
                        Label label = panel.Controls[0] as Label;
                        // 날짜 라벨 텍스트가 오늘 날짜와 일치하는지 확인
                        // 예를 들어, 라벨 텍스트가 "25\n"와 같은 형태일 수 있으므로 안전하게 비교합니다.
                        if (label != null && label.Text.StartsWith(today.Day.ToString() + "\n") || label.Text == today.Day.ToString())
                        {
                            // 이전에 선택된 패널이 있다면 하이라이트를 제거합니다.
                            if (selectedDay != null)
                            {
                                selectedDay.BackColor = Color.White;
                            }

                            // 오늘 날짜 패널을 하이라이트하고, selectedDay 변수를 업데이트합니다.
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

            if (selectedDay != null)
            {
                selectedDay.BackColor = Color.White;
            }

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

                    if (day.Date == selectDay.Date)
                    {
                        panel.BackColor = Color.LightBlue;
                        selectedDay = panel; // 새로 선택된 패널로 업데이트
                    }
                    else
                    {
                        panel.BackColor = Color.White; // 선택되지 않은 패널은 흰색으로 유지
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

            DateTime selectedDateFromWeek = cursorDatetime.Date;

            currentYear = cursorDatetime.Year;
            currentMonth = cursorDatetime.Month;

            Fill(currentYear, currentMonth);

            Panel newSelectedDayPanel = GetPanelByDate(cursorDatetime.Day);
            if (newSelectedDayPanel != null)
            {
                // 4. 해당 패널을 하이라이트하고, selectedDay 변수를 업데이트합니다.
                newSelectedDayPanel.BackColor = Color.LightBlue;
                selectedDay = newSelectedDayPanel;
            }
            else
            {
                // 만약 선택했던 날짜가 현재 월에 속하지 않는다면(월 경계를 넘어갔을 때), 선택을 해제합니다.
                selectedDay = null;
            }

            CalendarTable.Visible = true;
            tableLayoutPanel1.Visible = true;

            CalendarWeekTable.Visible = false;
            tableLayoutPanel3.Visible = false;
        }
        //

        //소현섭 코드
        private void ShowEventList()
        {
            List<CalendarEvent> events = selectDb(cursorDatetime);
            Dictionary<string, int> eventRowMap = new Dictionary<string, int>(); // 이벤트별 고정 행
            Dictionary<Panel, HashSet<int>> usedRows = new Dictionary<Panel, HashSet<int>>(); // 날짜별 사용한 행

            foreach (CalendarEvent e in events)
            {
                DateTime start = e.EventStart;
                DateTime end = e.EventEnd;

                int assignedRow = -1;

                if (!eventRowMap.ContainsKey(e.Title))
                {
                    for (int row = 0; row < 3; row++)
                    {
                        bool canAssign = true;
                        for (DateTime d = start; d <= end; d = d.AddDays(1))
                        {
                            if (d.Month != cursorDatetime.Month || d.Year != cursorDatetime.Year)
                                continue;

                            Panel targetPanel = GetPanelByDate(d.Day);
                            if (targetPanel == null) continue;

                            if (!usedRows.ContainsKey(targetPanel))
                                usedRows[targetPanel] = new HashSet<int>();

                            if (usedRows[targetPanel].Contains(row))
                            {
                                canAssign = false;
                                break;
                            }
                        }

                        if (canAssign)
                        {
                            assignedRow = row;
                            eventRowMap[e.Title] = row;
                            break;
                        }
                    }
                }
                else
                {
                    assignedRow = eventRowMap[e.Title];
                }

                for (DateTime d = start; d <= end; d = d.AddDays(1))
                {
                    if (d.Month != cursorDatetime.Month || d.Year != cursorDatetime.Year)
                        continue;

                    Panel panel = GetPanelByDate(d.Day);
                    if (panel == null) continue;

                    if (!usedRows.ContainsKey(panel))
                        usedRows[panel] = new HashSet<int>();

                    if (usedRows[panel].Count >= 3)
                        continue;

                    if (assignedRow >= 0 && !usedRows[panel].Contains(assignedRow))
                    {
                        // 날짜 라벨의 높이 확보
                        int baseTop = 0;
                        if (panel.Controls.Count > 0 && panel.Controls[0] is Label dayLabel)
                            baseTop = dayLabel.Height;

                        Label label = new Label();
                        label.Text = e.Title;
                        label.AutoSize = false;
                        label.Height = 15;
                        label.Width = panel.Width - 4;
                        label.Font = new Font("맑은 고딕", 7);
                        label.ForeColor = Color.DarkGreen;
                        label.BackColor = Color.Transparent;
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        label.Padding = new Padding(2, 0, 0, 0);
                        label.Top = baseTop + (assignedRow * 15);
                        label.Left = 2;
                        label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        label.BringToFront();
                        panel.Controls.Add(label);
                        usedRows[panel].Add(assignedRow);
                    }
                }
            }

            // "+n개 더 있음" 표시
            foreach (Control ctrl in CalendarTable.Controls)
            {
                if (ctrl is Panel panel)
                {
                    // 날짜 라벨 높이 확인
                    int baseTop = 15;
                    if (panel.Controls.Count > 0 && panel.Controls[0] is Label dayLabel)
                        baseTop = dayLabel.Height;

                    int labelCount = panel.Controls.OfType<Label>().Count(l => l != panel.Controls[0]);

                    if (labelCount > 3)
                    {
                        int hiddenCount = labelCount - 3;

                        // 기존 "+n개" 라벨 제거
                        foreach (var old in panel.Controls.OfType<Label>().Where(l => l.Text.StartsWith("+")).ToList())
                            panel.Controls.Remove(old);

                        Label moreLabel = new Label();
                        moreLabel.Text = $"+{hiddenCount}개 더 있음";
                        moreLabel.AutoSize = false;
                        moreLabel.Height = 15;
                        moreLabel.Width = panel.Width - 4;
                        moreLabel.Font = new Font("맑은 고딕", 7, FontStyle.Italic);
                        moreLabel.ForeColor = Color.Gray;
                        moreLabel.TextAlign = ContentAlignment.MiddleLeft;
                        moreLabel.Top = baseTop + (2 * 15);
                        moreLabel.Left = 2;
                        moreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        panel.Controls.Add(moreLabel);
                    }
                }
            }
        }
        private Panel GetPanelByDate(int day)
        {
            foreach (Control ctrl in CalendarTable.Controls)
            {
                if (ctrl is Panel panel && panel.Controls.Count > 0)
                {
                    if (panel.Controls[0] is Label label && int.TryParse(label.Text, out int labelDay))
                    {
                        if (labelDay == day)
                            return panel;
                    }
                }
            }
            return null;
        }

        private void insertDb(string startdate, string enddate, string title, string content)
        {
            //MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=calendar;Uid=root;Pwd=1234");
            MySqlConnection connection = new MySqlConnection("Server='teamproj-calendar.cxgqa06ootsh.ap-northeast-2.rds.amazonaws.com';Port=3306;Database=calSchema;Uid=admin;Pwd=12345678");
            string insertQuery = $"INSERT INTO eventlist(eventStart,eventEnd,title,content) VALUES(@vntStart, @vntEnd, @titleq, @contentq )";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@vntStart", startdate);
                command.Parameters.AddWithValue("@vntEnd", enddate);
                command.Parameters.AddWithValue("@titleq", title);
                command.Parameters.AddWithValue("@contentq", content);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("인서트 성공");
                else
                    MessageBox.Show("인서트 실패");
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패 : " + ex.ToString());
            }
        }

        private List<CalendarEvent> selectDb(DateTime cursorDatetimedate)
        {
            List<CalendarEvent> events = new List<CalendarEvent>();

            //string connStr = "Server=localhost;Port=3306;Database=calendar;Uid=root;Pwd=1234";
            string connStr = "Server='teamproj-calendar.cxgqa06ootsh.ap-northeast-2.rds.amazonaws.com';Port=3306;Database=calSchema;Uid=admin;Pwd=12345678";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();

                DateTime monthStart = new DateTime(cursorDatetimedate.Year, cursorDatetimedate.Month, 1);
                DateTime monthEnd = new DateTime(cursorDatetimedate.Year, cursorDatetimedate.Month, DateTime.DaysInMonth(cursorDatetimedate.Year, cursorDatetimedate.Month));

                string query = "SELECT * FROM eventlist WHERE eventStart>= @start AND eventEnd <= @end ORDER BY eventStart ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@start", monthStart);
                    cmd.Parameters.AddWithValue("@end", monthEnd);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            events.Add(new CalendarEvent
                            {
                                Title = reader.GetString("title"),
                                Content = reader.GetString("content"),
                                EventStart = reader.GetDateTime("eventStart"),
                                EventEnd = reader.GetDateTime("eventEnd")
                            });
                        }
                    }
                }
            }

            return events;
        }
        public class CalendarEvent
        {
            public string? Title { get; set; }
            public string? Content { get; set; }
            public DateTime EventStart { get; set; }
            public DateTime EventEnd { get; set; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label64.Text = cursorDatetime.ToString();
        }
        // 단축키



        private System.Windows.Forms.TextBox lastTextBox = null;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)                           //탭
            {
                TAB();                                         //날짜이동 +
                return true;
            }

            if (keyData == (Keys.Shift | Keys.Tab))              //쉬프트탭
            {
                SHIFTTAB();                                    //날짜이동 -
                return true;
            }
            if (keyData == Keys.OemPeriod)                     // "."
            {

                OMMa();                                        //원하는 날짜로 이동
                return true;
            }
            if (keyData == Keys.Enter)
            {

                // OMMa()로 생성된 텍스트 박스가 존재할 때만 실행
                if (lastTextBox != null && this.Controls.Contains(lastTextBox))
                {
                    selectOMma();
                    // Enter 키를 눌렀을 때 텍스트 박스를 닫는 로직을 추가할 수 있습니다.
                    ESC(); // 예를 들어, ESC()를 호출하여 텍스트 박스를 닫습니다.
                }
            }

            if (keyData == Keys.Escape)                         //ESC
            {
                ESC();                                          //최근에 연 탭 닫기
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private Form shortcutKey = null;
        private void Calendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Oem2)              // ? 키 입력받음
            {
                Question();                                      //도움말 창 열기
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.L)     // Ctrl + Shift + L
            {
                CtnlShiftL();                                    // 테마 어두움밝음 변경

            }

        }
        // 단축키 코드
        private void TAB()
        {
            DateTime previousDate = cursorDatetime;

            // 날짜 하루 증가
            cursorDatetime = cursorDatetime.AddDays(1);

            // 연도 또는 월이 바뀌면 currentYear/Month 갱신하고 Fill
            if (cursorDatetime.Year != previousDate.Year || cursorDatetime.Month != previousDate.Month)
            {
                currentYear = cursorDatetime.Year;
                currentMonth = cursorDatetime.Month;
                Fill(currentYear, currentMonth);
            }

            currentDay = cursorDatetime.Day;

            draw_blue(currentDay, currentMonth);


        }
        private void SHIFTTAB()
        {
            DateTime previousDate = cursorDatetime;

            // 날짜 하루 증가
            cursorDatetime = cursorDatetime.AddDays(-1);

            // 연도 또는 월이 바뀌면 currentYear/Month 갱신하고 Fill
            if (cursorDatetime.Year != previousDate.Year || cursorDatetime.Month != previousDate.Month)
            {
                currentYear = cursorDatetime.Year;
                currentMonth = cursorDatetime.Month;
                Fill(currentYear, currentMonth);
            }

            currentDay = cursorDatetime.Day;

            draw_blue(currentDay, currentMonth);

        }
        private void OMMa()
        {


            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Text = "예) (2025년10월7일)";
            textBox.Location = new Point(984, 8);
            textBox.Size = new Size(250, 80);
            textBox.Font = new Font("맑은 고딕", 15F);
            textBox.ForeColor = Color.Gray;
            this.Controls.Add(textBox);
            textBox.BringToFront();

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == "예) (2025년10월7일)")
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "예) (2025년10월7일)";
                    textBox.ForeColor = Color.Gray;
                }
            };

            lastTextBox = textBox;

        }
        private void selectOMma()
        {
            try
            {
                string strDate = lastTextBox.Text;
                string[] parts = strDate.Split(new[] { "년", "월", "일", " ", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 3)
                {
                    MessageBox.Show("날짜를 (YYYY년MM월DD일) 형식으로 입력하세요.");
                    return;
                }

                currentYear = int.Parse(parts[0]);
                currentMonth = int.Parse(parts[1]);
                currentDay = int.Parse(parts[2]);

                Fill(currentYear, currentMonth);
                draw_blue(currentDay, currentMonth);
            }
            catch (Exception ex)
            {
                MessageBox.Show("날짜 형식이 올바르지 않습니다.\n예: 2025년10월7일\n\n오류: " + ex.Message);
            }
        }
        private void CtnlShiftL()
        {
            if (this.BackColor == Color.White)//테마를 밝음 어두움으로 설정(미완성)
            {
                this.BackColor = Color.FromArgb(45, 45, 60);
                //dayPanel.BackColor = Color.FromArgb(60, 63, 80);
            }
            else if (this.BackColor == Color.FromArgb(45, 45, 60))
            {
                this.BackColor = Color.White;
            }
        }
        private void Question()
        {
            shortcutKey = new shotrcutKey();
            shortcutKey.Text = "명령어 도움말";
            shortcutKey.Size = new Size(300, 919);
            shortcutKey.StartPosition = FormStartPosition.Manual;
            shortcutKey.Location = new Point(1507, 60);
            shortcutKey.Show();                 // 도움말 폼 열기
        }
        private void ESC()
        {
            // 가장 최근에 만든 텍스트박스가 존재하면 제거
            if (lastTextBox != null && this.Controls.Contains(lastTextBox))
            {
                this.Controls.Remove(lastTextBox);
                lastTextBox.Dispose();
                lastTextBox = null;

            }

            // 도움말 폼이 열려 있으면 닫기 (안됌)
            if (shortcutKey != null && !shortcutKey.IsDisposed && shortcutKey.Visible)
            {
                shortcutKey.Close();
                shortcutKey = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventMaker eventMaker = new EventMaker();
            eventMaker.Show();
        }
    }

}   

