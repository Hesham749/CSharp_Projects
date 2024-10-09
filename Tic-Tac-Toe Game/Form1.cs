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

            e.Graphics.DrawLine(pen, 610, 328, 1338, 328);
            e.Graphics.DrawLine(pen, 610, 525, 1338, 525);
            e.Graphics.DrawLine(pen, 850, 143, 850, 710);
            e.Graphics.DrawLine(pen, 1099, 143, 1099, 710);
        }

  
    }
}
