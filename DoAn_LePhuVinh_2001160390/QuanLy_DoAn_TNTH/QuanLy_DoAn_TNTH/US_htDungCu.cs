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
    public partial class US_htDungCu : UserControl
    {
        public US_htDungCu()
        {
            InitializeComponent();
        }
        public static US_htDungCu _instance;
        public static US_htDungCu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_htDungCu();
                return _instance;
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            LoaddataGridView();
        }
        public void LoaddataGridView()
        {
            SqlConnection sql = DBUtils.GetDBConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("select  dk2.MaDK_HCDC, dk1.MaNhom, dc.TenDC, dk2.SoLuong_DC " +
                                            "from DK_HCDC as dk1, DK_DungCu as dk2, DungCu as dc " +
                                            "where dk1.MaDK_HCDC = dk2.MaDK_HCDC and dk2.MaDC = dc.MaDC and MaNhom LIKE '%" + txtMaNhom.Text + "%'", sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn Xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection sql = DBUtils.GetDBConnection();
                sql.Open();
                SqlCommand cmd1 = new SqlCommand("delete from DK_DUNGCU where MaDK_HCDC = '" + dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'", sql);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("delete from DK_HoaChat where MaDK_HCDC = '" + dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'", sql);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("delete from DK_HCDC where MaDK_HCDC = '" + dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'", sql);
                cmd3.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Xóa thành công");
                LoaddataGridView();
            }
        }
    }
}
