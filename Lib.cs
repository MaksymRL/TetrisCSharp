using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        #region Genera
        public static int GeneraPezzo(Matrice[] ele, int[] elePosizioni, ref int Rotazione)
        {
            Random random = new Random();
            int randomNumero = random.Next(6);
            //int randomNumero = 1;
            int[] posizioni = { 60, 61, 80, 81, 100, 101, 120, 121 };
            switch (randomNumero)
            {
                case (int)Pezzi.IBlock:
                    ele[60].Casella.BackColor = Color.LightBlue;
                    ele[60].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[80].Casella.BackColor = Color.LightBlue;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.LightBlue;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[120].Casella.BackColor = Color.LightBlue;
                    ele[120].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[0];
                    elePosizioni[1] = posizioni[2];
                    elePosizioni[2] = posizioni[4];
                    elePosizioni[3] = posizioni[6];
                    Rotazione = 0;
                    return (int)Pezzi.IBlock;
                case (int)Pezzi.JBlock:
                    ele[80].Casella.BackColor = Color.Blue;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[81].Casella.BackColor = Color.Blue;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Blue;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Blue;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[3];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    Rotazione = 0;
                    return (int)Pezzi.JBlock;
                case (int)Pezzi.LBlock:
                    ele[81].Casella.BackColor = Color.Gold;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Gold;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[120].Casella.BackColor = Color.Gold;
                    ele[120].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Gold;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[5];
                    elePosizioni[2] = posizioni[6];
                    elePosizioni[3] = posizioni[7];
                    Rotazione = 0;
                    return (int)Pezzi.LBlock;
                case (int)Pezzi.OBlock:
                    ele[80].Casella.BackColor = Color.Yellow;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[81].Casella.BackColor = Color.Yellow;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.Yellow;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Yellow;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[3];
                    elePosizioni[2] = posizioni[4];
                    elePosizioni[3] = posizioni[5];
                    Rotazione = 0;
                    return (int)Pezzi.OBlock;
                case (int)Pezzi.SBlock:
                    ele[81].Casella.BackColor = Color.LightGreen;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.LightGreen;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.LightGreen;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[120].Casella.BackColor = Color.LightGreen;
                    ele[120].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[6];
                    Rotazione = 0;
                    return (int)Pezzi.SBlock;
                case (int)Pezzi.TBlock:
                    ele[81].Casella.BackColor = Color.Purple;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.Purple;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Purple;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Purple;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    Rotazione = 0;
                    return (int)Pezzi.TBlock;
                case (int)Pezzi.ZBlock:
                    ele[80].Casella.BackColor = Color.Red;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.Red;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Red;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Red;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    Rotazione = 0;
                    return (int)Pezzi.ZBlock;
            }
            return -1;
        }
        #endregion Genera

        #region Scendi
        public static void Scendi(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case 0:
                        Lib.ScendiIBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 1:
                        Lib.ScendiJBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 2:
                        Lib.ScendiLBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 3:
                        Lib.ScendiOBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 4:
                        Lib.ScendiSBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 5:
                        Lib.ScendiTBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 6:
                        Lib.ScendiZBlock(ele, elePosizioni, Rotazione, x);
                        break;

                }

            }

        }
        public static void ScendiIBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)    
        {
            switch (Rotazione)
            {

                case 0:
                    ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                    elePosizioni[x] = elePosizioni[x] + 1;
                    ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    return;
                case 90:
                    if(x != 0)
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }

                    return;
                case 180:
                    return;
                case 270:
                    return;
            }
        }
        public static void ScendiJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void ScendiLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1 && x !=2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void ScendiOBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            if (x != 1 && x != 3)
            {
                ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                elePosizioni[x] = elePosizioni[x] + 1;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                elePosizioni[x] = elePosizioni[x] + 1;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public static void ScendiSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;

                case 90:
                    if (x != 1 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;

            }
        }
        public static void ScendiTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                break;
                case 90:
                    if (x != 1 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void ScendiZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        #endregion Scendi

        
        #region QualcosaSotto
        public static bool QualcosaSotto(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            bool Something = false;
            if (elePosizioni[3] != 199)
            {
                switch (Pezzo)
                {

                    case 0:
                        Something = Lib.QualcosaSottoIBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case 1:
                        Something = Lib.QualcosaSottoJBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case 2:
                        Something = Lib.QualcosaSottoLBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case 3:
                        Something = Lib.QualcosaSottoOBlock(ele, elePosizioni);
                        return Something;
                    case 4:
                        Something = Lib.QualcosaSottoSBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case 5:
                        Something = Lib.QualcosaSottoTBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case 6:
                        Something = Lib.QualcosaSottoZBlock(ele, elePosizioni, Rotazione);
                        break;

                }
            }
            else return true;



            return Something;
        }
        public static bool QualcosaSottoIBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;

                case 90:
                    if (ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;

            }

            return false;
        }
        public static bool QualcosaSottoJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
                case 90:
                    if (ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool QualcosaSottoLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
                case 90:
                    if (ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                
            }
            return false;
        }
        public static bool QualcosaSottoOBlock(Matrice[] ele, int[] elePosizioni)
        {
            
            if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
            {
              return true;
            }
               
            return false;
        }
        public static bool QualcosaSottoSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool QualcosaSottoTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
                case 90:
                    if (ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }   
                    break;
                case 180:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black |  ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool QualcosaSottoZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
                case 90:
                    if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black |  ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
            }
            return false;
        }
        #endregion QualcosaSotto

        #region QualcosaSinistra
        public static bool QualcosaSinistra(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            bool Something = false;
            switch (Pezzo)
            {

                case 0:
                    Something = Lib.QualcosaSinistraIBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case 1:
                    Something = Lib.QualcosaSinistraJBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case 2:
                    Something = Lib.QualcosaSinistraLBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case 3:
                    Something = Lib.QualcosaSinistraOBlock(ele, elePosizioni);
                    return Something;
                case 4:
                    Something = Lib.QualcosaSinistraSBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case 5:
                    Something = Lib.QualcosaSinistraTBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case 6:
                    Something = Lib.QualcosaSinistraZBlock(ele, elePosizioni, Rotazione);
                    return Something;

            }



            return Something;
        }
        public static bool QualcosaSinistraIBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
                case 90:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black| ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black| ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black| ele[elePosizioni[3] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
            }

            return false;
        }
        public static bool QualcosaSinistraJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                break;
                case 90:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool QualcosaSinistraLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;

            }
            return false;
        }
        public static bool QualcosaSinistraOBlock(Matrice[] ele, int[] elePosizioni)
        {
            if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
            {
                return true;
            }
            return false;
        }
        public static bool QualcosaSinistraSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool QualcosaSinistraTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool QualcosaSinistraZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        #endregion QualcosaSinistra

       
        #region QualcosaDestra
        public static bool QualcosaDestra(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            bool Something = false;
            switch (Pezzo)
            {

                case (int)Pezzi.IBlock:
                    Something = Lib.QualcosaDestraIBlock(ele,elePosizioni,Rotazione);
                    return Something;
                case (int)Pezzi.JBlock:
                    Something = Lib.QualcosaDestraJBlock(ele,elePosizioni,Rotazione);
                    return Something;
                case (int)Pezzi.LBlock:
                    Something = Lib.QualcosaDestraLBlock(ele,elePosizioni,Rotazione);
                    return Something;
                case (int)Pezzi.OBlock:
                    Something = Lib.QualcosaDestraOBlock(ele, elePosizioni);
                    return Something;
                case (int)Pezzi.SBlock:
                    Something = Lib.QualcosaDestraSBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.TBlock:
                    Something = Lib.QualcosaDestraTBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.ZBlock:
                    Something = Lib.QualcosaDestraZBlock(ele, elePosizioni, Rotazione);
                    return Something;

            }



            return Something;
        }
        public static bool QualcosaDestraIBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {

            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {


                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 20].Casella.BackColor != Color.Black| ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black| ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black| ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {


                        return true;
                    }
                    break;
            }

            return false;
        }
        public static bool QualcosaDestraJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[0] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;
        
        }
        public static bool QualcosaDestraLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;

        }
        public static bool QualcosaDestraOBlock(Matrice[] ele, int[] elePosizioni)
        {

            if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
            {
                return true;
            }
            return false;

        }
        public static bool QualcosaDestraSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;

        }
        public static bool QualcosaDestraTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;

        }
        public static bool QualcosaDestraZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            switch (Rotazione)
            {
                case 0:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;

        }
        #endregion QualcosaDestra  

        #region MuoviASinistra
        public static void MuoviASinistra(Matrice[] ele, int[] elePosizioni, int Pezzo,int Rotazione)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case 0:
                        Lib.MuoviASinistraIBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 1:
                        Lib.MuoviASinistraJBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 2:
                        Lib.MuoviASinistraLBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 3:
                        Lib.MuoviASinistraOBlock(ele, elePosizioni, x);
                        break;
                    case 4:
                        Lib.MuoviASinistraSBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 5:
                        Lib.MuoviASinistraTBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 6:
                        Lib.MuoviASinistraZBlock(ele, elePosizioni, Rotazione, x);
                        break;

                }

            }
        }
        public static void MuoviASinistraIBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 0 && x != 1 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                    elePosizioni[x] = elePosizioni[x] - 20;
                    ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }
        public static void MuoviASinistraJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 1 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 0 && x !=1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviASinistraLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 0 && x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 0 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviASinistraOBlock(Matrice[] ele, int[] elePosizioni, int x)
        {
            if (x != 0 && x != 1)
            {
                ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                elePosizioni[x] = elePosizioni[x] - 20;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                elePosizioni[x] = elePosizioni[x] - 20;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public static void MuoviASinistraSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 0 && x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviASinistraTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 0 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 0 && x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviASinistraZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 0 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        #endregion MuoviASinistra

        #region MuoviADestra
        public static void MuoviADestra(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case 0:
                        Lib.MuoviADestraIBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 1:
                        Lib.MuoviADestraJBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 2:
                        Lib.MuoviADestraLBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 3:
                        Lib.MuoviADestraOBlock(ele, elePosizioni, x);
                        break;
                    case 4:
                        Lib.MuoviADestraSBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 5:
                        Lib.MuoviADestraTBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case 6:
                        Lib.MuoviADestraZBlock(ele, elePosizioni, Rotazione, x);
                        break;
                       

                }

            }
        }
        public static void MuoviADestraIBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 1 && x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                    elePosizioni[x] = elePosizioni[x] + 20;
                    ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }
        public static void MuoviADestraJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 1 && x!=2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviADestraLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 1 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviADestraOBlock(Matrice[] ele, int[] elePosizioni, int x)
        {
            if (x != 2 && x != 3)
            {
                ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                elePosizioni[x] = elePosizioni[x] + 20;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                elePosizioni[x] = elePosizioni[x] + 20;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public static void MuoviADestraSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviADestraTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 1 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        public static void MuoviADestraZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione, int x)
        {
            switch (Rotazione)
            {
                case 0:
                    if (x != 1 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
            }
        }
        #endregion MuoviADestra

        #region Rotazione
        public static int Rotazione(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            switch(Pezzo)
            {
                case 0:
                    Rotazione = RotazioneIBlock(ele, elePosizioni, ref Rotazione);
                    return Rotazione;
                case 1:
                    Rotazione = RotazioneJBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case 2:
                    Rotazione = RotazioneLBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case 4:
                    Rotazione = RotazioneSBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case 5:
                    Rotazione = RotazioneTBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case 6:
                    Rotazione = RotazioneZBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
            }

            return -1;
        }
        public static int RotazioneIBlock(Matrice[] ele, int[] elePosizioni, ref int Rotazione)
        {
            int PosPezzoQuale;
            switch (Rotazione)
            {
                case 0:
                    PosPezzoQuale = 38;
                    for (int x = 0; x < 4; x++)
                    {
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                      

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    PosPezzoQuale = -38;
                    for (int x = 0; x < 4; x++)
                    {
                        if(x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                        PosPezzoQuale = PosPezzoQuale + 19;
                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = {20,20,1,-1};
            int[] ValoriUtiliR90 = {-19,0,19,2};
            int[] ValoriUtiliR180 = { 1, -1, -20, -20 };
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        
                    }
                    return 90;
                case 90:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR90[x];
                        if (x != 1)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 180;
                case 180:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR180[x];
                        if (x != 1)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 270;
                case 270:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x] + ValoriUtiliR90[x] + ValoriUtiliR180[x];
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 19, 0, -18, +1 };
            int[] ValoriUtiliR90 = { -19, -19, -1, -1 };
            int[] ValoriUtiliR180 = { -1, +18, 0, -19 };
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x != 1)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 90;
                case 90:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR90[x];
                        if (x != 1)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 180;
                case 180:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR180[x];
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 270;
                case 270:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x] + ValoriUtiliR90[x] + ValoriUtiliR180[x];
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 18, 0, 19, 1 };
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x != 1 && x != 3)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 90;
                case 90:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x != 1 && x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {

            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 19, 1, 1, 0 };
            int[] ValoriUtiliR90 = { -19, 0, 0, 0 };
            int[] ValoriUtiliR180 = { 0, -1, -1, -19 };
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x == 0)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 90;
                case 90:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR90[x];
                        if (x == 0)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 180;
                case 180:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR180[x];
                        if (x == 3)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 270;
                case 270:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x] + ValoriUtiliR90[x] + ValoriUtiliR180[x];
                        if (x == 3)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 20, 1, 18, -1 };
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x != 1 && x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 90;
                case 90:
                    for (int x = 0; x < 4; x++)
                    {
                        PosPezzoQuale = ValoriUtiliR0[x];
                        if (x != 0 && x != 1)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }
                    return 0;
            }
            return -1;
        }

        #endregion Rotazione



    }
}
