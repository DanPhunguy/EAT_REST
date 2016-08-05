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
    public partial class LogInForm : Form
    {
        
        public static string ConS = @"Data Source=DESKTOP-0AETRH1\SQLEXPRESS;Initial Catalog=Eat_This;Integrated Security=True";
        public static string xxo;
        public static string Pkey;


        SqlCommand cmd;

      
        SqlConnection con;
        SqlDataReader Reader;
        string Query;
        
     


        public LogInForm()
        {
            InitializeComponent();
        }

 
        private void BUT_Enter_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConS);


            try
            {
                con.Open();
                Query = "SELECT * FROM [USER] WHERE Log_In_Name=@Log_In_Name AND Log_In_Password=@Log_In_Password AND User_Type='R'";
                cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@Log_In_Name", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Log_In_Password", txtPassword.Text);

                xxo = txtUserName.Text;

                Reader = cmd.ExecuteReader();

                if(Reader.Read())
                {
                    MessageBox.Show("Log In Successful");

                  EatThis_MainMenu xMenu = new EatThis_MainMenu();

                   // Pkey = Reader["USER_ID"].ToString();
                   
                    xMenu.Show();

                   
                    this.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Invalid RestaurantName or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Reader.Close();
                con.Close();
            }

        }
     }
}
