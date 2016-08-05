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
    public partial class EatThis_MainMenu : Form
    {
        SqlCommand cmd;


        SqlConnection con;
        SqlDataReader Reader;
        string Query1;


        public  static int TotalPoints;
        public static int TotalMoney;
        int x50;
        int x100;
        int x150;
        int x200;
        int x250;
        int x300;
        int x350;
        int x400;
        int x450;
        int p50;
        int p100;
        int p150;
        int p200;
        int p250;
        int p300;
        int p350;
        int p400;
        int p450;




        public EatThis_MainMenu()
        {
            InitializeComponent();

            

            Do_checked();

            LBWELCOME.Text = "Welcome " + LogInForm.xxo;

            con = new SqlConnection(LogInForm.ConS);
            con.Open();



            Query1 = "SELECT * FROM [RESTAURANT] JOIN [USER] ON RESTAURANT.Log_In_Name=[USER].Log_In_Name WHERE [RESTAURANT].Log_In_Name=@Log_In_Name";

            cmd = new SqlCommand(Query1, con);
            cmd.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);



            using (Reader = cmd.ExecuteReader())
            {

                while (Reader.Read())
                {
                   // lbPoints.Text = Reader["Points"].ToString();
                    LB_checkCustomer.Text = Reader["Points"].ToString();
                }
            }
            Reader.Close();
            con.Close();
        }

        private void but_EnterCheckCustomer_Click(object sender, EventArgs e)
        {




            con = new SqlConnection(LogInForm.ConS);
            con.Open();
            Query1 = "SELECT * FROM [RESTAURANT] JOIN [USER] ON [RESTAURANT].Log_In_Name=[USER].Log_In_Name WHERE [RESTAURANT].Log_In_Name=@Log_In_Name";
            cmd = new SqlCommand(Query1, con);
            cmd.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);
            int PointAmountSUB = (Int32.Parse(txtPurchaseAmount.Text) * 10);

            



            try
            {
               
                
                DialogResult dialoResult = MessageBox.Show("By Pressing OK, points will be transfer points to Customer ", "Eat This!", MessageBoxButtons.OKCancel);

                if (PointAmountSUB <= 0)
                {
                    MessageBox.Show("Please use a number greater than 0.");
                }
                
                
                
             else  if (dialoResult == DialogResult.OK)
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE [USER] SET Points = Points - @PointAmountSub WHERE Log_In_Name=@Log_In_Name", con);
                    cmd1.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);
                    cmd1.Parameters.AddWithValue("@PointAmountSub", PointAmountSUB);

  

                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("UPDATE [USER] SET Points = Points + @PointAmountSub WHERE Log_In_Name=@Log_In_Name", con);
                    cmd2.Parameters.AddWithValue("@Log_In_Name", txtCustomerID.Text); //1000
                    cmd2.Parameters.AddWithValue("@PointAmountSub", PointAmountSUB);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO [TRANSACTION_INFO]  (Source_Name, Destination_Name, Trans_Type_ID, Amount_Money, Amount_Points,Time_Stamp) VALUES (@Log_In_Name, @Customer, @2, @Amount_Money, @Amount_Points,@Time_Stamp)", con);
                    cmd3.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);
                    cmd3.Parameters.AddWithValue("@Customer", txtCustomerID.Text);
                    cmd3.Parameters.AddWithValue("@2", "2");
                    cmd3.Parameters.AddWithValue("@Amount_Money", txtPurchaseAmount.Text);
                    cmd3.Parameters.AddWithValue("@Amount_Points", PointAmountSUB);
                    cmd3.Parameters.AddWithValue("@Time_Stamp", DateTime.Now);
                    cmd3.ExecuteNonQuery();

                    
                }
                if (dialoResult == DialogResult.Cancel)
                {

                }
            }
            finally
            {
                if (PointAmountSUB >= 0)
                {

                    using (Reader = cmd.ExecuteReader())
                {

                        while (Reader.Read())
                        {

                            con = new SqlConnection(LogInForm.ConS);
                            con.Open();
                            Query1 = "SELECT * FROM [RESTAURANT] JOIN [USER] ON [RESTAURANT].Log_In_Name=[USER].Log_In_Name WHERE [RESTAURANT].Log_In_Name=@Log_In_Name";
                            cmd = new SqlCommand(Query1, con);
                            cmd.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);

                            //lbPoints.Text = Reader["Points"].ToString();
                            LB_checkCustomer.Text = Reader["Points"].ToString();



                            
                        }
                        Reader.Close();

                        con.Close();
                    }

                
                }

            }

        }

        private void Ch50_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch100_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch150_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch200_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch250_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch300_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch350_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch400_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Ch450_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Do_checked()
        {
            if (Ch50.Checked == true)
            {
                x50 = 250;
                p50 = 50;
            }
            else
            {
                x50 = 0;
                p50 = 0;
            }
            if (Ch100.Checked == true)
            {
                x100 = 500;
                p100 = 100;
            }
            else
            {
                x100 = 0;
                p100 = 0;
            }
            if (Ch150.Checked == true)
            {
                x150 = 750;
                p150 = 150;
            }
            else
            {
                x150 = 0;
                p150 = 0;
            }
            if (Ch200.Checked == true)
            {
                x200 = 1000;
                p200 = 200;
            }
            else
            {
                x200 = 0;
                p200 = 0;
            }
            if (Ch250.Checked == true)
            {
                x250 = 1250;
                p250 = 250;
            }
            else
            {
                x250 = 0;
                p250 = 0;
            }
            if (Ch300.Checked == true)
            {
                x300 = 1500;
                p300 = 300;
            }
            else
            {
                x300 = 0;
                p300 = 0;
            }
            if (Ch350.Checked == true)
            {
                x350 = 1750;
                p350 = 350;
            }
            else
            {
                x350 = 0;
                p350 = 0;
            }
            if (Ch400.Checked == true)
            {
                x400 = 2000;
                p400 = 400;
            }
            else
            {
                x400 = 0;
                p400 = 0;
            }
            if (Ch450.Checked == true)
            {
                x450 = 2250;
                p450 = 450;
            }
            else
            {
                x450 = 0;
                p450 = 0;
            }


            TotalPoints = x50 + x100 + x150 + x200 + x250 + x300 + x350 + x400 + x450;
            TotalMoney = p50 + p100 + p150 + p200 + p250 + p300 + p350 + p400 + p450;
            lbTotalPoints.Text = TotalPoints.ToString();
        }

        private void but_BuyPoints_Click(object sender, EventArgs e)
        {
            ReenterPW xEnterPW = new ReenterPW();
            xEnterPW.Show();

            
        }

        private void combDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          //  Query1 = "SELECT * FROM [RESTAURANT] JOIN [USER] ON [RESTAURANT].Log_In_Name=[USER].Log_In_Name WHERE [RESTAURANT].Log_In_Name=@Log_In_Name";
         //   cmd = new SqlCommand(Query1, con);
         //   cmd.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);
          //  int PointAmountSUB = (Int32.Parse(txtPurchaseAmount.Text) * 10);
          
            con.Open();
            Query1 = "SELECT * FROM [RESTAURANT] JOIN [USER] ON [RESTAURANT].Log_In_Name=[USER].Log_In_Name WHERE [RESTAURANT].Log_In_Name=@Log_In_Name";
            cmd = new SqlCommand(Query1, con);
            cmd.Parameters.AddWithValue("@Log_In_Name", LogInForm.xxo);

            using (Reader = cmd.ExecuteReader())
            { 

                while (Reader.Read())
                {
                  //  combDate.Items.Add.(Reader[0]);
                }
            }
        }
    }
       
}

