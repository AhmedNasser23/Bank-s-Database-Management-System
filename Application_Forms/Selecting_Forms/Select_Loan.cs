using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Selecting_Forms
{
    public partial class Select_Loan : Form
    {
        public Select_Loan()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Select_Loan_Load(object sender, EventArgs e)
        {
            this.loanTableAdapter.Fill(this.bankSystemDataSet.Loan);
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.loanType.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM Loan", connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Loan WHERE loanType = '" + (loanType.Text) + "' ", connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
    }
}
