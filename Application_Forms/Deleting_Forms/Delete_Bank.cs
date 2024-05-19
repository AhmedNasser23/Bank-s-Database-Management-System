using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Deleting_Forms
{
    public partial class Delete_Bank : Form
    {
        public Delete_Bank()
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
                            using (SqlCommand deleteCustomerCmd = new SqlCommand(
                                "DELETE FROM Customer WHERE accountNo IN (SELECT accountNumber FROM Account WHERE branchNo IN (SELECT branchNumber FROM Branch WHERE bankCode = @bankCode)) ",
                                connection, transaction))
                            {
                                deleteCustomerCmd.Parameters.AddWithValue("@bankCode", bankCode.Text);
                                deleteCustomerCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteLoanCmd = new SqlCommand(
                                "DELETE FROM Loan WHERE branchNo IN (SELECT branchNumber FROM Branch WHERE bankCode = @bankCode)",
                                connection, transaction))
                            {
                                deleteLoanCmd.Parameters.AddWithValue("@bankCode", bankCode.Text);
                                deleteLoanCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteAccountCmd = new SqlCommand(
                                "DELETE FROM Account WHERE branchNo IN (SELECT branchNumber FROM Branch WHERE bankCode = @bankCode)",
                                connection, transaction))
                            {
                                deleteAccountCmd.Parameters.AddWithValue("@bankCode", bankCode.Text);
                                deleteAccountCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteBranchCmd = new SqlCommand(
                                "DELETE FROM Branch WHERE bankCode = @bankCode",
                                connection, transaction))
                            {
                                deleteBranchCmd.Parameters.AddWithValue("@bankCode", bankCode.Text);
                                deleteBranchCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteBankCmd = new SqlCommand(
                                "DELETE FROM Bank WHERE code = @bankCode",
                                connection, transaction))
                            {
                                deleteBankCmd.Parameters.AddWithValue("@bankCode", bankCode.Text);
                                deleteBankCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Record Deleted From Bank Table.");
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
