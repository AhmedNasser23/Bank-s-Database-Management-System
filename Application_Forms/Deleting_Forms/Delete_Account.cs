using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Deleting_Forms
{
    public partial class Delete_Account : Form
    {
        public Delete_Account()
        {
            InitializeComponent();
            deleteButton.Click += (sender, e) => ClearFormFields(this);
        }

        private void ClearFormFields(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand deleteCustomerCmd = new SqlCommand("DELETE FROM Customer WHERE accountNo = '" + int.Parse(accountNumber.Text) + "' ", connection))
                        {
                            deleteCustomerCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteAccountCmd = new SqlCommand("DELETE FROM Account WHERE accountNumber = '" + int.Parse(accountNumber.Text) + "' ", connection))
                        {
                            deleteAccountCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Record Deleted From Account Table.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
