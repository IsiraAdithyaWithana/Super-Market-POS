namespace Super_Market_POS
{
    partial class Form6
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
            this.previousbillstxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequenotxt = new System.Windows.Forms.TextBox();
            this.banktxt = new System.Windows.Forms.TextBox();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.paidtxt = new System.Windows.Forms.TextBox();
            this.fulltotaltxt = new System.Windows.Forms.TextBox();
            this.dtpchequerealizeddate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namecredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditstxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.previousbillstxt);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.chequenotxt);
            this.panel1.Controls.Add(this.banktxt);
            this.panel1.Controls.Add(this.balancetxt);
            this.panel1.Controls.Add(this.paidtxt);
            this.panel1.Controls.Add(this.fulltotaltxt);
            this.panel1.Controls.Add(this.dtpchequerealizeddate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(694, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 678);
            this.panel1.TabIndex = 0;
            // 
            // previousbillstxt
            // 
            this.previousbillstxt.AutoSize = true;
            this.previousbillstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbillstxt.Location = new System.Drawing.Point(419, 24);
            this.previousbillstxt.Name = "previousbillstxt";
            this.previousbillstxt.Size = new System.Drawing.Size(102, 16);
            this.previousbillstxt.TabIndex = 16;
            this.previousbillstxt.Text = "Previous Bills";
            this.previousbillstxt.Click += new System.EventHandler(this.previousbillstxt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceno,
            this.date1,
            this.balance1});
            this.dataGridView1.Location = new System.Drawing.Point(125, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 302);
            this.dataGridView1.TabIndex = 15;
            // 
            // invoiceno
            // 
            this.invoiceno.HeaderText = "Invoice No";
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.ReadOnly = true;
            // 
            // date1
            // 
            this.date1.HeaderText = "Date";
            this.date1.Name = "date1";
            this.date1.ReadOnly = true;
            // 
            // balance1
            // 
            this.balance1.HeaderText = "Balance";
            this.balance1.Name = "balance1";
            this.balance1.ReadOnly = true;
            // 
            // chequenotxt
            // 
            this.chequenotxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequenotxt.Location = new System.Drawing.Point(311, 500);
            this.chequenotxt.Name = "chequenotxt";
            this.chequenotxt.Size = new System.Drawing.Size(195, 27);
            this.chequenotxt.TabIndex = 14;
            // 
            // banktxt
            // 
            this.banktxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banktxt.Location = new System.Drawing.Point(311, 534);
            this.banktxt.Name = "banktxt";
            this.banktxt.Size = new System.Drawing.Size(195, 27);
            this.banktxt.TabIndex = 13;
            // 
            // balancetxt
            // 
            this.balancetxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancetxt.Location = new System.Drawing.Point(311, 467);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(195, 27);
            this.balancetxt.TabIndex = 12;
            // 
            // paidtxt
            // 
            this.paidtxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidtxt.Location = new System.Drawing.Point(311, 434);
            this.paidtxt.Name = "paidtxt";
            this.paidtxt.Size = new System.Drawing.Size(195, 27);
            this.paidtxt.TabIndex = 11;
            // 
            // fulltotaltxt
            // 
            this.fulltotaltxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulltotaltxt.Location = new System.Drawing.Point(311, 399);
            this.fulltotaltxt.Name = "fulltotaltxt";
            this.fulltotaltxt.Size = new System.Drawing.Size(195, 27);
            this.fulltotaltxt.TabIndex = 10;
            // 
            // dtpchequerealizeddate
            // 
            this.dtpchequerealizeddate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpchequerealizeddate.Location = new System.Drawing.Point(311, 363);
            this.dtpchequerealizeddate.Name = "dtpchequerealizeddate";
            this.dtpchequerealizeddate.Size = new System.Drawing.Size(195, 27);
            this.dtpchequerealizeddate.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Print Credits";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Paid";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cheque No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cheque Realized Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namecredit,
            this.contact,
            this.newbalance});
            this.dataGridView2.Location = new System.Drawing.Point(0, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(694, 634);
            this.dataGridView2.TabIndex = 1;
            // 
            // namecredit
            // 
            this.namecredit.HeaderText = "Name";
            this.namecredit.Name = "namecredit";
            this.namecredit.Width = 250;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            this.contact.Width = 200;
            // 
            // newbalance
            // 
            this.newbalance.HeaderText = "New Balance";
            this.newbalance.Name = "newbalance";
            this.newbalance.Width = 200;
            // 
            // creditstxt
            // 
            this.creditstxt.AutoSize = true;
            this.creditstxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditstxt.Location = new System.Drawing.Point(21, 1);
            this.creditstxt.Name = "creditstxt";
            this.creditstxt.Size = new System.Drawing.Size(120, 39);
            this.creditstxt.TabIndex = 17;
            this.creditstxt.Text = "Credits";
            this.creditstxt.Click += new System.EventHandler(this.creditstxt_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.creditstxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox paidtxt;
        private System.Windows.Forms.TextBox fulltotaltxt;
        private System.Windows.Forms.DateTimePicker dtpchequerealizeddate;
        private System.Windows.Forms.TextBox chequenotxt;
        private System.Windows.Forms.TextBox banktxt;
        private System.Windows.Forms.TextBox balancetxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance1;
        private System.Windows.Forms.Label previousbillstxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn newbalance;
        private System.Windows.Forms.Label creditstxt;
    }
}