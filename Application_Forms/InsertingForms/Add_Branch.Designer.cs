namespace Bank_System
{
    partial class Add_Branch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.br_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.br_add = new System.Windows.Forms.TextBox();
            this.bk_code = new System.Windows.Forms.TextBox();
            this.addBranch = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(196, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding New Bransh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Branch Number";
            // 
            // br_no
            // 
            this.br_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.br_no.Location = new System.Drawing.Point(202, 109);
            this.br_no.Name = "br_no";
            this.br_no.Size = new System.Drawing.Size(300, 29);
            this.br_no.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(35, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(35, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bank Code";
            // 
            // br_add
            // 
            this.br_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.br_add.Location = new System.Drawing.Point(202, 275);
            this.br_add.Name = "br_add";
            this.br_add.Size = new System.Drawing.Size(300, 29);
            this.br_add.TabIndex = 9;
            // 
            // bk_code
            // 
            this.bk_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bk_code.Location = new System.Drawing.Point(202, 187);
            this.bk_code.Name = "bk_code";
            this.bk_code.Size = new System.Drawing.Size(300, 29);
            this.bk_code.TabIndex = 10;
            // 
            // addBranch
            // 
            this.addBranch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.addBranch.ForeColor = System.Drawing.Color.Black;
            this.addBranch.Location = new System.Drawing.Point(202, 371);
            this.addBranch.Name = "addBranch";
            this.addBranch.Size = new System.Drawing.Size(174, 39);
            this.addBranch.TabIndex = 11;
            this.addBranch.Text = "Add Branch";
            this.addBranch.UseVisualStyleBackColor = true;
            this.addBranch.Click += new System.EventHandler(this.addBranch_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(384, 371);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 39);
            this.clearButton.TabIndex = 41;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Add_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addBranch);
            this.Controls.Add(this.bk_code);
            this.Controls.Add(this.br_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.br_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Branch";
            this.Text = "Add_Branch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox br_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox br_add;
        private System.Windows.Forms.TextBox bk_code;
        private System.Windows.Forms.Button addBranch;
        private System.Windows.Forms.Button clearButton;
    }
}