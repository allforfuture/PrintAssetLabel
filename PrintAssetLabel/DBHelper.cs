using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

using Npgsql;
using System.Windows.Forms;

namespace PrintAssetLabel
{
    public class DBHelper
    {
        static string DB1 = ConfigurationManager.ConnectionStrings["Database"].ToString();
        
        static string AOIDbConnectstringK6 = "";// ConfigurationManager.AppSettings["pqmcon_aoiK6"].ToString();
        static string AOIDbConnectstringK7 = "";// ConfigurationManager.AppSettings["pqmcon_aoiK7"].ToString();
        static string AOIDbConnectstringK4 = "";// ConfigurationManager.AppSettings["pqmcon_aoiK4"].ToString();
        NpgsqlConnection con;

        public int ExecuteSQL(string sql)
        {
            using (con = new NpgsqlConnection(DB1))
            {
                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库执行：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        public void ExecuteDataTable(string sql, ref DataTable dt)
        {
            using (con = new NpgsqlConnection(DB1))
            {
                try
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void TestTran(List<string> sql)
        {
            using (con = new NpgsqlConnection(DB1))
            {
                con.Open();
                NpgsqlTransaction tran = con.BeginTransaction();
                NpgsqlCommand cmd = new NpgsqlCommand() { Connection = con };
                try
                {
                    //cmd.CommandText = "Insert Into t_user Values('3','2','3','4','@')";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "Insert Into t_user Values('2','2','3','4','@')";
                    //cmd.ExecuteNonQuery();

                    foreach (string temp in sql)
                    {
                        cmd.CommandText = temp;
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message, "数据库事务", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void TranWithQuery(List<string> sql, ref DataTable dt)
        {
            using (con = new NpgsqlConnection(DB1))
            {
                con.Open();
                NpgsqlTransaction tran = con.BeginTransaction();
                NpgsqlCommand cmd = new NpgsqlCommand() { Connection = con };
                try
                {
                    foreach (string temp in sql)
                    {

                        if ((temp.Trim().ToUpper()).Contains("SELECT"))
                        {
                            cmd.CommandText = temp;
                            NpgsqlDataReader dr = cmd.ExecuteReader();
                            dt.Load(dr);
                            //dr.Close();
                            //con.Close(); 
                        }
                        else
                        {
                            cmd.CommandText = temp.Replace("@", "'" + dt.Rows[0][0].ToString() + "'");
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    dt = new DataTable();
                    MessageBox.Show(ex.Message, "数据库事务", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        public void ExcuteDataTableAOI(string model, string sql, ref DataTable dt)
        {
            string DBConStr;
            switch (model)
            {
                case "KK06":
                    DBConStr = AOIDbConnectstringK6;
                    break;
                case "KK04":
                    DBConStr = AOIDbConnectstringK4;
                    break;
                case "KK07":
                    DBConStr = AOIDbConnectstringK7;
                    break;
                default:
                    DBConStr = AOIDbConnectstringK6;
                    break;
            }
            using (con = new NpgsqlConnection(DBConStr))
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
    }
}