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
                        using (SqlCommand deleteLoanCmd = new SqlCommand("DELETE FROM Loan WHERE branchNo = '" + int.Parse(branchNumber.Text) + "'", connection))
                        {
                            deleteLoanCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteAccountCmd = new SqlCommand("DELETE FROM Account WHERE branchNo = '" + int.Parse(branchNumber.Text) + "' ", connection))
                        {
                            deleteAccountCmd.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteBranchCmd = new SqlCommand("DELETE FROM Branch WHERE branchNumber = '" + int.Parse(branchNumber.Text) + "' ", connection))
                        {
                            deleteBranchCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Record Deleted From Branch Table.");
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
