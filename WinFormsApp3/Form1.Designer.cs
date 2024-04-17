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
            SuspendLayout();
            // 
            // label_noticeLogin
            // 
            label_noticeLogin.AutoSize = true;
            label_noticeLogin.Location = new Point(97, 51);
            label_noticeLogin.Name = "label_noticeLogin";
            label_noticeLogin.Size = new Size(206, 15);
            label_noticeLogin.TabIndex = 0;
            label_noticeLogin.Text = "Please enter your Card details to login";
            // 
            // textBox1_CCdetails
            // 
            textBox1_CCdetails.Location = new Point(97, 79);
            textBox1_CCdetails.Name = "textBox1_CCdetails";
            textBox1_CCdetails.Size = new Size(179, 23);
            textBox1_CCdetails.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(281, 108);
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
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Card Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 112);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "PIN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 148);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(textBox1_CCdetails);
            Controls.Add(label_noticeLogin);
            Name = "Form1";
            Text = "Form1";
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
    }
}
