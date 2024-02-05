namespace pratique
{
    partial class formTransactions
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
            this.txtd = new System.Windows.Forms.DateTimePicker();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.Button();
            this.Suprimer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtnc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(817, 126);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(204, 26);
            this.txtd.TabIndex = 39;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(316, 178);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 26);
            this.txtid.TabIndex = 38;
            this.txtid.Visible = false;
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(63, 305);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(959, 251);
            this.tableau.TabIndex = 37;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            // 
            // Modifier
            // 
            this.Modifier.Enabled = false;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(834, 210);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(160, 40);
            this.Modifier.TabIndex = 36;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Suprimer
            // 
            this.Suprimer.Enabled = false;
            this.Suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suprimer.Location = new System.Drawing.Point(478, 210);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(160, 40);
            this.Suprimer.TabIndex = 35;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(126, 210);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(160, 40);
            this.Ajouter.TabIndex = 34;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(848, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Type Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Montant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "N°Compte";
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(577, 124);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(181, 26);
            this.txttt.TabIndex = 29;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(352, 124);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(181, 26);
            this.txtm.TabIndex = 28;
            // 
            // txtnc
            // 
            this.txtnc.Location = new System.Drawing.Point(102, 124);
            this.txtnc.Name = "txtnc";
            this.txtnc.Size = new System.Drawing.Size(181, 26);
            this.txtnc.TabIndex = 27;
            // 
            // formTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 630);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtnc);
            this.Name = "formTransactions";
            this.Text = "formTransactions";
            this.Load += new System.EventHandler(this.formTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtnc;
    }
}