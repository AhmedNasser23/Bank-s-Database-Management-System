using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Deleting_Forms
{
    public partial class Delete_Branch : Form
    {
        public Delete_Branch()
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
                            using (SqlCommand deleteLoanCmd = new SqlCommand("DELETE FROM Loan WHERE branchNo = @branchNumber", connection, transaction))
                            {
                                deleteLoanCmd.Parameters.AddWithValue("@branchNumber", int.Parse(branchNumber.Text));
                                deleteLoanCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteAccountCmd = new SqlCommand("DELETE FROM Account WHERE branchNo = @branchNumber", connection, transaction))
                            {
                                deleteAccountCmd.Parameters.AddWithValue("@branchNumber", int.Parse(branchNumber.Text));
                                deleteAccountCmd.ExecuteNonQuery();
                            }
                            using (SqlCommand deleteBranchCmd = new SqlCommand("DELETE FROM Branch WHERE branchNumber = @branchNumber", connection, transaction))
                            {
                                deleteBranchCmd.Parameters.AddWithValue("@branchNumber", int.Parse(branchNumber.Text));
                                deleteBranchCmd.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Record Deleted From Branch Table.");
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
