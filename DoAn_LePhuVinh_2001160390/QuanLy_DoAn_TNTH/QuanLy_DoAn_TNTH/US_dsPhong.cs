using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLy_DoAn_TNTH
{
    public partial class US_dsPhong : UserControl
    {
        public US_dsPhong()
        {
            InitializeComponent();
        }
        public static US_dsPhong _instance;
        public static US_dsPhong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_dsPhong();
                return _instance;
            }
        }

        private void US_dsPhong_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string str = "select * from PhongThiNghiem";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_Phong.DataSource = dt;
            conn.Close();
        }
    }
}
