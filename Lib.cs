using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public static int GeneraPezzo(Matrice[] ele, int[] elePosizioni, ref int Rotazione)
        {
            Random random = new Random();
            int randomNumero = random.Next(6);
            //int randomNumero = 0;
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

        public static void Scendi(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case 0:
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    case 1:
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
                    case 2:
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
                    case 3:
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
                        break;
                    case 4:
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
                    case 5:
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
                    case 6:
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

        }

        public static bool QualcosaSotto(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {
            if (elePosizioni[3] != 199)
            {
                switch (Pezzo)
                {

                    case 0:
                        if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;
                    case 1:
                        if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;
                    case 2:
                        if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;
                    case 3:
                        if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;
                    case 4:
                        if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;
                    case 5:
                        if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;
                    case 6:
                        if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
                        {
                            return true;
                        }
                        break;

                }
            }
            else return true;



            return false;
        }

        public static bool QualcosaSinistra(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {

            switch (Pezzo)
            {

                case 0:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black)
                    {


                        return true;
                    }
                    break;
                case 1:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (ele[elePosizioni[0] - 20].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 20].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;

            }



            return false;
        }

        public static bool QualcosaDestra(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {
            switch (Pezzo)
            {

                case 0:
                    if (ele[elePosizioni[3] + 20].Casella.BackColor != Color.Black)
                    {


                        return true;
                    }
                    break;
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



            return false;
        }

        public static void MuoviASinistra(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case 0:
                        if (x != 0 && x != 1 && x != 2)
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 20;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
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

        public static void MuoviADestra(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
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

        public static int RotazioneIBlock(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            int PosPezzoQuale = 58;
            switch (Rotazione)
            {
                case 0:
                    for (int x = 0; x < 4; x++)
                    {
                        if (x != 3)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {

                        }

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
        public static int RotazioneJBlock(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
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
        public static int RotazioneLBlock(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
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
        public static int RotazioneSBlock(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
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
        public static int RotazioneTBlock(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
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
        public static int RotazioneZBlock(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
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
    }
}
