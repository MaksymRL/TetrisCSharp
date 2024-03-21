using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisFunzioni
{
    public struct Matrice
    {
        public string Colonna;
        public int Riga;
        public TextBox Casella;
        public Color ColoreSfondo;
        public BorderStyle TipoBordi;
    }

    public struct MatriceRandom
    {
        public string Colonna;
        public int Riga;
        public TextBox Casella;
        public Color ColoreSfondo;
        public BorderStyle TipoBordi;
    }

    public enum Pezzi
    {
        IBlock, JBlock, LBlock, OBlock, SBlock, TBlock, ZBlock
    }

    internal class Lib
    {

        public static int PezzoRandom(MatriceRandom[] ele)
        {
            Random random = new Random();
            int randomNumero = random.Next(6);
            switch (randomNumero)
            {
                case 0:
                    ele[4].Casella.BackColor = Color.LightBlue;
                    ele[4].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.LightBlue;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.LightBlue;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.LightBlue;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.IBlock;
                case 1:
                    ele[1].Casella.BackColor = Color.Blue;
                    ele[1].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Blue;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Blue;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Blue;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.JBlock;
                case 2:
                    ele[3].Casella.BackColor = Color.Gold;
                    ele[3].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Gold;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Gold;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Gold;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.LBlock;
                case 3:
                    ele[1].Casella.BackColor = Color.Yellow;
                    ele[1].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[2].Casella.BackColor = Color.Yellow;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Yellow;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Yellow;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.OBlock;
                case 4:
                    ele[2].Casella.BackColor = Color.LightGreen;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[3].Casella.BackColor = Color.LightGreen;
                    ele[3].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.LightGreen;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.LightGreen;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.SBlock;
                case 5:
                    ele[2].Casella.BackColor = Color.Purple;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Purple;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Purple;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Purple;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.TBlock;
                case 6:
                    ele[1].Casella.BackColor = Color.Red;
                    ele[1].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[2].Casella.BackColor = Color.Red;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Red;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Red;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return (int)Pezzi.ZBlock;
            }
            return -1;
        }

        public static int ScendiPezzoRandom(MatriceRandom[] eleRandom, Matrice[] ele)
        {


            return -1;
        }
    }
}
