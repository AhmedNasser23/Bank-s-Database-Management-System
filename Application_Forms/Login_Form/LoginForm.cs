using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            clearButton.Click += (sender, e) => ClearFormFields(this);
        }

        private void ClearFormFields(Control control)
        {
            this.adminID.Clear();
            this.password.Clear();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.adminID.Text) || string.IsNullOrWhiteSpace(this.password.Text))
            {
                MessageBox.Show("Please enter your ID and password to login.");
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True"))
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Login_Table WHERE adminID = '" + int.Parse(adminID.Text) + "'", sqlConnection);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0) // I've data in dataTable
                        {
                            MessageBox.Show("Login Successfully");

                            MainForm mainForm = new MainForm();
                            mainForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password");
                            this.adminID.Clear();
                            this.password.Clear();
                            this.adminID.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
