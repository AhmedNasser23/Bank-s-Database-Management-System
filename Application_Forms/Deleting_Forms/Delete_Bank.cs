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
                        using (SqlCommand deleteCustomerCmd = new SqlCommand(
                            "DELETE FROM Customer WHERE accountNo IN (SELECT accountNumber FROM Account WHERE branchNo IN (SELECT branchNumber FROM Branch WHERE bankCode = '" + bankCode.Text + "')) ",
                            connection))
                        {
                            deleteCustomerCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteLoanCmd = new SqlCommand(
                            "DELETE FROM Loan WHERE branchNo IN (SELECT branchNumber FROM Branch WHERE bankCode = '" + bankCode.Text + "')",
                            connection))
                        {
                            deleteLoanCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteAccountCmd = new SqlCommand(
                            "DELETE FROM Account WHERE branchNo IN (SELECT branchNumber FROM Branch WHERE bankCode = '" + bankCode.Text + "')",
                            connection))
                        {
                            deleteAccountCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteBranchCmd = new SqlCommand(
                            "DELETE FROM Branch WHERE bankCode = '" + bankCode.Text + "'",
                            connection))
                        {
                            deleteBranchCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteBankCmd = new SqlCommand(
                            "DELETE FROM Bank WHERE code = '" + bankCode.Text + "' ",
                            connection))
                        {
                            deleteBankCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Record Deleted From Bank Table.");
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
