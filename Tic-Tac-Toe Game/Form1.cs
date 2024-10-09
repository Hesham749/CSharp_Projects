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

        private bool Player1Turn = true;
        private byte MoveCounter = 0;
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
            MoveCounter++;
            if (MoveCounter <= 8)
            {
                lblTurn.Text = (Player1Turn = !Player1Turn) ? "Player 1" : "Player 2";
            }
        }

        private bool ChangePic(PictureBox Box)
        {
            if (Box.Tag.ToString() == 0.ToString())
            {
                if (Player1Turn)
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

        private void ToggleFreezeGame()
        {
            pb1.Enabled = !pb1.Enabled;
            pb2.Enabled = !pb2.Enabled;
            pb3.Enabled = !pb3.Enabled;
            pb4.Enabled = !pb4.Enabled;
            pb5.Enabled = !pb5.Enabled;
            pb6.Enabled = !pb6.Enabled;
            pb7.Enabled = !pb7.Enabled;
            pb8.Enabled = !pb8.Enabled;
            pb9.Enabled = !pb9.Enabled;
        }
        private void EndResult()
        {
            lblWinner.Text = (Player1Turn) ? "Player 1" : "Player 2";
            lblTurn.Text = "Game Over";
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DrawWinLine((Player1Turn) ? enChoices.X.ToString() : enChoices.O.ToString());
            ToggleFreezeGame();
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
        private void CheckResult(string BoxTag)
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
                if (MoveCounter >= 8)
                {
                    lblWinner.Text = "Draw";
                    EndResult();
                }
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb1.Tag.ToString());
                ChangeTurn();
            }

        }


        private void pb2_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb2.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb3.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb4.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb5.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb6.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb7.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb8.Tag.ToString());
                ChangeTurn();
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (ChangePic((PictureBox)sender))
            {
                CheckResult(pb9.Tag.ToString());
                ChangeTurn();
            }
        }

        private void ResetGame()
        {
            lblWinner.Text = "In Progress";
            lblTurn.Text = "Player 1";
            Player1Turn = true;
            MoveCounter = 0;
            pb1.Image = Resources.question_mark_96;
            pb1.Tag = 0;
            pb1.BackColor = Color.Black;
            pb2.Image = Resources.question_mark_96;
            pb2.Tag = 0;
            pb2.BackColor = Color.Black;
            pb3.Image = Resources.question_mark_96;
            pb3.Tag = 0;
            pb3.BackColor = Color.Black;
            pb4.Image = Resources.question_mark_96;
            pb4.Tag = 0;
            pb4.BackColor = Color.Black;
            pb5.Image = Resources.question_mark_96;
            pb5.Tag = 0;
            pb5.BackColor = Color.Black;
            pb6.Image = Resources.question_mark_96;
            pb6.Tag = 0;
            pb6.BackColor = Color.Black;
            pb7.Image = Resources.question_mark_96;
            pb7.Tag = 0;
            pb7.BackColor = Color.Black;
            pb8.Image = Resources.question_mark_96;
            pb8.Tag = 0;
            pb8.BackColor = Color.Black;
            pb9.Image = Resources.question_mark_96;
            pb9.Tag = 0;
            pb9.BackColor = Color.Black;
            ToggleFreezeGame();
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
