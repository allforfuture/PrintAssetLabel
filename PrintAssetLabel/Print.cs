using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAssetLabel
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        public bool BtnPrint_Click(System.Drawing.Printing.PrinterSettings setting)
        {
            try
            {
                printDocument1.PrinterSettings = setting;
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "打印标签", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region 打印tabPage1
            Bitmap bitmap = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            #endregion
        }
    }
}
