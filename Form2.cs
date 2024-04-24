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
        }

        public struct giocatori
        {
            public string nome;
            public int punteggio;

        }
        public giocatori[] Elegiocatori = new giocatori[69];
        private int num = 0;
        public static void SalvaFile(giocatori[] ele, int n)
        {
            StreamWriter mioFile;


            mioFile = new StreamWriter("statistica");
            int x = 0;
            while (x < n)
            {
                giocatori tmpGiocatore = ele[x];
                mioFile.WriteLine(tmpGiocatore.nome);
                mioFile.WriteLine(tmpGiocatore.punteggio);

                x++;
            }

            mioFile.Close();


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            giocatori nuovigiocatori = default;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("inserisci nickname");
                return;

            }
            nuovigiocatori.nome = textBox1.Text;
            nuovigiocatori.punteggio = 1;

            Elegiocatori[num] = nuovigiocatori;
            num++;
            textBox1.Clear();


            SalvaFile(Elegiocatori, num);
            ListViewItem item = new ListViewItem(nuovigiocatori.nome);
            item.SubItems.Add(nuovigiocatori.punteggio.ToString());
            listView1.Items.Add(item);


            
            Form1 form1 = new Form1();
            form1.Show();
            Form2 form2 = new Form2();
            form2.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
