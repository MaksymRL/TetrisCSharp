using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private Giocatori[] eleGiocatori = new Giocatori[20000];
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
        private bool keyPress = default;
        private int numPlayer = default;
        public Form1()
        {
            InitializeComponent();
            Cursor.Hide();
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
                    if (Pezzo == -1)
                    {
                        
                        Giocatori nuovaGiocatore = default;
                        nuovaGiocatore.Nome = Lib.Player.Nickname;
                        nuovaGiocatore.Punteggio = Punteggio;
                        nuovaGiocatore.TempoRecord = DateTime.Now;
                        nuovaGiocatore.Lines = Lines;
                        nuovaGiocatore.Livello = Lib.Livello(Lines);
                        nuovaGiocatore.StatI = StatI;
                        nuovaGiocatore.StatJ = StatJ;
                        nuovaGiocatore.StatL = StatL;
                        nuovaGiocatore.StatO = StatO;
                        nuovaGiocatore.StatS = StatS;
                        nuovaGiocatore.StatT = StatT;
                        nuovaGiocatore.StatZ = StatZ;
                        eleGiocatori[numPlayer] = nuovaGiocatore;
                        Lib.Player.Punteggio = Punteggio;
                        Lib.Player.Data = DateTime.Now;
                        Lib.Player.Linee = Lines;
                        Lib.Player.Livello = Lib.Livello(Lines);
                        Lib.Player.StatI = StatI;
                        Lib.Player.StatJ = StatJ;
                        Lib.Player.StatL = StatL;
                        Lib.Player.StatO = StatO;
                        Lib.Player.StatS = StatS;
                        Lib.Player.StatT = StatT;
                        Lib.Player.StatZ = StatZ;
                        Lib.Player.FineGioco = true;
                        Lib.SalvaDati(eleGiocatori, numPlayer);
                        Cursor.Show();
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Close();
                    }
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
                    if(Punteggio > Lib.Player.TopScore)
                    {
                        switch (Punteggio)
                        {
                            case int n when n < 10:
                                LB_punteggiomigliore.Text = $"00000{Punteggio}";
                                break;
                            case int n when n < 100:
                                LB_punteggiomigliore.Text = $"0000{Punteggio}";
                                break;
                            case int n when n < 1000:
                                LB_punteggiomigliore.Text = $"000{Punteggio}";
                                break;
                            case int n when n < 10000:
                                LB_punteggiomigliore.Text = $"00{Punteggio}";
                                break;
                            case int n when n < 100000:
                                LB_punteggiomigliore.Text = $"0{Punteggio}";
                                break;
                            default:
                                LB_punteggiomigliore.Text = $"{Punteggio}";
                                break;
                        }
                    }
                    txt_linee.Text = $"LINES-{Lines}";  
                    LBL_livello.Text = Lib.Livello(Lines).ToString();
                }
                
                conta++;
            }
            #endregion PezzoScendi

            bool QualcosaSotto = Lib.QualcosaSotto(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
            
            

           

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

            int PunteggioMigliorePosizione = Lib.Player.TopScorePosizione;
            int PunteggioMigliore = Lib.Player.TopScore;
            if ( PunteggioMigliorePosizione == -1)
            {
                LB_punteggiomigliore.Text = "000000";
            }
            else
            {
                switch (PunteggioMigliore)
                {
                    case int n when n < 10:
                        LB_punteggiomigliore.Text = $"00000{PunteggioMigliore}";
                        break;
                    case int n when n < 100:
                        LB_punteggiomigliore.Text = $"0000{PunteggioMigliore}";
                        break;
                    case int n when n < 1000:
                        LB_punteggiomigliore.Text = $"000{PunteggioMigliore}";
                        break;
                    case int n when n < 10000:
                        LB_punteggiomigliore.Text = $"00{PunteggioMigliore}";
                        break;
                    case int n when n < 100000:
                        LB_punteggiomigliore.Text = $"0{PunteggioMigliore}";
                        break;
                    default:
                        LB_punteggiomigliore.Text = $"{PunteggioMigliore}";
                        break;
                }
            }
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
                    
                    
                    keyPress = true;
                }
                
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int Righe = Lib.QuanteRighe(eleMatrice, ref Lines, ArrPosizioniCanc);
            bool QualcosaSotto = Lib.QualcosaSotto(eleMatrice, PosPezzo, Pezzo, RotazionePezzo);
            keyPress = false;
            

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
       
    }
}
