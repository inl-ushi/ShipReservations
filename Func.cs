﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipReservations
{
    class Func
    {
        public static string FilterEscape(string src)
        {

            var buff = src;
            buff = buff.Replace("*", "[*]");
            buff = buff.Replace("%", "[%]");
            buff = buff.Replace("'", "''");
            buff = "'*" + buff + "*'";

            return buff;

        }
        public static string GetWorkFolder()
        {
            var appPath = Environment.CurrentDirectory;

            return appPath;
        }
        public static string GetMydoc()
        {
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            return appPath;
        }
        public static string GetTempFolder()
        {

            var tempPath = GetWorkFolder() + "/temp/";

            if (File.Exists(tempPath))
            {
            }
            else
            {
                // フォルダが無ければ作成しておく
                Directory.CreateDirectory(tempPath);
            }

            return tempPath;

        }
        /*public static string GetBumonCD(string uid)
        {
            //現在使用していない
            // ホスト名を取得する
            
            string hostname = Dns.GetHostName();
            string BCD = null;
            string[] IPCDS;

            // ホスト名からIPアドレスを取得する
            IPAddress[] adrList = Dns.GetHostAddresses(hostname);
            foreach (IPAddress address in adrList)
            {
                //Console.WriteLine(address.ToString());
                BCD = address.ToString();
            }
            IPCDS = BCD.Split('.');
            
            return IPCDS[2];
            
        }*/
        public static void SetReadonly(String fileName, Boolean flag)
        {
            FileInfo fi = new FileInfo(fileName);
            fi.IsReadOnly = flag;
        }
        public static string Nz(string s)
        {
            if (s == null || s == "")
            {
                s = "0";
            }
            return s;
        }
    }
}
