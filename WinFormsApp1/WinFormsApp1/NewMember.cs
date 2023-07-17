using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class NewMember : Form
    {

        string path = Application.StartupPath + "\\database.db";

        public NewMember()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e) { }

        private void Label5_Click(object sender, EventArgs e) { }

        private void NewMember_Load(object sender, EventArgs e) { }


        //  The function handles the click event of a "REGISTER" button, performs validation checks on input fields,
        //      inserts a new record into an SQLite database table, and displays appropriate success or error messages based on the outcome.
        private void REGISTER_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NAME.Text))
            {
                MessageBox.Show("Please enter your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(SURNAME.Text))
            {
                MessageBox.Show("Please enter your surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(EMAIL.Text))
            {
                MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(PASSWORD.Text))
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = NewMemberStatus(NAME.Text, SURNAME.Text, EMAIL.Text, PASSWORD.Text);
                if (success)
                {
                    MessageBox.Show("Successfully");
                    this.Hide();
                    LOGIN logg = new();
                    logg.Show();
                }
                else
                {
                    MessageBox.Show("Failed to register user.");
                }
            }
        }

        public bool NewMemberStatus(string name, string surname, string email, string password)
        {
            string sqlitetb1 = $"Data source = {path};Version=3;";

            using (var connect = new SQLiteConnection(sqlitetb1))
            {
                using (var command = new SQLiteCommand($"INSERT INTO properties(Name, Surname, email, password) VALUES(@Name, @Surname, @Email, @Password)", connect))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            return false;
        }


        //   The function handles the change event of a checkbox control, toggles the visibility of password characters in the associated password
        //      field based on the checkbox state, and updates the text of the checkbox to reflect the current visibility state.
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                PASSWORD.UseSystemPasswordChar = true;
                checkBox1.Text = "Don't show password";
            }
            else
            {
                PASSWORD.UseSystemPasswordChar = false;
                checkBox1.Text = "Show password";
            }
        }
    }
}