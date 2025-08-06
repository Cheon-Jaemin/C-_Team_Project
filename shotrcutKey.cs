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
    public partial class shotrcutKey : Form
    {
        public shotrcutKey()
        {
            InitializeComponent();
        }
        private int X = 80;
        private int Y = 30;
        int i = 0;
        private void shotrcutKey_Load(object sender, EventArgs e)
        {

            Clear();
            AddKey("일반", "");
            AddKey("", "");
            AddKey("?", "이 창 열기");
            AddKey("Tab", "포커스 이동");
            AddKey("Shift + Tab", "포커스 뒤로이동");
            AddKey("ESC", "닫기");
            AddKey("Ctnl + Shift + L", "테마변경");

            AddKey("워크플로", "");
            AddKey("", "");
            AddKey("C", "일정추가/편집");
            AddKey("Delete", "일정삭제");
            AddKey("Shift + Delete", "빠른삭제");

            AddKey("캘린더보기", "");
            AddKey("", "");
            AddKey(".", "날짜검색 이동");
            AddKey("T", "오늘 날짜로 이동");
            AddKey("M", "월 달력보기");
            AddKey("W", "주 달력보기");
            AddKey("->", "다음 날짜로 이동");
            AddKey("<-", "이전 날짜로 이동");

        }
        private void AddKey(string ShortKey, string Name)
        {
            Label myLabel = new Label();
            Label myLabel1 = new Label();


            myLabel.Location = new Point(10, 10 + Y * i);
            myLabel.Size = new Size(80, 30);
            myLabel.Text = ShortKey;    //단축키


            myLabel1.Location = new Point(10 + X, 10 + Y * i);
            myLabel1.Size = new Size(200, 30);
            myLabel1.Text = Name;        //단축키 기능


            this.Controls.Add(myLabel);
            this.Controls.Add(myLabel1);
            i++;
        }
        private void Clear()
        {
            foreach (Control ctrl in this.Controls.OfType<Label>().ToList())
            {
                this.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)                         //ESC
            {
                this.Close();                                      //최근에 연 탭 닫기
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
