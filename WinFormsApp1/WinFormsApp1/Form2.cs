using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class LOGIN : Form
    {

        string path = Application.StartupPath + "\\database.db";


        //  The `LOGIN()` function is a C# constructor that initializes GUI components for a login screen or form.
        //  It follows the PascalCase naming convention and could benefit from additional comments for clarity and context.
        public LOGIN()
        {
            InitializeComponent();
        }


        //  The label3_Click function is an event handler in C# that is triggered when a specific label is clicked.
        //  It creates a new instance of the NewMember class and shows the associated form or screen.
        //  The function seems to be designed to handle the event of creating a new member, but without more context, it's challenging to provide further details or improvements.
        private void Label3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                NewMember newMember = new();
                newMember.Show();
            }
        }


        private void Form2_Load(object sender, EventArgs e) { }


        //  The code handles the click event of a label and validates the user's input for email and password.
        //  It displays appropriate error messages if the input is missing or incorrect and proceeds with the login process if the input is valid.
        private void Label1_Click(object sender, EventArgs e)
        {
            string email = EMAIL.Text.Trim();
            string password = PASSWORD.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your e-mail and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your e-mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool active = Loginstatus(email, password);
                if (active)
                {
                    Form1 firstform = new();
                    firstform.Show();
                }
                else
                {
                    MessageBox.Show("Member Not Found!\nPlease Try Again!");
                }
            }
        }


        //  The loginstatus function connects to a SQLite database, executes a query to check if the provided email and password match a row in the "properties" table,
        //      and returns true if a match is found, false otherwise. It also handles any exceptions that may occur during the database operations and displays an error message.
        public bool Loginstatus(string email, string password)
        {
            string sqlitetb2 = $"Data source = {path};Version=3;";

            using (var connect = new SQLiteConnection(sqlitetb2))
            {
                using (var command = new SQLiteCommand("SELECT * FROM properties WHERE Name=@Email AND Password=@Password", connect))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        command.Connection.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot reach database!");
                    }
                }
            }
            return false;
        }


        //  The function handles the change event of a checkbox control, toggles the visibility of password characters in the associated password field based on the checkbox state,
        //      and updates the text of the checkbox to reflect the current visibility state.
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