using System;
using System.Windows.Forms;

namespace Bank_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.in_Bank = new System.Windows.Forms.ToolStripMenuItem();
            this.in_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.in_Loan = new System.Windows.Forms.ToolStripMenuItem();
            this.in_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.in_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.up_Bank = new System.Windows.Forms.ToolStripMenuItem();
            this.up_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.up_Loan = new System.Windows.Forms.ToolStripMenuItem();
            this.up_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.up_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.selectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.se_Bank = new System.Windows.Forms.ToolStripMenuItem();
            this.se_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.se_Loan = new System.Windows.Forms.ToolStripMenuItem();
            this.se_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.se_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.de_Bank = new System.Windows.Forms.ToolStripMenuItem();
            this.de_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.de_Loan = new System.Windows.Forms.ToolStripMenuItem();
            this.de_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.de_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Report1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Report2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.bankToolStripMenuItem.Text = "Bank";
            this.bankToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // branchToolStripMenuItem
            // 
            this.branchToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            this.branchToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.branchToolStripMenuItem.Text = "Branch";
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.loanToolStripMenuItem.Text = "Loan";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertMenu,
            this.updateMenu,
            this.selectMenu,
            this.deleteMenu,
            this.generateReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(884, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertMenu
            // 
            this.insertMenu.Checked = true;
            this.insertMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.insertMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.in_Bank,
            this.in_Branch,
            this.in_Loan,
            this.in_Customer,
            this.in_Account});
            this.insertMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.insertMenu.ForeColor = System.Drawing.Color.Black;
            this.insertMenu.Name = "insertMenu";
            this.insertMenu.Size = new System.Drawing.Size(130, 27);
            this.insertMenu.Text = "Insert Data";
            // 
            // in_Bank
            // 
            this.in_Bank.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_Bank.ForeColor = System.Drawing.Color.Black;
            this.in_Bank.Name = "in_Bank";
            this.in_Bank.Size = new System.Drawing.Size(139, 24);
            this.in_Bank.Text = "Bank";
            this.in_Bank.Click += new System.EventHandler(this.in_Bank_Click_1);
            // 
            // in_Branch
            // 
            this.in_Branch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_Branch.ForeColor = System.Drawing.Color.Black;
            this.in_Branch.Name = "in_Branch";
            this.in_Branch.Size = new System.Drawing.Size(139, 24);
            this.in_Branch.Text = "Branch";
            this.in_Branch.Click += new System.EventHandler(this.in_Branch_Click_1);
            // 
            // in_Loan
            // 
            this.in_Loan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_Loan.ForeColor = System.Drawing.Color.Black;
            this.in_Loan.Name = "in_Loan";
            this.in_Loan.Size = new System.Drawing.Size(139, 24);
            this.in_Loan.Text = "Loan";
            this.in_Loan.Click += new System.EventHandler(this.in_Loan_Click_1);
            // 
            // in_Customer
            // 
            this.in_Customer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_Customer.ForeColor = System.Drawing.Color.Black;
            this.in_Customer.Name = "in_Customer";
            this.in_Customer.Size = new System.Drawing.Size(139, 24);
            this.in_Customer.Text = "Customer";
            this.in_Customer.Click += new System.EventHandler(this.in_Customer_Click_1);
            // 
            // in_Account
            // 
            this.in_Account.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_Account.ForeColor = System.Drawing.Color.Black;
            this.in_Account.Name = "in_Account";
            this.in_Account.Size = new System.Drawing.Size(139, 24);
            this.in_Account.Text = "Account";
            this.in_Account.Click += new System.EventHandler(this.in_Account_Click_1);
            // 
            // updateMenu
            // 
            this.updateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.up_Bank,
            this.up_Branch,
            this.up_Loan,
            this.up_Customer,
            this.up_Account});
            this.updateMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.updateMenu.ForeColor = System.Drawing.Color.Black;
            this.updateMenu.Name = "updateMenu";
            this.updateMenu.Size = new System.Drawing.Size(145, 27);
            this.updateMenu.Text = "Update Data";
            // 
            // up_Bank
            // 
            this.up_Bank.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_Bank.ForeColor = System.Drawing.Color.Black;
            this.up_Bank.Name = "up_Bank";
            this.up_Bank.Size = new System.Drawing.Size(139, 24);
            this.up_Bank.Text = "Bank";
            this.up_Bank.Click += new System.EventHandler(this.up_Bank_Click_1);
            // 
            // up_Branch
            // 
            this.up_Branch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_Branch.ForeColor = System.Drawing.Color.Black;
            this.up_Branch.Name = "up_Branch";
            this.up_Branch.Size = new System.Drawing.Size(139, 24);
            this.up_Branch.Text = "Branch";
            this.up_Branch.Click += new System.EventHandler(this.up_Branch_Click_1);
            // 
            // up_Loan
            // 
            this.up_Loan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_Loan.ForeColor = System.Drawing.Color.Black;
            this.up_Loan.Name = "up_Loan";
            this.up_Loan.Size = new System.Drawing.Size(139, 24);
            this.up_Loan.Text = "Loan";
            this.up_Loan.Click += new System.EventHandler(this.up_Loan_Click_1);
            // 
            // up_Customer
            // 
            this.up_Customer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_Customer.ForeColor = System.Drawing.Color.Black;
            this.up_Customer.Name = "up_Customer";
            this.up_Customer.Size = new System.Drawing.Size(139, 24);
            this.up_Customer.Text = "Customer";
            this.up_Customer.Click += new System.EventHandler(this.up_Customer_Click_1);
            // 
            // up_Account
            // 
            this.up_Account.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_Account.ForeColor = System.Drawing.Color.Black;
            this.up_Account.Name = "up_Account";
            this.up_Account.Size = new System.Drawing.Size(139, 24);
            this.up_Account.Text = "Account";
            this.up_Account.Click += new System.EventHandler(this.up_Account_Click_1);
            // 
            // selectMenu
            // 
            this.selectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.se_Bank,
            this.se_Branch,
            this.se_Loan,
            this.se_Customer,
            this.se_Account});
            this.selectMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.selectMenu.ForeColor = System.Drawing.Color.Black;
            this.selectMenu.Name = "selectMenu";
            this.selectMenu.Size = new System.Drawing.Size(134, 27);
            this.selectMenu.Text = "Select Data";
            // 
            // se_Bank
            // 
            this.se_Bank.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Bank.ForeColor = System.Drawing.Color.Black;
            this.se_Bank.Name = "se_Bank";
            this.se_Bank.Size = new System.Drawing.Size(139, 24);
            this.se_Bank.Text = "Bank";
            this.se_Bank.Click += new System.EventHandler(this.se_Bank_Click_1);
            // 
            // se_Branch
            // 
            this.se_Branch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Branch.ForeColor = System.Drawing.Color.Black;
            this.se_Branch.Name = "se_Branch";
            this.se_Branch.Size = new System.Drawing.Size(139, 24);
            this.se_Branch.Text = "Branch";
            this.se_Branch.Click += new System.EventHandler(this.se_Branch_Click_1);
            // 
            // se_Loan
            // 
            this.se_Loan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Loan.ForeColor = System.Drawing.Color.Black;
            this.se_Loan.Name = "se_Loan";
            this.se_Loan.Size = new System.Drawing.Size(139, 24);
            this.se_Loan.Text = "Loan";
            this.se_Loan.Click += new System.EventHandler(this.se_Loan_Click_1);
            // 
            // se_Customer
            // 
            this.se_Customer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Customer.ForeColor = System.Drawing.Color.Black;
            this.se_Customer.Name = "se_Customer";
            this.se_Customer.Size = new System.Drawing.Size(139, 24);
            this.se_Customer.Text = "Customer";
            this.se_Customer.Click += new System.EventHandler(this.se_Customer_Click_1);
            // 
            // se_Account
            // 
            this.se_Account.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Account.ForeColor = System.Drawing.Color.Black;
            this.se_Account.Name = "se_Account";
            this.se_Account.Size = new System.Drawing.Size(139, 24);
            this.se_Account.Text = "Account";
            this.se_Account.Click += new System.EventHandler(this.se_Account_Click_1);
            // 
            // deleteMenu
            // 
            this.deleteMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.de_Bank,
            this.de_Branch,
            this.de_Loan,
            this.de_Customer,
            this.de_Account});
            this.deleteMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.deleteMenu.ForeColor = System.Drawing.Color.Black;
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(136, 27);
            this.deleteMenu.Text = "Delete Data";
            // 
            // de_Bank
            // 
            this.de_Bank.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Bank.ForeColor = System.Drawing.Color.Black;
            this.de_Bank.Name = "de_Bank";
            this.de_Bank.Size = new System.Drawing.Size(139, 24);
            this.de_Bank.Text = "Bank";
            this.de_Bank.Click += new System.EventHandler(this.de_Bank_Click_1);
            // 
            // de_Branch
            // 
            this.de_Branch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Branch.ForeColor = System.Drawing.Color.Black;
            this.de_Branch.Name = "de_Branch";
            this.de_Branch.Size = new System.Drawing.Size(139, 24);
            this.de_Branch.Text = "Branch";
            this.de_Branch.Click += new System.EventHandler(this.de_Branch_Click_1);
            // 
            // de_Loan
            // 
            this.de_Loan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Loan.ForeColor = System.Drawing.Color.Black;
            this.de_Loan.Name = "de_Loan";
            this.de_Loan.Size = new System.Drawing.Size(139, 24);
            this.de_Loan.Text = "Loan";
            this.de_Loan.Click += new System.EventHandler(this.de_Loan_Click_1);
            // 
            // de_Customer
            // 
            this.de_Customer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Customer.ForeColor = System.Drawing.Color.Black;
            this.de_Customer.Name = "de_Customer";
            this.de_Customer.Size = new System.Drawing.Size(139, 24);
            this.de_Customer.Text = "Customer";
            this.de_Customer.Click += new System.EventHandler(this.de_Customer_Click_1);
            // 
            // de_Account
            // 
            this.de_Account.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Account.ForeColor = System.Drawing.Color.Black;
            this.de_Account.Name = "de_Account";
            this.de_Account.Size = new System.Drawing.Size(139, 24);
            this.de_Account.Text = "Account";
            this.de_Account.Click += new System.EventHandler(this.de_Account_Click_1);
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report1,
            this.Report2});
            this.generateReportToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.generateReportToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(186, 27);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            // 
            // Report1
            // 
            this.Report1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(301, 24);
            this.Report1.Text = "Integrated Banking Services Report";
            this.Report1.Click += new System.EventHandler(this.Report1_Click);
            // 
            // Report2
            // 
            this.Report2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Report2.Name = "Report2";
            this.Report2.Size = new System.Drawing.Size(301, 24);
            this.Report2.Text = "Branch Loan Type Summary Report";
            this.Report2.Click += new System.EventHandler(this.Report2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 530);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Bank\'s Database Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertMenu;
        private ToolStripMenuItem in_Bank;
        private ToolStripMenuItem in_Branch;
        private ToolStripMenuItem in_Loan;
        private ToolStripMenuItem in_Customer;
        private ToolStripMenuItem in_Account;
        private ToolStripMenuItem updateMenu;
        private ToolStripMenuItem up_Bank;
        private ToolStripMenuItem up_Branch;
        private ToolStripMenuItem up_Loan;
        private ToolStripMenuItem up_Customer;
        private ToolStripMenuItem up_Account;
        private ToolStripMenuItem selectMenu;
        private ToolStripMenuItem se_Bank;
        private ToolStripMenuItem se_Branch;
        private ToolStripMenuItem se_Loan;
        private ToolStripMenuItem se_Customer;
        private ToolStripMenuItem se_Account;
        private ToolStripMenuItem deleteMenu;
        private ToolStripMenuItem de_Bank;
        private ToolStripMenuItem de_Branch;
        private ToolStripMenuItem de_Loan;
        private ToolStripMenuItem de_Customer;
        private ToolStripMenuItem de_Account;
        private PictureBox pictureBox1;
        private ToolStripMenuItem generateReportToolStripMenuItem;
        private ToolStripMenuItem Report1;
        private ToolStripMenuItem Report2;
    }
}

