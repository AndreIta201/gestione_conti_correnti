using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace gestione_conti_correnti
{
    public partial class Form1 : Form
    {
        string[] nome = new string[] { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
        string[] numero = new string[] { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
        int[] saldo = new int[] { 11534, -2345, 3451, 127, 45673, -13, 3452 };
        public Form1()
        {
            InitializeComponent();


            lbx_n1.Items.AddRange(nome);

            foreach (string n in numero)
            {
                lbx_n2.Items.Add(n);
            }
            foreach (int n2 in saldo)
            {
                lbx_n3.Items.Add(n2);
            }
            
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string n = txt_numero.Text;
            bool trovato = false; 
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] == n)
                {
                   
                    lbl_visualizza.Text = nome[i] + " + " + saldo[i];
                    trovato = true; 
                }
            }
            if (trovato == false)
            {
                lbl_visualizza.Text = "Conto non trovato";
            }
        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            string n = txt_nome.Text;
            bool trovato = false;
            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] == n)
                {
                    lbl_visualizza.Text = numero[i] + " + " + saldo[i];
                    trovato = true;
                    
                }
            }
            if (trovato == false)
            {
                lbl_visualizza.Text = "Cliente non trovato";
            }
        }

        private void btn_n3_Click(object sender, EventArgs e)
        {
            bool trovato = false;
            for (int i = 0; i < saldo.Length; i++)
            {
                    if (saldo[i] < 0)
                {
                    lbl_visualizza.Text += "I più poveri sono: " + nome[i] + "\n";
                    trovato = true;
                }

            }
           
        }

        private void btn_n4_Click(object sender, EventArgs e)
        {
            int max = 0;
            bool trovato = false;
            for (int i = 0; i < saldo.Length; i++)
            {
                if (i == 0)
                {
                    max = saldo[i];
                    lbl_visualizza.Text = "Il più ricco è: " + nome[i];
                    trovato = true;
                }
                else if (saldo[i] > max)
                {
                    max = saldo[i];
                    lbl_visualizza.Text = "Il più ricco è: " + nome[i];
                    trovato = true;
                }

            }

        }

        private void btn_n5_Click(object sender, EventArgs e)
        {
            float media;
            int somma= 0;
            for (int i = 0; i < saldo.Length; i++)
            {
                somma += saldo[i];
            }
            media = somma / saldo.Length;
            lbl_visualizza.Text = "La media dei saldi è: " + media;
        }
    }
}
