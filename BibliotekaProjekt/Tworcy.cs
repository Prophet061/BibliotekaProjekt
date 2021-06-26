using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class Tworcy : Form
    {
        public Tworcy()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.Show();
        }
    }
}
