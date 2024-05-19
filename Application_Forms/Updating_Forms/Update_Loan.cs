using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Updating_Forms
{
    public partial class Update_Loan : Form
    {
        public Update_Loan()
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
                if (c.HasChildren)
                {
                    ClearFormFields(c);
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Loan SET branchNo = '" + int.Parse(branchNumber.Text) + "', loanType = '" + loanType.Text + "', loanAmount = '" + int.Parse(loanAmout.Text) + "' WHERE loanNumber = '" + int.Parse(loanNumber.Text) + "' ", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Loan Details Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
