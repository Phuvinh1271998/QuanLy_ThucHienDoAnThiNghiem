using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_DoAn_TNTH
{
    public partial class US_dsThietBi : UserControl
    {
        public US_dsThietBi()
        {
            InitializeComponent();
        }
        public static US_dsThietBi _instance;
        public static US_dsThietBi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_dsThietBi();
                return _instance;
            }
        }
    }
}
