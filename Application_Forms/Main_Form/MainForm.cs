using Bank_System.Deleting_Forms;
using Bank_System.Insertin_Forms;
using Bank_System.Selecting_Forms;
using Bank_System.Updating_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class MainForm : Form
    {
        MenuStrip menuStrip = new MenuStrip();

        public MainForm()
        {
            InitializeComponent();
            CustomizeForm();
            this.Resize += Form1_Resize;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            menuStrip.Padding = new Padding((this.Width - menuStrip.PreferredSize.Width) / 2, 0, 0, 0);
        }

        private void CustomizeForm()
        {
            this.Text = "Bank's Database Management System";
            this.Size = new Size(900, 600);

            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 100;
            headerPanel.BackColor = Color.Teal;

            menuStrip.Items.AddRange(new ToolStripItem[] {
            insertMenu, updateMenu, selectMenu, deleteMenu});
            menuStrip.Dock = DockStyle.Top;
            menuStrip.AutoSize = false;
            menuStrip.Height = 70;
            menuStrip.BackColor = Color.DarkGray;
            menuStrip.ForeColor = Color.GhostWhite;
            menuStrip.Padding = new Padding((this.Width - menuStrip.PreferredSize.Width) / 2, 0, 0, 0);
            menuStrip.Font = new Font("Arial Rounded MT Bold", 12F);
            this.Controls.Add(menuStrip);

            Label titleLabel = new Label();
            titleLabel.Text = "Bank's Database Management System";
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Arial", 30, FontStyle.Bold);
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerPanel.Controls.Add(titleLabel);
            this.Controls.Add(headerPanel);
        }
        // ---------------------------------------------------------------------
        // Inserting Data
        // ---------------------------------------------------------------------
        private void in_Bank_Click_1(object sender, EventArgs e)
        {
            Add_Bank frm = new Add_Bank();
            frm.Show();
        }

        private void in_Branch_Click_1(object sender, EventArgs e)
        {
            Add_Branch frm = new Add_Branch();
            frm.Show();
        }

        private void in_Loan_Click_1(object sender, EventArgs e)
        {
            Add_Loan frm = new Add_Loan();
            frm.Show();
        }

        private void in_Customer_Click_1(object sender, EventArgs e)
        {
            Add_Customer frm = new Add_Customer();
            frm.Show();
        }

        private void in_Account_Click_1(object sender, EventArgs e)
        {
            Add_Account frm = new Add_Account();
            frm.Show();
        }

        // ---------------------------------------------------------------------
        // Updating Data
        // ---------------------------------------------------------------------
        private void up_Bank_Click_1(object sender, EventArgs e)
        {
            Update_Bank frm = new Update_Bank();
            frm.Show();
        }
        private void up_Branch_Click_1(object sender, EventArgs e)
        {
            Update_Branch frm = new Update_Branch();
            frm.Show();
        }
        private void up_Loan_Click_1(object sender, EventArgs e)
        {
            Update_Loan frm = new Update_Loan();
            frm.Show();
        }

        private void up_Customer_Click_1(object sender, EventArgs e)
        {
            Update_Customer frm = new Update_Customer();
            frm.Show();
        }

        private void up_Account_Click_1(object sender, EventArgs e)
        {
            Update_Account frm = new Update_Account();
            frm.Show();
        }

        // ---------------------------------------------------------------------
        // Selecting Data
        // ---------------------------------------------------------------------
        private void se_Bank_Click_1(object sender, EventArgs e)
        {
            Select_Bank frm = new Select_Bank();
            frm.Show();
        }

        private void se_Branch_Click_1(object sender, EventArgs e)
        {
            Select_Branch frm = new Select_Branch();
            frm.Show();
        }

        private void se_Loan_Click_1(object sender, EventArgs e)
        {
            Select_Loan frm = new Select_Loan();
            frm.Show();
        }

        private void se_Customer_Click_1(object sender, EventArgs e)
        {
            Select_Customer frm = new Select_Customer();
            frm.Show();
        }

        private void se_Account_Click_1(object sender, EventArgs e)
        {
            Select_Account frm = new Select_Account();
            frm.Show();
        }

        // ---------------------------------------------------------------------
        // Deleting Data
        // ---------------------------------------------------------------------
        private void de_Bank_Click_1(object sender, EventArgs e)
        {
            Delete_Bank frm = new Delete_Bank();
            frm.Show();
        }

        private void de_Branch_Click_1(object sender, EventArgs e)
        {
            Delete_Branch frm = new Delete_Branch();
            frm.Show();
        }

        private void de_Loan_Click_1(object sender, EventArgs e)
        {
            Delete_Loan frm = new Delete_Loan();
            frm.Show();
        }

        private void de_Customer_Click_1(object sender, EventArgs e)
        {
            Delete_Customer frm = new Delete_Customer();
            frm.Show();
        }

        private void de_Account_Click_1(object sender, EventArgs e)
        {
            Delete_Account frm = new Delete_Account();
            frm.Show();
        }

        private void Report1_Click(object sender, EventArgs e)
        {
            ReportForm1 reportForm1 = new ReportForm1();
            reportForm1.Show();
        }

        private void Report2_Click(object sender, EventArgs e)
        {
            ReportForm2 reportForm2 = new ReportForm2();
            reportForm2.Show();
        }
    }
}