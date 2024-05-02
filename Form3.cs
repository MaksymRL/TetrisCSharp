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
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TB_nickname.Text = Lib.Player.Nickname.ToString();
            TB_PuntiFatti.Text = Lib.Player.Punteggio.ToString();
            TB_linee.Text = Lib.Player.Linee.ToString();
            TB_livello.Text = Lib.Player.Livello.ToString();
            date_Punteggio.Value = Lib.Player.Data;
            end_statisticaI.Text = Lib.Player.StatI.ToString();
            end_statisticaJ.Text = Lib.Player.StatJ.ToString();
            end_statisticaL.Text = Lib.Player.StatL.ToString();
            end_statisticaO.Text = Lib.Player.StatO.ToString();
            end_statisticaS.Text = Lib.Player.StatS.ToString();
            end_statisticaT.Text = Lib.Player.StatT.ToString();
            end_statisticaZ.Text = Lib.Player.StatZ.ToString();
        }

        private void Btn_Menù_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
