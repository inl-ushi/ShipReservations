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
    public partial class 燃料調整金設定Form : Form
    {
        ShipInfo _ShipInfo = new ShipInfo();
        public string current部門名;
        public string current部門CD;
        public string current氏名;
        public string currentEMAIL;
        public string ShipName = "さんふらわ";
        public 燃料調整金設定Form()
        {
            InitializeComponent();
        }
    }
}
