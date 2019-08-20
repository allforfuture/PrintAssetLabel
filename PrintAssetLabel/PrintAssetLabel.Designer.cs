namespace PrintAssetLabel
{
    partial class PrintAssetLabel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtA_cd = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(10, 137);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersWidth = 82;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(719, 408);
            this.dgvShow.TabIndex = 0;
            this.dgvShow.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvShow_DataBindingComplete);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(354, 39);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // txtA_cd
            // 
            this.txtA_cd.Location = new System.Drawing.Point(14, 24);
            this.txtA_cd.Multiline = true;
            this.txtA_cd.Name = "txtA_cd";
            this.txtA_cd.Size = new System.Drawing.Size(334, 102);
            this.txtA_cd.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(354, 82);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "a_cd:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintAssetLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtA_cd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvShow);
            this.Name = "PrintAssetLabel";
            this.Text = "PrintAssetLabel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtA_cd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

