using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Updating_Forms
{
    public partial class Update_Bank : Form
    {
        public Update_Bank()
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
                    SqlCommand cmd = new SqlCommand("UPDATE Bank SET name = '" + bankName.Text + "', address = '" + bankAddress.Text + "' WHERE code = '" + bankCode.Text + "' ", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bank Details Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
