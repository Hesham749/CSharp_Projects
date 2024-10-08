namespace OrderPizza
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTmoato = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.gbPlace = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lPriceValue = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lPlaceValue = new System.Windows.Forms.Label();
            this.lPlace = new System.Windows.Forms.Label();
            this.lCrustTypeValue = new System.Windows.Forms.Label();
            this.lCrustType = new System.Windows.Forms.Label();
            this.lToppingsValue = new System.Windows.Forms.Label();
            this.lToppings = new System.Windows.Forms.Label();
            this.lSizeValue = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbPlace.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(77, 170);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(185, 154);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Tag = "20";
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(16, 112);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(66, 23);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(16, 75);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(83, 23);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(16, 38);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(66, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(77, 398);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(185, 124);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Tag = "0";
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(16, 75);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(107, 23);
            this.rbThick.TabIndex = 1;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(16, 38);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(101, 23);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPappers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTmoato);
            this.gbToppings.Controls.Add(this.chkMashrooms);
            this.gbToppings.Controls.Add(this.chkCheese);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(413, 170);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(348, 124);
            this.gbToppings.TabIndex = 4;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "0";
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Location = new System.Drawing.Point(182, 94);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(131, 23);
            this.chkGreenPappers.TabIndex = 5;
            this.chkGreenPappers.Text = "Green Pappers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkGreenPappers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(182, 66);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(71, 23);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(182, 38);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(71, 23);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTmoato
            // 
            this.chkTmoato.AutoSize = true;
            this.chkTmoato.Location = new System.Drawing.Point(16, 94);
            this.chkTmoato.Name = "chkTmoato";
            this.chkTmoato.Size = new System.Drawing.Size(83, 23);
            this.chkTmoato.TabIndex = 2;
            this.chkTmoato.Text = "Tmoato";
            this.chkTmoato.UseVisualStyleBackColor = true;
            this.chkTmoato.CheckedChanged += new System.EventHandler(this.chkTmoato_CheckedChanged);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Location = new System.Drawing.Point(16, 66);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(109, 23);
            this.chkMashrooms.TabIndex = 1;
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.CheckedChanged += new System.EventHandler(this.chkMashrooms_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(16, 38);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(127, 23);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Extraa Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // gbPlace
            // 
            this.gbPlace.Controls.Add(this.rbTakeOut);
            this.gbPlace.Controls.Add(this.rbEatIn);
            this.gbPlace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlace.Location = new System.Drawing.Point(413, 398);
            this.gbPlace.Name = "gbPlace";
            this.gbPlace.Size = new System.Drawing.Size(240, 86);
            this.gbPlace.TabIndex = 4;
            this.gbPlace.TabStop = false;
            this.gbPlace.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(127, 38);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(92, 23);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(16, 38);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(69, 23);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lPriceValue);
            this.gbSummary.Controls.Add(this.lPrice);
            this.gbSummary.Controls.Add(this.lPlaceValue);
            this.gbSummary.Controls.Add(this.lPlace);
            this.gbSummary.Controls.Add(this.lCrustTypeValue);
            this.gbSummary.Controls.Add(this.lCrustType);
            this.gbSummary.Controls.Add(this.lToppingsValue);
            this.gbSummary.Controls.Add(this.lToppings);
            this.gbSummary.Controls.Add(this.lSizeValue);
            this.gbSummary.Controls.Add(this.lSize);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Location = new System.Drawing.Point(880, 156);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(250, 355);
            this.gbSummary.TabIndex = 5;
            this.gbSummary.TabStop = false;
            // 
            // lPriceValue
            // 
            this.lPriceValue.AutoSize = true;
            this.lPriceValue.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPriceValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.lPriceValue.Location = new System.Drawing.Point(111, 280);
            this.lPriceValue.Name = "lPriceValue";
            this.lPriceValue.Size = new System.Drawing.Size(102, 56);
            this.lPriceValue.TabIndex = 10;
            this.lPriceValue.Text = "$20";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrice.Location = new System.Drawing.Point(19, 280);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(98, 18);
            this.lPrice.TabIndex = 9;
            this.lPrice.Text = "Total Price :";
            // 
            // lPlaceValue
            // 
            this.lPlaceValue.AutoSize = true;
            this.lPlaceValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlaceValue.Location = new System.Drawing.Point(135, 244);
            this.lPlaceValue.Name = "lPlaceValue";
            this.lPlaceValue.Size = new System.Drawing.Size(40, 16);
            this.lPlaceValue.TabIndex = 8;
            this.lPlaceValue.Text = "Eat In";
            // 
            // lPlace
            // 
            this.lPlace.AutoSize = true;
            this.lPlace.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlace.Location = new System.Drawing.Point(19, 242);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(116, 18);
            this.lPlace.TabIndex = 7;
            this.lPlace.Text = "Where To Eat :";
            // 
            // lCrustTypeValue
            // 
            this.lCrustTypeValue.AutoSize = true;
            this.lCrustTypeValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCrustTypeValue.Location = new System.Drawing.Point(118, 202);
            this.lCrustTypeValue.Name = "lCrustTypeValue";
            this.lCrustTypeValue.Size = new System.Drawing.Size(66, 16);
            this.lCrustTypeValue.TabIndex = 6;
            this.lCrustTypeValue.Text = "Thin Crust";
            // 
            // lCrustType
            // 
            this.lCrustType.AutoSize = true;
            this.lCrustType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCrustType.Location = new System.Drawing.Point(19, 200);
            this.lCrustType.Name = "lCrustType";
            this.lCrustType.Size = new System.Drawing.Size(97, 18);
            this.lCrustType.TabIndex = 5;
            this.lCrustType.Text = "Crust Type :";
            // 
            // lToppingsValue
            // 
            this.lToppingsValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToppingsValue.Location = new System.Drawing.Point(57, 131);
            this.lToppingsValue.Name = "lToppingsValue";
            this.lToppingsValue.Size = new System.Drawing.Size(175, 59);
            this.lToppingsValue.TabIndex = 4;
            // 
            // lToppings
            // 
            this.lToppings.AutoSize = true;
            this.lToppings.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToppings.Location = new System.Drawing.Point(19, 109);
            this.lToppings.Name = "lToppings";
            this.lToppings.Size = new System.Drawing.Size(84, 18);
            this.lToppings.TabIndex = 3;
            this.lToppings.Text = "Toppings :";
            // 
            // lSizeValue
            // 
            this.lSizeValue.AutoSize = true;
            this.lSizeValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSizeValue.Location = new System.Drawing.Point(64, 74);
            this.lSizeValue.Name = "lSizeValue";
            this.lSizeValue.Size = new System.Drawing.Size(39, 16);
            this.lSizeValue.TabIndex = 2;
            this.lSizeValue.Text = "Small";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.Location = new System.Drawing.Point(19, 72);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(49, 18);
            this.lSize.TabIndex = 1;
            this.lSize.Text = "Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Summary";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(381, 534);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(139, 40);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(646, 534);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 630);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbPlace);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbPlace.ResumeLayout(false);
            this.gbPlace.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTmoato;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.GroupBox gbPlace;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lSizeValue;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCrustTypeValue;
        private System.Windows.Forms.Label lCrustType;
        private System.Windows.Forms.Label lToppingsValue;
        private System.Windows.Forms.Label lToppings;
        private System.Windows.Forms.Label lPlaceValue;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.Label lPriceValue;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
    }
}

