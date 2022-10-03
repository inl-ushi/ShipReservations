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
    public partial class CSV出力Form : Form
    {

        public CSV出力Form()
        {
            InitializeComponent();
        }

        private void CSV取込Form_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            tx計上年月.Text = dt.AddMonths(-1).ToString("yyyyMM");
        }

        private void btCSV出力_Click(object sender, EventArgs ea)
        {

            try
            {
                MySqlConnection myconn = DB.GetConnection();

                var query = $"select t1.* from v_CSV出力 t1 where 摘要 = concat('ﾌｪﾘｰ',{tx計上年月.Text})";
                MySqlDataReader rs;
                rs = DB.GetReader(myconn, query);

                var Fname = DateTime.Now.ToString("yyyymmdd_HHmmss");
                var downPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).Replace("MyDocuments", "Downloads");
                var Path = downPath + @"\フェリー取込用" + Fname + ".csv";

                StreamWriter file = new StreamWriter(Path, false, Encoding.UTF8);
                while (rs.Read())
                {
                    //list.Add(rs.GetString("名称"));
                    file.WriteLine(string.Format("{0},,,{1},{2},{3},,,,,,,,{4},,{5},{6},,{7}", rs.GetString("車番"), rs.GetString("経費コード"), rs.GetString("発生日付").ToString(), rs.GetString("計上日"), rs.GetString("金額"), rs.GetString("税区分"), rs.GetString("税率種別"), rs.GetString("摘要")));
                }
                Msg.Info("登録が完了しました。");

                rs.Close();
                file.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // 例外検出時にエラーメッセージを表示
            }
        }
    }
}
