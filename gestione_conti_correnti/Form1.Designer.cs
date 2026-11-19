namespace gestione_conti_correnti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_n1 = new System.Windows.Forms.ListBox();
            this.lbx_n2 = new System.Windows.Forms.ListBox();
            this.lbx_n3 = new System.Windows.Forms.ListBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_n1
            // 
            this.lbx_n1.FormattingEnabled = true;
            this.lbx_n1.Location = new System.Drawing.Point(214, 86);
            this.lbx_n1.Name = "lbx_n1";
            this.lbx_n1.Size = new System.Drawing.Size(120, 95);
            this.lbx_n1.TabIndex = 0;
            // 
            // lbx_n2
            // 
            this.lbx_n2.FormattingEnabled = true;
            this.lbx_n2.Location = new System.Drawing.Point(340, 178);
            this.lbx_n2.Name = "lbx_n2";
            this.lbx_n2.Size = new System.Drawing.Size(120, 95);
            this.lbx_n2.TabIndex = 1;
            // 
            // lbx_n3
            // 
            this.lbx_n3.FormattingEnabled = true;
            this.lbx_n3.Location = new System.Drawing.Point(466, 271);
            this.lbx_n3.Name = "lbx_n3";
            this.lbx_n3.Size = new System.Drawing.Size(120, 95);
            this.lbx_n3.TabIndex = 2;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(322, 387);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(151, 51);
            this.btn_n1.TabIndex = 3;
            this.btn_n1.Text = "visualizza";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(23, 449);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(35, 13);
            this.lbl_n1.TabIndex = 4;
            this.lbl_n1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 485);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.lbx_n3);
            this.Controls.Add(this.lbx_n2);
            this.Controls.Add(this.lbx_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_n1;
        private System.Windows.Forms.ListBox lbx_n2;
        private System.Windows.Forms.ListBox lbx_n3;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Label lbl_n1;
    }
}

