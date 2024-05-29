using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Updating_Forms
{
    public partial class Update_Account : Form
    {
        public Update_Account()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            updateButton.Click += (sender, e) => ClearFormFields(this);
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
        private void updateButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Account SET branchNo = '" + int.Parse(branchNumber.Text) + "', balance = '" + int.Parse(balance.Text) + "', accountType = '" + accountType.Text + "' WHERE accountNumber = '" + int.Parse(accountNumber.Text) + "' ", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Details Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
