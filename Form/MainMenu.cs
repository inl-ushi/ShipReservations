using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipReservations
{
    public partial class mainmenu : Form
    {
        ShipInfo _ShipInfo = new ShipInfo();
        public mainmenu()
        {
            InitializeComponent();
        }

        private void bt周防灘_Click(object sender, EventArgs e)
        {
            周防灘Form nextForm = new 周防灘Form();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void bt川崎近海_Click(object sender, EventArgs e)
        {
            川崎近海Form nextForm = new 川崎近海Form();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void bt阪九_Click(object sender, EventArgs e)
        {
            阪九フェリーForm nextForm = new 阪九フェリーForm();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void bt名門フェリー_Click(object sender, EventArgs e)
        {
            名門大洋フェリーForm nextForm = new 名門大洋フェリーForm();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            if (this.docb部門() >= 1)
            {

                if (this.docb部門() != 1)
                {
                    this.btオーシャントランス.Enabled = false;
                    this.bt燃料調整金設定.Enabled = false;
                }
                    // ゴミファイル削除
                    DirectoryInfo tempDir = new DirectoryInfo(Func.GetTempFolder());

                foreach (FileInfo s in tempDir.GetFiles())
                {
                    try
                    {
                        s.IsReadOnly = false;
                        s.Delete();
                    }
                    catch
                    {
                        // 削除エラーは無視する
                    }
                }
                //ステータス表示
                this.sl接続先.Text = DB.GetSchemaName();
                this.sl接続先.ForeColor = DB.GetSchemaColor();

                this.dgv更新履歴.Columns["更新日"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgv更新履歴.Columns["バージョン"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgv更新履歴.Columns["内容"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                setMainDataGrid();

            }
            else
            {
                Msg.Info("使用権限がありません。確認してください。");
                this.Close();
            }
        }
        private void setMainDataGrid()
        {
            var query = new System.Text.StringBuilder();

            query.Append($" select `更新日`,バージョン,`内容` from t_releaseNote ");

            var dv = new DataView();
            dv.Table = DB.GetDataTable(query.ToString());

            this.dgv更新履歴.AutoGenerateColumns = false;
            this.dgv更新履歴.DataSource = dv;

        }
        private int docb部門()
        {
            try
            {
                MySqlConnection myconn = DB.GetConnection();

                //コマンドライン引数を配列で取得する
                string[] cmds = System.Environment.GetCommandLineArgs();
                int i = 0;
                if (cmds.Length > 1)
                {

                    String query = $"SELECT DISTINCT 部門CD,氏名,EMAIL,部門名 FROM shipR.`m_user`t1,jikodb.m_部門 t2";
                    query = query + $" WHERE t1.EMAIL = '{cmds[1]}' AND t1.部門CD = t2.部門コード ";
                    MySqlDataReader rs;
                    rs = DB.GetReader(myconn, query);

                    this.cb部門.Items.Clear();
                    var _ShipInfo = new ShipInfo();
                    while (rs.Read())
                    {
                        _ShipInfo = new ShipInfo();
                        _ShipInfo.item1 = DB.NVL(rs["部門名"]).ToString();
                        _ShipInfo.item2 = DB.NVL(rs["部門名"]).ToString();
                        _ShipInfo.item3 = DB.NVL(rs["部門CD"]).ToString();
                        _ShipInfo.item4 = DB.NVL(rs["氏名"]).ToString();
                        _ShipInfo.item5 = DB.NVL(rs["EMAIL"]).ToString();
                        this.cb部門.Items.Add(_ShipInfo);
                        i++;
                    }

                    this.cb部門.Refresh();
                    this.cb部門.SelectedIndex = 0;

                    rs.Close();
                }
                //return i;
                return Int32.Parse(_ShipInfo.部門CD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void cb部門_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShipInfo inf = (ShipInfo)this.cb部門.SelectedItem;
            this.cb部門.Text = inf.item1;
            _ShipInfo.部門名 = inf.item1;
            _ShipInfo.部門名 = inf.item2;
            _ShipInfo.部門CD = inf.item3;
            _ShipInfo.氏名 = inf.item4;
            _ShipInfo.EMAIL = inf.item5;
        }

        private void slSpacer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btさんふらわ_Click(object sender, EventArgs e)
        {
            さんふらわForm nextForm = new さんふらわForm();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void btオレンジ_Click(object sender, EventArgs e)
        {
            オレンジForm nextForm = new オレンジForm();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void bt宇和島_Click(object sender, EventArgs e)
        {
            宇和島Form nextForm = new 宇和島Form();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }

        private void bt燃料調整金設定_Click(object sender, EventArgs e)
        {
            調整金設定Form nextForm = new 調整金設定Form();
            nextForm.ShowDialog(this);
        }

        private void bt共有サーバ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\\192.168.1.230\共有フォルダ(公開)\01_本社\フェリー請求書");
        }

        private void bt請求書E_Click(object sender, EventArgs e)
        {
            String c_name = "";

            switch (_ShipInfo.部門CD){
                case "1":
                case "3":
                case "4":
                case "7":
                case "9":
                case "10":
                case "11":
                case "12":
                case "13":
                    c_name = "フェリー請求書アイエヌライン.xlsx";
                    break;
                case "2":
                case "5":
                    c_name = "フェリー請求書九州.xlsx";
                    break;
                case "6":
                    c_name = "フェリー請求書ロジ.xlsx";
                    break;
                default:
                    break;
            }
#if DEBUG
            String appPath = Environment.CurrentDirectory;
            String path = appPath + @"\Report\" + c_name;
#else
            String appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String path = appPath + @"\ShipReservations\Report\" + c_name;
#endif

            System.Diagnostics.Process.Start(path);
        }

        private void bt閉じる_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btマニュアル_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                確認画面Form nextForm = new 確認画面Form();
                nextForm.ShowDialog(this);
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            CSV出力Form nextForm = new CSV出力Form();
            nextForm.ShowDialog(this);
        }

        private void btオーシャントランス_Click(object sender, EventArgs e)
        {
            オーシャンForm nextForm = new オーシャンForm();
            nextForm.current部門CD = _ShipInfo.部門CD;
            nextForm.current部門名 = _ShipInfo.部門名;
            nextForm.current氏名 = _ShipInfo.氏名;
            nextForm.currentEMAIL = _ShipInfo.EMAIL;
            nextForm.ShowDialog(this);
        }
    }
}
