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
    public partial class US_dsDungCu : UserControl
    {
        public US_dsDungCu()
        {
            InitializeComponent();
        }
        public static US_dsDungCu _instance;
        public static US_dsDungCu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_dsDungCu();
                return _instance;
            }
        }

        private void US_dsDungCu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string str = "select * from DungCu";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_DungCu.DataSource = dt;
            conn.Close();
        }
    }
}
