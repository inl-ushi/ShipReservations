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
    public partial class 川崎近海InputForm : Form
    {
        public ShipInfo _ShipInfo = new ShipInfo();
        public string currentsid;
        public string current調整金;
        public string current計上年月;

        public 川崎近海InputForm()
        {
            InitializeComponent();
        }

        private void 川崎近海InputForm_Load(object sender, EventArgs e)
        {
            set利用区分();
            set車番();
            setドアNO();
            set調整金();
            if (this.currentsid != "")
            {//変更の場合
                MySqlConnection myconn = DB.GetConnection();


                //コマンドライン引数を配列で取得する
                string[] cmds = System.Environment.GetCommandLineArgs();

                String query = $"SELECT sid,部門CD,フェリー会社,利用区分,乗船日,車番,ドアNO,車長,請求額,調整金,消費税,計上年月 FROM t_予約 t1 WHERE sid = {currentsid}";

                MySqlDataReader rs;
                rs = DB.GetReader(myconn, query);

                while (rs.Read())
                {
                    this.cb利用区分.Text = DB.NVL(rs["利用区分"]).ToString();
                    if (rs["乗船日"].ToString() == null || rs["乗船日"].ToString() == " " || rs["乗船日"].ToString() == "")
                    {
                        this.dtp積日.Text = " ";
                    }
                    else
                    {
                        this.dtp積日.Text = DB.NVL(rs["乗船日"]).ToString();
                    }
                    this.tx車番.Text = DB.NVL(rs["車番"]).ToString();
                    this.txドアNO.Text = DB.NVL(rs["ドアNO"]).ToString();
                    this.txSIZE.Text = DB.NVL(rs["車長"]).ToString();
                    this.tx調整金.Text = DB.NVL(rs["調整金"]).ToString();
                    this.tx消費税.Text = DB.NVL(rs["消費税"]).ToString();
                    this.tx運賃.Text = DB.NVL(rs["請求額"]).ToString();

                    _ShipInfo.sid = DB.NVL(rs["sid"]).ToString();
                    _ShipInfo.部門CD = DB.NVL(rs["部門CD"]).ToString();
                    _ShipInfo.利用区分 = DB.NVL(rs["利用区分"]).ToString();
                    _ShipInfo.フェリー会社 = DB.NVL(rs["フェリー会社"]).ToString();
                    _ShipInfo.乗船日 = DB.NVL(rs["乗船日"]).ToString();
                    _ShipInfo.車番 = DB.NVL(rs["車番"]).ToString();
                    _ShipInfo.ドアNO = DB.NVL(rs["ドアNO"]).ToString();
                    _ShipInfo.車長 = DB.NVL(rs["車長"]).ToString();
                    _ShipInfo.請求額 = DB.NVL(rs["請求額"]).ToString();
                    _ShipInfo.調整金 = DB.NVL(rs["調整金"]).ToString();
                    _ShipInfo.消費税 = DB.NVL(rs["消費税"]).ToString();
                    _ShipInfo.計上年月 = DB.NVL(rs["計上年月"]).ToString();
                }
            }
            else
            {
            }
        }

        private void set調整金()
        {
            this.tx調整金.Text = this.current調整金;
        }
        private void set利用区分()
        {
            MySqlConnection myconn = DB.GetConnection();

            //コマンドライン引数を配列で取得する
            string[] cmds = System.Environment.GetCommandLineArgs();
            int i = 0;
            if (cmds.Length > 1)
            {

                String query = $"SELECT DISTINCT 名称 FROM m_利用区分 t1";

                MySqlDataReader rs;
                rs = DB.GetReader(myconn, query);

                this.cb利用区分.Items.Clear();
                var _ShipInfo = new ShipInfo();
                while (rs.Read())
                {
                    _ShipInfo = new ShipInfo();
                    _ShipInfo.item1 = DB.NVL(rs["名称"]).ToString();
                    this.cb利用区分.Items.Add(_ShipInfo);
                    i++;
                }

                this.cb利用区分.Refresh();
                this.cb利用区分.SelectedIndex = 0;

                rs.Close();
            }
        }

        private void setドアNO()
        {
            MySqlConnection myconn = DB.GetConnection();

            String query = $"SELECT DISTINCT `車番`,CONCAT(`陸運支局名`,`分類番号`,`ひらがな`,`ナンバー`) as ＮＯ FROM common_db.`l_m_車番マスタ` WHERE CONCAT(`陸運支局名`,`分類番号`,`ひらがな`,`ナンバー`) LIKE '%{this.tx車番.Text}%'";

            MySqlDataReader rs;
            rs = DB.GetReader(myconn, query);

            this.txドアNO.Items.Clear();
            var _ShipInfo = new ShipInfo();

            if (this.tx車番.Text == "")
            {
                _ShipInfo.item1 = "";
                this.txドアNO.Items.Add(_ShipInfo);
            }
            while (rs.Read())
            {
                _ShipInfo = new ShipInfo();
                _ShipInfo.item1 = DB.NVL(rs["車番"]).ToString();
                this.txドアNO.Items.Add(_ShipInfo);
            }

            this.txドアNO.SelectedIndex = 0;
            this.txドアNO.Refresh();

            rs.Close();
        }
        private void set車番()
        {
            MySqlConnection myconn = DB.GetConnection();

            String query = $"SELECT DISTINCT `車番`,CONCAT(`陸運支局名`,`分類番号`,`ひらがな`,`ナンバー`) as ＮＯ FROM common_db.`l_m_車番マスタ` WHERE CONCAT(`陸運支局名`,`分類番号`,`ひらがな`,`ナンバー`) LIKE '%{this.tx車番検索.Text}'";

            MySqlDataReader rs;
            rs = DB.GetReader(myconn, query);

            this.tx車番.Items.Clear();
            var _ShipInfo = new ShipInfo();
            _ShipInfo.item1 = "";
            this.tx車番.Items.Add(_ShipInfo);
            if (this.tx車番.Text == "")
            {
                _ShipInfo.item1 = "";
                this.txドアNO.Items.Add(_ShipInfo);
            }
            while (rs.Read())
            {
                _ShipInfo = new ShipInfo();
                _ShipInfo.item1 = DB.NVL(rs["ＮＯ"]).ToString();
                this.tx車番.Items.Add(_ShipInfo);
            }

            this.txドアNO.Refresh();

            rs.Close();
        }
        private void txドアNO_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tx車番_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtp積日_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt入力_Click(object sender, EventArgs e)
        {
            _ShipInfo.sid = this.currentsid;
            _ShipInfo.利用区分 = this.cb利用区分.Text;
            if (this.dtp積日.Text == null || this.dtp積日.Text == "" || this.dtp積日.Text == " ")
            {
                _ShipInfo.乗船日 = " ";
            }
            else
            {
                _ShipInfo.乗船日 = this.dtp積日.Value.ToString("yyyy/MM/dd");
            }
            _ShipInfo.車番 = this.tx車番.Text;
            _ShipInfo.ドアNO = this.txドアNO.Text;
            _ShipInfo.車長 = this.txSIZE.Text;
            _ShipInfo.請求額 = this.tx運賃.Text;
            _ShipInfo.調整金 = this.tx調整金.Text;
            _ShipInfo.消費税 = this.tx消費税.Text;

            _ShipInfo.currentInputFLG = "1";
            this.Close();
        }

        private void tx車番_SelectedIndexChanged(object sender, EventArgs e)
        {
            setドアNO();
        }

        private void tx車番検索_TextChanged(object sender, EventArgs e)
        {
            set車番();
        }

        private void tx運賃_TextChanged(object sender, EventArgs e)
        {
            this.tx消費税.Text = (Int32.Parse(Func.Nz(this.tx運賃.Text)) * 0.1).ToString();
        }

        private void tx車番_Enter(object sender, EventArgs e)
        {
            tx車番.DroppedDown = true;
        }

        private void txドアNO_Enter(object sender, EventArgs e)
        {
            txドアNO.DroppedDown = true;
        }

        private void txSIZE_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection myconn = DB.GetConnection();

            if (this.txSIZE.Text == "")
            {
                this.txSIZE.Text = "0";
            }
            String query = $"SELECT 調整金 FROM t_調整金 t1 WHERE 年月 = {current計上年月} and フェリー名 = '川崎近海' and 長さ = {this.txSIZE.Text}";

            MySqlDataReader rs;
            rs = DB.GetReader(myconn, query);

            this.tx調整金.Text = "0";
            while (rs.Read())
            {
                this.tx調整金.Text = DB.NVL(rs["調整金"]).ToString();
            }
        }
    }
}
