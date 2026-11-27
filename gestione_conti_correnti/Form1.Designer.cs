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
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.lbl_visualizza = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.btn_n3 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.btn_n5 = new System.Windows.Forms.Button();
            this.btn_n4 = new System.Windows.Forms.Button();
            this.btn_n6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_n1
            // 
            this.lbx_n1.FormattingEnabled = true;
            this.lbx_n1.Location = new System.Drawing.Point(39, 37);
            this.lbx_n1.Name = "lbx_n1";
            this.lbx_n1.Size = new System.Drawing.Size(120, 95);
            this.lbx_n1.TabIndex = 0;
            // 
            // lbx_n2
            // 
            this.lbx_n2.FormattingEnabled = true;
            this.lbx_n2.Location = new System.Drawing.Point(307, 37);
            this.lbx_n2.Name = "lbx_n2";
            this.lbx_n2.Size = new System.Drawing.Size(120, 95);
            this.lbx_n2.TabIndex = 1;
            // 
            // lbx_n3
            // 
            this.lbx_n3.FormattingEnabled = true;
            this.lbx_n3.Location = new System.Drawing.Point(573, 37);
            this.lbx_n3.Name = "lbx_n3";
            this.lbx_n3.Size = new System.Drawing.Size(120, 95);
            this.lbx_n3.TabIndex = 2;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(97, 290);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(173, 51);
            this.btn_n1.TabIndex = 3;
            this.btn_n1.Text = "visualizza\r\nNome e cognome+Saldo\r\ninserendo il Numero\r\n";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(331, 9);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(44, 13);
            this.lbl_n2.TabIndex = 5;
            this.lbl_n2.Text = "Numero";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(621, 9);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(34, 13);
            this.lbl_n3.TabIndex = 6;
            this.lbl_n3.Text = "Saldo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(39, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(120, 20);
            this.txt_nome.TabIndex = 7;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(308, 150);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(119, 20);
            this.txt_numero.TabIndex = 8;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(573, 150);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(120, 20);
            this.txt_saldo.TabIndex = 9;
            // 
            // lbl_visualizza
            // 
            this.lbl_visualizza.AutoSize = true;
            this.lbl_visualizza.Location = new System.Drawing.Point(331, 401);
            this.lbl_visualizza.Name = "lbl_visualizza";
            this.lbl_visualizza.Size = new System.Drawing.Size(0, 13);
            this.lbl_visualizza.TabIndex = 10;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(55, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(91, 13);
            this.lbl_n1.TabIndex = 11;
            this.lbl_n1.Text = "Nome e cognome";
            // 
            // btn_n3
            // 
            this.btn_n3.Location = new System.Drawing.Point(455, 290);
            this.btn_n3.Name = "btn_n3";
            this.btn_n3.Size = new System.Drawing.Size(173, 51);
            this.btn_n3.TabIndex = 12;
            this.btn_n3.Text = "visualizza\r\nconto in rosso";
            this.btn_n3.UseVisualStyleBackColor = true;
            this.btn_n3.Click += new System.EventHandler(this.btn_n3_Click);
            // 
            // btn_n2
            // 
            this.btn_n2.Location = new System.Drawing.Point(276, 290);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(173, 51);
            this.btn_n2.TabIndex = 13;
            this.btn_n2.Text = "visualizza\r\nNumero+Saldo\r\nInserendo il Nome\r\n";
            this.btn_n2.UseVisualStyleBackColor = true;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // btn_n5
            // 
            this.btn_n5.Location = new System.Drawing.Point(276, 347);
            this.btn_n5.Name = "btn_n5";
            this.btn_n5.Size = new System.Drawing.Size(173, 51);
            this.btn_n5.TabIndex = 14;
            this.btn_n5.Text = "visualizza\r\nmedia dei saldi\r\n\r\n";
            this.btn_n5.UseVisualStyleBackColor = true;
            this.btn_n5.Click += new System.EventHandler(this.btn_n5_Click);
            // 
            // btn_n4
            // 
            this.btn_n4.Location = new System.Drawing.Point(97, 347);
            this.btn_n4.Name = "btn_n4";
            this.btn_n4.Size = new System.Drawing.Size(173, 51);
            this.btn_n4.TabIndex = 15;
            this.btn_n4.Text = "visualizza\r\nNome del cliente più ricco";
            this.btn_n4.UseVisualStyleBackColor = true;
            this.btn_n4.Click += new System.EventHandler(this.btn_n4_Click);
            // 
            // btn_n6
            // 
            this.btn_n6.Location = new System.Drawing.Point(455, 347);
            this.btn_n6.Name = "btn_n6";
            this.btn_n6.Size = new System.Drawing.Size(173, 51);
            this.btn_n6.TabIndex = 16;
            this.btn_n6.Text = "visualizza \r\nelenco clienti";
            this.btn_n6.UseVisualStyleBackColor = true;
            this.btn_n6.Click += new System.EventHandler(this.btn_n6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 485);
            this.Controls.Add(this.btn_n6);
            this.Controls.Add(this.btn_n4);
            this.Controls.Add(this.btn_n5);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n3);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.lbl_visualizza);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
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
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label lbl_visualizza;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Button btn_n3;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Button btn_n5;
        private System.Windows.Forms.Button btn_n4;
        private System.Windows.Forms.Button btn_n6;
    }
}

