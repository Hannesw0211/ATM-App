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
        //CC Number , PIN 
        //TODO: Database
        string[,] kunden = { { "1010", "1111", "1405,64" }, { "2020303040405050", "2222", "10,34" }, { "3030404050506060", "3333", "502,13" }, { "4040505060607070", "4444", "1,34" }, { "5050606070708080", "5555", "10404,41" }, { "6060707080809090", "6666", "692,29" } };
        bool UserFound;
        int kundenID;
        

        private void button2_Click(object sender, EventArgs e)
        {
            String CCdetails = textBox1_CCdetails.Text;
            String PIN = textBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hannes\\Desktop\\Projekte\\WinFormsApp3\\WinFormsApp3\\ATM_Database.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT PIN FROM kunden", con);
            SqlCommand cmd_search_clientID = new SqlCommand("SELECT id FROM kunden WHERE cardnumber=@CCdetails", con);
            con.Open();

            using (SqlDataReader reader = cmd_search_clientID.ExecuteReader())
            {
                while (reader.Read())
                {
                    kundenID = int.Parse(reader[0].ToString());
                }
            }

            SqlCommand cmd_search_PIN = new SqlCommand("SELECT PIN FROM kunden WHERE id=@kundenID", con);

            using (SqlDataReader reader = cmd_search_PIN.ExecuteReader())
            {
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                }
            }


            for (int i = 0; i < (kunden.Length / 3); i++)
            {


                if (CCdetails == kunden[i, 0])
                {
                    UserFound = true;
                    kundenID = i;
                }
                else
                {
                    continue;
                }
            }
            if (UserFound && PIN == kunden[kundenID, 1])
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
            label_cash_available.Text = kunden[kundenID, 2];
            label_notice_moneyavailable.Visible = true;
            label_notice_withdraw.Visible = true;
            tb_withdraw_amount.Visible = true;
            bt_withdraw.Visible = true;

        }

        private void bt_withdraw_Click(object sender, EventArgs e)
        {
            String amountWithdraw = tb_withdraw_amount.Text;
            double cash_available = double.Parse(kunden[kundenID,2]);
            double cash_after_withdraw = cash_available - double.Parse(amountWithdraw); 
            cash_after_withdraw = Math.Round(cash_after_withdraw, 2);
            kunden[kundenID, 2] = cash_after_withdraw.ToString();
            label_cash_available.Text = cash_after_withdraw.ToString();
        }
    }
}
