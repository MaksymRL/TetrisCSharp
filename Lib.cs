using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
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
    }

    public struct MatriceNextPiece
    {
        public string Colonna;
        public int Riga;
        public TextBox Casella;
    }

    public enum Pezzi
    {
        IBlock, JBlock, LBlock, OBlock, SBlock, TBlock, ZBlock
    }

    internal class Lib
    {

        #region Genera
        public static int GeneraPezzo(Matrice[] ele, int[] elePosizioni, ref int Rotazione, int PezzoSuccessivo)
        {
            int randomNumero = -1;
            if (PezzoSuccessivo == -1) randomNumero = RandomNum(randomNumero);
            else randomNumero = PezzoSuccessivo;
            
            //int randomNumero = 0;
            int[] posizioni = { 69, 70, 92, 93, 115, 116, 138, 139 };
            bool Lose;
            switch (randomNumero)
            {
                case (int)Pezzi.IBlock:
                    elePosizioni[0] = posizioni[0];
                    elePosizioni[1] = posizioni[2];
                    elePosizioni[2] = posizioni[4];
                    elePosizioni[3] = posizioni[6];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[0]].Casella.BackColor = Color.LightBlue;
                    ele[posizioni[0]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[2]].Casella.BackColor = Color.LightBlue;
                    ele[posizioni[2]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[4]].Casella.BackColor = Color.LightBlue;
                    ele[posizioni[4]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[6]].Casella.BackColor = Color.LightBlue;
                    ele[posizioni[6]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    Rotazione = 0;
                    return (int)Pezzi.IBlock;
                case (int)Pezzi.JBlock:
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[3];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[2]].Casella.BackColor = Color.Blue;
                    ele[posizioni[2]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[3]].Casella.BackColor = Color.Blue;
                    ele[posizioni[3]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[5]].Casella.BackColor = Color.Blue;
                    ele[posizioni[5]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[7]].Casella.BackColor = Color.Blue;
                    ele[posizioni[7]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    
                    Rotazione = 0;
                    return (int)Pezzi.JBlock;
                case (int)Pezzi.LBlock:
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[5];
                    elePosizioni[2] = posizioni[6];
                    elePosizioni[3] = posizioni[7];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[3]].Casella.BackColor = Color.Gold;
                    ele[posizioni[3]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[5]].Casella.BackColor = Color.Gold;
                    ele[posizioni[5]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[6]].Casella.BackColor = Color.Gold;
                    ele[posizioni[6]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[7]].Casella.BackColor = Color.Gold;
                    ele[posizioni[7]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    
                    Rotazione = 0;
                    return (int)Pezzi.LBlock;
                case (int)Pezzi.OBlock:
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[3];
                    elePosizioni[2] = posizioni[4];
                    elePosizioni[3] = posizioni[5];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[2]].Casella.BackColor = Color.Yellow;
                    ele[posizioni[2]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[3]].Casella.BackColor = Color.Yellow;
                    ele[posizioni[3]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[4]].Casella.BackColor = Color.Yellow;
                    ele[posizioni[4]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[5]].Casella.BackColor = Color.Yellow;
                    ele[posizioni[5]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    
                    Rotazione = 0;
                    return (int)Pezzi.OBlock;
                case (int)Pezzi.SBlock:
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[6];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[3]].Casella.BackColor = Color.LightGreen;
                    ele[posizioni[3]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[4]].Casella.BackColor = Color.LightGreen;
                    ele[posizioni[4]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[5]].Casella.BackColor = Color.LightGreen;
                    ele[posizioni[5]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[6]].Casella.BackColor = Color.LightGreen;
                    ele[posizioni[6]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    
                    Rotazione = 0;
                    return (int)Pezzi.SBlock;
                case (int)Pezzi.TBlock:
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[3]].Casella.BackColor = Color.Purple;
                    ele[posizioni[3]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[4]].Casella.BackColor = Color.Purple;
                    ele[posizioni[4]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[5]].Casella.BackColor = Color.Purple;
                    ele[posizioni[5]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[7]].Casella.BackColor = Color.Purple;
                    ele[posizioni[7]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    
                    Rotazione = 0;
                    return (int)Pezzi.TBlock;
                case (int)Pezzi.ZBlock:
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    Lose = Lib.Lose(ele, elePosizioni);
                    if (Lose) return -1;
                    ele[posizioni[2]].Casella.BackColor = Color.Red;
                    ele[posizioni[2]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[4]].Casella.BackColor = Color.Red;
                    ele[posizioni[4]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[5]].Casella.BackColor = Color.Red;
                    ele[posizioni[5]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[posizioni[7]].Casella.BackColor = Color.Red;
                    ele[posizioni[7]].Casella.BorderStyle = BorderStyle.Fixed3D;
                   
                    Rotazione = 0;
                    return (int)Pezzi.ZBlock;
            }
            return -1;
        }
        public static int RandomNum(int num)
        {
            Random random = new Random();
            return num = random.Next(7);
        }
        public static int PezzoSuccessivo(MatriceNextPiece[] ele)
        {
            for(int x = 0; x < ele.Length; x++)
            {
                ele[x].Casella.BackColor = Color.Black;
                ele[x].Casella.BorderStyle = BorderStyle.None;
            }
            int Pezzo = 0;
            Pezzo = RandomNum(Pezzo);
            switch (Pezzo)
            {
                case (int)Pezzi.IBlock:
                    ele[4].Casella.BackColor = Color.LightBlue;
                    ele[4].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.LightBlue;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.LightBlue;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.LightBlue;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case (int)Pezzi.JBlock:
                    ele[1].Casella.BackColor = Color.Blue;
                    ele[1].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Blue;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Blue;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Blue;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case (int)Pezzi.LBlock:
                    ele[3].Casella.BackColor = Color.Gold;
                    ele[3].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Gold;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Gold;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Gold;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case (int)Pezzi.OBlock:
                    ele[1].Casella.BackColor = Color.Yellow;
                    ele[1].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[2].Casella.BackColor = Color.Yellow;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Yellow;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Yellow;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case (int)Pezzi.SBlock:
                    ele[2].Casella.BackColor = Color.LightGreen;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[3].Casella.BackColor = Color.LightGreen;
                    ele[3].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.LightGreen;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.LightGreen;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case (int)Pezzi.TBlock:
                    ele[2].Casella.BackColor = Color.Purple;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[5].Casella.BackColor = Color.Purple;
                    ele[5].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Purple;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Purple;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case (int)Pezzi.ZBlock:
                    ele[1].Casella.BackColor = Color.Red;
                    ele[1].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[2].Casella.BackColor = Color.Red;
                    ele[2].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[6].Casella.BackColor = Color.Red;
                    ele[6].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[7].Casella.BackColor = Color.Red;
                    ele[7].Casella.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
            return Pezzo;
        }
        #endregion Genera

        #region Scendi
        public static void Scendi(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case (int)Pezzi.IBlock:
                        Lib.ScendiIBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.JBlock:
                        Lib.ScendiJBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.LBlock:
                        Lib.ScendiLBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.OBlock:
                        Lib.ScendiOBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.SBlock:
                        Lib.ScendiSBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.TBlock:
                        Lib.ScendiTBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.ZBlock:
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
                    if (x != 0)
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
                    if (x != 1 && x != 2)
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
            if (elePosizioni[3] != 226)
            {
                switch (Pezzo)
                {

                    case (int)Pezzi.IBlock:
                        Something = Lib.QualcosaSottoIBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case (int)Pezzi.JBlock:
                        Something = Lib.QualcosaSottoJBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case (int)Pezzi.LBlock:
                        Something = Lib.QualcosaSottoLBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case (int)Pezzi.OBlock:
                        Something = Lib.QualcosaSottoOBlock(ele, elePosizioni);
                        return Something;
                    case (int)Pezzi.SBlock:
                        Something = Lib.QualcosaSottoSBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case (int)Pezzi.TBlock:
                        Something = Lib.QualcosaSottoTBlock(ele, elePosizioni, Rotazione);
                        return Something;
                    case (int)Pezzi.ZBlock:
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
                    if (ele[elePosizioni[0] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[1] + 1].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 1].Casella.BackColor != Color.Black)
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

                case (int)Pezzi.IBlock:
                    Something = Lib.QualcosaSinistraIBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.JBlock:
                    Something = Lib.QualcosaSinistraJBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.LBlock:
                    Something = Lib.QualcosaSinistraLBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.OBlock:
                    Something = Lib.QualcosaSinistraOBlock(ele, elePosizioni);
                    return Something;
                case (int)Pezzi.SBlock:
                    Something = Lib.QualcosaSinistraSBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.TBlock:
                    Something = Lib.QualcosaSinistraTBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.ZBlock:
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
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;

            }
            return false;
        }
        public static bool QualcosaSinistraOBlock(Matrice[] ele, int[] elePosizioni)
        {
            if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] - 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] - 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] - 23].Casella.BackColor != Color.Black)
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
                    Something = Lib.QualcosaDestraIBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.JBlock:
                    Something = Lib.QualcosaDestraJBlock(ele, elePosizioni, Rotazione);
                    return Something;
                case (int)Pezzi.LBlock:
                    Something = Lib.QualcosaDestraLBlock(ele, elePosizioni, Rotazione);
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
                    if (ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {


                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[0] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;

        }
        public static bool QualcosaDestraOBlock(Matrice[] ele, int[] elePosizioni)
        {

            if (ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[0] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 180:
                    if (ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 270:
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
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
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
                case 90:
                    if (ele[elePosizioni[1] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[2] + 23].Casella.BackColor != Color.Black | ele[elePosizioni[3] + 23].Casella.BackColor != Color.Black)
                    {
                        return true;
                    }
                    break;
            }

            return false;

        }
        #endregion QualcosaDestra  

        #region MuoviASinistra
        public static void MuoviASinistra(Matrice[] ele, int[] elePosizioni, int Pezzo, int Rotazione)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case (int)Pezzi.IBlock:
                        Lib.MuoviASinistraIBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.JBlock:
                        Lib.MuoviASinistraJBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.LBlock:
                        Lib.MuoviASinistraLBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.OBlock:
                        Lib.MuoviASinistraOBlock(ele, elePosizioni, x);
                        break;
                    case (int)Pezzi.SBlock:
                        Lib.MuoviASinistraSBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.TBlock:
                        Lib.MuoviASinistraTBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.ZBlock:
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
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                    elePosizioni[x] = elePosizioni[x] - 23;
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
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 0 && x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
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
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 0 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
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
                elePosizioni[x] = elePosizioni[x] - 23;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                elePosizioni[x] = elePosizioni[x] - 23;
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
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
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
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 0 && x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
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
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 0)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] - 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] - 23;
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
                    case (int)Pezzi.IBlock:
                        Lib.MuoviADestraIBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.JBlock:
                        Lib.MuoviADestraJBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.LBlock:
                        Lib.MuoviADestraLBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.OBlock:
                        Lib.MuoviADestraOBlock(ele, elePosizioni, x);
                        break;
                    case (int)Pezzi.SBlock:
                        Lib.MuoviADestraSBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.TBlock:
                        Lib.MuoviADestraTBlock(ele, elePosizioni, Rotazione, x);
                        break;
                    case (int)Pezzi.ZBlock:
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
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                    ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                    elePosizioni[x] = elePosizioni[x] + 23;
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
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 1 && x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
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
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 2 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 1)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
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
                elePosizioni[x] = elePosizioni[x] + 23;
                ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                elePosizioni[x] = elePosizioni[x] + 23;
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
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
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
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 180:
                    if (x != 1 && x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 270:
                    if (x != 2)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
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
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case 90:
                    if (x != 3)
                    {
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 23;
                        ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        elePosizioni[x] = elePosizioni[x] + 23;
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
            switch (Pezzo)
            {
                case (int)Pezzi.IBlock:
                    Rotazione = RotazioneIBlock(ele, elePosizioni, ref Rotazione);
                    return Rotazione;
                case (int)Pezzi.JBlock:
                    Rotazione = RotazioneJBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case (int)Pezzi.LBlock:
                    Rotazione = RotazioneLBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case (int)Pezzi.SBlock:
                    Rotazione = RotazioneSBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case (int)Pezzi.TBlock:
                    Rotazione = RotazioneTBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
                case (int)Pezzi.ZBlock:
                    Rotazione = RotazioneZBlock(ele, elePosizioni, Rotazione);
                    return Rotazione;
            }

            return -1;
        }
        public static int RotazioneIBlock(Matrice[] ele, int[] elePosizioni, ref int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 44, 22, 0, -22 };
            bool PuòRuotare;
            bool PuòRuotareEnd;
            int[] Escludi = new int[3];
            switch (Rotazione)
            {
                case 0:
                    Escludi[0] = 2;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            PosPezzoQuale = ValoriUtiliR0[x];
                            if (x != 2)
                            {
                                ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                                elePosizioni[x] = elePosizioni[x] + PosPezzoQuale;
                                ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                            }



                        }
                    }
                    else
                    {
                        return 0;
                    }
                    return 90;
                case 90:
                    Escludi[0] = 2;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotareReverse(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            PosPezzoQuale = ValoriUtiliR0[x];
                            if (x != 2)
                            {
                                ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                                elePosizioni[x] = elePosizioni[x] - PosPezzoQuale;
                                ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                                ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                            }

                        }
                    }
                    else
                    {
                        return 90;
                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneJBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 23, 23, 1, -1 };
            int[] ValoriUtiliR90 = { -22, 0, 22, 2 };
            int[] ValoriUtiliR180 = { 1, -1, -23, -23 };
            int[] Escludi = new int[3];
            bool PuòRuotare;
            bool PuòRuotareEnd;
            switch (Rotazione)
            {
                case 0:
                    Escludi[0] = 1;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 0;
                    }
                    return 90;
                case 90:
                    Escludi[0] = 1;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR90, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 90;
                    }
                    return 180;
                case 180:
                    Escludi[0] = 2;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR180, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 180;
                    }
                    return 270;
                case 270:
                    Escludi[0] = 2;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotareReverse(ele, elePosizioni, ValoriUtiliR0, ValoriUtiliR90, ValoriUtiliR180, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 270;
                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneLBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 22, 0, -21, +1 };
            int[] ValoriUtiliR90 = { -22, -22, -1, -1 };
            int[] ValoriUtiliR180 = { -1, +21, 0, -22 };
            bool PuòRuotare;
            int[] Escludi = new int[3];
            bool PuòRuotareEnd;
            switch (Rotazione)
            {
                case 0:
                    Escludi[0] = 1;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 0;
                    }
                    return 90;
                case 90:
                    Escludi[0] = 2;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR90, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 90;
                    }
                    return 180;
                case 180:
                    Escludi[0] = 2;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR180, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 180;
                    }
                    return 270;
                case 270:
                    Escludi[0] = 1;
                    Escludi[1] = -1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotareReverse(ele, elePosizioni, ValoriUtiliR0, ValoriUtiliR90, ValoriUtiliR180, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 270;
                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneSBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 21, 0, 22, 1 };
            bool PuòRuotare;
            int[] Escludi = new int[3];
            bool PuòRuotareEnd;
            switch (Rotazione)
            {
                case 0:
                    Escludi[0] = 1;
                    Escludi[1] = 2;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 0;
                    }
                    return 90;
                case 90:
                    Escludi[0] = 1;
                    Escludi[1] = 3;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotareReverse(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 90;
                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneTBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {

            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 22, 1, 1, 0 };
            int[] ValoriUtiliR90 = { -22, 0, 0, 0 };
            int[] ValoriUtiliR180 = { 0, -1, -1, -22 };
            int[] Escludi = new int[3];
            bool PuòRuotare;
            bool PuòRuotareEnd;
            switch (Rotazione)
            {
                case 0:
                    Escludi[0] = 0;
                    Escludi[1] = 1;
                    Escludi[2] = 3;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 0;
                    }
                    return 90;
                case 90:
                    Escludi[0] = 1;
                    Escludi[1] = 2;
                    Escludi[2] = 3;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR90, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 90;
                    }
                    return 180;
                case 180:
                    Escludi[0] = 0;
                    Escludi[1] = 2;
                    Escludi[2] = 3;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR180, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 180;
                    }
                    return 270;
                case 270:
                    Escludi[0] = 0;
                    Escludi[1] = 1;
                    Escludi[2] = 2;
                    PuòRuotare = Lib.PuòRuotareReverse(ele, elePosizioni, ValoriUtiliR0, ValoriUtiliR90, ValoriUtiliR180, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[2]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 270;
                    }
                    return 0;
            }
            return -1;
        }
        public static int RotazioneZBlock(Matrice[] ele, int[] elePosizioni, int Rotazione)
        {
            int PosPezzoQuale;
            int[] ValoriUtiliR0 = { 23, 1, 21, -1 };
            bool PuòRuotare;
            int[] Escludi = new int[3];
            bool PuòRuotareEnd;
            switch (Rotazione)
            {
                case 0:
                    Escludi[0] = 0;
                    Escludi[1] = 1;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[1]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 0;
                    }
                    return 90;
                case 90:
                    Escludi[0] = 0;
                    Escludi[1] = 3;
                    Escludi[2] = -1;
                    PuòRuotare = Lib.PuòRuotare(ele, elePosizioni, ValoriUtiliR0, Escludi);
                    PuòRuotareEnd = Lib.PuòRuotareEnd(elePosizioni[0]);
                    if (PuòRuotare && PuòRuotareEnd)
                    {
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
                    }
                    else
                    {
                        return 90;
                    }
                    return 0;
            }
            return -1;
        }

        #endregion Rotazione

        #region PuòRuotare
        public static bool PuòRuotare(Matrice[] ele, int[] elePosizioni, int[] Valori, int[] Escludi)
        {
            for (int x = 0; x < 4; x++)
            {
                if (x != Escludi[0] && x != Escludi[1] && x != Escludi[2])
                {

                    if (elePosizioni[x] + Valori[x] < 0 | elePosizioni[x] + Valori[x] > 226)
                    {
                        return false;
                    }
                    else if (ele[elePosizioni[x] + Valori[x]].Casella.BackColor != Color.Black)
                    {

                        return false;
                    }

                }
                else if (elePosizioni[x] + Valori[x] < 0 | elePosizioni[x] + Valori[x] > 226)
                {

                    return false;
                }
            }
            return true;
        }

        public static bool PuòRuotareReverse(Matrice[] ele, int[] elePosizioni, int[] Valori, int[] Escludi)
        {
            for (int x = 0; x < 4; x++)
            {
                if (x != Escludi[0] && x != Escludi[1])
                {
                    if (elePosizioni[x] - Valori[x] < 0 | elePosizioni[x] - Valori[x] > 226)
                    {
                        return false;
                    }
                    else if (ele[elePosizioni[x] - Valori[x]].Casella.BackColor != Color.Black)
                    {
                        return false;
                    }

                }
                else if (elePosizioni[x] - Valori[x] < 0 | elePosizioni[x] - Valori[x] > 226)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool PuòRuotareReverse(Matrice[] ele, int[] elePosizioni, int[] Valori, int[] Valori2, int[] Valori3, int[] Escludi)
        {
            for (int x = 0; x < 4; x++)
            {
                if (x != Escludi[0] && x != Escludi[1] && x != Escludi[2])
                {
                    if (elePosizioni[x] - Valori[x] - Valori2[x] - Valori3[x] < 0 | elePosizioni[x] - Valori[x] - Valori2[x] - Valori3[x] > 226)
                    {
                        return false;
                    }
                    else if (ele[elePosizioni[x] - Valori[x] - Valori2[x] - Valori3[x]].Casella.BackColor != Color.Black)
                    {

                        return false;

                    }

                }
                else if (elePosizioni[x] - Valori[x] - Valori2[x] - Valori3[x] < 0 | elePosizioni[x] - Valori[x] - Valori2[x] - Valori3[x] > 226)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool PuòRuotareEnd(int Centro)
        {
            int[] stop = { 19, 42, 65, 88, 111, 134, 157, 180, 203, 226 };
            for (int x = 0; x < stop.Length; x++)
            {
                if (Centro == stop[x])
                {
                    return false;
                }
            }
            return true;
        }

        #endregion PuòRuotare

        #region Lose
        public static bool Lose(Matrice[] ele ,int[] PosGenerazione)
        {
            for (int x = 0; x < PosGenerazione.Length; x++)
            {
                if (ele[PosGenerazione[x]].Casella.BackColor != Color.Black)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion Lose

        #region Punteggio
        public static int CalcoloPunteggio(Matrice[] ele, ref int PunteggioAttuale, int Livello, ref int SommaLine)
        {
            int[] ArrPosizioniCanc = new int[4];
            int Righe = QuanteRighe(ele, ref SommaLine,ArrPosizioniCanc);
            
            switch (Righe)
            {
                case 0:
                    return PunteggioAttuale;
                case 1:
                    PunteggioAttuale = PunteggioAttuale + 40 * (Livello + 1);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[0]);
                    return PunteggioAttuale;
                case 2:
                    PunteggioAttuale = PunteggioAttuale + 100 * (Livello + 1);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[0]);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[1]);
                    return PunteggioAttuale;
                case 3:
                    PunteggioAttuale = PunteggioAttuale + 300 * (Livello + 1);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[0]);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[1]);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[2]);
                    return PunteggioAttuale;
                case 4:
                    PunteggioAttuale = PunteggioAttuale + 1200 * (Livello + 1);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[0]);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[1]);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[2]);
                    Lib.CancelloRiga(ele, ArrPosizioniCanc[3]);
                    return PunteggioAttuale;
            }
            return 0;
        }

        public static void CancelloRiga(Matrice[] ele, int x)
        {
            int temp = x;
            for(int y = 0; y < 10; y++)
            {
                for (int z = 0; z <= 20; z++)
                {
                    if (x != 0 && x % 23 != 0)
                    {
                        ele[x].Casella.BackColor = ele[x - 1].Casella.BackColor;
                        ele[x].Casella.BorderStyle = ele[x - 1].Casella.BorderStyle;
                        x--;
                    }
                }
                x = temp + 23;
                temp = x;
            }
        }

        public static int QuanteRighe(Matrice[] ele, ref int SommaLine, int[] ArrPosizioneCanc)
        {
            int PosizioneCanc = 0;
            int Righe = 0;
            
            for (int Posizione = 0; Posizione < 20; Posizione++)
            {
                if (ele[Posizione + 0].Casella.BackColor != Color.Black && ele[Posizione + 23].Casella.BackColor != Color.Black && ele[Posizione + 46].Casella.BackColor != Color.Black && ele[Posizione + 69].Casella.BackColor != Color.Black && ele[Posizione + 92].Casella.BackColor != Color.Black && ele[Posizione + 115].Casella.BackColor != Color.Black && ele[Posizione + 138].Casella.BackColor != Color.Black && ele[Posizione + 161].Casella.BackColor != Color.Black && ele[Posizione + 184].Casella.BackColor != Color.Black && ele[Posizione + 207].Casella.BackColor != Color.Black)
                {
                    Righe = Righe + 1;
                    SommaLine = SommaLine + 1;
                    ArrPosizioneCanc[PosizioneCanc] = Posizione;
                    PosizioneCanc++;
                }
            }
            return Righe;
        }
        #endregion Punteggio

        #region Statistica
        public static int Livello(int SommaLine)
        {
            int Livello = SommaLine / 10;
            return Livello;
        }
        public static void Statitistiche(ref int StatisticaT, ref int StatisticaJ, ref int StatisticaL, ref int StatisticaZ, ref int StatisticaI, ref int StatisticaS, ref int StatisticaO, int Pezzo)
        {
           
            switch (Pezzo)
            {
                case (int)Pezzi.IBlock:
                    StatisticaI = StatisticaI + 1;
                    break;
                case (int)Pezzi.JBlock:
                    StatisticaJ = StatisticaJ + 1;
                    break;
                case (int)Pezzi.LBlock:
                    StatisticaL = StatisticaL + 1;
                    break;
                case (int)Pezzi.OBlock:
                    StatisticaO = StatisticaO + 1;
                    break;
                case (int)Pezzi.SBlock:
                    StatisticaS = StatisticaS + 1;
                    break;
                case (int)Pezzi.TBlock:
                    StatisticaT = StatisticaT + 1;
                    break;
                case (int)Pezzi.ZBlock:
                    StatisticaZ = StatisticaZ + 1;
                    break;
            }
            
        }
        #endregion Statistica
    }
}
