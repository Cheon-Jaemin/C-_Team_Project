using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_TeamProject
{
    public partial class loginForm : Form
    {
        public static string ID;
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLoing_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;




            login(username, password);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)                           //탭
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                login(username, password);
                return true;
            }

            

            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void login(string uid, string ups)
        {
            using (MySqlConnection connection = new MySqlConnection("Server='teamproj-calendar.cxgqa06ootsh.ap-northeast-2.rds.amazonaws.com';Port=3306;Database=calSchema;Uid=admin;Pwd=12345678"))
            {
                try//예외 처리
                {
                    connection.Open();
                    // string  = string.Format("UPDATE accounts_table SET name = '{1}', phone = '{2}' WHERE id={0};", index, textBoxName.Text, textBoxPhone.Text);
                    string sql = string.Format("SELECT name,username,password,group_name FROM users WHERE username='{0}'", uid);

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();
                    DialogResult dialogResult;
                    if (table.Read())
                    {

                        if (table["password"].ToString() == ups)
                        {
                            Calendar.yourGroupValue = table.GetInt16("group_name");
                            ID = table["username"].ToString();
                            
                            dialogResult = MessageBox.Show(table["name"].ToString() + "님 환영해요", "login", MessageBoxButtons.OK);

                            if (dialogResult == DialogResult.OK)
                                this.Close();
                        }
                        else
                            MessageBox.Show("계정의 정보가 맞지않아요");
                    }
                    else
                        MessageBox.Show("계정의 정보를 찾을 수 없어요");

                    table.Close();




                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

            }
        }

        
    }
}
