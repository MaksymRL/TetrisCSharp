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
            nuovaCasella.Casella = new TextBox[200];
            int x = 0;
            int conta = 0;
            string[] Lettere = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int PosLettera = 0;
            while (x < num)
            {
                if (conta < 10)
                {
                    nuovaCasella.Casella[x] = (TextBox)this.Controls.Find($"{conta}{Lettere[PosLettera]}", true)[0];
                    conta++;
                }
                else
                {
                    conta = 0;
                    PosLettera++;
                }
                x++;
            }

        }

       
    }
}
