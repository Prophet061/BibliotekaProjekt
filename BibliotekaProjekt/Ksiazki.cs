using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class Ksiazki : Form
    {
        public Ksiazki()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
