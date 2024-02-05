namespace pratique
{
    partial class Menu
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
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_compte = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(156, 153);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(413, 120);
            this.btn_client.TabIndex = 0;
            this.btn_client.Text = "Gestion Client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_compte
            // 
            this.btn_compte.Location = new System.Drawing.Point(156, 279);
            this.btn_compte.Name = "btn_compte";
            this.btn_compte.Size = new System.Drawing.Size(413, 120);
            this.btn_compte.TabIndex = 1;
            this.btn_compte.Text = "Gestion Compte";
            this.btn_compte.UseVisualStyleBackColor = true;
            this.btn_compte.Click += new System.EventHandler(this.btn_compte_Click);
            // 
            // btn_transactions
            // 
            this.btn_transactions.Location = new System.Drawing.Point(156, 410);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(413, 120);
            this.btn_transactions.TabIndex = 2;
            this.btn_transactions.Text = "Gestion Transactions";
            this.btn_transactions.UseVisualStyleBackColor = true;
            this.btn_transactions.Click += new System.EventHandler(this.btn_transactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gestion Banque";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_transactions);
            this.Controls.Add(this.btn_compte);
            this.Controls.Add(this.btn_client);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_compte;
        private System.Windows.Forms.Button btn_transactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}