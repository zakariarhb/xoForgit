using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationXO
{
    public partial class Form1 : Form
    {
        bool tourner = true; // X=true , Y=false
        int nombreDeTourni = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void proposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Réaliser par monsieur Super Stilling in the back !!","XO Game");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
