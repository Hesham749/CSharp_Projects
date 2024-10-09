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
            lblSizeValue.Text = rbSmall.Text;
            gbSize.Tag = rbSmall.Tag;
            UpdatePrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeValue.Text = rbMedium.Text;
            gbSize.Tag = rbMedium.Tag;
            UpdatePrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeValue.Text = rbLarge.Text;
            gbSize.Tag = rbLarge.Tag;
            UpdatePrice();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeValue.Text = rbThin.Text;
            gbCrust.Tag = rbThin.Tag;
            UpdatePrice();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeValue.Text = rbThick.Text;
            gbCrust.Tag = rbThick.Tag;
            UpdatePrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblPlaceValue.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblPlaceValue.Text = rbTakeOut.Text;
        }

        private void AddTopping(string Topping, float Price)
        {

            if (lblToppingsValue.Text == "No Toppings")
                lblToppingsValue.Text = Topping;
            else
                lblToppingsValue.Text += " , " + Topping;

            gbToppings.Tag = Convert.ToUInt32(gbToppings.Tag) + Price;
            UpdatePrice();
        }

        private void RemoveTopping(string Topping, float Price)
        {
            if (lblToppingsValue.Text.IndexOf(",") == -1)
                lblToppingsValue.Text = "No Toppings";
            else if (lblToppingsValue.Text.IndexOf(Topping) == 0)
                lblToppingsValue.Text = lblToppingsValue.Text.Replace(Topping + " , ", "");
            else
                lblToppingsValue.Text = lblToppingsValue.Text.Replace(" , " + Topping, "");
            gbToppings.Tag = Convert.ToUInt32(gbToppings.Tag) - 5;
            UpdatePrice();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked && lblToppingsValue.Text.IndexOf(chkCheese.Text) == -1)
                AddTopping(chkCheese.Text, Convert.ToSingle(chkCheese.Tag));
            else
                RemoveTopping(chkCheese.Text, Convert.ToSingle(chkCheese.Tag));
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMashrooms.Checked && lblToppingsValue.Text.IndexOf(chkMashrooms.Text) == -1)
                AddTopping(chkMashrooms.Text, Convert.ToSingle(chkMashrooms.Tag));
            else
                RemoveTopping(chkMashrooms.Text, Convert.ToSingle(chkMashrooms.Tag));
        }

        private void chkTmoato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTmoato.Checked && lblToppingsValue.Text.IndexOf(chkTmoato.Text) == -1)
                AddTopping(chkTmoato.Text, Convert.ToSingle(chkTmoato.Tag));
            else
                RemoveTopping(chkTmoato.Text, Convert.ToSingle(chkTmoato.Tag));
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked && lblToppingsValue.Text.IndexOf(chkOnion.Text) == -1)
                AddTopping(chkOnion.Text, Convert.ToSingle(chkOnion.Tag));
            else
                RemoveTopping(chkOnion.Text, Convert.ToSingle(chkOnion.Tag));
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked && lblToppingsValue.Text.IndexOf(chkOlives.Text) == -1)
                AddTopping(chkOlives.Text, Convert.ToSingle(chkOlives.Tag));
            else
                RemoveTopping(chkOlives.Text, Convert.ToSingle(chkOlives.Tag));
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPappers.Checked && lblToppingsValue.Text.IndexOf(chkGreenPappers.Text) == -1)
                AddTopping(chkGreenPappers.Text, Convert.ToSingle(chkGreenPappers.Tag));
            else
                RemoveTopping(chkGreenPappers.Text, Convert.ToSingle(chkGreenPappers.Tag));
        }

        private void UpdatePrice()
        {
            int price = Convert.ToInt32(gbToppings.Tag) + Convert.ToInt32(gbSize.Tag) + Convert.ToInt32(gbCrust.Tag);

            lblPriceValue.Text = "$" + price.ToString();
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

        private void ResetForm()
        {
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbSize.Enabled = true;
            btnOrder.Enabled = true;
            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;
            chkCheese.Checked = false;
            chkTmoato.Checked = false;
            chkMashrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkGreenPappers.Checked = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
