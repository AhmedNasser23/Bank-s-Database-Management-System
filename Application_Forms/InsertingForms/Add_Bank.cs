using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Insertin_Forms
{
    public partial class Add_Bank : Form
    {
        public Add_Bank()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            ad_bn.Click += (sender, e) => ClearFormFields(this);
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

        private void ad_bn_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Bank VALUES" +
                                                    "('" + (bankCode.Text) + "','" + (bankName.Text) + "','" + (bankAddress.Text) + "')", connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Recored Added To Bank Table.");
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
