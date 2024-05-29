using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class ReportForm1 : Form
    {
        public ReportForm1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReportForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT C.name, C.SSN, C.phone FROM Customer C JOIN Account A ON C.accountNo = A.accountNumber JOIN Loan L ON C.loanNo = L.loanNumber WHERE A.accountType = 'Savings' AND L.loanType = 'Home' AND A.branchNo = L.branchNo;", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = null;
                        dataGridView1.Columns.Clear();

                        dataGridView1.Columns.Add("name", "Customer Name");
                        dataGridView1.Columns.Add("SSN", "Customer SSN");
                        dataGridView1.Columns.Add("phone", "Phone Number");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            dataGridView1.Rows.Add(row["name"], row["SSN"], row["phone"]);
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
