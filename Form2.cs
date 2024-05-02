using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TetrisFunzioni;
using System.Diagnostics;

namespace ProgettoFineAnno
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            Lib.CaricaDati(eleGiocatori, ref numPlayer);
            for(int x = 0; x < numPlayer; x++)
            {
                var riga = new ListViewItem(new string[]
                {
                    eleGiocatori[x].Nome,
                    eleGiocatori[x].Punteggio.ToString(),
                });
                leaderboard.Items.Add(riga);
                x++;
            }
        }

        
        public Giocatori[] eleGiocatori = new Giocatori[69];
        private int numPlayer = 0;
       



       

        
        private void b_gioca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nickname.Text)) return;
            

            Lib.Player.Nickname = txt_nickname.Text;
            this.Close();
           
           

        }
        private void b_esci_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
