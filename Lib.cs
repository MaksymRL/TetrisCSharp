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
            //int randomNumero = random.Next(6);
            int randomNumero = 0;
            int[] posizioni = { 60, 61, 80, 81, 100, 101, 120, 121 };
            switch (randomNumero)
            {
                case 0:
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
                case 1:
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
                case 2:
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
                case 3:
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
                case 4:
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
                case 5:
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
                case 6:
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
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black)
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

                case 0:
                    Something = Lib.QualcosaDestraIBlock(ele,elePosizioni,Rotazione);
                    return Something;
                case 1:
                    if (ele[elePosizioni[0] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (ele[elePosizioni[2] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (ele[elePosizioni[1] + 20].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;

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
                    case 2:
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
                    case 3:
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
                        break;
                    case 4:
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
                    case 5:
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
                    case 6:
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
                    case 2:
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
                    case 3:
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
                        break;
                    case 4:
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
                    case 5:
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
                    case 6:
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
                case 3:
                    Rotazione = RotazioneOBlock(ele, elePosizioni, Rotazione);
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
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {

                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    return 180;
                case 180:
                    return 270;
                case 270:
                    return 0;
            }
            return -1;
        }
        public static int RotazioneLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {

                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    return 180;
                case 180:
                    return 270;
                case 270:
                    return 0;
            }
            return -1;
        }
        public static int RotazioneOBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {

                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    return 180;
                case 180:
                    return 270;
                case 270:
                    return 0;
            }
            return -1;
        }
        public static int RotazioneSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {

                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    return 180;
                case 180:
                    return 270;
                case 270:
                    return 0;
            }
            return -1;
        }
        public static int RotazioneTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {

                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    return 180;
                case 180:
                    return 270;
                case 270:
                    return 0;
            }
            return -1;
        }
        public static int RotazioneZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {

                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;

                        PosPezzoQuale = PosPezzoQuale - 19;
                    }
                    return 90;
                case 90:
                    return 180;
                case 180:
                    return 270;
                case 270:
                    return 0;
            }
            return -1;
        }

        #endregion Rotazione



    }
}
