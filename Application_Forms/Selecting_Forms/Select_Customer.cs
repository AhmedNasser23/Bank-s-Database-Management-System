using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Selecting_Forms
{
    public partial class Select_Customer : Form
    {
        public Select_Customer()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.loanNumber.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = null;
                            dataGridView1.Columns.Clear();

                            dataGridView1.Columns.Add("ssn", "SSN");
                            dataGridView1.Columns.Add("accountNo", "Account Number");
                            dataGridView1.Columns.Add("loanNo", "Loan Number");
                            dataGridView1.Columns.Add("name", "Customer Name");
                            dataGridView1.Columns.Add("phone", "Phone Number");
                            dataGridView1.Columns.Add("address", "Customer Address");

                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataGridView1.Rows.Add(row["ssn"], row["accountNo"], row["loanNo"], row["name"], row["phone"], row["address"]);
                            }
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
                    using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                    {
                        connection.Open();
                        string query = @"select Ct.SSN, Ct.accountNo, Ct.loanNo, Ct.[name], Ct.phone, Ct.[address], Lo.loanType, Lo.loanAmount
                                        from Customer Ct join Loan Lo
                                        on Ct.loanNo = Lo.loanNumber
                                        where Ct.loanNo = @loanNumber";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@loanNumber", int.Parse(loanNumber.Text));

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = null;
                            dataGridView1.Columns.Clear();

                            dataGridView1.Columns.Add("ssn", "SSN");
                            dataGridView1.Columns.Add("accountNo", "Account Number");
                            dataGridView1.Columns.Add("loanNo", "Loan Number");
                            dataGridView1.Columns.Add("name", "Customer Name");
                            dataGridView1.Columns.Add("phone", "Phone Number");
                            dataGridView1.Columns.Add("address", "Customer Address");
                            dataGridView1.Columns.Add("loanType", "Loan Type");
                            dataGridView1.Columns.Add("loanAmount", "Loan Amount");


                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataGridView1.Rows.Add(row["ssn"], row["accountNo"], row["loanNo"], row["name"], row["phone"], row["address"], row["loanType"], row["loanAmount"]);
                            }
                        }
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
