using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisFunzioni;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgettoFineAnno
{
    public partial class Form1 : Form
    {
        private Matrice[] elePezzi = new Matrice[200];
        int num = 199;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Matrice nuovaCasella = default;
            int x = 0;
            int riga = 1;
            string[] Colonna = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int PosColonna = 0;
            while (x <= num)
            {
                if (riga <= 20)
                {
                    nuovaCasella.Colonna = Colonna[PosColonna];
                    nuovaCasella.Riga = riga;
                    nuovaCasella.Casella = (System.Windows.Forms.TextBox)this.Controls.Find(nuovaCasella.Colonna + nuovaCasella.Riga, true).FirstOrDefault();
                    riga = riga + 1;
                    nuovaCasella.ColoreSfondo = nuovaCasella.Casella.BackColor;
                    nuovaCasella.TipoBordi = nuovaCasella.Casella.BorderStyle;
                }
                else
                {
                    if(PosColonna < 9) {
                        PosColonna = PosColonna + 1;
                        x--;
                        riga = 1;
                    }
                }
                elePezzi[x] = nuovaCasella;
                x++;
            }
            

        }

        private void b_test_Click(object sender, EventArgs e)
        {
           
        }
    }
}
