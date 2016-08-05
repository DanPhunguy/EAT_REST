using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EAT_ThisLogin
{
    public partial class ReenterPW : Form
    {

        SqlConnection con = new SqlConnection(LogInForm.ConS);
        public ReenterPW()
        {
            InitializeComponent();
            LbNotice.Text = "By Pressing ACCEPT, you agree to pay $" + EatThis_MainMenu.TotalMoney + "\r\nNote: This will be charge on your credit on file";
        }
        public static int xx;

        private void ButEnterPw_Click(object sender, EventArgs e)
        {

            
            con.Open();
            string Query = "SELECT * FROM [USER] WHERE Log_In_Name=@Log_In_Name";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);

            SqlDataReader Reader;
            using (Reader = cmd.ExecuteReader())
            {
                if (Reader.Read())
                {
                    string PW = Reader["Log_In_Password"].ToString();

                    if (PW == txtPasswordRelog.Text)
                    {
                        xlabel.Text = "YES";
                        xx = 1;
                        
                    }
                    else
                    {
                        xlabel.Text = "Incorrect Password";

                        xx = 0;
                    }
                    Reader.Close();
                    con.Close();
                }

                if (1 == ReenterPW.xx)
                {
                    SqlConnection con = new SqlConnection(LogInForm.ConS);
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("UPDATE [USER] SET Points = Points + @TotalPoints WHERE Log_In_Name=@Log_In_Name", con);
                    cmd1.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);
                    cmd1.Parameters.AddWithValue("@TotalPoints", EatThis_MainMenu.TotalPoints);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO [TRANSACTION_INFO]  (Source_Name, Destination_Name, Trans_Type_ID, Amount_Money, Amount_Points,Time_Stamp) VALUES (@EAT_THIS, @Restaurant, @1, @Amount_Money, @Amount_Points,@Time_Stamp)", con);
                    cmd3.Parameters.AddWithValue("@EAT_THIS", "CourtneyLe");
                    cmd3.Parameters.AddWithValue("@Restaurant", LogInForm.xxo);
                    cmd3.Parameters.AddWithValue("@1", "1");
                    cmd3.Parameters.AddWithValue("@Amount_Money", EatThis_MainMenu.TotalMoney);
                    cmd3.Parameters.AddWithValue("@Amount_Points", EatThis_MainMenu.TotalPoints);
                    cmd3.Parameters.AddWithValue("@Time_Stamp", DateTime.Now);
                    cmd3.ExecuteNonQuery();

                    con.Close();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("It didnt work");
                }
            }

        }
    }
}
