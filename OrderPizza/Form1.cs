using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbSummary_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lSizeValue.Text = rbSmall.Text;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lSizeValue.Text = rbMedium.Text;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lSizeValue.Text = rbLarge.Text;
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            lCrustTypeValue.Text = rbThin.Text;
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            lCrustTypeValue.Text = rbThick.Text;
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lPlaceValue.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lPlaceValue.Text = rbTakeOut.Text;
        }

        private void AddTopping(string Topping)
        {

            if (lToppingsValue.Text == "")
                lToppingsValue.Text += Topping;
            else
                lToppingsValue.Text += " , " + Topping;
        }



        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked)
                AddTopping(chkCheese.Text);

            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + chkCheese.Text, "");
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMashrooms.Checked)
                AddTopping(chkMashrooms.Text);

            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + chkMashrooms.Text, "");
        }

        private void chkTmoato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTmoato.Checked)
                AddTopping(chkTmoato.Text);

            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + chkTmoato.Text, "");
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
                AddTopping(chkOnion.Text);

            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + chkOnion.Text, "");
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
                AddTopping(chkOlives.Text);

            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + chkOlives.Text, "");
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPappers.Checked)
                AddTopping(chkGreenPappers.Text);

            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + chkGreenPappers.Text, "");
        }
    }
}
