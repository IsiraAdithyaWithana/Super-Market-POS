namespace Super_Market_POS
{
    partial class Form4
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
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscounts = new System.Windows.Forms.Button();
            this.btnCashDrawer = new System.Windows.Forms.Button();
            this.btnSalesDetails = new System.Windows.Forms.Button();
            this.btnStockOverview = new System.Windows.Forms.Button();
            this.btnSalesSummary = new System.Windows.Forms.Button();
            this.btnUserDetails = new System.Windows.Forms.Button();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnMismatchLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::Super_Market_POS.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(1202, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 28;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Super_Market_POS.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(1146, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(788, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(353, 26);
            this.txtSearch.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search";
            // 
            // lblReport
            // 
            this.lblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(21, 27);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(102, 31);
            this.lblReport.TabIndex = 23;
            this.lblReport.Text = "Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 367);
            this.dataGridView1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnMismatchLog);
            this.panel1.Controls.Add(this.btnDiscounts);
            this.panel1.Controls.Add(this.btnCashDrawer);
            this.panel1.Controls.Add(this.btnSalesDetails);
            this.panel1.Controls.Add(this.btnStockOverview);
            this.panel1.Controls.Add(this.btnSalesSummary);
            this.panel1.Controls.Add(this.btnUserDetails);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 231);
            this.panel1.TabIndex = 30;
            // 
            // btnDiscounts
            // 
            this.btnDiscounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiscounts.AutoSize = true;
            this.btnDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscounts.Location = new System.Drawing.Point(385, 151);
            this.btnDiscounts.Name = "btnDiscounts";
            this.btnDiscounts.Size = new System.Drawing.Size(182, 39);
            this.btnDiscounts.TabIndex = 38;
            this.btnDiscounts.Text = "Discounts";
            this.btnDiscounts.UseVisualStyleBackColor = true;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);
            // 
            // btnCashDrawer
            // 
            this.btnCashDrawer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCashDrawer.AutoSize = true;
            this.btnCashDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashDrawer.Location = new System.Drawing.Point(90, 151);
            this.btnCashDrawer.Name = "btnCashDrawer";
            this.btnCashDrawer.Size = new System.Drawing.Size(182, 39);
            this.btnCashDrawer.TabIndex = 37;
            this.btnCashDrawer.Text = "Cash Drawer";
            this.btnCashDrawer.UseVisualStyleBackColor = true;
            this.btnCashDrawer.Click += new System.EventHandler(this.btnCashDrawer_Click);
            // 
            // btnSalesDetails
            // 
            this.btnSalesDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalesDetails.AutoSize = true;
            this.btnSalesDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesDetails.Location = new System.Drawing.Point(983, 39);
            this.btnSalesDetails.Name = "btnSalesDetails";
            this.btnSalesDetails.Size = new System.Drawing.Size(182, 39);
            this.btnSalesDetails.TabIndex = 36;
            this.btnSalesDetails.Text = "Sales Details";
            this.btnSalesDetails.UseVisualStyleBackColor = true;
            this.btnSalesDetails.Click += new System.EventHandler(this.btnSalesDetails_Click);
            // 
            // btnStockOverview
            // 
            this.btnStockOverview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockOverview.AutoSize = true;
            this.btnStockOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOverview.Location = new System.Drawing.Point(682, 151);
            this.btnStockOverview.Name = "btnStockOverview";
            this.btnStockOverview.Size = new System.Drawing.Size(182, 39);
            this.btnStockOverview.TabIndex = 35;
            this.btnStockOverview.Text = "Stock Overview";
            this.btnStockOverview.UseVisualStyleBackColor = true;
            this.btnStockOverview.Click += new System.EventHandler(this.btnStockOverview_Click);
            // 
            // btnSalesSummary
            // 
            this.btnSalesSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalesSummary.AutoSize = true;
            this.btnSalesSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesSummary.Location = new System.Drawing.Point(682, 39);
            this.btnSalesSummary.Name = "btnSalesSummary";
            this.btnSalesSummary.Size = new System.Drawing.Size(182, 39);
            this.btnSalesSummary.TabIndex = 34;
            this.btnSalesSummary.Text = "Sales Summary";
            this.btnSalesSummary.UseVisualStyleBackColor = true;
            this.btnSalesSummary.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUserDetails
            // 
            this.btnUserDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserDetails.AutoSize = true;
            this.btnUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetails.Location = new System.Drawing.Point(385, 39);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.Size = new System.Drawing.Size(182, 39);
            this.btnUserDetails.TabIndex = 33;
            this.btnUserDetails.Text = "User Details";
            this.btnUserDetails.UseVisualStyleBackColor = true;
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomerDetails.AutoSize = true;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.Location = new System.Drawing.Point(90, 39);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(182, 39);
            this.btnCustomerDetails.TabIndex = 32;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.UseVisualStyleBackColor = true;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnMismatchLog
            // 
            this.btnMismatchLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMismatchLog.AutoSize = true;
            this.btnMismatchLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMismatchLog.Location = new System.Drawing.Point(983, 151);
            this.btnMismatchLog.Name = "btnMismatchLog";
            this.btnMismatchLog.Size = new System.Drawing.Size(182, 39);
            this.btnMismatchLog.TabIndex = 39;
            this.btnMismatchLog.Text = "Mismatch Log";
            this.btnMismatchLog.UseVisualStyleBackColor = true;
            this.btnMismatchLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReport);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalesDetails;
        private System.Windows.Forms.Button btnStockOverview;
        private System.Windows.Forms.Button btnSalesSummary;
        private System.Windows.Forms.Button btnUserDetails;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnDiscounts;
        private System.Windows.Forms.Button btnCashDrawer;
        private System.Windows.Forms.Button btnMismatchLog;
    }
}