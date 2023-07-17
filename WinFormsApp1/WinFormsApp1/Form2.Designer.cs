namespace WinFormsApp1
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            EMAIL = new TextBox();
            label2 = new Label();
            PASSWORD = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EMAIL
            // 
            EMAIL.Font = new Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            EMAIL.Location = new Point(329, 132);
            EMAIL.Multiline = true;
            EMAIL.Name = "EMAIL";
            EMAIL.Size = new Size(144, 27);
            EMAIL.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 128, 255);
            label2.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(232, 136);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 8;
            label2.Text = "Name :";
            // 
            // PASSWORD
            // 
            PASSWORD.Font = new Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PASSWORD.Location = new Point(329, 188);
            PASSWORD.Multiline = true;
            PASSWORD.Name = "PASSWORD";
            PASSWORD.PasswordChar = '*';
            PASSWORD.Size = new Size(144, 27);
            PASSWORD.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 128, 255);
            label6.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(201, 188);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 12;
            label6.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(369, 233);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 3;
            label1.Text = "Enter";
            label1.Click += Label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 128, 255);
            label3.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(353, 352);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 4;
            label3.Text = "SIGN IN";
            label3.Click += Label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(507, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(128, 128, 255);
            label4.Font = new Font("Lucida Sans", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(303, 18);
            label4.Name = "label4";
            label4.Size = new Size(170, 34);
            label4.TabIndex = 13;
            label4.Text = "WELCOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 71);
            panel1.TabIndex = 14;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(805, 435);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(PASSWORD);
            Controls.Add(label6);
            Controls.Add(EMAIL);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOG IN";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EMAIL;
        private Label label2;
        private TextBox PASSWORD;
        private Label label6;
        private Label label1;
        private Label label3;
        private CheckBox checkBox1;
        private Label label4;
        private Panel panel1;
    }
}