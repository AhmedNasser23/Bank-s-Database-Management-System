using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_System.Selecting_Forms
{
    public partial class Select_Account : Form
    {
        public Select_Account()
        {
            InitializeComponent();
            clearButton.Click += (sender, e) => ClearFormFields(this);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.accounType.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=A7MED\MICORSOFSQLSERVE;Initial Catalog=BankSystem;Integrated Security=True;"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Account", connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Account WHERE accountType = '" + (accounType.Text) + "' ", connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
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
