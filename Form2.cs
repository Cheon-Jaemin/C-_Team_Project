using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Event_Add_Click(object sender, EventArgs e)
        {
            string title = tb_Title2.Text.Trim();
            string date = lb_Time_2.Text.Trim();
            string time = cb_TimeSet1_2.Text.Trim();  // 시간 입력 TextBox
            string time2 = cb_TimeSet1_2.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("제목을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CheckBox newTask = new CheckBox();

            newTask.AutoSize = true;
            newTask.Text = $"{date} {time} ~ {time2} - {title}";
            newTask.CheckedChanged += Task_CheckedChanged;

            flowLayoutPanel1.Controls.Add(newTask);

            tb_Title2.Clear();
        }

        private void Task_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox task = sender as CheckBox;
            if (task.Checked)
            {
                task.ForeColor = Color.Gray;
                task.Font = new Font(task.Font, FontStyle.Strikeout);
            }
            else
            {
                task.ForeColor = Color.Black;
                task.Font = new Font(task.Font, FontStyle.Regular);
            }
        }

        // 이벤트 제목을 TextBox에 입력하면 "제목" 라벨이 사라지도록 설정
        private void tb_Title2_TextChanged(object sender, EventArgs e)
        {
            lb_Title2.Visible = string.IsNullOrWhiteSpace(tb_Title2.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lb_Time_2.Text = DateTime.Now.ToString("M월 d일")
                + $"({DateTime.Now.ToString("ddd", new System.Globalization.CultureInfo("ko-KR"))})";
        }
    }
}
