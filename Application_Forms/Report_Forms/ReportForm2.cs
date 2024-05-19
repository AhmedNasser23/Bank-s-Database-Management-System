using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class ReportForm2 : Form
    {
        public ReportForm2()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReportForm2_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT L.branchNo, L.loanType, SUM(L.loanAmount) AS totalLoanAmount FROM Loan L GROUP BY L.branchNo, L.loanType HAVING SUM(L.loanAmount) > 50000", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = null;
                        dataGridView1.Columns.Clear();

                        dataGridView1.Columns.Add("branchNo", "Branch Number");
                        dataGridView1.Columns.Add("loanType", "Loan Type");
                        dataGridView1.Columns.Add("totalLoanAmount", "Total Loan Amount");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            dataGridView1.Rows.Add(row["branchNo"], row["loanType"], row["totalLoanAmount"]);
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
}
