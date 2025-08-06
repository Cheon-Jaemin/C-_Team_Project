using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_TeamProject
{
    public partial class EventMaker : Form
    {
        public EventMaker()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           DateTime cursorDateTime = Calendar.cursorDatetime;
            panel1.Size = tb_Title.Size + new Size(2, 2);
            panel1.Location = tb_Title.Location - new Size(2, 2);

            tb_Title.Parent = panel1 ;
            tb_Title.Location = new Point(1, 1);

            lb_Repeat.Visible = true;

            btn_Repeat.ForeColor = Color.DarkGray;

            // 이벤트 콤보박스 초기화
            if (cb_Event.Items.Count > 0)
                cb_Event.SelectedIndex = 0;

            // 시간 설정 콤보박스 초기화
            if (cb_TimeSet1.Items.Count > 0)
                cb_TimeSet1.SelectedIndex = 0;

            // 시간 설정 콤보박스2 초기화
            if (cb_TimeSet2.Items.Count > 0)
                cb_TimeSet2.SelectedIndex = 0;

            // 상태 설정 콤보박스 초기화
            if (cb_Status_Setting.Items.Count > 0)
                cb_Status_Setting.SelectedIndex = 0;

            // 정보 표시 여부 콤보박스 초기화
            if (cb_Information_Setting.Items.Count > 0)
                cb_Information_Setting.SelectedIndex = 0;

            // 현재 날짜 표시
            lb_Time.Text = cursorDateTime.ToString("M월 d일");
                

            // 현재 날짜 표시("종일"을 눌렀을 경우)
            lb_Time2.Text = cursorDateTime.ToString("M월 d일");

            if (Calendar.clickedLabel != null)
            {

                tb_Content.Text = Calendar.clickedLabel.Text;
            }
            else
            {
                tb_Content.Text = "";
            }

        }

        // 이벤트 제목을 TextBox에 입력하면 "제목" 라벨이 사라지도록 설정 
        private void tb_Title_TextChanged(object sender, EventArgs e)
        {
           
             lb_Title.Visible = string.IsNullOrWhiteSpace(tb_Title.Text);
        }

        // 참가자 입력 시 "참가자" 라벨이 사라지도록 설정
        private void tb_Participant_TextChanged(object sender, EventArgs e)
        {
            lb_Participant.Visible = string.IsNullOrWhiteSpace(tb_Participant.Text);
        }

        // 위치 입력 시 "위치" 라벨이 사라지도록 설정
        private void tb_Location_TextChanged(object sender, EventArgs e)
        {
            lb_Location.Visible = string.IsNullOrWhiteSpace(tb_Location.Text);
        }

        private void lb_TimeNow_Click(object sender, EventArgs e)
        {
            // 미니 달력 클릭하면 lb_TimeNow 날짜 바뀌게 설정
        }

        // "종일" 버튼 클릭 시
        private void btn_AllTime_Click(object sender, EventArgs e)
        {
            btn_AllTime.ForeColor = Color.Black;        // "종일" 버튼 글자색 변경
            btn_TimeSlot.ForeColor = Color.DarkGray;    // "시간대" 버튼 글자색 변경

            lb_Time2.Visible = true;                    // "종일" 현재 날짜 표시 라벨2 보이게 설정
            pb_Clock2.Visible = true;                   // "종일"의 시계 아이콘 보이게 설정
            pb_RightArrow2.Visible = true;              // "종일"의 화살표 보이게 설정

            pb_clock.Visible = false;                   // "시간대"의 시계 아이콘 숨김 
            cb_TimeSet1.Visible = false;                // "시간대"의 시간 설정 콤보박스 숨김
            cb_TimeSet2.Visible = false;                // "시간대"의 시간 설정 콤보박스 숨김
            pb_RightArrow.Visible = false;              // "시간대"의 화살표 숨김
        }

        // "시간대" 버튼 클릭 시
        private void btn_TimeSlot_Click(object sender, EventArgs e)
        {
            btn_AllTime.ForeColor = Color.DarkGray;     // "종일" 버튼 글자색 변경
            btn_TimeSlot.ForeColor = Color.Black;       // "시간대" 버튼 글자색 변경

            pb_Clock2.Visible = false;                  // "종일"의 시계 아이콘 숨김
            pb_RightArrow2.Visible = false;             // "종일"의 화살표 숨김
            lb_Time2.Visible = false;                   // "종일" 현재 날짜 표시 라벨2 숨김

            pb_clock.Visible = true;                    // "시간대"의 시계 아이콘 보이게 설정
            cb_TimeSet1.Visible = true;                 // "시간대"의 시간 설정 콤보박스 보이게 설정
            cb_TimeSet2.Visible = true;                 // "시간대"의 시간 설정 콤보박스 보이게 설정
            pb_RightArrow.Visible = true;               // "시간대"의 화살표 보이게 설정
        }

        // "반복" 버튼 클릭 시
        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            btn_Repeat.ForeColor = Color.Black;
        }

        // "반복" 콤보박스 선택 시
        private void cb_repeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Repeat.Visible = false;      // "반복" 라벨 숨김

            if (cb_repeat.SelectedIndex == 6) // "반복 안 함" 선택 시
            {
                lb_Repeat.Visible = true;   // "반복" 라벨 보이게 설정
                btn_Repeat.ForeColor = Color.DarkGray; // "반복" 버튼 글자색 변경

                // 콤보 박스 선택 해제
                cb_repeat.SelectedIndexChanged -= cb_repeat_SelectedIndexChanged;
                cb_repeat.SelectedIndex = -1; 
                cb_repeat.SelectedIndexChanged += cb_repeat_SelectedIndexChanged;
            }
            else
            {
                btn_Repeat.ForeColor = Color.Black; // "반복" 버튼 글자색 변경
            }
        }

        // "회의 도구" 콤보박스 선택 시
        private void cb_Meeting_Tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Meeting_Tool.Visible = false;        // "회의 도구" 라벨 숨김

            if (cb_Meeting_Tool.SelectedIndex == 2) // "선택 안 함" 선택 시
            {
                lb_Meeting_Tool.Visible = true;     // "회의 도구" 라벨 보이게 설정

                // 콤보 박스 선택 해제
                cb_Meeting_Tool.SelectedIndexChanged -= cb_Meeting_Tool_SelectedIndexChanged;
                cb_Meeting_Tool.SelectedIndex = -1; 
                cb_Meeting_Tool.SelectedIndexChanged += cb_Meeting_Tool_SelectedIndexChanged;
            }
        }

        // 상태 설정 콤보박스 선택 시
        private void btn_Status_Setting_Click(object sender, EventArgs e)
        {
            pn_Status_Setting.Visible = !pn_Status_Setting.Visible; // 상태 설정 패널 보이기/숨기기
        }

        // 정보 표시 여부 콤보박스 선택 시
        private void btn_Information_Setting_Click(object sender, EventArgs e)
        {
            pn_Information_Setting.Visible = !pn_Information_Setting.Visible; // 정보 표시 여부 패널 보이기/숨기기
        }

        // 리마인더 콤보박스 선택 시
        private void cb_Remind_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Remind.ForeColor = Color.Black; // "알림" 라벨 글자색 변경

            if (cb_Remind.SelectedIndex == 5) // "선택 안 함" 선택 시
            {
                lb_Remind.ForeColor = Color.DarkGray; // "알림" 라벨 글자색 변경

                // 콤보 박스 선택 해제
                cb_Remind.SelectedIndexChanged -= cb_Remind_SelectedIndexChanged;
                cb_Remind.SelectedIndex = -1;
                cb_Remind.SelectedIndexChanged += cb_Remind_SelectedIndexChanged;
            }
        }

        // "이벤트 색상" 버튼 클릭 시
        private void btn_Event_Color_Click(object sender, EventArgs e)
        {
            pn_Event_Color.Visible = !pn_Event_Color.Visible;
        }

    }
}

