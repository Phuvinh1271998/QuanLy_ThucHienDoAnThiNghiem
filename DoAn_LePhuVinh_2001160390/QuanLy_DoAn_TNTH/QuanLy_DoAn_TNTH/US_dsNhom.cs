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
    public partial class US_dsNhom : UserControl
    {
        public US_dsNhom()
        {
            InitializeComponent();
        }
        public static US_dsNhom _instance;
        public static US_dsNhom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_dsNhom();
                return _instance;
            }
        }
        private void US_dsNhom_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string str = "select SinhVien.MaNhom,NhomSV.TenNhom,COUNT(SinhVien.MaNhom) as SoLuong from NhomSV, SinhVien where SinhVien.MaNhom = NhomSV.MaNhom group by NhomSV.TenNhom,SinhVien.MaNhom";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_Nhom.DataSource = dt;
            conn.Close();
        }
    }
}
