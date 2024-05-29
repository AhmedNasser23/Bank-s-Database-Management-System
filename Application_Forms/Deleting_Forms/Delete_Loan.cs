using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Deleting_Forms
{
    public partial class Delete_Loan : Form
    {
        public Delete_Loan()
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
                        using (SqlCommand deleteCustomerCmd = new SqlCommand("DELETE FROM Customer WHERE loanNo = '" + int.Parse(loanNumber.Text) + "' ", connection))
                        {
                            deleteCustomerCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteLoanCmd = new SqlCommand("DELETE FROM Loan WHERE loanNumber = '" + int.Parse(loanNumber.Text) + "' ", connection))
                        {
                            deleteLoanCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Record Deleted From Loan Table.");
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
