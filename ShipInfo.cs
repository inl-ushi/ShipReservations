using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipReservations
{
    public class ShipInfo
    {
        public string item1;
        public string item2;
        public string item3;
        public string item4;
        public string item5;

        public string 部門名;
        public string 部門CD;
        public string 氏名;
        public string EMAIL;

        public string OpenState;

        public string sid;
        public string フェリー会社;
        public string 利用区分;
        public string 乗船日;
        public string 車番;
        public string ドアNO;
        public string 車長;
        public string 請求額;
        public string 調整金;
        public string 作業乗船;
        public string 作業下船;
        public string 小計;
        public string 消費税;
        public string 計上年月;
        public string currentInputFLG = "0";

        public override string ToString()
        {
            // Combobox は自動でToStringを呼び出す
            return this.item1;
        }
        public void Exp予約データ(String BUMONCD, String FNAME,String KEI)
        {
            String c_name = "";

#if DEBUG
            String appPath = Environment.CurrentDirectory;
            XLWorkbook xlBook = new XLWorkbook(appPath + "/Report/請求一覧temp.xlsx");
#else
            String appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            XLWorkbook xlBook = new XLWorkbook(appPath + "/ShipReservations/Report/請求一覧temp.xlsx");
            Console.WriteLine(appPath);
#endif

            IXLWorksheet xlSheet = xlBook.Worksheet("一覧");

            String fileName = Func.GetWorkFolder() + @"\temp\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
            xlBook.SaveAs(fileName);

            xlSheet.Cells("A1").Select();


            //レスポンス改善のため、Connectionは最初に貼る
            MySqlConnection myconn = DB.GetConnection();

            String query = String.Format(" SELECT 乗船日,フェリー会社,車番,台数,cast(請求額 AS SIGNED)+cast(消費税 AS SIGNED)+cast(作業乗船 AS SIGNED)+cast(作業下船 AS SIGNED) AS 請求額,利用区分 FROM `t_予約` WHERE 部門CD = '{0}' AND フェリー会社 = '{1}' AND 計上年月 = '{2}' ", BUMONCD, FNAME, KEI);

            MySqlDataReader rs;
            rs = DB.GetReader(myconn, query);

            var i = 3;
            while (rs.Read())
            {
                this.setvalue(xlSheet.Range("A" + i), DateTime.Parse(DB.NVL(rs["乗船日"]).ToString()).ToString("MM月dd日") );
                this.setvalue(xlSheet.Range("B" + i), DB.NVL(rs["フェリー会社"]).ToString());
                this.setvalue(xlSheet.Range("C" + i), DB.NVL(rs["車番"]).ToString());
                this.setvalue(xlSheet.Range("D" + i), DB.NVL(rs["台数"]).ToString());
                this.setvalue(xlSheet.Range("E" + i), DB.NVL(rs["請求額"]).ToString(),true);
                this.setvalue(xlSheet.Range("F" + i), DB.NVL(rs["利用区分"]).ToString());
                
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
    }
}
