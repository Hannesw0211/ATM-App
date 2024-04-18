using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] kunden = { }; //Placeholder, delete/change old loc and use db
        bool UserFound;
        int kundenID;
        String cash_available;



        private void button2_Click(object sender, EventArgs e)
        {
            String CCdetails = textBox1_CCdetails.Text;
            String PIN = textBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hannes\\Desktop\\Projekte\\WinFormsApp3\\WinFormsApp3\\ATM_Database.mdf;Integrated Security=True");
            SqlCommand cmd_search_clientID = new SqlCommand("SELECT id FROM kunden WHERE cardnumber=@CCdetails", con);
            cmd_search_clientID.Parameters.AddWithValue("@CCdetails", CCdetails);
            con.Open();

            using (SqlDataReader reader = cmd_search_clientID.ExecuteReader())
            {
                while (reader.Read())
                {
                    kundenID = int.Parse(reader[0].ToString());
                }
            }

            SqlCommand cmd_search_PIN = new SqlCommand("SELECT PIN FROM kunden WHERE id=@kundenID", con);
            cmd_search_PIN.Parameters.AddWithValue("@kundenID", kundenID);

            SqlCommand cmd_search_cashAvailable = new SqlCommand("SELECT balance FROM kunden WHERE id=@kundenID", con);
            cmd_search_cashAvailable.Parameters.AddWithValue("@kundenID", kundenID);

            using (SqlDataReader reader = cmd_search_PIN.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (PIN == reader[0].ToString())
                    {
                        UserFound = true;
                    }
                    else
                    {
                        UserFound = false;
                    }
                }
            }

            using (SqlDataReader reader = cmd_search_cashAvailable.ExecuteReader())
            {
                while (reader.Read())
                {
                    cash_available = reader[0].ToString();
                }
            }
            con.Close();

            if (UserFound)
            {
                label3.Text = "Success";
                login_success();
            }
            else
            {
                label3.Text = "Etwas ist Schiefgelaufen";

            }
        }

        private void login_success()
        {
            panel1.Visible = true;
            label_cash_available.Visible = true;
            label_cash_available.Text = cash_available;
            label_notice_moneyavailable.Visible = true;
            label_notice_withdraw.Visible = true;
            tb_withdraw_amount.Visible = true;
            bt_withdraw.Visible = true;

        }

        private void bt_withdraw_Click(object sender, EventArgs e)
        {
            String amountWithdraw = tb_withdraw_amount.Text;

            if (double.Parse(amountWithdraw) > 1000)
            {
                label_notice_withdrawError.Text = "Ihr Abhebelimit liegt bei 1000€";
            }
            else
            {
                double cash_after_withdraw = double.Parse(cash_available) - double.Parse(amountWithdraw);
                cash_after_withdraw = Math.Round(cash_after_withdraw, 2);
                label_cash_available.Text = cash_after_withdraw.ToString();

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hannes\\Desktop\\Projekte\\WinFormsApp3\\WinFormsApp3\\ATM_Database.mdf;Integrated Security=True");
                SqlCommand cmd_withdraw = new SqlCommand("UPDATE kunden SET balance = @cash_after_withdraw WHERE id=@kundenID", con);
                con.Open();
                cmd_withdraw.Parameters.AddWithValue("@cash_after_withdraw", cash_after_withdraw.ToString());
                cmd_withdraw.Parameters.AddWithValue("@kundenID", kundenID);
                cmd_withdraw.ExecuteNonQuery();
                con.Close();
            }


        }

        private void bt_QW_20_Click(object sender, EventArgs e)
        {
            double cash_after_quick_withdraw = double.Parse(cash_available) - 20;
            cash_after_quick_withdraw = Math.Round(cash_after_quick_withdraw, 2);
            label_cash_available.Text = cash_after_quick_withdraw.ToString();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hannes\\Desktop\\Projekte\\WinFormsApp3\\WinFormsApp3\\ATM_Database.mdf;Integrated Security=True");
            SqlCommand cmd_withdraw = new SqlCommand("UPDATE kunden SET balance = @cash_after_withdraw WHERE id=@kundenID", con);
            con.Open();
            cmd_withdraw.Parameters.AddWithValue("@cash_after_withdraw", cash_after_quick_withdraw.ToString());
            cmd_withdraw.Parameters.AddWithValue("@kundenID", kundenID);
            cmd_withdraw.ExecuteNonQuery();
            con.Close();
        }

        private void bt_QW_50_Click(object sender, EventArgs e)
        {
            double cash_after_quick_withdraw = double.Parse(cash_available) - 50;
            cash_after_quick_withdraw = Math.Round(cash_after_quick_withdraw, 2);
            label_cash_available.Text = cash_after_quick_withdraw.ToString();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hannes\\Desktop\\Projekte\\WinFormsApp3\\WinFormsApp3\\ATM_Database.mdf;Integrated Security=True");
            SqlCommand cmd_withdraw = new SqlCommand("UPDATE kunden SET balance = @cash_after_withdraw WHERE id=@kundenID", con);
            con.Open();
            cmd_withdraw.Parameters.AddWithValue("@cash_after_withdraw", cash_after_quick_withdraw.ToString());
            cmd_withdraw.Parameters.AddWithValue("@kundenID", kundenID);
            cmd_withdraw.ExecuteNonQuery();
            con.Close();
        }

        private void bt_QW_100_Click(object sender, EventArgs e)
        {
            double cash_after_quick_withdraw = double.Parse(cash_available) - 100;
            cash_after_quick_withdraw = Math.Round(cash_after_quick_withdraw, 2);
            label_cash_available.Text = cash_after_quick_withdraw.ToString();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hannes\\Desktop\\Projekte\\WinFormsApp3\\WinFormsApp3\\ATM_Database.mdf;Integrated Security=True");
            SqlCommand cmd_withdraw = new SqlCommand("UPDATE kunden SET balance = @cash_after_withdraw WHERE id=@kundenID", con);
            con.Open();
            cmd_withdraw.Parameters.AddWithValue("@cash_after_withdraw", cash_after_quick_withdraw.ToString());
            cmd_withdraw.Parameters.AddWithValue("@kundenID", kundenID);
            cmd_withdraw.ExecuteNonQuery();
            con.Close();
        }
    }
}
