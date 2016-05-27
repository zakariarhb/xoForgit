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

        private void button_click(object sender, EventArgs e)
        {
            //le button cliqué est sender
            Button b = (Button)sender;
            if (tourner)
                b.Text = "X";
            else
                b.Text = "O";
            tourner = !tourner;//au prochain clique sera inversé
            //Resoudre le probleme de "On peut modifier le O avec Y dans la même Case(button)"
            b.Enabled = false;

            nombreDeTourni++;//on incremente le nombre de button touurni

            checkForWinner();
        }

        private void checkForWinner()
        {
            //horizontal check
            bool ici_winner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && !(A1.Enabled))//il faut verifier que le button est desabled ok!
                ici_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !(B1.Enabled))
               ici_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !(C1.Enabled))
               ici_winner = true;
            
            //vertical check
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !(A1.Enabled))//il faut verifier que le button est desabled ok!
                ici_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !(A2.Enabled))
                ici_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !(A3.Enabled))
                ici_winner = true;

            //Diagonal check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !(A1.Enabled))//il faut verifier que le button est desabled ok!
                ici_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && !(C1.Enabled))
                ici_winner = true;
            

            if (ici_winner)
            {
                //si on trouve un gagnant, on desactive les autres button qui sont actifs
                desactiverBouton();
                String winner = "";
                if (tourner)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " a gagné !", "OX Game");
            }//end if
            //si on ne trouve pas de gagnant

            else
            {
                if (nombreDeTourni == 9)
                    MessageBox.Show("Game Over !!", "XO Game");
            }
        }//end checkForWinner

        private void desactiverBouton()
        {
            try
            { foreach (Control c in Controls)
                {
                    Button b = (Button)c;

                    b.Enabled = false;
                }//end foreach
            }//end try
            catch { }        
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mise à zero tous les parametre de l'application
            tourner = true;
            nombreDeTourni = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled =true;
                    b.Text = "";
                }//end foreach
            }//end try
            catch { }
        }

        private void button_enter(object sender, EventArgs e)
        {

        }

        private void button_leave(object sender, EventArgs e)
        {

        }
    }
}
