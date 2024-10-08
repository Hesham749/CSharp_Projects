﻿using System;
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
            DrawWinLine((_Player1Turn) ? enChoices.X.ToString() : enChoices.O.ToString());
            FreezeGame();
        }

        private void DrawWinLine(string WinnerTag)
        {
            //draw row
            if (WinnerTag == pb1.Tag.ToString() && pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;
            }
            if (WinnerTag == pb4.Tag.ToString() && pb4.Tag.ToString() == pb5.Tag.ToString() && pb4.Tag.ToString() == pb6.Tag.ToString())
            {
                pb4.BackColor = Color.GreenYellow;
                pb5.BackColor = Color.GreenYellow;
                pb6.BackColor = Color.GreenYellow;
            }
            if (WinnerTag == pb7.Tag.ToString() && pb7.Tag.ToString() == pb8.Tag.ToString() && pb7.Tag.ToString() == pb9.Tag.ToString())
            {
                pb7.BackColor = Color.GreenYellow;
                pb8.BackColor = Color.GreenYellow;
                pb9.BackColor = Color.GreenYellow;
            }
            //draw col
            if (WinnerTag == pb1.Tag.ToString() && pb1.Tag.ToString() == pb4.Tag.ToString() && pb1.Tag.ToString() == pb7.Tag.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb4.BackColor = Color.GreenYellow;
                pb7.BackColor = Color.GreenYellow;
            }
            if (WinnerTag == pb2.Tag.ToString() && pb2.Tag.ToString() == pb5.Tag.ToString() && pb2.Tag.ToString() == pb8.Tag.ToString())
            {
                pb2.BackColor = Color.GreenYellow;
                pb5.BackColor = Color.GreenYellow;
                pb8.BackColor = Color.GreenYellow;
            }
            if (WinnerTag == pb3.Tag.ToString() && pb3.Tag.ToString() == pb6.Tag.ToString() && pb3.Tag.ToString() == pb9.Tag.ToString())
            {
                pb3.BackColor = Color.GreenYellow;
                pb6.BackColor = Color.GreenYellow;
                pb9.BackColor = Color.GreenYellow;
            }
            //draw x
            if (WinnerTag == pb5.Tag.ToString() && pb5.Tag.ToString() == pb3.Tag.ToString() && pb5.Tag.ToString() == pb7.Tag.ToString())
            {
                pb5.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;
                pb7.BackColor = Color.GreenYellow;
            }
            if (WinnerTag == pb5.Tag.ToString() && pb5.Tag.ToString() == pb1.Tag.ToString() && pb5.Tag.ToString() == pb9.Tag.ToString())
            {
                pb5.BackColor = Color.GreenYellow;
                pb1.BackColor = Color.GreenYellow;
                pb9.BackColor = Color.GreenYellow;
            }
        }


        private void CheckWinner(string BoxTag)
        {

            //check rows
            if (
                (BoxTag == pb1.Tag.ToString() && BoxTag == pb2.Tag.ToString() && BoxTag == pb3.Tag.ToString())
                ||
                (BoxTag == pb4.Tag.ToString() && BoxTag == pb5.Tag.ToString() && BoxTag == pb6.Tag.ToString())
                ||
                (BoxTag == pb7.Tag.ToString() && BoxTag == pb8.Tag.ToString() && BoxTag == pb9.Tag.ToString())
                )
            {
                EndResult();
            }
            //check cols
            else if (
                (BoxTag == pb1.Tag.ToString() && BoxTag == pb4.Tag.ToString() && BoxTag == pb7.Tag.ToString())
                ||
                (BoxTag == pb2.Tag.ToString() && BoxTag == pb5.Tag.ToString() && BoxTag == pb8.Tag.ToString())
                ||
                (BoxTag == pb3.Tag.ToString() && BoxTag == pb6.Tag.ToString() && BoxTag == pb9.Tag.ToString())
                )
            {
                EndResult();
            }

            //check x
            else if (
               (BoxTag == pb1.Tag.ToString() && BoxTag == pb5.Tag.ToString() && BoxTag == pb9.Tag.ToString())
               ||
               (BoxTag == pb3.Tag.ToString() && BoxTag == pb5.Tag.ToString() && BoxTag == pb7.Tag.ToString())
               )
            {
                EndResult();
            }
            else
            {
                if (_MoveCounter >= 8)
                {
                    EndResult();
                }
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb1.Tag.ToString());
                ChangeTurn();
            }

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb2.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb3.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb4.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb5.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb6.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb7.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb8.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckWinner(pb9.Tag.ToString());
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
