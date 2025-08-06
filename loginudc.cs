using MySql.Data.MySqlClient;
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
    public partial class loginudc : UserControl
    {
        public loginudc()
        {
            InitializeComponent();
        }



        private void btnLoing_Click_1(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.ShowDialog();
            lb_id.Text = loginForm.ID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_id.Text = null;
            login("", "");

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
                            loginForm.ID = table["username"].ToString();
                            MessageBox.Show("로그아웃 되었습니다");

                         

                            
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
