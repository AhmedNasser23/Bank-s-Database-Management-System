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
                if (c.HasChildren)
                {
                    ClearFormFields(c);
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand deleteCustomerCmd = new SqlCommand("DELETE FROM Customer WHERE loanNo = @loanNumber", connection, transaction))
                            {
                                deleteCustomerCmd.Parameters.AddWithValue("@loanNumber", int.Parse(loanNumber.Text));
                                deleteCustomerCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteLoanCmd = new SqlCommand("DELETE FROM Loan WHERE loanNumber = @loanNumber", connection, transaction))
                            {
                                deleteLoanCmd.Parameters.AddWithValue("@loanNumber", int.Parse(loanNumber.Text));
                                deleteLoanCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Record Deleted From Loan Table.");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message);
                        }
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
