using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Add_Loan : Form
    {
        public Add_Loan()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            addLoan.Click += (sender, e) => ClearFormFields(this);
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
        private void addLoan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Loan VALUES" +
                                                    "('" + int.Parse(loanNumber.Text) + "','" + int.Parse(branchNumber.Text) + "','" + (loanType.Text) + "','" + int.Parse(loanAmount.Text) + "')", connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Recored Added To Loan Table.");
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
