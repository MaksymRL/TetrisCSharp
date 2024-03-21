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
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            timer_screenupdate.Interval = 1000;
            timer_screenupdate.Tick += Timer_Tick;
            timer_screenupdate.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            #region ScendiTest
            //Matrice temp = default;
            //int x = 0;
            //int riga = 1;
            //int PosColonna = 0;
            //int[] rigastart = { 2, 3, 4, 4 };
            //string[] colonnastart = { "E", "E", "E", "F" };
            //int PartePos = 0;
            //while (x <= num - 1)
            //{
            //    if (riga < 20 && PosColonna <= 10)
            //    {
            //        if (elePezzi[x].Riga == rigastart[PartePos] && elePezzi[x].Colonna == colonnastart[PartePos])
            //        {
            //            temp = elePezzi[x];
            //            elePezzi[x] = elePezzi[x + 1];
            //            elePezzi[x + 1] = temp;
            //        }
            //        else if (elePezzi[x].Riga == rigastart[PartePos + 1] && elePezzi[x].Colonna == colonnastart[PartePos + 1])
            //        {
            //            temp = elePezzi[x];
            //            elePezzi[x] = elePezzi[x + 1];
            //            elePezzi[x + 1] = temp;
            //        }
            //        else if (elePezzi[x].Riga == rigastart[PartePos + 2] && elePezzi[x].Colonna == colonnastart[PartePos + 2])
            //        {
            //            temp = elePezzi[x];
            //            elePezzi[x] = elePezzi[x + 1];
            //            elePezzi[x + 1] = temp;
            //        }
            //        else if (elePezzi[x].Riga == rigastart[PartePos + 3] && elePezzi[x].Colonna == colonnastart[PartePos + 3])
            //        {
            //            temp = elePezzi[x];
            //            elePezzi[x] = elePezzi[x + 1];
            //            elePezzi[x + 1] = temp;
            //        }
            //    }
            //    else
            //    {
            //        PosColonna = PosColonna + 1;
            //        riga = 0;
            //    }

            //    riga++;
            //    x++;
            //}
            #endregion ScendiTest

            #region PezzoRandom
            
            if (conta == 0)
            {

                int z = 0;
                while (z < numRandom)
                {
                    eleMatriceRandom[z].Casella.BackColor = Color.Black;
                    eleMatriceRandom[z].Casella.BorderStyle = BorderStyle.None;
                    z++;
                }
                int PezzoRandom = Lib.PezzoRandom(eleMatriceRandom);
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
