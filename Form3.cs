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

namespace ProgettoFineAnno
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Menù_Click(object sender, EventArgs e)
        {
            Form3 form= new Form3();
            form.Close();
            Form2 form2= new Form2();
            form2.Show();
        }
    }
}
