using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisFunzioni;

namespace ProgettoFineAnno
{
    public partial class Form3 : Form
    {
        public Giocatori[] eleGiocatori = new Giocatori[10000];
        private int numPlayer = 0;
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Lib.CaricaDati(eleGiocatori, ref numPlayer);
            Lib.SortLeaderboard(eleGiocatori, 0, numPlayer - 1);    
            if (Lib.Player.FineGioco == true)
            {
                LB_Nickname.Text = Lib.Player.Nickname.ToString();
                LB_punteggio.Text = Lib.Player.Punteggio.ToString();
                LB_linee.Text = Lib.Player.Linee.ToString();
                LB_livello.Text = Lib.Player.Livello.ToString();
                LB_data.Text = Lib.Player.Data.ToString();
                end_statisticaI.Text = Lib.Player.StatI.ToString();
                end_statisticaJ.Text = Lib.Player.StatJ.ToString();
                end_statisticaL.Text = Lib.Player.StatL.ToString();
                end_statisticaO.Text = Lib.Player.StatO.ToString();
                end_statisticaS.Text = Lib.Player.StatS.ToString();
                end_statisticaT.Text = Lib.Player.StatT.ToString();
                end_statisticaZ.Text = Lib.Player.StatZ.ToString();
                b_replay.Visible = true;
            }
            else
            {
                
                int posizioneScelta = Lib.Player.QualePlayerScelto;
                LB_Nickname.Text = eleGiocatori[posizioneScelta].Nome;
                LB_punteggio.Text = eleGiocatori[posizioneScelta].Punteggio.ToString();
                LB_linee.Text = eleGiocatori[posizioneScelta].Lines.ToString();
                LB_livello.Text = eleGiocatori[posizioneScelta].Livello.ToString();
                LB_data.Text = eleGiocatori[posizioneScelta].TempoRecord.ToString();
                end_statisticaI.Text = eleGiocatori[posizioneScelta].StatI.ToString();
                end_statisticaJ.Text = eleGiocatori[posizioneScelta].StatJ.ToString();
                end_statisticaL.Text = eleGiocatori[posizioneScelta].StatL.ToString();
                end_statisticaO.Text = eleGiocatori[posizioneScelta].StatO.ToString();
                end_statisticaS.Text = eleGiocatori[posizioneScelta].StatS.ToString();
                end_statisticaT.Text = eleGiocatori[posizioneScelta].StatT.ToString();
                end_statisticaZ.Text = eleGiocatori[posizioneScelta].StatZ.ToString();
            }

        }

        private void Btn_Menù_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void b_replay_Click(object sender, EventArgs e)
        {
            Lib.Player.TopScorePosizione = Lib.Cerca(eleGiocatori, TB_nickname.Text);
            Lib.Player.TopScore = eleGiocatori[Lib.Player.TopScorePosizione].Punteggio;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
    }
}
