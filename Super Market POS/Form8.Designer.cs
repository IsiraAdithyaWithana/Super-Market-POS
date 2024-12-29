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
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totallbl = new System.Windows.Forms.Label();
            this.btnupdateitem = new System.Windows.Forms.Button();
            this.tnadditem = new System.Windows.Forms.Button();
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
            this.btncusadd = new System.Windows.Forms.Button();
            this.lblcustomerid = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.Invoice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totallblinvoice = new System.Windows.Forms.Label();
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblinvoice = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 838);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.Quantity,
            this.Price,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 564);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 10;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 200;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 200;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 200;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.totallbl);
            this.panel4.Controls.Add(this.btnupdateitem);
            this.panel4.Controls.Add(this.tnadditem);
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
            this.panel4.Location = new System.Drawing.Point(4, 559);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 278);
            this.panel4.TabIndex = 0;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.BackColor = System.Drawing.Color.Transparent;
            this.totallbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(858, 38);
            this.totallbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(115, 45);
            this.totallbl.TabIndex = 34;
            this.totallbl.Text = " *****";
            this.totallbl.Click += new System.EventHandler(this.totallbl_Click);
            // 
            // btnupdateitem
            // 
            this.btnupdateitem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnupdateitem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdateitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateitem.Location = new System.Drawing.Point(565, 142);
            this.btnupdateitem.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdateitem.Name = "btnupdateitem";
            this.btnupdateitem.Size = new System.Drawing.Size(120, 71);
            this.btnupdateitem.TabIndex = 33;
            this.btnupdateitem.Text = "Update";
            this.btnupdateitem.UseVisualStyleBackColor = false;
            this.btnupdateitem.Click += new System.EventHandler(this.button2_Click);
            // 
            // tnadditem
            // 
            this.tnadditem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tnadditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tnadditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnadditem.Location = new System.Drawing.Point(437, 142);
            this.tnadditem.Margin = new System.Windows.Forms.Padding(4);
            this.tnadditem.Name = "tnadditem";
            this.tnadditem.Size = new System.Drawing.Size(120, 71);
            this.tnadditem.TabIndex = 32;
            this.tnadditem.Text = "Add";
            this.tnadditem.UseVisualStyleBackColor = false;
            this.tnadditem.Click += new System.EventHandler(this.tnadditem_Click);
            // 
            // txtitemname
            // 
            this.txtitemname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.Location = new System.Drawing.Point(137, 95);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(265, 39);
            this.txtitemname.TabIndex = 31;
            this.txtitemname.TextChanged += new System.EventHandler(this.txtitemname_TextChanged);
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.BackColor = System.Drawing.Color.Transparent;
            this.lblitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.Location = new System.Drawing.Point(8, 107);
            this.lblitemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(115, 25);
            this.lblitemname.TabIndex = 30;
            this.lblitemname.Text = "Item Name";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(872, 41);
            this.lbltotalamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(0, 45);
            this.lbltotalamount.TabIndex = 29;
            this.lbltotalamount.Click += new System.EventHandler(this.label19_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(723, 38);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(127, 45);
            this.lbltotal.TabIndex = 22;
            this.lbltotal.Text = "Total  ";
            this.lbltotal.Click += new System.EventHandler(this.label18_Click);
            // 
            // btnvoidbill
            // 
            this.btnvoidbill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnvoidbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvoidbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoidbill.Location = new System.Drawing.Point(565, 14);
            this.btnvoidbill.Margin = new System.Windows.Forms.Padding(4);
            this.btnvoidbill.Name = "btnvoidbill";
            this.btnvoidbill.Size = new System.Drawing.Size(120, 103);
            this.btnvoidbill.TabIndex = 28;
            this.btnvoidbill.Text = "Void Bill";
            this.btnvoidbill.UseVisualStyleBackColor = false;
            this.btnvoidbill.Click += new System.EventHandler(this.btnvoidbill_Click);
            // 
            // btndeleteline
            // 
            this.btndeleteline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndeleteline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeleteline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteline.Location = new System.Drawing.Point(437, 12);
            this.btndeleteline.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteline.Name = "btndeleteline";
            this.btndeleteline.Size = new System.Drawing.Size(120, 103);
            this.btndeleteline.TabIndex = 27;
            this.btndeleteline.Text = "Delete  Line";
            this.btndeleteline.UseVisualStyleBackColor = false;
            this.btndeleteline.Click += new System.EventHandler(this.btndeleteline_Click);
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(137, 222);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(265, 39);
            this.txtprice.TabIndex = 26;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(137, 158);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(265, 39);
            this.txtqty.TabIndex = 25;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // txtitemcode
            // 
            this.txtitemcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemcode.Location = new System.Drawing.Point(137, 41);
            this.txtitemcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(265, 39);
            this.txtitemcode.TabIndex = 22;
            this.txtitemcode.TextChanged += new System.EventHandler(this.txtitemcode_TextChanged);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(7, 233);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(61, 25);
            this.lblprice.TabIndex = 24;
            this.lblprice.Text = "Price";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Transparent;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(8, 162);
            this.lblqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(46, 25);
            this.lblqty.TabIndex = 23;
            this.lblqty.Text = "Qty";
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.BackColor = System.Drawing.Color.Transparent;
            this.lblitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemcode.Location = new System.Drawing.Point(7, 46);
            this.lblitemcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(111, 25);
            this.lblitemcode.TabIndex = 22;
            this.lblitemcode.Text = "Item Code";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btncusadd);
            this.panel2.Controls.Add(this.lblcustomerid);
            this.panel2.Controls.Add(this.txtcustomerid);
            this.panel2.Controls.Add(this.Invoice);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtcontact);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.lblcontact);
            this.panel2.Controls.Add(this.lblfirstname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblinvoice);
            this.panel2.Location = new System.Drawing.Point(1175, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 838);
            this.panel2.TabIndex = 2;
            // 
            // btncusadd
            // 
            this.btncusadd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncusadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncusadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncusadd.Location = new System.Drawing.Point(402, 103);
            this.btncusadd.Margin = new System.Windows.Forms.Padding(4);
            this.btncusadd.Name = "btncusadd";
            this.btncusadd.Size = new System.Drawing.Size(90, 34);
            this.btncusadd.TabIndex = 33;
            this.btncusadd.Text = "Enter";
            this.btncusadd.UseVisualStyleBackColor = false;
            this.btncusadd.Click += new System.EventHandler(this.btncusadd_Click);
            // 
            // lblcustomerid
            // 
            this.lblcustomerid.AutoSize = true;
            this.lblcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerid.Location = new System.Drawing.Point(21, 113);
            this.lblcustomerid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustomerid.Name = "lblcustomerid";
            this.lblcustomerid.Size = new System.Drawing.Size(115, 20);
            this.lblcustomerid.TabIndex = 11;
            this.lblcustomerid.Text = "Customer ID";
            this.lblcustomerid.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(154, 113);
            this.txtcustomerid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(229, 22);
            this.txtcustomerid.TabIndex = 10;
            this.txtcustomerid.TextChanged += new System.EventHandler(this.txtcustomerid_TextChanged);
            // 
            // Invoice
            // 
            this.Invoice.AutoSize = true;
            this.Invoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Invoice.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice.Location = new System.Drawing.Point(269, 11);
            this.Invoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(26, 40);
            this.Invoice.TabIndex = 9;
            this.Invoice.Text = " ";
            this.Invoice.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.totallblinvoice);
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
            this.panel3.Location = new System.Drawing.Point(4, 215);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 619);
            this.panel3.TabIndex = 8;
            // 
            // totallblinvoice
            // 
            this.totallblinvoice.AutoSize = true;
            this.totallblinvoice.BackColor = System.Drawing.Color.Transparent;
            this.totallblinvoice.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallblinvoice.Location = new System.Drawing.Point(180, 17);
            this.totallblinvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totallblinvoice.Name = "totallblinvoice";
            this.totallblinvoice.Size = new System.Drawing.Size(115, 45);
            this.totallblinvoice.TabIndex = 32;
            this.totallblinvoice.Text = " *****";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 45);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total  ";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Red;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Location = new System.Drawing.Point(9, 539);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(488, 71);
            this.btnprint.TabIndex = 21;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lbltotalbalance
            // 
            this.lbltotalbalance.AutoSize = true;
            this.lbltotalbalance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbltotalbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbalance.Location = new System.Drawing.Point(391, 454);
            this.lbltotalbalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalbalance.Name = "lbltotalbalance";
            this.lbltotalbalance.Size = new System.Drawing.Size(87, 39);
            this.lbltotalbalance.TabIndex = 20;
            this.lbltotalbalance.Text = "0.00";
            this.lbltotalbalance.Click += new System.EventHandler(this.lbltotalbalance_Click);
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(15, 471);
            this.lblbalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(90, 25);
            this.lblbalance.TabIndex = 19;
            this.lblbalance.Text = "Balance";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(224, 335);
            this.txtpaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(264, 53);
            this.txtpaid.TabIndex = 18;
            this.txtpaid.TextChanged += new System.EventHandler(this.txtpaid_TextChanged);
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid.Location = new System.Drawing.Point(24, 356);
            this.lblpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(55, 25);
            this.lblpaid.TabIndex = 17;
            this.lblpaid.Text = "Paid";
            // 
            // lbltlamount
            // 
            this.lbltlamount.AutoSize = true;
            this.lbltlamount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbltlamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltlamount.Location = new System.Drawing.Point(381, 245);
            this.lbltlamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltlamount.Name = "lbltlamount";
            this.lbltlamount.Size = new System.Drawing.Size(87, 39);
            this.lbltlamount.TabIndex = 16;
            this.lbltlamount.Text = "0.00";
            this.lbltlamount.Click += new System.EventHandler(this.lbltlamount_Click);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(15, 258);
            this.lblamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(86, 25);
            this.lblamount.TabIndex = 15;
            this.lblamount.Text = "Amount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(231, 169);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(265, 30);
            this.txtdiscount.TabIndex = 14;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // radiobtnpercentage
            // 
            this.radiobtnpercentage.AutoSize = true;
            this.radiobtnpercentage.Location = new System.Drawing.Point(139, 155);
            this.radiobtnpercentage.Margin = new System.Windows.Forms.Padding(4);
            this.radiobtnpercentage.Name = "radiobtnpercentage";
            this.radiobtnpercentage.Size = new System.Drawing.Size(76, 50);
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
            this.lbldiscount.Location = new System.Drawing.Point(8, 175);
            this.lbldiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(102, 25);
            this.lbldiscount.TabIndex = 12;
            this.lbldiscount.Text = "Discount ";
            // 
            // lblfullqty
            // 
            this.lblfullqty.AutoSize = true;
            this.lblfullqty.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblfullqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullqty.Location = new System.Drawing.Point(8, 92);
            this.lblfullqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfullqty.Name = "lblfullqty";
            this.lblfullqty.Size = new System.Drawing.Size(124, 25);
            this.lblfullqty.TabIndex = 9;
            this.lblfullqty.Text = "Item Qty(S)";
            // 
            // numericUpDownfullqty
            // 
            this.numericUpDownfullqty.Location = new System.Drawing.Point(409, 79);
            this.numericUpDownfullqty.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownfullqty.Name = "numericUpDownfullqty";
            this.numericUpDownfullqty.Size = new System.Drawing.Size(83, 53);
            this.numericUpDownfullqty.TabIndex = 2;
            this.numericUpDownfullqty.ValueChanged += new System.EventHandler(this.numericUpDownfullqty_ValueChanged);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(263, 175);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(229, 22);
            this.txtcontact.TabIndex = 5;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(17, 175);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(229, 22);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(259, 156);
            this.lblcontact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(74, 20);
            this.lblcontact.TabIndex = 3;
            this.lblcontact.Text = "Contact";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(13, 151);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(108, 20);
            this.lblfirstname.TabIndex = 2;
            this.lblfirstname.Text = " First Name";
            this.lblfirstname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Details";
            // 
            // lblinvoice
            // 
            this.lblinvoice.AutoSize = true;
            this.lblinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblinvoice.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoice.Location = new System.Drawing.Point(7, 11);
            this.lblinvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinvoice.Name = "lblinvoice";
            this.lblinvoice.Size = new System.Drawing.Size(267, 40);
            this.lblinvoice.TabIndex = 0;
            this.lblinvoice.Text = "INVOICE NO       ";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(341, 17);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 34);
            this.btnback.TabIndex = 34;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblinvoice;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label Invoice;
        private System.Windows.Forms.Label totallblinvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdateitem;
        private System.Windows.Forms.Button tnadditem;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label lblcustomerid;
        private System.Windows.Forms.Button btncusadd;
        private System.Windows.Forms.Button btnback;
    }
}