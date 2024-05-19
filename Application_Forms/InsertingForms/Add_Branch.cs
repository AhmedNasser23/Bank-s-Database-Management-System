using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Add_Branch : Form
    {
        public Add_Branch()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            addBranch.Click += (sender, e) => ClearFormFields(this);
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
        private void addBranch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Branch VALUES" +
                                                    "('" + int.Parse(br_no.Text) + "','" + (bk_code.Text) + "','" + (br_add.Text) + "')", connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Recored Added To Branch Table.");
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
