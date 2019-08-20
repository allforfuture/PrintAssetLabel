namespace PrintAssetLabel
{
    partial class Print
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.txtA5 = new System.Windows.Forms.TextBox();
            this.txtA6 = new System.Windows.Forms.TextBox();
            this.txtB6 = new System.Windows.Forms.TextBox();
            this.txtB5 = new System.Windows.Forms.TextBox();
            this.txtB4 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(3, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(200, 21);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "NSTD    设备标识";
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(3, 22);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(200, 21);
            this.txtA1.TabIndex = 1;
            this.txtA1.Text = "设备名称：$A1$";
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(3, 42);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(200, 21);
            this.txtA2.TabIndex = 2;
            this.txtA2.Text = "机 身 号：$A2$";
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(3, 62);
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(100, 21);
            this.txtA3.TabIndex = 3;
            this.txtA3.Text = "资产番号：$A3$";
            // 
            // txtA4
            // 
            this.txtA4.Location = new System.Drawing.Point(103, 62);
            this.txtA4.Name = "txtA4";
            this.txtA4.Size = new System.Drawing.Size(100, 21);
            this.txtA4.TabIndex = 4;
            this.txtA4.Text = "编号：$A4$";
            // 
            // txtA5
            // 
            this.txtA5.Location = new System.Drawing.Point(3, 82);
            this.txtA5.Name = "txtA5";
            this.txtA5.Size = new System.Drawing.Size(100, 21);
            this.txtA5.TabIndex = 5;
            this.txtA5.Text = "入厂日期：$A5$";
            // 
            // txtA6
            // 
            this.txtA6.Location = new System.Drawing.Point(103, 82);
            this.txtA6.Name = "txtA6";
            this.txtA6.Size = new System.Drawing.Size(100, 21);
            this.txtA6.TabIndex = 6;
            this.txtA6.Text = "型号：$A6$";
            // 
            // txtB6
            // 
            this.txtB6.Location = new System.Drawing.Point(103, 189);
            this.txtB6.Name = "txtB6";
            this.txtB6.Size = new System.Drawing.Size(100, 21);
            this.txtB6.TabIndex = 13;
            this.txtB6.Text = "型号：$B6$";
            // 
            // txtB5
            // 
            this.txtB5.Location = new System.Drawing.Point(3, 189);
            this.txtB5.Name = "txtB5";
            this.txtB5.Size = new System.Drawing.Size(100, 21);
            this.txtB5.TabIndex = 12;
            this.txtB5.Text = "入厂日期：$B5$";
            // 
            // txtB4
            // 
            this.txtB4.Location = new System.Drawing.Point(103, 169);
            this.txtB4.Name = "txtB4";
            this.txtB4.Size = new System.Drawing.Size(100, 21);
            this.txtB4.TabIndex = 11;
            this.txtB4.Text = "编号：$B4$";
            // 
            // txtB3
            // 
            this.txtB3.Location = new System.Drawing.Point(3, 169);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(100, 21);
            this.txtB3.TabIndex = 10;
            this.txtB3.Text = "资产番号：$B3$";
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(3, 149);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(200, 21);
            this.txtB2.TabIndex = 9;
            this.txtB2.Text = "机 身 号：$B2$";
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(3, 129);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(200, 21);
            this.txtB1.TabIndex = 8;
            this.txtB1.Text = "设备名称：$B1$";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(3, 109);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(200, 21);
            this.txtB.TabIndex = 7;
            this.txtB.Text = "NSTD    设备标识";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.txtA);
            this.pnl.Controls.Add(this.txtB6);
            this.pnl.Controls.Add(this.txtA1);
            this.pnl.Controls.Add(this.txtB5);
            this.pnl.Controls.Add(this.txtA2);
            this.pnl.Controls.Add(this.txtB4);
            this.pnl.Controls.Add(this.txtA3);
            this.pnl.Controls.Add(this.txtB3);
            this.pnl.Controls.Add(this.txtA4);
            this.pnl.Controls.Add(this.txtB2);
            this.pnl.Controls.Add(this.txtA5);
            this.pnl.Controls.Add(this.txtB1);
            this.pnl.Controls.Add(this.txtA6);
            this.pnl.Controls.Add(this.txtB);
            this.pnl.Location = new System.Drawing.Point(12, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(207, 217);
            this.pnl.TabIndex = 14;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 452);
            this.Controls.Add(this.pnl);
            this.Name = "Print";
            this.Text = "Print";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtA4;
        private System.Windows.Forms.TextBox txtA5;
        private System.Windows.Forms.TextBox txtA6;
        private System.Windows.Forms.TextBox txtB6;
        private System.Windows.Forms.TextBox txtB5;
        private System.Windows.Forms.TextBox txtB4;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnl;
    }
}