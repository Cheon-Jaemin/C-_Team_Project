using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFrom.cs
{
    public partial class lbLogin : Form
    {
        public lbLogin()
        {
            InitializeComponent();
        }

        private void btnLoing_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


           // string correctUsername = "abc";
           // string correctPassword = "123";

            login(username, password);
            
        }

        public static void login(string uid,string ups)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=workdb;Uid=root;Pwd=1234"))
            {
                try//예외 처리
                {
                    connection.Open();
                    // string  = string.Format("UPDATE accounts_table SET name = '{1}', phone = '{2}' WHERE id={0};", index, textBoxName.Text, textBoxPhone.Text);
                    string sql = string.Format("SELECT userpassword,uname FROM usertable WHERE userid='{0}'",uid);
                    //string sql = string.Format("SELECT * FROM usertable");
                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    if (table.Read())
                    {

                        if (table["userpassword"].ToString() == ups)
                            MessageBox.Show(table["uname"].ToString());
                        else
                            MessageBox.Show("누구세요");
                    }
                    else
                        MessageBox.Show("없는 아이디");

                    
                    table.Close();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("실패");
                    
                }

            }
        }
    }
}
