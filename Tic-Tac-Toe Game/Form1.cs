using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _Player1Turn = true;
        private bool _HaveWinner = false;
        private byte _MoveCounter = 0;
        private enum enChoices : Byte
        {
            X = 1, O
        };
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 610, 329, 1338, 329);
            e.Graphics.DrawLine(pen, 610, 524, 1338, 524);
            e.Graphics.DrawLine(pen, 850, 143, 850, 710);
            e.Graphics.DrawLine(pen, 1099, 143, 1099, 710);
        }

        private void ChangeTurn()
        {
            _MoveCounter++;
            if (_MoveCounter <= 8 && !_HaveWinner)
            {
                lblTurn.Text = (_Player1Turn = !_Player1Turn) ? "Player 1" : "Player 2";
            }
        }

        private bool ChangePic(PictureBox Box)
        {
            if (Box.Tag.ToString() == 0.ToString())
            {
                if (_Player1Turn)
                {
                    Box.Image = Resources.X;
                    Box.Tag = enChoices.X;
                }
                else
                {
                    Box.Image = Resources.O;
                    Box.Tag = enChoices.O;
                }
                return true;
            }
            else
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void FreezeGame(bool Freeze = true)
        {
            pb1.Enabled = !Freeze;
            pb2.Enabled = !Freeze;
            pb3.Enabled = !Freeze;
            pb4.Enabled = !Freeze;
            pb5.Enabled = !Freeze;
            pb6.Enabled = !Freeze;
            pb7.Enabled = !Freeze;
            pb8.Enabled = !Freeze;
            pb9.Enabled = !Freeze;
        }

        private void EndResult()
        {
            lblWinner.Text = (_Player1Turn) ? "Player 1" : "Player 2";
            lblWinner.Text = (_MoveCounter >= 8) ? "Draw" : lblWinner.Text;
            if (lblWinner.Text != "Draw")
                _HaveWinner = true;
            lblTurn.Text = "Game Over";
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FreezeGame();
        }

        private void DrawWinLine(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {

            pb1.BackColor = Color.GreenYellow;
            pb2.BackColor = Color.GreenYellow;
            pb3.BackColor = Color.GreenYellow;

        }

        private bool CheckResult(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag.ToString() != 0.ToString() && pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                DrawWinLine(pb1, pb2, pb3);
                return true;
            }
            return false;
        }

        private void CheckWinner()
        {

            //check rows
            if (CheckResult(pb1, pb2, pb3))
            {
                EndResult();
                return;
            }

            if (CheckResult(pb4, pb5, pb6))
            {
                EndResult();
                return;
            }

            if (CheckResult(pb7, pb8, pb9))
            {
                EndResult();
                return;
            }
            //check cols
            if (CheckResult(pb1, pb4, pb7))
            {
                EndResult();
                return;
            }

            if (CheckResult(pb2, pb5, pb8))
            {
                EndResult();
                return;
            }

            if (CheckResult(pb3, pb6, pb9))
            {
                EndResult();
                return;
            }

            //check x

            if (CheckResult(pb1, pb5, pb9))
            {
                EndResult();
                return;
            }

            if (CheckResult(pb3, pb5, pb7))
            {
                EndResult();
                return;
            }

            else
            {
                if (_MoveCounter >= 8)
                {
                    EndResult();
                }
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if (ChangePic(sender as PictureBox))
            {
                CheckWinner();
                ChangeTurn();
            }
        }

        private void ResetPb(PictureBox pb)
        {
            pb.Image = Resources.question_mark_96;
            pb.Tag = 0;
            pb.BackColor = Color.Black;
        }

        private void ResetGame()
        {
            lblWinner.Text = "In Progress";
            lblTurn.Text = "Player 1";
            _Player1Turn = true;
            _HaveWinner = false;
            _MoveCounter = 0;
            ResetPb(pb1);
            ResetPb(pb2);
            ResetPb(pb3);
            ResetPb(pb4);
            ResetPb(pb5);
            ResetPb(pb6);
            ResetPb(pb7);
            ResetPb(pb8);
            ResetPb(pb9);
            FreezeGame(false);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnRestart_MouseEnter(object sender, EventArgs e)
        {
            btnRestart.BackColor = Color.Green;
        }

        private void btnRestart_MouseLeave(object sender, EventArgs e)
        {
            btnRestart.BackColor = Color.Black;
        }
    }
}
