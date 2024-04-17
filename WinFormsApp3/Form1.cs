using System.Windows.Forms.VisualStyles;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kunden = ["5050", "6060", "7070"];
        bool UserFound;
        private void button1_Click(object sender, EventArgs e)
        {
            String CCdetails = textBox1.Text;

            for (int i = 0; i < kunden.Length; i++)
            {
                
                
                if (CCdetails == kunden[i])
                {
                    UserFound = true;
                }
                else
                {
                    continue;
                }
            }
            if (UserFound)
            {
                label1.Text = "Success";
            }
        }
    }
}
