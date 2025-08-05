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
        static int i = 0;
        private void shotrcutKey_Load(object sender, EventArgs e)
        {
            AddKey("단축키", "단축키 기능");
            AddKey("단축키2", "단축키 기능");
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

    }
}

