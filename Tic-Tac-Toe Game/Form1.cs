using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 610, 325, 1330, 325);
            e.Graphics.DrawLine(pen, 610, 525, 1330, 525);
            e.Graphics.DrawLine(pen, 850, 150, 850, 700);
            e.Graphics.DrawLine(pen, 1100, 150, 1100, 700);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
