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
    public partial class US_dsDeTai : UserControl
    {
        public US_dsDeTai()
        {
            InitializeComponent();
        }
        public static US_dsDeTai _instance;
        public static US_dsDeTai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_dsDeTai();
                return _instance;
            }
        }

        private void US_dsDeTai_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string str = "select * from DEAN";           
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_DeTai.DataSource = dt;
            conn.Close();           
        }
    }
}
