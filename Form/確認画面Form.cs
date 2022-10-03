using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipReservations
{
    public partial class 確認画面Form : Form
    {
        ShipInfo _ShipInfo = new ShipInfo();
        public 確認画面Form()
        {
            InitializeComponent();
        }

        private void 確認画面_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            set計上年(dt);
            set計上月(dt);
            docb部門();
        }
        private void docb部門()
        {
            MySqlConnection myconn = DB.GetConnection();

            String query = $"SELECT 部門コード as 部門CD,部門名 FROM jikodb.m_部門 t2 where 部門コード <> '99' ";
            MySqlDataReader rs;
            rs = DB.GetReader(myconn, query);

            this.cb営業所.Items.Clear();
            var _ShipInfo = new ShipInfo();
            _ShipInfo.item1 = "*";
            _ShipInfo.item2 = "";
            this.cb営業所.Items.Add(_ShipInfo);
            while (rs.Read())
            {
                _ShipInfo = new ShipInfo();
                _ShipInfo.item1 = DB.NVL(rs["部門名"]).ToString();
                _ShipInfo.item2 = DB.NVL(rs["部門CD"]).ToString();
                this.cb営業所.Items.Add(_ShipInfo);
            }

            this.cb営業所.Refresh();
            this.cb営業所.SelectedIndex = 0;

            rs.Close();
        }

        private void tx計上月_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.tx計上月.Text.Length == 1)
                {
                    this.tx計上月.Text = int.Parse(this.tx計上月.Text).ToString("00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.tx計上月.Text = dt.AddMonths(-1).Month.ToString("00");
        }

        private void bt予約一覧表_Click(object sender, EventArgs e)
        {
            String BumoNCD = _ShipInfo.部門CD;
            String 計上年月 = this.tx計上年.Text + this.tx計上月.Text;

            this.Exp予約データ(BumoNCD, 計上年月);
        }
        public void Exp予約データ(String BUMONCD, String KEI)
        {
            String c_name = "";

#if DEBUG
            String appPath = Environment.CurrentDirectory;
            XLWorkbook xlBook = new XLWorkbook(appPath + "/Report/請求一覧経理temp.xlsx");
#else
            String appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            XLWorkbook xlBook = new XLWorkbook(appPath + "/ShipReservations/Report/請求一覧経理temp.xlsx");
#endif

            IXLWorksheet xlSheet = xlBook.Worksheet("一覧");

            String fileName = Func.GetWorkFolder() + @"\temp\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
            xlBook.SaveAs(fileName);

            xlSheet.Cells("A1").Select();


            //レスポンス改善のため、Connectionは最初に貼る
            MySqlConnection myconn = DB.GetConnection();

            String query = "";

            if (BUMONCD == "")
            {
                query = String.Format(" SELECT t1.部門名,t2.利用区分,t2.フェリー会社,t2.乗船日,t2.車番,t2.ドアNO,t2.車長,cast(t2.請求額 AS SIGNED)+cast(t2.作業乗船 AS SIGNED)+cast(t2.作業下船 AS SIGNED) AS 請求額,t2.調整金,t2.消費税,t2.計上年月 FROM shipR.`t_予約`t2,jikodb.`m_部門`t1 WHERE t2.部門CD = t1.部門コード and t2.計上年月 = '{0}' ", KEI);
            }
            else
            {
                query = String.Format(" SELECT t1.部門名,t2.利用区分,t2.フェリー会社,t2.乗船日,t2.車番,t2.ドアNO,t2.車長,cast(t2.請求額 AS SIGNED)+cast(t2.作業乗船 AS SIGNED)+cast(t2.作業下船 AS SIGNED) AS 請求額,t2.調整金,t2.消費税,t2.計上年月 FROM shipR.`t_予約`t2,jikodb.`m_部門`t1 WHERE t2.部門CD = t1.部門コード and t2.計上年月 = '{0}' and t2.部門CD = '{1}' ", KEI, BUMONCD);
            }
            Console.WriteLine(query);

            MySqlDataReader rs;
            rs = DB.GetReader(myconn, query);

            var i = 3;
            while (rs.Read())
            {
                this.setvalue(xlSheet.Range("A" + i), DB.NVL(rs["部門名"]).ToString());
                this.setvalue(xlSheet.Range("B" + i), DB.NVL(rs["利用区分"]).ToString());
                this.setvalue(xlSheet.Range("C" + i), DB.NVL(rs["フェリー会社"]).ToString());
                this.setvalue(xlSheet.Range("D" + i), DB.NVL(rs["乗船日"]).ToString());
                this.setvalue(xlSheet.Range("E" + i), DB.NVL(rs["車番"]).ToString());
                this.setvalue(xlSheet.Range("F" + i), DB.NVL(rs["ドアNO"]).ToString());
                this.setvalue(xlSheet.Range("G" + i), DB.NVL(rs["車長"]).ToString(), true);
                this.setvalue(xlSheet.Range("H" + i), DB.NVL(rs["請求額"]).ToString(), true);
                this.setvalue(xlSheet.Range("I" + i), DB.NVL(rs["調整金"]).ToString(), true);
                this.setvalue(xlSheet.Range("J" + i), DB.NVL(rs["消費税"]).ToString(), true);
                this.setvalue(xlSheet.Range("K" + i), DB.NVL(rs["計上年月"]).ToString());
                i++;
            }


            #region "ヘッダ"
            #endregion

            try
            {
                xlBook.SaveAs(fileName);

                Func.SetReadonly(fileName, true);

                Process.Start(fileName);
            }
            catch
            {
                Exception ex = new Exception();
                Msg.ShowError(ex.Message);
            }

        }
        private void setvalue(IXLRange cell, Object value, Boolean needFormat = false)
        {
            string buff;

            if (value == null)
            {
                buff = "";
            }
            else
            {
                buff = value.ToString();
            }

            if (needFormat)
            {
                cell.Value = buff;
            }
            else
            {
                cell.Value = "'" + buff;
            }
        }

        private void cb営業所_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShipInfo inf = (ShipInfo)this.cb営業所.SelectedItem;
            this.cb営業所.Text = inf.item1;
            _ShipInfo.部門名 = inf.item1;
            _ShipInfo.部門CD = inf.item2;
        }

        private void bt旧予約一覧表_Click(object sender, EventArgs e)
        {

        }

        private void btマニュアル１_Click(object sender, EventArgs e)
        {
            String c_name = "README１.xlsx";

#if DEBUG
            String appPath = Environment.CurrentDirectory;
            String path = appPath + @"\Report\" + c_name;
#else
            String appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String path = appPath + @"\ShipReservations\Report\" + c_name;
#endif
            System.Diagnostics.Process.Start(path);
        }

        private void btマニュアル２_Click(object sender, EventArgs e)
        {
            String c_name = "README２.xlsx";

#if DEBUG
            String appPath = Environment.CurrentDirectory;
            String path = appPath + @"\Report\" + c_name;
#else
            String appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String path = appPath + @"\ShipReservations\Report\" + c_name;
#endif
            System.Diagnostics.Process.Start(path);
        }

        private void bt請求データ保管場所_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\\192.168.1.230\共有フォルダ(公開)\01_本社\フェリー請求書");
        }
    }
}
