using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Selecting_Forms
{
    public partial class Select_Branch : Form
    {
        public Select_Branch()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.bankCode.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM Branch", connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = null;
                            dataGridView1.Columns.Clear();

                            dataGridView1.Columns.Add("branchNumber", "Branch Number");
                            dataGridView1.Columns.Add("bankCode", "Bank Code");
                            dataGridView1.Columns.Add("Address", "Branch Address");

                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataGridView1.Rows.Add(row["branchNumber"], row["bankCode"], row["Address"]);
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
                        string query = @"SELECT Br.branchNumber, Br.bankCode, Bk.[name] AS bankName
                                         FROM Branch Br JOIN Bank Bk ON Br.bankCode = Bk.code
                                         WHERE Bk.code = @bankCode";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@bankCode", bankCode.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = null;
                            dataGridView1.Columns.Clear();

                            dataGridView1.Columns.Add("branchNumber", "Branch Number");
                            dataGridView1.Columns.Add("bankCode", "Bank Code");
                            dataGridView1.Columns.Add("bankName", "Bank Name");

                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataGridView1.Rows.Add(row["branchNumber"], row["bankCode"], row["bankName"]);
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
