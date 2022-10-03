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
    public partial class オーシャンForm : Form
    {
        ShipInfo _ShipInfo = new ShipInfo();
        public string current部門名;
        public string current部門CD;
        public string current氏名;
        public string currentEMAIL;
        public string ShipName = "オーシャン";
        public オーシャンForm()
        {
            InitializeComponent();
        }
        private void オーシャン_Load(object sender, EventArgs e)
        {
            this.dgv1.Columns["利用区分"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns["乗船"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns["区間"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns["車種"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns["車番"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns["ドアNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns["車長"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["車幅"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["数量"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["船送料"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["調整金"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["作業乗船"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["作業下船"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["小計"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv1.Columns["備考"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DateTime dt = DateTime.Now;

            set計上年(dt);
            set計上月(dt);
            this.tx燃料価格調整金.Text = "車長により変動";
            setMainDataGrid();
        }
        private void setMainDataGrid()
        {
            var query = new System.Text.StringBuilder();

            query.Append($" select sid,`利用区分`,`乗船日`,`車種`,`車番`,`ドアNO`,`車長`,`請求額`,`調整金`,`消費税`,作業乗船,作業下船,`計上年月` from t_予約 WHERE 部門CD = '{this.current部門CD}' AND 計上年月 like '%{this.tx計上年.Text}{this.tx計上月.Text}%' AND フェリー会社 = '{ShipName}' order by 乗船日 desc ");

            var dv = new DataView();
            dv.Table = DB.GetDataTable(query.ToString());

            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.DataSource = dv;

            int i = 0;
            int max = dv.Count;

            double wk請求書計 = 0;
            double wk乗船料計 = 0;
            double wk下船料計 = 0;
            double wk消費税計 = 0;
            double wk調整金計 = 0;

            while (i < max)
            {
                wk請求書計 = wk請求書計 + double.Parse(Func.Nz(dv.Table.Rows[i]["請求額"].ToString()));
                wk消費税計 = wk消費税計 + double.Parse(Func.Nz(dv.Table.Rows[i]["消費税"].ToString()));
                wk乗船料計 = wk乗船料計 + double.Parse(Func.Nz(dv.Table.Rows[i]["作業乗船"].ToString()));
                wk下船料計 = wk下船料計 + double.Parse(Func.Nz(dv.Table.Rows[i]["作業下船"].ToString()));
                wk調整金計 = wk調整金計 + double.Parse(Func.Nz(dv.Table.Rows[i]["調整金"].ToString()));
                i++;
            }

            this.tx請求書計.Text = wk請求書計.ToString("c");
            this.tx乗船料.Text = wk乗船料計.ToString("c");
            this.tx下船料.Text = wk下船料計.ToString("c");
            this.tx消費税計.Text = wk消費税計.ToString("c");
            this.tx調整金計.Text = wk調整金計.ToString("c");
            this.tx合計.Text = (wk請求書計 + wk乗船料計 + wk下船料計 + wk消費税計 + wk調整金計).ToString("c");
        }
        private void bt読込_Click(object sender, EventArgs e)
        {
            this.bt登録.Enabled = true;
            this.bt新規.Enabled = true;
            lock計上();
            setMainDataGrid();
        }
        private void set計上年(DateTime dt)
        {
            if (dt.Month == 1)
            {
                this.tx計上年.Text = dt.AddMonths(0).Year.ToString();
            }
            else
            {
                this.tx計上年.Text = dt.Year.ToString();
            }
        }
        private void set計上月(DateTime dt)
        {
            this.tx計上月.Text = dt.AddMonths(0).Month.ToString("00");
        }
        private void lock計上()
        {
            this.tx計上年.Enabled = false;
            this.tx計上月.Enabled = false;
        }

        private void bt新規_Click(object sender, EventArgs e)
        {
            if (this.tx計上年.Text == "" || this.tx計上月.Text == "")
            {
                MessageBox.Show($"計上年/計上月の項目を入れて、\r\n「新規作成」ボタンを押してください。");
            }
            else
            {
                lock計上();
                オーシャンInputForm nextForm = new オーシャンInputForm();
                nextForm.currentsid = "";
                nextForm.current計上年月 = this.tx計上年.Text + this.tx計上月.Text;
                nextForm.ShowDialog(this);

                DataView dv = (DataView)dgv1.DataSource;
                if (nextForm._ShipInfo.currentInputFLG == "1")
                {//編集データあり
                    DataRow row = dv.Table.NewRow();
                    if (nextForm._ShipInfo.sid == null || nextForm._ShipInfo.sid == "")
                    {
                    }
                    else
                    {
                        row["sid"] = nextForm._ShipInfo.sid;
                    }

                    row["利用区分"] = nextForm._ShipInfo.利用区分;
                    row["乗船日"] = nextForm._ShipInfo.乗船日;
                    row["車番"] = nextForm._ShipInfo.車番;
                    row["ドアNO"] = nextForm._ShipInfo.ドアNO;
                    row["車長"] = nextForm._ShipInfo.車長;
                    row["請求額"] = Func.Nz(nextForm._ShipInfo.請求額);
                    row["調整金"] = Func.Nz(nextForm._ShipInfo.調整金);
                    row["作業乗船"] = Func.Nz(nextForm._ShipInfo.作業乗船);
                    row["作業下船"] = Func.Nz(nextForm._ShipInfo.作業下船);
                    row["消費税"] = Func.Nz(nextForm._ShipInfo.消費税);
                    row["計上年月"] = this.tx計上年.Text + this.tx計上月.Text;
                    this._ShipInfo.計上年月 = this.tx計上年.Text + this.tx計上月.Text;
                    dv.Table.Rows.Add(row);
                }
                else
                {//編集データなし

                }
            }
        }

        private void bt閉じる_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt請求データ_Click(object sender, EventArgs e)
        {
            _ShipInfo.Exp予約データ(this.current部門CD, this.ShipName, tx計上年.Text + tx計上月.Text);
        }

        private void bt登録_Click(object sender, EventArgs e)
        {
            this.bt登録.Enabled = false;
            if (this.tx計上年.Text.Length == 4)
            {
                if (this.tx計上月.Text.Length == 2)
                {
                    saveData();
                    Reload();
                    this.tx計上年.Enabled = true;
                    this.tx計上月.Enabled = true;
                }
                else
                {
                    Msg.Info("計上月の桁数に、問題があります。01～12");
                }
            }
            else
            {
                Msg.Info("計上年の桁数に、問題があります。1900～2023");
            }
        }
        private void Reload()
        {
            setMainDataGrid();
            this.bt登録.Enabled = true;
        }
        private void saveData()
        {
            try
            {
                var query = new StringBuilder();
                MySqlCommand comm = DB.GetCommand();

                query.AppendLine(" DELETE FROM `t_予約` ");
                query.Append(" WHERE `計上年月`= @計上年月 ");
                query.Append(" AND `フェリー会社`= @フェリー会社 ");
                query.Append(" AND `部門CD`= @部門CD ");

                comm.CommandText = query.ToString();

                comm.Parameters.Add("@計上年月", MySqlDbType.VarChar);
                comm.Parameters["@計上年月"].Value = this.tx計上年.Text + this.tx計上月.Text;

                comm.Parameters.Add("@フェリー会社", MySqlDbType.VarChar);
                comm.Parameters["@フェリー会社"].Value = this.ShipName;

                comm.Parameters.Add("@部門CD", MySqlDbType.VarChar);
                comm.Parameters["@部門CD"].Value = this.current部門CD;

                _ = comm.ExecuteNonQuery();
                comm.Parameters.Clear();

                query = new StringBuilder();

                query.AppendLine(" REPLACE INTO `t_予約` (");
                query.Append(" `sid`, ");
                query.Append(" `部門CD`, ");
                query.Append(" `利用区分`, ");
                query.Append(" `フェリー会社`, ");
                query.Append(" `乗船日`, ");
                query.Append(" `車番`, ");
                query.Append(" `ドアNO`, ");
                query.Append(" `車長`, ");
                query.Append(" `請求額`, ");
                query.Append(" `調整金`, ");
                query.Append(" `消費税`, ");
                query.Append(" `作業乗船`, ");
                query.Append(" `作業下船`, ");
                query.Append(" `計上年月` ");
                query.Append(" ) VALUES ( ");
                query.Append(" @sid, ");
                query.Append(" @部門CD, ");
                query.Append(" @利用区分, ");
                query.Append(" @フェリー会社, ");
                query.Append(" @乗船日, ");
                query.Append(" @車番, ");
                query.Append(" @ドアNO, ");
                query.Append(" @車長,  ");
                query.Append(" @請求額,  ");
                query.Append(" @調整金,  ");
                query.Append(" @消費税,  ");
                query.Append(" @作業乗船, ");
                query.Append(" @作業下船, ");
                query.Append(" @計上年月  ");
                query.Append(" ) ");

                comm.CommandText = query.ToString();

                var dv = (DataView)this.dgv1.DataSource;
                var max = dv.Table.Rows.Count;
                var i = 0;

                comm.Parameters.Clear();
                while (i < max)
                {

                    comm.Parameters.Add("@sid", MySqlDbType.Int32);
                    comm.Parameters["@sid"].Value = dv.Table.Rows[i]["sid"];

                    comm.Parameters.Add("@部門CD", MySqlDbType.VarChar);
                    comm.Parameters["@部門CD"].Value = current部門CD;

                    comm.Parameters.Add("@利用区分", MySqlDbType.VarChar);
                    comm.Parameters["@利用区分"].Value = dv.Table.Rows[i]["利用区分"];

                    comm.Parameters.Add("@フェリー会社", MySqlDbType.VarChar);
                    comm.Parameters["@フェリー会社"].Value = this.ShipName;

                    comm.Parameters.Add("@乗船日", MySqlDbType.VarChar);
                    comm.Parameters["@乗船日"].Value = dv.Table.Rows[i]["乗船日"];

                    comm.Parameters.Add("@車番", MySqlDbType.VarChar);
                    comm.Parameters["@車番"].Value = dv.Table.Rows[i]["車番"];

                    comm.Parameters.Add("@ドアNO", MySqlDbType.VarChar);
                    comm.Parameters["@ドアNO"].Value = dv.Table.Rows[i]["ドアNO"];

                    comm.Parameters.Add("@車長", MySqlDbType.VarChar);
                    comm.Parameters["@車長"].Value = dv.Table.Rows[i]["車長"];

                    comm.Parameters.Add("@請求額", MySqlDbType.VarChar);
                    comm.Parameters["@請求額"].Value = dv.Table.Rows[i]["請求額"];

                    comm.Parameters.Add("@調整金", MySqlDbType.VarChar);
                    comm.Parameters["@調整金"].Value = dv.Table.Rows[i]["調整金"];

                    comm.Parameters.Add("@消費税", MySqlDbType.VarChar);
                    comm.Parameters["@消費税"].Value = dv.Table.Rows[i]["消費税"];

                    comm.Parameters.Add("@作業乗船", MySqlDbType.VarChar);
                    comm.Parameters["@作業乗船"].Value = dv.Table.Rows[i]["作業乗船"];

                    comm.Parameters.Add("@作業下船", MySqlDbType.VarChar);
                    comm.Parameters["@作業下船"].Value = dv.Table.Rows[i]["作業下船"];

                    comm.Parameters.Add("@計上年月", MySqlDbType.VarChar);
                    comm.Parameters["@計上年月"].Value = this.tx計上年.Text + this.tx計上月.Text;

                    i++;
                    _ = comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                }

                MessageBox.Show("登録完了しました。");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                オーシャンInputForm nextForm = new オーシャンInputForm();
                nextForm.currentsid = dgv1.Rows[e.RowIndex].Cells["sid"].Value.ToString();

                DataView dv = (DataView)dgv1.DataSource;

                switch (e.ColumnIndex)
                {
                    case 1:
                        if (this.tx計上年.Text == "" || this.tx計上月.Text == "")
                        {
                            MessageBox.Show($"計上年/計上月/燃料価格調整金の項目を入れて、\r\n「新規作成」ボタンを押してください。");
                        }
                        else
                        {
                            nextForm.current計上年月 = this.tx計上年.Text + this.tx計上月.Text;
                            nextForm.ShowDialog(this);

                            if (nextForm._ShipInfo.currentInputFLG == "1")
                            {//編集データあり
                                dv.Table.Rows[e.RowIndex]["sid"] = nextForm._ShipInfo.sid;
                                dv.Table.Rows[e.RowIndex]["利用区分"] = nextForm._ShipInfo.利用区分;
                                dv.Table.Rows[e.RowIndex]["乗船日"] = nextForm._ShipInfo.乗船日;
                                dv.Table.Rows[e.RowIndex]["車番"] = nextForm._ShipInfo.車番;
                                dv.Table.Rows[e.RowIndex]["ドアNO"] = nextForm._ShipInfo.ドアNO;
                                dv.Table.Rows[e.RowIndex]["車長"] = nextForm._ShipInfo.車長;
                                dv.Table.Rows[e.RowIndex]["請求額"] = nextForm._ShipInfo.請求額;
                                dv.Table.Rows[e.RowIndex]["調整金"] = nextForm._ShipInfo.調整金;
                                dv.Table.Rows[e.RowIndex]["作業乗船"] = nextForm._ShipInfo.作業乗船;
                                dv.Table.Rows[e.RowIndex]["作業下船"] = nextForm._ShipInfo.作業下船;
                                dv.Table.Rows[e.RowIndex]["消費税"] = nextForm._ShipInfo.消費税;

                                this._ShipInfo.計上年月 = this.tx計上年.Text + this.tx計上月.Text;
                                dv.Table.Rows[e.RowIndex]["計上年月"] = nextForm._ShipInfo.計上年月;
                            }
                            else
                            {//編集データなし

                            }
                        }
                        break;

                    case 2:
                        DataRow dr = dv.Table.Rows[e.RowIndex];
                        dv.Table.Rows.Remove(dr);
                        break;
                }
            }
        }

        private void tx計上年_Leave(object sender, EventArgs e)
        {
            if (this.tx計上年.Text.Length == 4)
            {
                if (this.tx計上月.Text.Length == 2)
                {
                    setMainDataGrid();
                }
            }
            else
            {
                Msg.Info("4桁で入力を行ってください。");
            }
        }

        private void tx計上月_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.tx計上月.Text.Length <= 2)
                {
                    if (this.tx計上月.Text.Length == 1)
                    {
                        this.tx計上月.Text = int.Parse(this.tx計上月.Text).ToString("00");
                    }
                    if (this.tx計上年.Text.Length == 4)
                    {
                        setMainDataGrid();
                    }
                }
                else
                {
                    Msg.Info("2桁以内で入力を行ってください。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
