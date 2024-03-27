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
        private Matrice[] eleMatrice = new Matrice[200];
        private MatriceRandom[] eleMatriceRandom = new MatriceRandom[8];
        private int num = 200;
        private string[] Colonna = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        private string[] ColonnaRandom = { "X", "Z" };
        private int numRandom = 8;
        private int conta = 0;
        private int[] PosPezzo = new int[4];
        private int Pezzo;

        public Form1()
        {
            InitializeComponent();
            timer_screenupdate.Interval = 1000;
            timer_screenupdate.Tick += Timer_Tick;
            timer_screenupdate.Start();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {


            #region PezzoScendi

            if (conta == 1)
            {
                Lib.Scendi(eleMatrice, PosPezzo, Pezzo);
            }

            if (conta == 0)
            {
                Pezzo = Lib.GeneraPezzo(eleMatrice, PosPezzo);
                conta++;
            }
            #endregion PezzoRandom

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Matrice Main
            Matrice nuovaCasella = default;
            int x = 0;
            int riga = 1;
            int PosColonna = 0;
            while (x <= num - 1)
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
                    if (PosColonna < 9)
                    {
                        PosColonna = PosColonna + 1;
                        x--;
                        riga = 1;
                    }
                }
                eleMatrice[x] = nuovaCasella;
                x++;
            }
            #endregion Matrice Main
            #region Matrice Random
            MatriceRandom nuovaCasellaRandom = default;
            int y = 0;
            int rigaRandom = 1;
            int PosColonnaRandom = 0;
            while (y <= numRandom - 1)
            {
                if (rigaRandom <= 4)
                {
                    nuovaCasellaRandom.Colonna = ColonnaRandom[PosColonnaRandom];
                    nuovaCasellaRandom.Riga = rigaRandom;
                    nuovaCasellaRandom.Casella = (System.Windows.Forms.TextBox)this.Controls.Find(nuovaCasellaRandom.Colonna + nuovaCasellaRandom.Riga, true).FirstOrDefault();
                    rigaRandom = rigaRandom + 1;
                    nuovaCasellaRandom.ColoreSfondo = nuovaCasellaRandom.Casella.BackColor;
                    nuovaCasellaRandom.TipoBordi = nuovaCasellaRandom.Casella.BorderStyle;
                }
                else
                {
                    if (PosColonnaRandom < 1)
                    {
                        PosColonnaRandom = PosColonnaRandom + 1;
                        y--;
                        rigaRandom = 1;
                    }
                }
                eleMatriceRandom[y] = nuovaCasellaRandom;
                y++;
            }
            #endregion Matrice Random

            

        }
    }
}
