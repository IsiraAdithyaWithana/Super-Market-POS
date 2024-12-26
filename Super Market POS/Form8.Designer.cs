namespace Super_Market_POS
{
    partial class Form8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnvoidbill = new System.Windows.Forms.Button();
            this.btndeleteline = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.lbltotalbalance = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.lblpaid = new System.Windows.Forms.Label();
            this.lbltlamount = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.radiobtnpercentage = new System.Windows.Forms.RadioButton();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblfullqty = new System.Windows.Forms.Label();
            this.numericUpDownfullqty = new System.Windows.Forms.NumericUpDown();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblinvoice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownfullqty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 681);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 458);
            this.dataGridView1.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Code";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 280;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 280;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 280;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 280;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.txtitemname);
            this.panel4.Controls.Add(this.lblitemname);
            this.panel4.Controls.Add(this.lbltotalamount);
            this.panel4.Controls.Add(this.lbltotal);
            this.panel4.Controls.Add(this.btnvoidbill);
            this.panel4.Controls.Add(this.btndeleteline);
            this.panel4.Controls.Add(this.txtprice);
            this.panel4.Controls.Add(this.txtqty);
            this.panel4.Controls.Add(this.txtitemcode);
            this.panel4.Controls.Add(this.lblprice);
            this.panel4.Controls.Add(this.lblqty);
            this.panel4.Controls.Add(this.lblitemcode);
            this.panel4.Location = new System.Drawing.Point(3, 454);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 226);
            this.panel4.TabIndex = 0;
            // 
            // txtitemname
            // 
            this.txtitemname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.Location = new System.Drawing.Point(103, 77);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(199, 31);
            this.txtitemname.TabIndex = 31;
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.BackColor = System.Drawing.Color.Transparent;
            this.lblitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.Location = new System.Drawing.Point(6, 87);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(96, 20);
            this.lblitemname.TabIndex = 30;
            this.lblitemname.Text = "Item Name";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(654, 33);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(88, 36);
            this.lbltotalamount.TabIndex = 29;
            this.lbltotalamount.Text = " *****";
            this.lbltotalamount.Click += new System.EventHandler(this.label19_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(542, 31);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(101, 36);
            this.lbltotal.TabIndex = 22;
            this.lbltotal.Text = "Total  ";
            this.lbltotal.Click += new System.EventHandler(this.label18_Click);
            // 
            // btnvoidbill
            // 
            this.btnvoidbill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnvoidbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvoidbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoidbill.Location = new System.Drawing.Point(424, 11);
            this.btnvoidbill.Name = "btnvoidbill";
            this.btnvoidbill.Size = new System.Drawing.Size(90, 84);
            this.btnvoidbill.TabIndex = 28;
            this.btnvoidbill.Text = "Void Bill";
            this.btnvoidbill.UseVisualStyleBackColor = false;
            // 
            // btndeleteline
            // 
            this.btndeleteline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndeleteline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeleteline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteline.Location = new System.Drawing.Point(328, 10);
            this.btndeleteline.Name = "btndeleteline";
            this.btndeleteline.Size = new System.Drawing.Size(90, 84);
            this.btndeleteline.TabIndex = 27;
            this.btndeleteline.Text = "Delete  Line";
            this.btndeleteline.UseVisualStyleBackColor = false;
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(103, 180);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(199, 31);
            this.txtprice.TabIndex = 26;
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(103, 128);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(199, 31);
            this.txtqty.TabIndex = 25;
            // 
            // txtitemcode
            // 
            this.txtitemcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemcode.Location = new System.Drawing.Point(103, 33);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(199, 31);
            this.txtitemcode.TabIndex = 22;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(5, 189);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(49, 20);
            this.lblprice.TabIndex = 24;
            this.lblprice.Text = "Price";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Transparent;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(6, 132);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(36, 20);
            this.lblqty.TabIndex = 23;
            this.lblqty.Text = "Qty";
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.BackColor = System.Drawing.Color.Transparent;
            this.lblitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemcode.Location = new System.Drawing.Point(5, 37);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(92, 20);
            this.lblitemcode.TabIndex = 22;
            this.lblitemcode.Text = "Item Code";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtcontact);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.lblcontact);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblinvoice);
            this.panel2.Location = new System.Drawing.Point(881, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 681);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = " *****";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnprint);
            this.panel3.Controls.Add(this.lbltotalbalance);
            this.panel3.Controls.Add(this.lblbalance);
            this.panel3.Controls.Add(this.txtpaid);
            this.panel3.Controls.Add(this.lblpaid);
            this.panel3.Controls.Add(this.lbltlamount);
            this.panel3.Controls.Add(this.lblamount);
            this.panel3.Controls.Add(this.txtdiscount);
            this.panel3.Controls.Add(this.radiobtnpercentage);
            this.panel3.Controls.Add(this.lbldiscount);
            this.panel3.Controls.Add(this.lblfullqty);
            this.panel3.Controls.Add(this.numericUpDownfullqty);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 529);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = " *****";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total  ";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Red;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Location = new System.Drawing.Point(7, 438);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(366, 58);
            this.btnprint.TabIndex = 21;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // lbltotalbalance
            // 
            this.lbltotalbalance.AutoSize = true;
            this.lbltotalbalance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbltotalbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbalance.Location = new System.Drawing.Point(293, 369);
            this.lbltotalbalance.Name = "lbltotalbalance";
            this.lbltotalbalance.Size = new System.Drawing.Size(71, 31);
            this.lbltotalbalance.TabIndex = 20;
            this.lbltotalbalance.Text = "0.00";
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(11, 383);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(74, 20);
            this.lblbalance.TabIndex = 19;
            this.lblbalance.Text = "Balance";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(168, 272);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(199, 44);
            this.txtpaid.TabIndex = 18;
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid.Location = new System.Drawing.Point(18, 289);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(44, 20);
            this.lblpaid.TabIndex = 17;
            this.lblpaid.Text = "Paid";
            // 
            // lbltlamount
            // 
            this.lbltlamount.AutoSize = true;
            this.lbltlamount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbltlamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltlamount.Location = new System.Drawing.Point(286, 199);
            this.lbltlamount.Name = "lbltlamount";
            this.lbltlamount.Size = new System.Drawing.Size(71, 31);
            this.lbltlamount.TabIndex = 16;
            this.lbltlamount.Text = "0.00";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(11, 210);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(71, 20);
            this.lblamount.TabIndex = 15;
            this.lblamount.Text = "Amount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(173, 137);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(199, 24);
            this.txtdiscount.TabIndex = 14;
            // 
            // radiobtnpercentage
            // 
            this.radiobtnpercentage.AutoSize = true;
            this.radiobtnpercentage.Location = new System.Drawing.Point(104, 126);
            this.radiobtnpercentage.Name = "radiobtnpercentage";
            this.radiobtnpercentage.Size = new System.Drawing.Size(63, 41);
            this.radiobtnpercentage.TabIndex = 13;
            this.radiobtnpercentage.TabStop = true;
            this.radiobtnpercentage.Text = "%";
            this.radiobtnpercentage.UseVisualStyleBackColor = true;
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(6, 142);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(85, 20);
            this.lbldiscount.TabIndex = 12;
            this.lbldiscount.Text = "Discount ";
            // 
            // lblfullqty
            // 
            this.lblfullqty.AutoSize = true;
            this.lblfullqty.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblfullqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullqty.Location = new System.Drawing.Point(6, 75);
            this.lblfullqty.Name = "lblfullqty";
            this.lblfullqty.Size = new System.Drawing.Size(101, 20);
            this.lblfullqty.TabIndex = 9;
            this.lblfullqty.Text = "Item Qty(S)";
            // 
            // numericUpDownfullqty
            // 
            this.numericUpDownfullqty.Location = new System.Drawing.Point(307, 64);
            this.numericUpDownfullqty.Name = "numericUpDownfullqty";
            this.numericUpDownfullqty.Size = new System.Drawing.Size(62, 44);
            this.numericUpDownfullqty.TabIndex = 2;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(200, 106);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(173, 20);
            this.txtcontact.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(10, 106);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(173, 20);
            this.txtname.TabIndex = 4;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(197, 86);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(59, 16);
            this.lblcontact.TabIndex = 3;
            this.lblcontact.Text = "Contact";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(7, 86);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Details";
            // 
            // lblinvoice
            // 
            this.lblinvoice.AutoSize = true;
            this.lblinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblinvoice.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoice.Location = new System.Drawing.Point(5, 9);
            this.lblinvoice.Name = "lblinvoice";
            this.lblinvoice.Size = new System.Drawing.Size(213, 31);
            this.lblinvoice.TabIndex = 0;
            this.lblinvoice.Text = "INVOICE NO       ";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownfullqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnvoidbill;
        private System.Windows.Forms.Button btndeleteline;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lbltotalbalance;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.Label lbltlamount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.RadioButton radiobtnpercentage;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblfullqty;
        private System.Windows.Forms.NumericUpDown numericUpDownfullqty;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblinvoice;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}