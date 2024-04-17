using System.Windows.Forms.VisualStyles;

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
        string[,] kunden = { { "1010202030304040", "1111" }, { "2020303040405050", "2222" }, { "3030404050506060", "3333" }, { "4040505060607070", "4444" }, { "5050606070708080", "5555" }, { "6060707080809090", "6666" } };
        bool UserFound;
        int kundenID;

        private void button2_Click(object sender, EventArgs e)
        {
            String CCdetails = textBox1_CCdetails.Text;
            String PIN = textBox1.Text;

            for (int i = 0; i < (kunden.Length / 2); i++)
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
            if (UserFound && PIN == kunden[kundenID,1])
            {
                label3.Text = "Success";                
            }
            else
            {
                label3.Text = "Etwas ist Schiefgelaufen";
            }
        }
    }
}
