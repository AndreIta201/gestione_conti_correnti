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
        int[] numero = new int[] { 11264, 99780, 00342, 03419, 34562, 09887, 02341 };
        int[] saldo = new int[] { 11534, -2345, 3451, 127, 45673, -13, 3452 };
        public Form1()
        {
            InitializeComponent();


            lbx_n1.Items.AddRange(nome);

            foreach (int n in numero)
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
            int indice = lbx_n1.SelectedIndex;
            int indice1 = lbx_n2.SelectedIndex;
            int indice2 = lbx_n3.SelectedIndex;

            if (indice <= -1 || indice >= 7|| indice1 <= -1 || indice1 >= 7 || indice2 <= -1 || indice2 >= 7 )
            {
                MessageBox.Show("Selezionare un nome dalla lista");
                return;
            }
            if (indice1 == 0)
            {
                lbl_n1.Text = nome[indice1];
            }

        }
    }
}
