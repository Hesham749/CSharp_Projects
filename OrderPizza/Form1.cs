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

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lSizeValue.Text = rbSmall.Text;
            gbSize.Tag = rbSmall.Tag;
            UpdatePrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lSizeValue.Text = rbMedium.Text;
            gbSize.Tag = rbMedium.Tag;
            UpdatePrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lSizeValue.Text = rbLarge.Text;
            gbSize.Tag = rbLarge.Tag;
            UpdatePrice();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            lCrustTypeValue.Text = rbThin.Text;
            gbCrust.Tag = rbThin.Tag;
            UpdatePrice();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            lCrustTypeValue.Text = rbThick.Text;
            gbCrust.Tag = rbThick.Tag;
            UpdatePrice();
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

            if (lToppingsValue.Text == "No Toppings")
                lToppingsValue.Text = Topping;
            else
                lToppingsValue.Text += " , " + Topping;

            gbToppings.Tag = Convert.ToUInt32(gbToppings.Tag) + 5;
            UpdatePrice();
        }

        private void RemoveTopping(string Topping)
        {
            if (lToppingsValue.Text.IndexOf(",") == -1)
                lToppingsValue.Text = "No Toppings";
            else if (lToppingsValue.Text.IndexOf(Topping) == 0)
                lToppingsValue.Text = lToppingsValue.Text.Replace(Topping + " , ", "");
            else
                lToppingsValue.Text = lToppingsValue.Text.Replace(" , " + Topping, "");
            gbToppings.Tag = Convert.ToUInt32(gbToppings.Tag) - 5;
            UpdatePrice();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked && lToppingsValue.Text.IndexOf(chkCheese.Text) == -1)
                AddTopping(chkCheese.Text);

            else
                RemoveTopping(chkCheese.Text);
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMashrooms.Checked && lToppingsValue.Text.IndexOf(chkMashrooms.Text) == -1)
                AddTopping(chkMashrooms.Text);

            else
                RemoveTopping(chkMashrooms.Text);
        }

        private void chkTmoato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTmoato.Checked && lToppingsValue.Text.IndexOf(chkTmoato.Text) == -1)
                AddTopping(chkTmoato.Text);

            else
                RemoveTopping(chkTmoato.Text);
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked && lToppingsValue.Text.IndexOf(chkOnion.Text) == -1)
                AddTopping(chkOnion.Text);

            else
                RemoveTopping(chkOnion.Text);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked && lToppingsValue.Text.IndexOf(chkOlives.Text) == -1)
                AddTopping(chkOlives.Text);

            else
                RemoveTopping(chkOlives.Text);
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPappers.Checked && lToppingsValue.Text.IndexOf(chkGreenPappers.Text) == -1)
                AddTopping(chkGreenPappers.Text);

            else
                RemoveTopping(chkGreenPappers.Text);
        }

        private void UpdatePrice()
        {
            int price = Convert.ToInt32(gbToppings.Tag) + Convert.ToInt32(gbSize.Tag) + Convert.ToInt32(gbCrust.Tag);

            lPriceValue.Text = "$" + Convert.ToString(price);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbSize.Enabled = false;
                btnOrder.Enabled = false;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbSize.Enabled = true;
            btnOrder.Enabled = true;
        }
    }
}
