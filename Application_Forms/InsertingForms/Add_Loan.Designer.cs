namespace Bank_System
{
    partial class Add_Loan
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
            this.branchNumber = new System.Windows.Forms.TextBox();
            this.loanAmount = new System.Windows.Forms.TextBox();
            this.loanType = new System.Windows.Forms.TextBox();
            this.loanNumber = new System.Windows.Forms.TextBox();
            this.addLoan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // branchNumber
            // 
            this.branchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.branchNumber.Location = new System.Drawing.Point(209, 170);
            this.branchNumber.Name = "branchNumber";
            this.branchNumber.Size = new System.Drawing.Size(300, 29);
            this.branchNumber.TabIndex = 47;
            // 
            // loanAmount
            // 
            this.loanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loanAmount.Location = new System.Drawing.Point(209, 304);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(300, 29);
            this.loanAmount.TabIndex = 46;
            // 
            // loanType
            // 
            this.loanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loanType.Location = new System.Drawing.Point(209, 235);
            this.loanType.Name = "loanType";
            this.loanType.Size = new System.Drawing.Size(300, 29);
            this.loanType.TabIndex = 45;
            // 
            // loanNumber
            // 
            this.loanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loanNumber.Location = new System.Drawing.Point(209, 102);
            this.loanNumber.Name = "loanNumber";
            this.loanNumber.Size = new System.Drawing.Size(300, 29);
            this.loanNumber.TabIndex = 44;
            // 
            // addLoan
            // 
            this.addLoan.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.addLoan.Location = new System.Drawing.Point(209, 380);
            this.addLoan.Name = "addLoan";
            this.addLoan.Size = new System.Drawing.Size(147, 39);
            this.addLoan.TabIndex = 43;
            this.addLoan.Text = "Add Loan";
            this.addLoan.UseVisualStyleBackColor = true;
            this.addLoan.Click += new System.EventHandler(this.addLoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(27, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Loan Amout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(27, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Loan Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Branch Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Loan Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(203, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Adding New Loan";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(362, 380);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(147, 39);
            this.clearButton.TabIndex = 48;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Add_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.branchNumber);
            this.Controls.Add(this.loanAmount);
            this.Controls.Add(this.loanType);
            this.Controls.Add(this.loanNumber);
            this.Controls.Add(this.addLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Loan";
            this.Text = "Add_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox branchNumber;
        private System.Windows.Forms.TextBox loanAmount;
        private System.Windows.Forms.TextBox loanType;
        private System.Windows.Forms.TextBox loanNumber;
        private System.Windows.Forms.Button addLoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
    }
}