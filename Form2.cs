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
using System.Net.WebSockets;

namespace ProgettoFineAnno
{
    public partial class Form2 : Form

    {
        public Giocatori[] eleGiocatori = new Giocatori[10000];
        private int numPlayer = 0;
        private int originalFormWidth;
        private int originalFormHeight;
        public Form2()
        {
            
            InitializeComponent();
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;


            Lib.CaricaDati(eleGiocatori, ref numPlayer);
            Lib.SortLeaderboard(eleGiocatori, 0, numPlayer - 1);
            
                TXT_Top1.Text = eleGiocatori[0].Nome;
                TXT_Top2.Text = eleGiocatori[1].Nome;
                TXT_Top3.Text = eleGiocatori[2].Nome;
            
            
            int Posizione = 0;
            for(int x = 0; x < numPlayer; x++)
            {
                Posizione = Posizione + 1;
                var riga = new ListViewItem(new string[]
                {
                    Posizione.ToString(),
                    eleGiocatori[x].Nome,
                    eleGiocatori[x].Punteggio.ToString(),
                    "Vedi tutte le statistiche...."
                });
                leaderboard.Items.Add(riga);
                
            }
        }

        
      



       

        
        private void b_gioca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nickname.Text)) return;
            

            Lib.Player.Nickname = txt_nickname.Text;
            Lib.Player.TopScorePosizione = Lib.Cerca(eleGiocatori, txt_nickname.Text);
            if (Lib.Player.TopScorePosizione != -1)
            {
                Lib.Player.TopScore = eleGiocatori[Lib.Player.TopScorePosizione].Punteggio;
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            



        }
        private void b_esci_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }



        private void leaderboard_MouseClick(object sender, MouseEventArgs e)
        {
            
                
                ListViewItem clickedItem = leaderboard.GetItemAt(e.X, e.Y);

                
                if (clickedItem != null)
                {
                    
                    int itemIndex = leaderboard.Items.IndexOf(clickedItem);

                    
                    int clickedColumnIndex = -1;
                    for (int i = 0; i < leaderboard.Columns.Count; i++)
                    {
                        if (leaderboard.Columns[i].Width <= e.X)
                        e = new MouseEventArgs(e.Button,e.Clicks, e.X - leaderboard.Columns[i].Width, e.Y, e.Delta);
                        else
                        {
                            clickedColumnIndex = i;
                            break;
                        }
                    }

                    
                    if (clickedColumnIndex == 3)
                    {
                        
                        Lib.Player.QualePlayerScelto = itemIndex;
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                }
            
        }

        //private void Form2_Resize(object sender, EventArgs e)
        //{
        //    // Calculate scaling factor based on the new size of the form and original size
        //    float scaleX = (float)this.ClientSize.Width / originalFormWidth;
        //    float scaleY = (float)this.ClientSize.Height / originalFormHeight;

        //    // Scale controls based on the scaling factor
        //    ScaleControls(this.Controls, scaleX, scaleY);
        //}

        //private void ScaleControls(Control.ControlCollection controls, float scaleX, float scaleY)
        //{
        //    foreach (Control control in controls)
        //    {
        //        // Adjust size and position of each control
        //        control.Left = (int)(control.Left * scaleX);
        //        control.Top = (int)(control.Top * scaleY);
        //        control.Width = (int)(control.Width * scaleX);
        //        control.Height = (int)(control.Height * scaleY);

        //        // Recursively scale child controls
        //        if (control.Controls.Count > 0)
        //        {
        //            ScaleControls(control.Controls, scaleX, scaleY);
        //        }
        //    }
        //}
    }
}
