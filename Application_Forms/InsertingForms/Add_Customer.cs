using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            addCustomer.Click += (sender, e) => ClearFormFields(this);
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
        private void addCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES" +
                                                    "('" + int.Parse(ssn.Text) + "','" + int.Parse(accNumber.Text) + "','" + int.Parse(loanNumber.Text) + "','" + (name.Text) + "','" + (phoneNumber.Text) + "','" + (address.Text) + "')", connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Recored Added To Customer Table.");
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
