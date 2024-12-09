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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpchequerealizeddate = new System.Windows.Forms.DateTimePicker();
            this.fulltotaltxt = new System.Windows.Forms.TextBox();
            this.paidtxt = new System.Windows.Forms.TextBox();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.banktxt = new System.Windows.Forms.TextBox();
            this.chequenotxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.panel1.Location = new System.Drawing.Point(700, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 670);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cheque Realized Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // dtpchequerealizeddate
            // 
            this.dtpchequerealizeddate.Location = new System.Drawing.Point(311, 379);
            this.dtpchequerealizeddate.Name = "dtpchequerealizeddate";
            this.dtpchequerealizeddate.Size = new System.Drawing.Size(195, 20);
            this.dtpchequerealizeddate.TabIndex = 9;
            // 
            // fulltotaltxt
            // 
            this.fulltotaltxt.Location = new System.Drawing.Point(311, 410);
            this.fulltotaltxt.Name = "fulltotaltxt";
            this.fulltotaltxt.Size = new System.Drawing.Size(195, 20);
            this.fulltotaltxt.TabIndex = 10;
            // 
            // paidtxt
            // 
            this.paidtxt.Location = new System.Drawing.Point(311, 440);
            this.paidtxt.Name = "paidtxt";
            this.paidtxt.Size = new System.Drawing.Size(195, 20);
            this.paidtxt.TabIndex = 11;
            // 
            // balancetxt
            // 
            this.balancetxt.Location = new System.Drawing.Point(311, 475);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(195, 20);
            this.balancetxt.TabIndex = 12;
            // 
            // banktxt
            // 
            this.banktxt.Location = new System.Drawing.Point(311, 545);
            this.banktxt.Name = "banktxt";
            this.banktxt.Size = new System.Drawing.Size(195, 20);
            this.banktxt.TabIndex = 13;
            // 
            // chequenotxt
            // 
            this.chequenotxt.Location = new System.Drawing.Point(311, 510);
            this.chequenotxt.Name = "chequenotxt";
            this.chequenotxt.Size = new System.Drawing.Size(195, 20);
            this.chequenotxt.TabIndex = 14;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}