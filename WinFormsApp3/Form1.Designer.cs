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
            tb_withdraw_amount = new TextBox();
            bt_withdraw = new Button();
            label_notice_withdraw = new Label();
            label_cash_available = new Label();
            label_notice_moneyavailable = new Label();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(tb_withdraw_amount);
            panel1.Controls.Add(bt_withdraw);
            panel1.Controls.Add(label_notice_withdraw);
            panel1.Controls.Add(label_cash_available);
            panel1.Controls.Add(label_notice_moneyavailable);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 365);
            panel1.TabIndex = 8;
            panel1.Visible = false;
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
            ClientSize = new Size(442, 389);
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
    }
}
