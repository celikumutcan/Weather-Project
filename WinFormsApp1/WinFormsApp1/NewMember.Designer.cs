namespace WinFormsApp1
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            NAME = new TextBox();
            SURNAME = new TextBox();
            EMAIL = new TextBox();
            PASSWORD = new TextBox();
            REGISTER = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 17);
            label1.Name = "label1";
            label1.Size = new Size(401, 34);
            label1.TabIndex = 0;
            label1.Text = "CREATE YOUR ACCOUNT";
            label1.Click += Label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 63);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 123);
            label2.Name = "label2";
            label2.Size = new Size(93, 26);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 164);
            label3.Name = "label3";
            label3.Size = new Size(126, 26);
            label3.TabIndex = 3;
            label3.Text = "Surname :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(79, 207);
            label5.Name = "label5";
            label5.Size = new Size(96, 26);
            label5.TabIndex = 5;
            label5.Text = "E-mail :";
            label5.Click += Label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(44, 248);
            label6.Name = "label6";
            label6.Size = new Size(131, 26);
            label6.TabIndex = 6;
            label6.Text = "Password :";
            // 
            // NAME
            // 
            NAME.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NAME.Location = new Point(181, 120);
            NAME.Multiline = true;
            NAME.Name = "NAME";
            NAME.Size = new Size(185, 27);
            NAME.TabIndex = 7;
            // 
            // SURNAME
            // 
            SURNAME.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SURNAME.Location = new Point(181, 161);
            SURNAME.Multiline = true;
            SURNAME.Name = "SURNAME";
            SURNAME.Size = new Size(185, 27);
            SURNAME.TabIndex = 8;
            // 
            // EMAIL
            // 
            EMAIL.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMAIL.Location = new Point(181, 204);
            EMAIL.Multiline = true;
            EMAIL.Name = "EMAIL";
            EMAIL.Size = new Size(185, 27);
            EMAIL.TabIndex = 10;
            // 
            // PASSWORD
            // 
            PASSWORD.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PASSWORD.Location = new Point(181, 245);
            PASSWORD.Multiline = true;
            PASSWORD.Name = "PASSWORD";
            PASSWORD.PasswordChar = '*';
            PASSWORD.Size = new Size(185, 27);
            PASSWORD.TabIndex = 11;
            // 
            // REGISTER
            // 
            REGISTER.AutoSize = true;
            REGISTER.BackColor = Color.Goldenrod;
            REGISTER.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(181, 332);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(123, 26);
            REGISTER.TabIndex = 12;
            REGISTER.Text = "REGISTER";
            REGISTER.Click += REGISTER_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ActiveBorder;
            checkBox1.Location = new Point(392, 252);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(806, 446);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(REGISTER);
            Controls.Add(PASSWORD);
            Controls.Add(EMAIL);
            Controls.Add(SURNAME);
            Controls.Add(NAME);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Member";
            Load += NewMember_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox NAME;
        private TextBox SURNAME;
        private TextBox EMAIL;
        private TextBox PASSWORD;
        private Label REGISTER;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}