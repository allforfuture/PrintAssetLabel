using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace PrintAssetLabel
{
    public partial class PrintAssetLabel : Form
    {
        List<string[]> list = new List<string[]>();
        public PrintAssetLabel()
        {
            InitializeComponent();
            Text = Text + "-" + Application.ProductVersion.ToString();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            string[] strArray = txtA_cd.Text.Split(new string[] { "\r\n", }, StringSplitOptions.RemoveEmptyEntries);
            if (strArray.Length == 0)
                return;
            string strA_cd = "";
            foreach (string str in strArray)
            {
                strA_cd += "'" + str + "',";
            }
            strA_cd = strA_cd.Remove(strA_cd.Length - 1, 1);

            //StringBuilder sql = new StringBuilder();
            //sql.AppendLine("select a_name, a_fuselage_cd, a_cd, a_self_cd, a_purchase_time, a_type_cd");
            //sql.AppendLine("from asset_material");
            //sql.AppendLine(string.Format("where a_cd in ({0})", strA_cd));
            string sql = string.Format(@"with list as
                                (select unnest(ARRAY[{0}]) as a_cd)
                                select list.a_cd,a_name, a_fuselage_cd,  a_self_cd, a_purchase_time, a_type_cd
                                from asset_material as t1
                                right join list
                                on t1.a_cd=list.a_cd"
                                , strA_cd);
            DataTable dt = new DataTable();
            new DBHelper().ExecuteDataTable(sql, ref dt);



            dgvShow.DataSource = dt;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvShow.Rows.Count == 0)
                return;
            list.Clear();
            for (int i = 0; i < dgvShow.Rows.Count; i++)
            {
                if (dgvShow.Rows[i].Cells["a_fuselage_cd"].Value.ToString()=="")
                {
                    MessageBox.Show("存在数据库没有的记录，不能打印","打印",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                string[] strArr = { dgvShow.Rows[i].Cells["a_name"].Value.ToString(),
                    dgvShow.Rows[i].Cells["a_fuselage_cd"].Value.ToString(),
                    dgvShow.Rows[i].Cells["a_cd"].Value.ToString(),
                    dgvShow.Rows[i].Cells["a_self_cd"].Value.ToString(),
                    Convert.ToDateTime(dgvShow.Rows[i].Cells["a_purchase_time"].Value.ToString()).ToString("yyyy-MM-dd"),
                    dgvShow.Rows[i].Cells["a_type_cd"].Value.ToString() };
                list.Add(strArr);
            }
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            System.Drawing.Printing.PrinterSettings setting = pd.PrinterSettings;
            printDocument1.PrinterSettings = setting;

            
            printTime = list.Count / printOneTimeCount;
            printTime = list.Count % printOneTimeCount == 0 ? printTime : ++printTime;
            printedCount = 0;
            for (int i=0; i < printTime; i++ )
            {
                printDocument1.Print();
            }
            return;
            Print print = new Print();
            print.Show();//预览，不显示的话，全是空白
            if (print.BtnPrint_Click(setting))
            {
                print.Dispose();
                return;
            }
            print.Dispose();
        }
        int printOneTimeCount = Convert.ToInt16(ConfigurationManager.AppSettings["printOneTimeCount"]);//打印一页有多少个数据
        int printTime = 0;//需要打印的页数（次数）
        int printedCount = 0;//已经打印的个数
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;            
            Brush b = new SolidBrush(Color.Black);
            //字体大小
            int fontSize1 = Convert.ToInt16(ConfigurationManager.AppSettings["fontSize1"]);
            int fontSize2 = Convert.ToInt16(ConfigurationManager.AppSettings["fontSize2"]);            
            int dateSize = Convert.ToInt16(ConfigurationManager.AppSettings["dateSize"]);
            Font f1 = new Font("Arial", fontSize1, FontStyle.Bold);            
            Font f2 = new Font("Arial", fontSize2, FontStyle.Bold);
            Font f0 = new Font("Arial", dateSize, FontStyle.Bold);
            int switchSize = Convert.ToInt16(ConfigurationManager.AppSettings["switchSize"]);
            //两列的位置
            int column_1st = Convert.ToInt16(ConfigurationManager.AppSettings["column_1st"]);
            int column_2nd = Convert.ToInt16(ConfigurationManager.AppSettings["column_2nd"]);
            //行的开始位置和间隔
            int yStart = Convert.ToInt16(ConfigurationManager.AppSettings["yStart"]);
            int yInterval = Convert.ToInt16(ConfigurationManager.AppSettings["yInterval"]);
            //单元的间隔
            int unitInterval = Convert.ToInt16(ConfigurationManager.AppSettings["unitInterval"]);
            for (int i=0;i< printOneTimeCount;i++ )
            {
                if (printedCount == list.Count)
                    break;
                string[] printStr = list[printedCount];
                
                //第一行
                int fontW = Convert.ToInt16(g.MeasureString(printStr[0], f1).Width);
                if (fontW <= switchSize*2.5)
                { g.DrawString(printStr[0], f1, b, new Point(column_1st, (yStart + yInterval * 0) + unitInterval * i)); }
                else
                { g.DrawString(printStr[0], f2, b, new Point(column_1st, (yStart + yInterval * 0) + unitInterval * i)); }
                //第二行
                fontW = Convert.ToInt16(g.MeasureString(printStr[1], f1).Width);
                if (fontW <= switchSize * 2.5)
                { g.DrawString(printStr[1], f1, b, new Point(column_1st, (yStart + yInterval * 1) + unitInterval * i)); }
                else
                { g.DrawString(printStr[1], f2, b, new Point(column_1st, (yStart + yInterval * 1) + unitInterval * i)); }
                //第三行—1
                fontW = Convert.ToInt16(g.MeasureString(printStr[2], f1).Width);
                if (fontW <= switchSize)
                { g.DrawString(printStr[2], f1, b, new Point(column_1st, (yStart + yInterval * 2) + unitInterval * i)); }
                else
                { g.DrawString(printStr[2], f2, b, new Point(column_1st, (yStart + yInterval * 2) + unitInterval * i)); }
                //第三行—2
                fontW = Convert.ToInt16(g.MeasureString(printStr[3], f1).Width);
                if (fontW <= switchSize)
                { g.DrawString(printStr[3], f1, b, new Point(column_2nd, (yStart + yInterval * 2) + unitInterval * i)); }
                else
                { g.DrawString(printStr[3], f2, b, new Point(column_2nd, (yStart + yInterval * 2) + unitInterval * i)); }
                //第四行—1
                fontW = Convert.ToInt16(g.MeasureString(printStr[4], f1).Width);
                if (fontW <= switchSize)
                { g.DrawString(printStr[4], f0, b, new Point(column_1st, (yStart + yInterval * 3) + unitInterval * i)); }
                else
                { g.DrawString(printStr[4], f0, b, new Point(column_1st, (yStart + yInterval * 3) + unitInterval * i)); }
                //第四行—2
                fontW = Convert.ToInt16(g.MeasureString(printStr[5], f1).Width);
                if (fontW <= switchSize)
                { g.DrawString(printStr[5], f1, b, new Point(column_2nd, (yStart + yInterval * 3) + unitInterval * i)); }
                else
                { g.DrawString(printStr[5], f2, b, new Point(column_2nd, (yStart + yInterval * 3) + unitInterval * i)); }


                //g.DrawString(printStr[1], f1, b, new Point(column_1st, (yStart + yInterval * 1) + unitInterval * i));
                //g.DrawString(printStr[2], f1, b, new Point(column_1st, (yStart + yInterval * 2) + unitInterval * i)); g.DrawString(printStr[3], f1, b, new Point(column_2nd, (yStart + yInterval * 2) + unitInterval * i));
                //g.DrawString(printStr[4], f1, b, new Point(column_1st, (yStart + yInterval * 3) + unitInterval * i)); g.DrawString(printStr[5], f1, b, new Point(column_2nd, (yStart + yInterval * 3) + unitInterval * i));
                printedCount++;
            }
        }

        private void DgvShow_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvShow.RowCount; i++)
            {
                dgvShow.Rows[i].HeaderCell.Value = (dgvShow.RowCount - i).ToString();
            }
        }
    }
}