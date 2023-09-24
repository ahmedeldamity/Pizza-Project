namespace Pizza_Project
{
    partial class mainform
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
            this.lborderdetails = new System.Windows.Forms.Label();
            this.btorder = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.cbmushrooms = new System.Windows.Forms.CheckBox();
            this.cbtomatoes = new System.Windows.Forms.CheckBox();
            this.cbgreenpeppers = new System.Windows.Forms.CheckBox();
            this.cbolives = new System.Windows.Forms.CheckBox();
            this.cbonion = new System.Windows.Forms.CheckBox();
            this.cbextracheese = new System.Windows.Forms.CheckBox();
            this.gbcrusttype = new System.Windows.Forms.GroupBox();
            this.rbthick = new System.Windows.Forms.RadioButton();
            this.rbthin = new System.Windows.Forms.RadioButton();
            this.gbsize = new System.Windows.Forms.GroupBox();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmedium = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbwhereyoueat = new System.Windows.Forms.GroupBox();
            this.rbtakeaway = new System.Windows.Forms.RadioButton();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.olbsize = new System.Windows.Forms.Label();
            this.olbtoppings = new System.Windows.Forms.Label();
            this.olbcrusttype = new System.Windows.Forms.Label();
            this.olbwhereyoueat = new System.Windows.Forms.Label();
            this.olbtotalprice = new System.Windows.Forms.Label();
            this.anssize = new System.Windows.Forms.Label();
            this.anstoppings = new System.Windows.Forms.Label();
            this.anscrusttype = new System.Windows.Forms.Label();
            this.answhereyoueat = new System.Windows.Forms.Label();
            this.anstotalprice = new System.Windows.Forms.Label();
            this.gbtoppings = new System.Windows.Forms.GroupBox();
            this.gbtheme = new System.Windows.Forms.GroupBox();
            this.rbdark = new System.Windows.Forms.RadioButton();
            this.rblight = new System.Windows.Forms.RadioButton();
            this.gbcrusttype.SuspendLayout();
            this.gbsize.SuspendLayout();
            this.gbwhereyoueat.SuspendLayout();
            this.gbtoppings.SuspendLayout();
            this.gbtheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lborderdetails
            // 
            this.lborderdetails.AutoSize = true;
            this.lborderdetails.Font = new System.Drawing.Font("Lucida Sans", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborderdetails.ForeColor = System.Drawing.Color.Cyan;
            this.lborderdetails.Location = new System.Drawing.Point(819, 57);
            this.lborderdetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lborderdetails.Name = "lborderdetails";
            this.lborderdetails.Size = new System.Drawing.Size(222, 34);
            this.lborderdetails.TabIndex = 29;
            this.lborderdetails.Text = "Order Details";
            // 
            // btorder
            // 
            this.btorder.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btorder.Location = new System.Drawing.Point(47, 419);
            this.btorder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btorder.Name = "btorder";
            this.btorder.Size = new System.Drawing.Size(600, 59);
            this.btorder.TabIndex = 19;
            this.btorder.Text = "Order Pizza";
            this.btorder.UseVisualStyleBackColor = true;
            this.btorder.Click += new System.EventHandler(this.btorder_Click_1);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.Location = new System.Drawing.Point(653, 419);
            this.btreset.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(600, 59);
            this.btreset.TabIndex = 20;
            this.btreset.Text = "Reset Program";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // cbmushrooms
            // 
            this.cbmushrooms.AutoSize = true;
            this.cbmushrooms.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmushrooms.ForeColor = System.Drawing.Color.Gray;
            this.cbmushrooms.Location = new System.Drawing.Point(31, 88);
            this.cbmushrooms.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbmushrooms.Name = "cbmushrooms";
            this.cbmushrooms.Size = new System.Drawing.Size(161, 29);
            this.cbmushrooms.TabIndex = 26;
            this.cbmushrooms.Tag = "5";
            this.cbmushrooms.Text = "Mushrooms";
            this.cbmushrooms.UseVisualStyleBackColor = true;
            this.cbmushrooms.CheckedChanged += new System.EventHandler(this.cbmushrooms_CheckedChanged);
            // 
            // cbtomatoes
            // 
            this.cbtomatoes.AutoSize = true;
            this.cbtomatoes.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtomatoes.ForeColor = System.Drawing.Color.Gray;
            this.cbtomatoes.Location = new System.Drawing.Point(31, 132);
            this.cbtomatoes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbtomatoes.Name = "cbtomatoes";
            this.cbtomatoes.Size = new System.Drawing.Size(140, 29);
            this.cbtomatoes.TabIndex = 25;
            this.cbtomatoes.Tag = "5";
            this.cbtomatoes.Text = "Tomatoes";
            this.cbtomatoes.UseVisualStyleBackColor = true;
            this.cbtomatoes.CheckedChanged += new System.EventHandler(this.cbtomatoes_CheckedChanged);
            // 
            // cbgreenpeppers
            // 
            this.cbgreenpeppers.AutoSize = true;
            this.cbgreenpeppers.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgreenpeppers.ForeColor = System.Drawing.Color.Gray;
            this.cbgreenpeppers.Location = new System.Drawing.Point(225, 43);
            this.cbgreenpeppers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbgreenpeppers.Name = "cbgreenpeppers";
            this.cbgreenpeppers.Size = new System.Drawing.Size(191, 29);
            this.cbgreenpeppers.TabIndex = 24;
            this.cbgreenpeppers.Tag = "5";
            this.cbgreenpeppers.Text = "Green Peppers";
            this.cbgreenpeppers.UseVisualStyleBackColor = true;
            this.cbgreenpeppers.CheckedChanged += new System.EventHandler(this.cbgreenpeppers_CheckedChanged);
            // 
            // cbolives
            // 
            this.cbolives.AutoSize = true;
            this.cbolives.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbolives.ForeColor = System.Drawing.Color.Gray;
            this.cbolives.Location = new System.Drawing.Point(225, 88);
            this.cbolives.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbolives.Name = "cbolives";
            this.cbolives.Size = new System.Drawing.Size(99, 29);
            this.cbolives.TabIndex = 23;
            this.cbolives.Tag = "5";
            this.cbolives.Text = "Olives";
            this.cbolives.UseVisualStyleBackColor = true;
            this.cbolives.CheckedChanged += new System.EventHandler(this.cbolives_CheckedChanged);
            // 
            // cbonion
            // 
            this.cbonion.AutoSize = true;
            this.cbonion.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbonion.ForeColor = System.Drawing.Color.Gray;
            this.cbonion.Location = new System.Drawing.Point(225, 133);
            this.cbonion.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbonion.Name = "cbonion";
            this.cbonion.Size = new System.Drawing.Size(97, 29);
            this.cbonion.TabIndex = 22;
            this.cbonion.Tag = "5";
            this.cbonion.Text = "Onion";
            this.cbonion.UseVisualStyleBackColor = true;
            this.cbonion.CheckedChanged += new System.EventHandler(this.cbonion_CheckedChanged);
            // 
            // cbextracheese
            // 
            this.cbextracheese.AutoSize = true;
            this.cbextracheese.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbextracheese.ForeColor = System.Drawing.Color.Gray;
            this.cbextracheese.Location = new System.Drawing.Point(31, 43);
            this.cbextracheese.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbextracheese.Name = "cbextracheese";
            this.cbextracheese.Size = new System.Drawing.Size(173, 29);
            this.cbextracheese.TabIndex = 21;
            this.cbextracheese.Tag = "5";
            this.cbextracheese.Text = "Extra Cheese";
            this.cbextracheese.UseVisualStyleBackColor = true;
            this.cbextracheese.CheckedChanged += new System.EventHandler(this.cbextracheese_CheckedChanged);
            // 
            // gbcrusttype
            // 
            this.gbcrusttype.Controls.Add(this.rbthick);
            this.gbcrusttype.Controls.Add(this.rbthin);
            this.gbcrusttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbcrusttype.Font = new System.Drawing.Font("Lucida Fax", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrusttype.ForeColor = System.Drawing.Color.Cyan;
            this.gbcrusttype.Location = new System.Drawing.Point(47, 245);
            this.gbcrusttype.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbcrusttype.Name = "gbcrusttype";
            this.gbcrusttype.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbcrusttype.Size = new System.Drawing.Size(322, 142);
            this.gbcrusttype.TabIndex = 18;
            this.gbcrusttype.TabStop = false;
            this.gbcrusttype.Text = "Crust Type";
            // 
            // rbthick
            // 
            this.rbthick.AutoSize = true;
            this.rbthick.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthick.ForeColor = System.Drawing.Color.Gray;
            this.rbthick.Location = new System.Drawing.Point(24, 91);
            this.rbthick.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbthick.Name = "rbthick";
            this.rbthick.Size = new System.Drawing.Size(91, 29);
            this.rbthick.TabIndex = 3;
            this.rbthick.Tag = "10";
            this.rbthick.Text = "Thick";
            this.rbthick.UseVisualStyleBackColor = true;
            this.rbthick.CheckedChanged += new System.EventHandler(this.rbthick_CheckedChanged);
            // 
            // rbthin
            // 
            this.rbthin.AutoSize = true;
            this.rbthin.Checked = true;
            this.rbthin.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthin.ForeColor = System.Drawing.Color.Gray;
            this.rbthin.Location = new System.Drawing.Point(24, 49);
            this.rbthin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(80, 29);
            this.rbthin.TabIndex = 2;
            this.rbthin.TabStop = true;
            this.rbthin.Tag = "0";
            this.rbthin.Text = "Thin";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // gbsize
            // 
            this.gbsize.Controls.Add(this.rblarge);
            this.gbsize.Controls.Add(this.rbmedium);
            this.gbsize.Controls.Add(this.rbsmall);
            this.gbsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbsize.Font = new System.Drawing.Font("Lucida Fax", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsize.ForeColor = System.Drawing.Color.Aqua;
            this.gbsize.Location = new System.Drawing.Point(47, 57);
            this.gbsize.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbsize.Name = "gbsize";
            this.gbsize.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbsize.Size = new System.Drawing.Size(322, 175);
            this.gbsize.TabIndex = 17;
            this.gbsize.TabStop = false;
            this.gbsize.Text = "Size";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblarge.ForeColor = System.Drawing.Color.Gray;
            this.rblarge.Location = new System.Drawing.Point(24, 135);
            this.rblarge.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(90, 29);
            this.rblarge.TabIndex = 4;
            this.rblarge.Tag = "30";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.Checked = true;
            this.rbmedium.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmedium.ForeColor = System.Drawing.Color.Gray;
            this.rbmedium.Location = new System.Drawing.Point(24, 91);
            this.rbmedium.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(118, 29);
            this.rbmedium.TabIndex = 3;
            this.rbmedium.TabStop = true;
            this.rbmedium.Tag = "20";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = true;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbmedium_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsmall.ForeColor = System.Drawing.Color.Gray;
            this.rbsmall.Location = new System.Drawing.Point(24, 47);
            this.rbsmall.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(89, 29);
            this.rbsmall.TabIndex = 2;
            this.rbsmall.Tag = "10";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(347, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pizza Delivery - Order";
            // 
            // gbwhereyoueat
            // 
            this.gbwhereyoueat.Controls.Add(this.rbtakeaway);
            this.gbwhereyoueat.Controls.Add(this.rbeatin);
            this.gbwhereyoueat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbwhereyoueat.Font = new System.Drawing.Font("Lucida Fax", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbwhereyoueat.ForeColor = System.Drawing.Color.Cyan;
            this.gbwhereyoueat.Location = new System.Drawing.Point(372, 245);
            this.gbwhereyoueat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbwhereyoueat.Name = "gbwhereyoueat";
            this.gbwhereyoueat.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbwhereyoueat.Size = new System.Drawing.Size(424, 142);
            this.gbwhereyoueat.TabIndex = 20;
            this.gbwhereyoueat.TabStop = false;
            this.gbwhereyoueat.Text = "Where You Eat";
            // 
            // rbtakeaway
            // 
            this.rbtakeaway.AutoSize = true;
            this.rbtakeaway.Checked = true;
            this.rbtakeaway.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtakeaway.ForeColor = System.Drawing.Color.Gray;
            this.rbtakeaway.Location = new System.Drawing.Point(24, 91);
            this.rbtakeaway.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbtakeaway.Name = "rbtakeaway";
            this.rbtakeaway.Size = new System.Drawing.Size(148, 29);
            this.rbtakeaway.TabIndex = 3;
            this.rbtakeaway.TabStop = true;
            this.rbtakeaway.Text = "Take Away";
            this.rbtakeaway.UseVisualStyleBackColor = true;
            this.rbtakeaway.CheckedChanged += new System.EventHandler(this.rbtakeaway_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Font = new System.Drawing.Font("Lucida Fax", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbeatin.ForeColor = System.Drawing.Color.Gray;
            this.rbeatin.Location = new System.Drawing.Point(24, 49);
            this.rbeatin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(93, 29);
            this.rbeatin.TabIndex = 2;
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // olbsize
            // 
            this.olbsize.AutoSize = true;
            this.olbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbsize.Location = new System.Drawing.Point(821, 104);
            this.olbsize.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.olbsize.Name = "olbsize";
            this.olbsize.Size = new System.Drawing.Size(56, 24);
            this.olbsize.TabIndex = 30;
            this.olbsize.Text = "Size:";
            // 
            // olbtoppings
            // 
            this.olbtoppings.AutoSize = true;
            this.olbtoppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbtoppings.Location = new System.Drawing.Point(819, 169);
            this.olbtoppings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.olbtoppings.Name = "olbtoppings";
            this.olbtoppings.Size = new System.Drawing.Size(104, 24);
            this.olbtoppings.TabIndex = 31;
            this.olbtoppings.Text = "Toppings:";
            // 
            // olbcrusttype
            // 
            this.olbcrusttype.AutoSize = true;
            this.olbcrusttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbcrusttype.Location = new System.Drawing.Point(819, 234);
            this.olbcrusttype.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.olbcrusttype.Name = "olbcrusttype";
            this.olbcrusttype.Size = new System.Drawing.Size(117, 24);
            this.olbcrusttype.TabIndex = 32;
            this.olbcrusttype.Text = "Crust Type:";
            // 
            // olbwhereyoueat
            // 
            this.olbwhereyoueat.AutoSize = true;
            this.olbwhereyoueat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbwhereyoueat.Location = new System.Drawing.Point(819, 299);
            this.olbwhereyoueat.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.olbwhereyoueat.Name = "olbwhereyoueat";
            this.olbwhereyoueat.Size = new System.Drawing.Size(157, 24);
            this.olbwhereyoueat.TabIndex = 33;
            this.olbwhereyoueat.Text = "Where You Eat:";
            // 
            // olbtotalprice
            // 
            this.olbtotalprice.AutoSize = true;
            this.olbtotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbtotalprice.Location = new System.Drawing.Point(819, 364);
            this.olbtotalprice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.olbtotalprice.Name = "olbtotalprice";
            this.olbtotalprice.Size = new System.Drawing.Size(116, 24);
            this.olbtotalprice.TabIndex = 34;
            this.olbtotalprice.Text = "Total Price:";
            // 
            // anssize
            // 
            this.anssize.AutoSize = true;
            this.anssize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anssize.ForeColor = System.Drawing.Color.Gray;
            this.anssize.Location = new System.Drawing.Point(880, 105);
            this.anssize.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.anssize.Name = "anssize";
            this.anssize.Size = new System.Drawing.Size(65, 20);
            this.anssize.TabIndex = 35;
            this.anssize.Text = "Medium";
            // 
            // anstoppings
            // 
            this.anstoppings.AutoSize = true;
            this.anstoppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anstoppings.ForeColor = System.Drawing.Color.Gray;
            this.anstoppings.Location = new System.Drawing.Point(917, 170);
            this.anstoppings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.anstoppings.Name = "anstoppings";
            this.anstoppings.Size = new System.Drawing.Size(80, 20);
            this.anstoppings.TabIndex = 36;
            this.anstoppings.Text = "No Things";
            // 
            // anscrusttype
            // 
            this.anscrusttype.AutoSize = true;
            this.anscrusttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anscrusttype.ForeColor = System.Drawing.Color.Gray;
            this.anscrusttype.Location = new System.Drawing.Point(932, 235);
            this.anscrusttype.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.anscrusttype.Name = "anscrusttype";
            this.anscrusttype.Size = new System.Drawing.Size(39, 20);
            this.anscrusttype.TabIndex = 37;
            this.anscrusttype.Text = "Thin";
            // 
            // answhereyoueat
            // 
            this.answhereyoueat.AutoSize = true;
            this.answhereyoueat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answhereyoueat.ForeColor = System.Drawing.Color.Gray;
            this.answhereyoueat.Location = new System.Drawing.Point(968, 300);
            this.answhereyoueat.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.answhereyoueat.Name = "answhereyoueat";
            this.answhereyoueat.Size = new System.Drawing.Size(86, 20);
            this.answhereyoueat.TabIndex = 38;
            this.answhereyoueat.Text = "Take Away";
            // 
            // anstotalprice
            // 
            this.anstotalprice.AutoSize = true;
            this.anstotalprice.Font = new System.Drawing.Font("Ravie", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anstotalprice.ForeColor = System.Drawing.Color.Lime;
            this.anstotalprice.Location = new System.Drawing.Point(928, 356);
            this.anstotalprice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.anstotalprice.Name = "anstotalprice";
            this.anstotalprice.Size = new System.Drawing.Size(91, 36);
            this.anstotalprice.TabIndex = 40;
            this.anstotalprice.Text = "$ 20";
            // 
            // gbtoppings
            // 
            this.gbtoppings.Controls.Add(this.cbextracheese);
            this.gbtoppings.Controls.Add(this.cbonion);
            this.gbtoppings.Controls.Add(this.cbolives);
            this.gbtoppings.Controls.Add(this.cbgreenpeppers);
            this.gbtoppings.Controls.Add(this.cbtomatoes);
            this.gbtoppings.Controls.Add(this.cbmushrooms);
            this.gbtoppings.Font = new System.Drawing.Font("Lucida Sans", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtoppings.ForeColor = System.Drawing.Color.Aqua;
            this.gbtoppings.Location = new System.Drawing.Point(372, 57);
            this.gbtoppings.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbtoppings.Name = "gbtoppings";
            this.gbtoppings.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbtoppings.Size = new System.Drawing.Size(424, 175);
            this.gbtoppings.TabIndex = 41;
            this.gbtoppings.TabStop = false;
            this.gbtoppings.Tag = "5";
            this.gbtoppings.Text = "Toppings";
            // 
            // gbtheme
            // 
            this.gbtheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbtheme.Controls.Add(this.rbdark);
            this.gbtheme.Controls.Add(this.rblight);
            this.gbtheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtheme.ForeColor = System.Drawing.Color.Aqua;
            this.gbtheme.Location = new System.Drawing.Point(1097, 346);
            this.gbtheme.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbtheme.Name = "gbtheme";
            this.gbtheme.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbtheme.Size = new System.Drawing.Size(156, 57);
            this.gbtheme.TabIndex = 42;
            this.gbtheme.TabStop = false;
            this.gbtheme.Text = "Mode";
            // 
            // rbdark
            // 
            this.rbdark.AutoSize = true;
            this.rbdark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdark.ForeColor = System.Drawing.Color.Gray;
            this.rbdark.Location = new System.Drawing.Point(88, 30);
            this.rbdark.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbdark.Name = "rbdark";
            this.rbdark.Size = new System.Drawing.Size(56, 21);
            this.rbdark.TabIndex = 44;
            this.rbdark.TabStop = true;
            this.rbdark.Text = "Dark";
            this.rbdark.UseVisualStyleBackColor = true;
            this.rbdark.CheckedChanged += new System.EventHandler(this.rbdark_CheckedChanged);
            // 
            // rblight
            // 
            this.rblight.AutoSize = true;
            this.rblight.Checked = true;
            this.rblight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblight.ForeColor = System.Drawing.Color.Gray;
            this.rblight.Location = new System.Drawing.Point(23, 30);
            this.rblight.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rblight.Name = "rblight";
            this.rblight.Size = new System.Drawing.Size(57, 21);
            this.rblight.TabIndex = 43;
            this.rblight.TabStop = true;
            this.rblight.Text = "Light";
            this.rblight.UseVisualStyleBackColor = true;
            this.rblight.CheckedChanged += new System.EventHandler(this.rblight_CheckedChanged);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 501);
            this.Controls.Add(this.gbtheme);
            this.Controls.Add(this.gbtoppings);
            this.Controls.Add(this.anstotalprice);
            this.Controls.Add(this.answhereyoueat);
            this.Controls.Add(this.anscrusttype);
            this.Controls.Add(this.anstoppings);
            this.Controls.Add(this.anssize);
            this.Controls.Add(this.olbtotalprice);
            this.Controls.Add(this.olbwhereyoueat);
            this.Controls.Add(this.olbcrusttype);
            this.Controls.Add(this.olbtoppings);
            this.Controls.Add(this.olbsize);
            this.Controls.Add(this.gbwhereyoueat);
            this.Controls.Add(this.lborderdetails);
            this.Controls.Add(this.btorder);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.gbcrusttype);
            this.Controls.Add(this.gbsize);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.gbcrusttype.ResumeLayout(false);
            this.gbcrusttype.PerformLayout();
            this.gbsize.ResumeLayout(false);
            this.gbsize.PerformLayout();
            this.gbwhereyoueat.ResumeLayout(false);
            this.gbwhereyoueat.PerformLayout();
            this.gbtoppings.ResumeLayout(false);
            this.gbtoppings.PerformLayout();
            this.gbtheme.ResumeLayout(false);
            this.gbtheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lborderdetails;
        private System.Windows.Forms.Button btorder;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.CheckBox cbmushrooms;
        private System.Windows.Forms.CheckBox cbtomatoes;
        private System.Windows.Forms.CheckBox cbgreenpeppers;
        private System.Windows.Forms.CheckBox cbolives;
        private System.Windows.Forms.CheckBox cbonion;
        private System.Windows.Forms.CheckBox cbextracheese;
        private System.Windows.Forms.GroupBox gbcrusttype;
        private System.Windows.Forms.RadioButton rbthick;
        private System.Windows.Forms.RadioButton rbthin;
        private System.Windows.Forms.GroupBox gbsize;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmedium;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbwhereyoueat;
        private System.Windows.Forms.RadioButton rbtakeaway;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.Label olbsize;
        private System.Windows.Forms.Label olbtoppings;
        private System.Windows.Forms.Label olbcrusttype;
        private System.Windows.Forms.Label olbwhereyoueat;
        private System.Windows.Forms.Label olbtotalprice;
        private System.Windows.Forms.Label anssize;
        private System.Windows.Forms.Label anstoppings;
        private System.Windows.Forms.Label anscrusttype;
        private System.Windows.Forms.Label answhereyoueat;
        private System.Windows.Forms.Label anstotalprice;
        private System.Windows.Forms.GroupBox gbtoppings;
        private System.Windows.Forms.GroupBox gbtheme;
        private System.Windows.Forms.RadioButton rblight;
        private System.Windows.Forms.RadioButton rbdark;
    }
}

