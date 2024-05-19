namespace Bank_System.Insertin_Forms
{
    partial class Add_Bank
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
            this.label3 = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.TextBox();
            this.bankAddress = new System.Windows.Forms.TextBox();
            this.bankCode = new System.Windows.Forms.TextBox();
            this.ad_bn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(43, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(43, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(47, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bank Code";
            // 
            // bankName
            // 
            this.bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bankName.Location = new System.Drawing.Point(169, 192);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(300, 29);
            this.bankName.TabIndex = 3;
            // 
            // bankAddress
            // 
            this.bankAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bankAddress.Location = new System.Drawing.Point(169, 275);
            this.bankAddress.Name = "bankAddress";
            this.bankAddress.Size = new System.Drawing.Size(300, 29);
            this.bankAddress.TabIndex = 6;
            // 
            // bankCode
            // 
            this.bankCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bankCode.Location = new System.Drawing.Point(173, 108);
            this.bankCode.Name = "bankCode";
            this.bankCode.Size = new System.Drawing.Size(300, 29);
            this.bankCode.TabIndex = 7;
            // 
            // ad_bn
            // 
            this.ad_bn.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.ad_bn.ForeColor = System.Drawing.Color.Black;
            this.ad_bn.Location = new System.Drawing.Point(169, 360);
            this.ad_bn.Name = "ad_bn";
            this.ad_bn.Size = new System.Drawing.Size(174, 39);
            this.ad_bn.TabIndex = 9;
            this.ad_bn.Text = "Add Bank";
            this.ad_bn.UseVisualStyleBackColor = true;
            this.ad_bn.Click += new System.EventHandler(this.ad_bn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adding New Bank";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(355, 360);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 39);
            this.clearButton.TabIndex = 40;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Add_Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ad_bn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bankCode);
            this.Controls.Add(this.bankAddress);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Name = "Add_Bank";
            this.Text = "Add_Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bankName;
        private System.Windows.Forms.TextBox bankAddress;
        private System.Windows.Forms.TextBox bankCode;
        private System.Windows.Forms.Button ad_bn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
    }
}