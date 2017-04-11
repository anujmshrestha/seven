namespace Seven.UI
{
    partial class Account
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
            this.From = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromAccountHoldersName = new System.Windows.Forms.TextBox();
            this.txtAmountFrom = new System.Windows.Forms.TextBox();
            this.txtFromAccountNo = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToAccountHoldersName = new System.Windows.Forms.TextBox();
            this.txtToAccountNo = new System.Windows.Forms.TextBox();
            this.btnTransferAmount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToAccountAmount = new System.Windows.Forms.TextBox();
            this.From.SuspendLayout();
            this.To.SuspendLayout();
            this.SuspendLayout();
            // 
            // From
            // 
            this.From.Controls.Add(this.label3);
            this.From.Controls.Add(this.label2);
            this.From.Controls.Add(this.label1);
            this.From.Controls.Add(this.txtFromAccountHoldersName);
            this.From.Controls.Add(this.txtAmountFrom);
            this.From.Controls.Add(this.txtFromAccountNo);
            this.From.Location = new System.Drawing.Point(0, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(428, 231);
            this.From.TabIndex = 0;
            this.From.TabStop = false;
            this.From.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "AccountHoldersName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "AccountNo";
            // 
            // txtFromAccountHoldersName
            // 
            this.txtFromAccountHoldersName.Location = new System.Drawing.Point(138, 82);
            this.txtFromAccountHoldersName.Name = "txtFromAccountHoldersName";
            this.txtFromAccountHoldersName.Size = new System.Drawing.Size(172, 20);
            this.txtFromAccountHoldersName.TabIndex = 2;
            // 
            // txtAmountFrom
            // 
            this.txtAmountFrom.Location = new System.Drawing.Point(137, 129);
            this.txtAmountFrom.Name = "txtAmountFrom";
            this.txtAmountFrom.Size = new System.Drawing.Size(172, 20);
            this.txtAmountFrom.TabIndex = 1;
            // 
            // txtFromAccountNo
            // 
            this.txtFromAccountNo.Location = new System.Drawing.Point(137, 33);
            this.txtFromAccountNo.Name = "txtFromAccountNo";
            this.txtFromAccountNo.Size = new System.Drawing.Size(172, 20);
            this.txtFromAccountNo.TabIndex = 0;
            // 
            // To
            // 
            this.To.Controls.Add(this.txtToAccountAmount);
            this.To.Controls.Add(this.label6);
            this.To.Controls.Add(this.label5);
            this.To.Controls.Add(this.label4);
            this.To.Controls.Add(this.txtToAccountHoldersName);
            this.To.Controls.Add(this.txtToAccountNo);
            this.To.Location = new System.Drawing.Point(463, 12);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(480, 209);
            this.To.TabIndex = 0;
            this.To.TabStop = false;
            this.To.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "AccountHoldersName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AccountNo";
            // 
            // txtToAccountHoldersName
            // 
            this.txtToAccountHoldersName.Location = new System.Drawing.Point(148, 62);
            this.txtToAccountHoldersName.Name = "txtToAccountHoldersName";
            this.txtToAccountHoldersName.Size = new System.Drawing.Size(172, 20);
            this.txtToAccountHoldersName.TabIndex = 3;
            // 
            // txtToAccountNo
            // 
            this.txtToAccountNo.Location = new System.Drawing.Point(148, 19);
            this.txtToAccountNo.Name = "txtToAccountNo";
            this.txtToAccountNo.Size = new System.Drawing.Size(172, 20);
            this.txtToAccountNo.TabIndex = 1;
            // 
            // btnTransferAmount
            // 
            this.btnTransferAmount.Location = new System.Drawing.Point(401, 264);
            this.btnTransferAmount.Name = "btnTransferAmount";
            this.btnTransferAmount.Size = new System.Drawing.Size(128, 34);
            this.btnTransferAmount.TabIndex = 1;
            this.btnTransferAmount.Text = "TrasferAmount";
            this.btnTransferAmount.UseVisualStyleBackColor = true;
            this.btnTransferAmount.Click += new System.EventHandler(this.btnTransferAmount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount";
            // 
            // txtToAccountAmount
            // 
            this.txtToAccountAmount.Location = new System.Drawing.Point(148, 110);
            this.txtToAccountAmount.Name = "txtToAccountAmount";
            this.txtToAccountAmount.Size = new System.Drawing.Size(172, 20);
            this.txtToAccountAmount.TabIndex = 10;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 402);
            this.Controls.Add(this.btnTransferAmount);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Name = "Account";
            this.Text = "Account";
            this.From.ResumeLayout(false);
            this.From.PerformLayout();
            this.To.ResumeLayout(false);
            this.To.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromAccountHoldersName;
        private System.Windows.Forms.TextBox txtAmountFrom;
        private System.Windows.Forms.TextBox txtFromAccountNo;
        private System.Windows.Forms.GroupBox To;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToAccountHoldersName;
        private System.Windows.Forms.TextBox txtToAccountNo;
        private System.Windows.Forms.Button btnTransferAmount;
        private System.Windows.Forms.TextBox txtToAccountAmount;
        private System.Windows.Forms.Label label6;
    }
}