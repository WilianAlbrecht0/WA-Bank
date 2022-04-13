namespace WA_Bank.Forms
{
    partial class CreateAccount
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbTell = new System.Windows.Forms.TextBox();
            this.txbBalance = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbRPassword = new System.Windows.Forms.TextBox();
            this.btbCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(33, 40);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "saldo inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "repetir senha";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(33, 84);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(100, 20);
            this.txbCpf.TabIndex = 7;
            // 
            // txbTell
            // 
            this.txbTell.Location = new System.Drawing.Point(33, 128);
            this.txbTell.Name = "txbTell";
            this.txbTell.Size = new System.Drawing.Size(100, 20);
            this.txbTell.TabIndex = 8;
            // 
            // txbBalance
            // 
            this.txbBalance.Location = new System.Drawing.Point(33, 182);
            this.txbBalance.Name = "txbBalance";
            this.txbBalance.Size = new System.Drawing.Size(100, 20);
            this.txbBalance.TabIndex = 9;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(33, 227);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 10;
            // 
            // txbRPassword
            // 
            this.txbRPassword.Location = new System.Drawing.Point(33, 276);
            this.txbRPassword.Name = "txbRPassword";
            this.txbRPassword.Size = new System.Drawing.Size(100, 20);
            this.txbRPassword.TabIndex = 11;
            // 
            // btbCreate
            // 
            this.btbCreate.Location = new System.Drawing.Point(33, 313);
            this.btbCreate.Name = "btbCreate";
            this.btbCreate.Size = new System.Drawing.Size(75, 23);
            this.btbCreate.TabIndex = 12;
            this.btbCreate.Text = "cadastrar";
            this.btbCreate.UseVisualStyleBackColor = true;
            this.btbCreate.Click += new System.EventHandler(this.btbCreate_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 365);
            this.Controls.Add(this.btbCreate);
            this.Controls.Add(this.txbRPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbBalance);
            this.Controls.Add(this.txbTell);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbTell;
        private System.Windows.Forms.TextBox txbBalance;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbRPassword;
        private System.Windows.Forms.Button btbCreate;
    }
}