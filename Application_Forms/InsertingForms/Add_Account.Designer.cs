namespace Bank_System
{
    partial class Add_Account
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
            this.add_acc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acc_no = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.acc_type = new System.Windows.Forms.TextBox();
            this.br_no = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_acc
            // 
            this.add_acc.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.add_acc.Location = new System.Drawing.Point(209, 383);
            this.add_acc.Name = "add_acc";
            this.add_acc.Size = new System.Drawing.Size(167, 39);
            this.add_acc.TabIndex = 33;
            this.add_acc.Text = "Add Account";
            this.add_acc.UseVisualStyleBackColor = true;
            this.add_acc.Click += new System.EventHandler(this.add_acc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(27, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(27, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Branch Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(203, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adding New Account";
            // 
            // acc_no
            // 
            this.acc_no.AccessibleName = "";
            this.acc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.acc_no.Location = new System.Drawing.Point(209, 105);
            this.acc_no.Name = "acc_no";
            this.acc_no.Size = new System.Drawing.Size(300, 29);
            this.acc_no.TabIndex = 34;
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.balance.Location = new System.Drawing.Point(209, 238);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(300, 29);
            this.balance.TabIndex = 35;
            // 
            // acc_type
            // 
            this.acc_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.acc_type.Location = new System.Drawing.Point(209, 307);
            this.acc_type.Name = "acc_type";
            this.acc_type.Size = new System.Drawing.Size(300, 29);
            this.acc_type.TabIndex = 36;
            // 
            // br_no
            // 
            this.br_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.br_no.Location = new System.Drawing.Point(209, 173);
            this.br_no.Name = "br_no";
            this.br_no.Size = new System.Drawing.Size(300, 29);
            this.br_no.TabIndex = 37;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(382, 383);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 39);
            this.clearButton.TabIndex = 39;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.br_no);
            this.Controls.Add(this.acc_type);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.acc_no);
            this.Controls.Add(this.add_acc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Account";
            this.Text = "Add_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_acc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acc_no;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox acc_type;
        private System.Windows.Forms.TextBox br_no;
        private System.Windows.Forms.Button clearButton;
    }
}