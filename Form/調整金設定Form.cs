using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipReservations
{
    public partial class 調整金設定Form : Form
    {
        public 調整金設定Form()
        {
            InitializeComponent();
        }

        private void 調整金設定Form_Load(object sender, EventArgs e)
        {

            this.tx年月.Text = DateTime.Now.AddMonths(-1).ToString("yyyyMM");
            this.tx長さ.Text = "0";
            this.tx調整金.Text = "0";
            var query = new System.Text.StringBuilder();

            query.Append($" select 年月,フェリー名,長さ,調整金 from t_調整金 order by 年月 desc,フェリー名 asc" );

            var dv = new DataView();
            dv.Table = DB.GetDataTable(query.ToString());

            this.dgv1.DataSource = dv;

            set調整金();
        }
        private void set調整金()
        {
            try
            {
                MySqlConnection myconn = DB.GetConnection();

                String query = $"SELECT フェリー会社名 FROM m_調整金";
                MySqlDataReader rs;
                rs = DB.GetReader(myconn, query);

                this.cbフェリー名.Items.Clear();
                var _ShipInfo = new ShipInfo();
                while (rs.Read())
                {
                    _ShipInfo = new ShipInfo();
                    _ShipInfo.item1 = DB.NVL(rs["フェリー会社名"]).ToString();
                    this.cbフェリー名.Items.Add(_ShipInfo);
                }

                this.cbフェリー名.Refresh();
                this.cbフェリー名.SelectedIndex = 0;

                rs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt追加_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new StringBuilder();
                MySqlCommand comm = DB.GetCommand();

                query.AppendLine(" REPLACE INTO `t_調整金` (");
                query.Append(" `年月`, ");
                query.Append(" `フェリー名`, ");
                query.Append(" `長さ`, ");
                query.Append(" `調整金` ");
                query.Append(" ) VALUES ( ");
                query.Append(" @年月,  ");
                query.Append(" @フェリー名,  ");
                query.Append(" @長さ,  ");
                query.Append(" @調整金  ");
                query.Append(" ) ");

                comm.CommandText = query.ToString();

                comm.Parameters.Add("@年月", MySqlDbType.VarChar);
                comm.Parameters["@年月"].Value = this.tx年月.Text;

                comm.Parameters.Add("@フェリー名", MySqlDbType.VarChar);
                comm.Parameters["@フェリー名"].Value = this.cbフェリー名.Text;

                comm.Parameters.Add("@長さ", MySqlDbType.Int32);
                comm.Parameters["@長さ"].Value = this.tx長さ.Text;

                comm.Parameters.Add("@調整金", MySqlDbType.Int32);
                comm.Parameters["@調整金"].Value = this.tx調整金.Text;

                _ = comm.ExecuteNonQuery();

                query = new System.Text.StringBuilder();

                query.Append($" select 年月,フェリー名,長さ,調整金 from t_調整金 order by 年月 desc,フェリー名 asc");

                var dv = new DataView();
                dv.Table = DB.GetDataTable(query.ToString());

                //this.dgv1.AutoGenerateColumns = false;
                this.dgv1.DataSource = dv;

                var max = dv.Table.Rows.Count;
                var i = 0;
                while (max>i)
                {

                    query = new System.Text.StringBuilder();
                    query.AppendLine(" UPDATE `t_予約` ");
                    query.Append(" SET ");
                    query.Append(" `調整金` ");
                    query.Append(" = ");
                    query.Append(" @調整金 ");
                    query.Append("  WHERE  ");
                    query.Append(" 計上年月 ");
                    query.Append(" = ");
                    query.Append(" @年月 ");
                    query.Append(" AND ");
                    query.Append(" フェリー会社 ");
                    query.Append(" = ");
                    query.Append(" @フェリー名 ");
                    if (dv.Table.Rows[i]["フェリー名"].ToString() == "オレンジ")
                    {
                        query.Append(" AND ");
                        query.Append(" 車長 ");
                        query.Append(" = ");
                        query.Append(" @長さ ");
                    }


                    comm.CommandText = query.ToString();
                    comm.Parameters.Clear();

                    comm.Parameters.Add("@年月", MySqlDbType.VarChar);
                    comm.Parameters["@年月"].Value = dv.Table.Rows[i]["年月"].ToString();

                    comm.Parameters.Add("@フェリー名", MySqlDbType.VarChar);
                    comm.Parameters["@フェリー名"].Value = dv.Table.Rows[i]["フェリー名"].ToString();

                    if (dv.Table.Rows[i]["フェリー名"].ToString()=="オレンジ")
                    {
                        comm.Parameters.Add("@長さ", MySqlDbType.Int32);
                        comm.Parameters["@長さ"].Value = dv.Table.Rows[i]["長さ"];
                    }

                    comm.Parameters.Add("@調整金", MySqlDbType.Int32);
                    comm.Parameters["@調整金"].Value = dv.Table.Rows[i]["調整金"];

                    _ = comm.ExecuteNonQuery();

                    i++;
                }

                Msg.Info("登録が完了しました。");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                string ErrMSG = "同一の年月・フェリー会社が存在します。訂正から行ってください。";
                MessageBox.Show(ErrMSG, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (0 <= e.RowIndex)
            {
                if (0 >= e.ColumnIndex)
                {
                    DataView dv = (DataView)dgv1.DataSource;

                    this.tx年月.Text = dv.Table.Rows[e.RowIndex]["年月"].ToString();
                    this.cbフェリー名.Text = dv.Table.Rows[e.RowIndex]["フェリー名"].ToString();
                    this.tx長さ.Text = dv.Table.Rows[e.RowIndex]["長さ"].ToString();
                    this.tx調整金.Text = dv.Table.Rows[e.RowIndex]["調整金"].ToString();

                }

            }
            else
            {
            }
        }

        private void bt削除_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new StringBuilder();
                MySqlCommand comm = DB.GetCommand();

                query.AppendLine(" DELETE FROM `t_調整金` WHERE");
                query.Append(" `年月` ");
                query.Append(" = ");
                query.Append(" @年月 AND ");
                query.Append(" `フェリー名` ");
                query.Append(" = ");
                query.Append(" @フェリー名 AND ");
                query.Append(" `長さ` ");
                query.Append(" = ");
                query.Append(" @長さ ");

                comm.CommandText = query.ToString();

                comm.Parameters.Add("@年月", MySqlDbType.VarChar);
                comm.Parameters["@年月"].Value = this.tx年月.Text;

                comm.Parameters.Add("@フェリー名", MySqlDbType.VarChar);
                comm.Parameters["@フェリー名"].Value = this.cbフェリー名.Text;

                comm.Parameters.Add("@長さ", MySqlDbType.Int32);
                comm.Parameters["@長さ"].Value = this.tx長さ.Text;

                _ = comm.ExecuteNonQuery();

                query = new System.Text.StringBuilder();

                query.Append($" select 年月,フェリー名,長さ,調整金 from t_調整金 order by 年月 desc,フェリー名 asc");

                var dv = new DataView();
                dv.Table = DB.GetDataTable(query.ToString());

                this.dgv1.DataSource = dv;

                Msg.Info("削除が完了しました。");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                string ErrMSG = "削除エラー:" + ex.ToString();
                MessageBox.Show(ErrMSG, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
