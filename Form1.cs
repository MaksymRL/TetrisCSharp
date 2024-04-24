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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgettoFineAnno
{
    public partial class Form1 : Form
    {
        private Matrice[] eleMatrice = new Matrice[230];
        private MatriceNextPiece[] eleMatricePezzoSuccessivo = new MatriceNextPiece[8];
        private int num = 230;
        private string[] Colonna = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        private string[] ColonnaRandom = { "X", "Z" };
        private int numRandom = 8;
        private int conta = 0;
        private int[] PosPezzo = new int[4];
        private int Pezzo;
        private int RotazionePezzo;
        private int Punteggio = 0;
        private int Livello = 0;
        private int StatI = 0;
        private int StatJ = 0;
        private int StatL = 0;
        private int StatO = 0;
        private int StatS = 0;
        private int StatT = 0;
        private int StatZ = 0;
        private int Lines = 0;
        private int PezzoSuccessivo = -1;
        private int[] ArrPosizioniCanc = new int[4]; 
        private int keyPress = default;
        public Form1()
        {
            InitializeComponent();
            
            timer_screenupdate.Interval = 48000 / 64;
            timer_screenupdate.Tick += Timer_Tick;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            timer_screenupdate.Start();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {


            #region PezzoScendi
            int[] stop = { 19, 42, 65, 88, 111, 134, 157, 180, 203, 226 };
            bool contienevalori = stop.Any(value => PosPezzo.Contains(value));


            if (conta == 1)
            {

                bool stopPezzo = Lib.QualcosaSotto(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
                if (contienevalori == false && stopPezzo == false)
                {

                    Lib.Scendi(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);


                    
                }
                else
                {
                    conta = 0;
                }
            }




            if (conta == 0)
            {
                int temp = Lines;
                int Righe = Lib.QuanteRighe(eleMatrice, ref Lines, ArrPosizioniCanc);
                Lines = temp;
                if (Righe == 0)
                {
                    Pezzo = Lib.GeneraPezzo(eleMatrice, PosPezzo, ref RotazionePezzo, PezzoSuccessivo);
                    if (Pezzo == -1) Close();
                    PezzoSuccessivo = Lib.PezzoSuccessivo(eleMatricePezzoSuccessivo);

                    #region Statistica
                    Lib.Statitistiche(ref StatT, ref StatJ, ref StatL, ref StatZ, ref StatI, ref StatS, ref StatO, Pezzo);
                    switch (Pezzo)
                    {
                        case 0:
                            if (Convert.ToInt32(statisticaI.Text) < 10)
                            {

                                statisticaI.Text = $"00{StatI}";
                            }
                            else if (Convert.ToInt32(statisticaI.Text) < 100)
                            {
                                statisticaI.Text = $"0{StatI}";
                            }
                            else
                            {
                                statisticaI.Text = $"{StatI}";
                            }
                            break;
                        case 1:
                            if (Convert.ToInt32(statisticaJ.Text) < 10)
                            {

                                statisticaJ.Text = $"00{StatJ}";
                            }
                            else if (Convert.ToInt32(statisticaJ.Text) < 100)
                            {
                                statisticaJ.Text = $"0{StatJ}";
                            }
                            else
                            {
                                statisticaJ.Text = $"{StatJ}";
                            }
                            break;
                        case 2:
                            if (Convert.ToInt32(statisticaL.Text) < 10)
                            {

                                statisticaL.Text = $"00{StatL}";
                            }
                            else if (Convert.ToInt32(statisticaL.Text) < 100)
                            {
                                statisticaL.Text = $"0{StatL}";
                            }
                            else
                            {
                                statisticaL.Text = $"{StatL}";
                            }
                            break;
                        case 3:
                            if (Convert.ToInt32(statisticaO.Text) < 10)
                            {

                                statisticaO.Text = $"00{StatO}";
                            }
                            else if (Convert.ToInt32(statisticaO.Text) < 100)
                            {
                                statisticaO.Text = $"0{StatO}";
                            }
                            else
                            {
                                statisticaO.Text = $"{StatO}";
                            }
                            break;
                        case 4:
                            if (Convert.ToInt32(statisticaS.Text) < 10)
                            {

                                statisticaS.Text = $"00{StatS}";
                            }
                            else if (Convert.ToInt32(statisticaS.Text) < 100)
                            {
                                statisticaS.Text = $"0{StatS}";
                            }
                            else
                            {
                                statisticaS.Text = $"{StatS}";
                            }
                            break;
                        case 5:
                            if (Convert.ToInt32(statisticaT.Text) < 10)
                            {

                                statisticaT.Text = $"00{StatT}";
                            }
                            else if (Convert.ToInt32(statisticaT.Text) < 100)
                            {
                                statisticaT.Text = $"0{StatT}";
                            }
                            else
                            {
                                statisticaT.Text = $"{StatT}";
                            }
                            break;
                        case 6:
                            if (Convert.ToInt32(statisticaZ.Text) < 10)
                            {

                                statisticaZ.Text = $"00{StatZ}";
                            }
                            else if (Convert.ToInt32(statisticaZ.Text) < 100)
                            {
                                statisticaZ.Text = $"0{StatZ}";
                            }
                            else
                            {
                                statisticaZ.Text = $"{StatZ}";
                            }
                            break;
                    }
                    
                    #endregion Statistica
                }
                else
                {
                    Punteggio = Lib.CalcoloPunteggio(eleMatrice, ref Punteggio, Livello, ref Lines);
                   
                    txt_linee.Text = $"LINES-{Lines}";  
                    LBL_livello.Text = Lib.Livello(Lines).ToString();
                }
                
                conta++;
            }
            #endregion PezzoScendi

            bool QualcosaSotto = Lib.QualcosaSotto(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
            
            if(QualcosaSotto == true | contienevalori == true)
            {
                Punteggio += keyPress;
                keyPress = 0;
            }
            switch (Punteggio)
            {
                case int n when n < 10:
                    LBL_punteggio.Text = $"00000{Punteggio}";
                    break;
                case int n when n < 100:
                    LBL_punteggio.Text = $"0000{Punteggio}";
                    break;
                case int n when n < 1000:
                    LBL_punteggio.Text = $"000{Punteggio}";
                    break;
                case int n when n < 10000:
                    LBL_punteggio.Text = $"00{Punteggio}";
                    break;
                case int n when n < 100000:
                    LBL_punteggio.Text = $"0{Punteggio}";
                    break;
                default:
                    LBL_punteggio.Text = $"{Punteggio}";
                    break;
            }
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
                if (riga <= 23)
                {
                    nuovaCasella.Colonna = Colonna[PosColonna];
                    nuovaCasella.Riga = riga;
                    nuovaCasella.Casella = (System.Windows.Forms.TextBox)this.Controls.Find(nuovaCasella.Colonna + nuovaCasella.Riga, true).FirstOrDefault();
                    riga = riga + 1;
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
            #region Matrice PezzoSuccessivo
            MatriceNextPiece nuovaCasellaRandom = default;
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
                eleMatricePezzoSuccessivo[y] = nuovaCasellaRandom;
                y++;
            }
            #endregion Matrice Random

            
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool QualcosaSotto = Lib.QualcosaSotto(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
            int Righe = Lib.QuanteRighe(eleMatrice, ref Lines, ArrPosizioniCanc);
            if (conta == 1 && Righe == 0)
            {
                if (e.KeyCode == Keys.Left && PosPezzo[0] - 22 > 0)
                {
                    bool QualcosaSinistra = Lib.QualcosaSinistra(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
                    if (QualcosaSinistra == false)
                    {
                        Lib.MuoviASinistra(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
                    }
                }
                else if (e.KeyCode == Keys.Right && PosPezzo[3] + 22 < 226)
                {
                    bool QualcosaDestra = Lib.QualcosaDestra(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
                    if (QualcosaDestra == false)
                    {
                        Lib.MuoviADestra(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
                    }

                }
                else if (e.KeyCode == Keys.Up)
                {
                    RotazionePezzo = Lib.Rotazione(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);

                   
                }
                else if (e.KeyCode == Keys.Down )
                {

                    timer_screenupdate.Interval = 1000 / 64;
                    
                    
                    keyPress += 1;
                }
                
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int Righe = Lib.QuanteRighe(eleMatrice, ref Lines, ArrPosizioniCanc);
            bool QualcosaSotto = Lib.QualcosaSotto(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
            keyPress = 0;
            

            if (e.KeyCode == Keys.Down)
            {
                

                switch (Livello)
                {
                    case 0:
                        timer_screenupdate.Interval = 48000/64;
                        break;
                    case 1:
                        timer_screenupdate.Interval = 43000/64;
                        break;
                    case 2:
                        timer_screenupdate.Interval = 38000/64;
                        break;
                    case 3:
                        timer_screenupdate.Interval = 33000/64;
                        break;
                    case 4:
                        timer_screenupdate.Interval = 28000/64;
                        break;
                    case 5:
                        timer_screenupdate.Interval = 23000/64;
                        break;
                    case 6:
                        timer_screenupdate.Interval = 18000/64;
                        break;
                    case 7:
                        timer_screenupdate.Interval = 13000/64;
                        break;
                    case 8:
                        timer_screenupdate.Interval = 8000/64;
                        break;
                    case 9:
                        timer_screenupdate.Interval = 6000/64;
                        break;
                    case 10:
                    case 11:
                    case 12:
                        timer_screenupdate.Interval = 5000/64;
                        break;
                    case 13:
                    case 14:
                    case 15:
                        timer_screenupdate.Interval = 4000/64;
                        break;
                    case 16:
                    case 17:
                    case 18:
                        timer_screenupdate.Interval = 3000/64;
                        break;
                    case int n when n > 18:
                    case int z when z <= 28:
                        timer_screenupdate.Interval = 2000/64;
                        break;
                    case int n when n > 28:
                        timer_screenupdate.Interval = 1000/64;
                        break;


                }
               
            }
        }

        private void textBox392_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox196_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox197_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox106_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox108_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox102_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox104_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox103_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox98_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox97_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox100_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox94_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox93_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox96_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox297_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox296_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox322_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox323_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox338_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox89_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox198_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox199_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox91_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox109_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox110_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox111_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox337_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox321_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox320_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox298_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox299_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox88_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox404_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox393_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox201_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox262_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox261_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox264_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox263_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox258_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox257_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox260_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox259_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox254_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox253_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox256_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox255_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox250_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox249_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox252_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox251_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox248_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox247_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox204_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox203_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox202_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox206_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox205_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox214_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox213_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox210_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox209_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox208_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox207_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox212_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox211_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox225_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox226_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox227_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox229_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox228_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox232_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox233_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox230_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox231_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox236_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox237_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox234_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox235_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox240_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox241_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox238_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox239_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox244_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox245_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox242_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox243_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox246_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox395_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox394_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox403_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox402_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox399_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox398_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox397_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox396_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox401_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox400_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox405_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox391_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox390_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox355_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox354_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox356_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox357_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox359_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox358_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox371_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox373_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox362_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox370_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox375_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox376_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox372_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox374_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox367_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox369_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox363_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox364_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox365_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox366_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox368_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox379_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox377_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox378_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
