using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            add_acc.Click += (sender, e) => ClearFormFields(this);
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
        private void add_acc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Account VALUES" +
                                                    "('" + int.Parse(acc_no.Text) + "','" + int.Parse(br_no.Text) + "','" + int.Parse(balance.Text) + "','" + (acc_type.Text) + "')", connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Recored Added To Account Table.");
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
