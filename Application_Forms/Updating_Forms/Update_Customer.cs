using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Updating_Forms
{
    public partial class Update_Customer : Form
    {
        public Update_Customer()
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
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET accountNo = '" + int.Parse(accountNumber.Text) + "', loanNo = '" + int.Parse(loanNumber.Text) + "', name = '" + (name.Text) + "', phone = '" + phoneNumber.Text + "', address = '" + addresss.Text + "' WHERE SSN = '" + int.Parse(ssn.Text) + "' ", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Details Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
