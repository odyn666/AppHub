using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerTut
{
    public partial class Form3 : Form
    {
        bool turn = true;//True = X turn, False = O turn
        int turn_count = 0;
        //TODO win counter
        int xwin_count= 0;
        int owin_count = 0;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe", "Lorem Ipsum");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn == true)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            labelTurn.Text = "Turn count: " + turn_count;
            winner_check();
        }
        private void winner_check()
        {
            bool isWinner = false;

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && (!A2.Enabled))
            {
                isWinner = true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text && (!A3.Enabled))
            {
                isWinner = true;
            }
            //vertical check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B2.Enabled))
            {
                isWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C3.Enabled))
            {
                isWinner = true;
            }
            // slide check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (!B2.Enabled))
            {
                isWinner = true;
            }
            if (isWinner)
            {
                String winner = "";
                if (!turn)
                {
                    winner = "X";
                    labelXwinCoutn.Text = "X win count: "+xwin_count;
                    
                }
                else
                {
                    winner = "O";
                    labelOwinCoutn.Text = "O win count: " + owin_count;
                    
                }
                disableButtons();
                MessageBox.Show($"AND THE WINNER IS {winner}", "WE HAVE A WINNER");
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("WE HAVE DRAW TRY AGAIN", "DRAW");
            }

        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {

                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
    }
}
