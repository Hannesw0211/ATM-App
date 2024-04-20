namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_noticeLogin = new Label();
            textBox1_CCdetails = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label_notice_transaktions = new Label();
            dataGridView1 = new DataGridView();
            bt_QW_100 = new Button();
            bt_QW_50 = new Button();
            bt_QW_20 = new Button();
            label_quick_withdraw = new Label();
            label_notice_withdrawError = new Label();
            tb_withdraw_amount = new TextBox();
            bt_withdraw = new Button();
            label_notice_withdraw = new Label();
            label_cash_available = new Label();
            label_notice_moneyavailable = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_noticeLogin
            // 
            label_noticeLogin.AutoSize = true;
            label_noticeLogin.Location = new Point(118, 134);
            label_noticeLogin.Name = "label_noticeLogin";
            label_noticeLogin.Size = new Size(206, 15);
            label_noticeLogin.TabIndex = 0;
            label_noticeLogin.Text = "Please enter your Card details to login";
            // 
            // textBox1_CCdetails
            // 
            textBox1_CCdetails.Location = new Point(118, 162);
            textBox1_CCdetails.Name = "textBox1_CCdetails";
            textBox1_CCdetails.Size = new Size(179, 23);
            textBox1_CCdetails.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(302, 191);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 165);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Card Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 195);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "PIN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 231);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_notice_transaktions);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(bt_QW_100);
            panel1.Controls.Add(bt_QW_50);
            panel1.Controls.Add(bt_QW_20);
            panel1.Controls.Add(label_quick_withdraw);
            panel1.Controls.Add(label_notice_withdrawError);
            panel1.Controls.Add(tb_withdraw_amount);
            panel1.Controls.Add(bt_withdraw);
            panel1.Controls.Add(label_notice_withdraw);
            panel1.Controls.Add(label_cash_available);
            panel1.Controls.Add(label_notice_moneyavailable);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 426);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // label_notice_transaktions
            // 
            label_notice_transaktions.AutoSize = true;
            label_notice_transaktions.Location = new Point(48, 190);
            label_notice_transaktions.Name = "label_notice_transaktions";
            label_notice_transaktions.Size = new Size(80, 15);
            label_notice_transaktions.TabIndex = 11;
            label_notice_transaktions.Text = "Transaktionen";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(341, 215);
            dataGridView1.TabIndex = 10;
            // 
            // bt_QW_100
            // 
            bt_QW_100.Location = new Point(140, 153);
            bt_QW_100.Name = "bt_QW_100";
            bt_QW_100.Size = new Size(42, 23);
            bt_QW_100.TabIndex = 9;
            bt_QW_100.Text = "100€";
            bt_QW_100.UseVisualStyleBackColor = true;
            bt_QW_100.Click += bt_QW_100_Click;
            // 
            // bt_QW_50
            // 
            bt_QW_50.Location = new Point(92, 153);
            bt_QW_50.Name = "bt_QW_50";
            bt_QW_50.Size = new Size(42, 23);
            bt_QW_50.TabIndex = 8;
            bt_QW_50.Text = "50€";
            bt_QW_50.UseVisualStyleBackColor = true;
            bt_QW_50.Click += bt_QW_50_Click;
            // 
            // bt_QW_20
            // 
            bt_QW_20.Location = new Point(44, 153);
            bt_QW_20.Name = "bt_QW_20";
            bt_QW_20.Size = new Size(42, 23);
            bt_QW_20.TabIndex = 7;
            bt_QW_20.Text = "20€";
            bt_QW_20.UseVisualStyleBackColor = true;
            bt_QW_20.Click += bt_QW_20_Click;
            // 
            // label_quick_withdraw
            // 
            label_quick_withdraw.AutoSize = true;
            label_quick_withdraw.Location = new Point(44, 132);
            label_quick_withdraw.Name = "label_quick_withdraw";
            label_quick_withdraw.Size = new Size(92, 15);
            label_quick_withdraw.TabIndex = 6;
            label_quick_withdraw.Text = "Quick Withdraw";
            // 
            // label_notice_withdrawError
            // 
            label_notice_withdrawError.AutoSize = true;
            label_notice_withdrawError.Location = new Point(222, 96);
            label_notice_withdrawError.Name = "label_notice_withdrawError";
            label_notice_withdrawError.Size = new Size(0, 15);
            label_notice_withdrawError.TabIndex = 5;
            // 
            // tb_withdraw_amount
            // 
            tb_withdraw_amount.Location = new Point(221, 70);
            tb_withdraw_amount.Name = "tb_withdraw_amount";
            tb_withdraw_amount.Size = new Size(100, 23);
            tb_withdraw_amount.TabIndex = 4;
            tb_withdraw_amount.Visible = false;
            // 
            // bt_withdraw
            // 
            bt_withdraw.Location = new Point(327, 69);
            bt_withdraw.Name = "bt_withdraw";
            bt_withdraw.Size = new Size(75, 23);
            bt_withdraw.TabIndex = 3;
            bt_withdraw.Text = "Withdraw";
            bt_withdraw.UseVisualStyleBackColor = true;
            bt_withdraw.Visible = false;
            bt_withdraw.Click += bt_withdraw_Click;
            // 
            // label_notice_withdraw
            // 
            label_notice_withdraw.AutoSize = true;
            label_notice_withdraw.Location = new Point(221, 42);
            label_notice_withdraw.Name = "label_notice_withdraw";
            label_notice_withdraw.Size = new Size(165, 15);
            label_notice_withdraw.TabIndex = 2;
            label_notice_withdraw.Text = "Enter the amount to withdraw";
            label_notice_withdraw.Visible = false;
            // 
            // label_cash_available
            // 
            label_cash_available.AutoSize = true;
            label_cash_available.Location = new Point(44, 73);
            label_cash_available.Name = "label_cash_available";
            label_cash_available.Size = new Size(69, 15);
            label_cash_available.TabIndex = 1;
            label_cash_available.Text = "placeholder";
            label_cash_available.Visible = false;
            // 
            // label_notice_moneyavailable
            // 
            label_notice_moneyavailable.AutoSize = true;
            label_notice_moneyavailable.Location = new Point(44, 42);
            label_notice_moneyavailable.Name = "label_notice_moneyavailable";
            label_notice_moneyavailable.Size = new Size(93, 15);
            label_notice_moneyavailable.TabIndex = 0;
            label_notice_moneyavailable.Text = "Money available";
            label_notice_moneyavailable.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(textBox1_CCdetails);
            Controls.Add(label_noticeLogin);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_noticeLogin;
        private TextBox textBox1_CCdetails;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox tb_withdraw_amount;
        private Button bt_withdraw;
        private Label label_notice_withdraw;
        private Label label_cash_available;
        private Label label_notice_moneyavailable;
        private Label label_notice_withdrawError;
        private Label label_quick_withdraw;
        private Button bt_QW_100;
        private Button bt_QW_50;
        private Button bt_QW_20;
        private DataGridView dataGridView1;
        private Label label_notice_transaktions;
    }
}
