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
    public partial class US_themSV : UserControl
    {
        public US_themSV()
        {
            InitializeComponent();
        }
        public static US_themSV _instance;
        public static US_themSV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new US_themSV();
                return _instance;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void US_themSV_Load(object sender, EventArgs e)
        {
            SqlConnection sql = DBUtils.GetDBConnection();
            sql.Open();
            SqlCommand cm = new SqlCommand("select MaNhom,TenNhom from NhomSV", sql);
            SqlDataAdapter adap = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            cbTenNhom.DisplayMember = "TenNhom";
            cbTenNhom.ValueMember = "MaNhom";
            cbTenNhom.DataSource = dt;
                        
            cm = new SqlCommand("select MaLop,TenLop from Lop", sql);
            adap = new SqlDataAdapter(cm);
            dt = new DataTable();
            adap.Fill(dt);
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbLop.DataSource = dt;

            //-------------------grid TB
            cm = new SqlCommand("select * from SinhVien", sql);
            adap = new SqlDataAdapter(cm);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

          
            btnLuu.Enabled = false;

            sql.Close();
        }

        public Boolean exedata(string cmd)
        {
            SqlConnection sql = DBUtils.GetDBConnection();
            sql.Open();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, sql);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            sql.Close();
            return check;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text.Trim();
            string tensv = txtTenSV.Text.Trim();
            DateTime ngaysinh = dateNgaySinh.Value;
            int hocky = Int32.Parse(txtHocKy.Text.Trim()); ;
            int namhoc = Int32.Parse(txtNamHoc.Text.Trim()); ;
            string manhom = cbTenNhom.SelectedValue.ToString().Trim();
            string malop = cbLop.SelectedValue.ToString().Trim();
            SqlConnection sql = DBUtils.GetDBConnection();
            sql.Open();
            SqlCommand cm = new SqlCommand($"select count(*) as SoLuong from SinhVien where MaNhom = '{manhom}'", sql);
            SqlDataAdapter adap = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            string so = dt.Rows[0]["SoLuong"].ToString();
            if (Int32.Parse(so) >= 3)
            {
                MessageBox.Show("Nhóm Đủ người !");
                return;
            }                

            if (!exedata($"insert into SinhVien values('{masv}',N'{tensv}','{ngaysinh}',{hocky},{namhoc},'{manhom}','{malop}')"))
                MessageBox.Show("Có Lỗi !");
            else
                MessageBox.Show("Thành công !");

            //-------------------grid TB
            cm = new SqlCommand("select * from SinhVien", sql);
            adap = new SqlDataAdapter(cm);            
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Close();
                        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string masv = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (!exedata($"delete from SinhVien where MaSV='{masv}'"))
                    MessageBox.Show("Có Lỗi !");
                else
                    MessageBox.Show("Thành công !");
                SqlConnection sql = DBUtils.GetDBConnection();
                sql.Open();                
                SqlCommand cm = new SqlCommand("select * from SinhVien", sql);
                SqlDataAdapter adap = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;

                
                sql.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                txtMaSV.Enabled = false;
                dataGridView1.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection sql = DBUtils.GetDBConnection();
            sql.Open();
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string masv = txtMaSV.Text.Trim();
                string tensv = txtTenSV.Text.Trim();
                DateTime ngaysinh = dateNgaySinh.Value;
                int hocky = Int32.Parse(txtHocKy.Text.Trim()); ;
                int namhoc = Int32.Parse(txtNamHoc.Text.Trim()); ;
                string manhom = cbTenNhom.SelectedValue.ToString().Trim();
                string malop = cbLop.SelectedValue.ToString().Trim();
                //SqlCommand sc = new SqlCommand($"update DK_PTN set MaGVQL='{gv}',SoLuongTB={sl} where NgayDK='{ngay}' and MaBuoi='{buoi}' and MaNhom='{nhom}' and MaLoaiTN='{loai}' and MaPTN='{phong}' and MaTB='{tb}'", sql);
                //sc.ExecuteNonQuery();

                if (!exedata($"update SinhVien set TenSV='{tensv}',NgaySinh='{ngaysinh}',HocKy={hocky},NamHoc={namhoc},MaNhom='{manhom}',MaLop='{malop}' where MaSV='{masv}'"))
                    MessageBox.Show("Có Lỗi !");
                else
                    MessageBox.Show("Thành công !");

                SqlCommand cm = new SqlCommand("select * from SinhVien", sql);
                SqlDataAdapter adap = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;

                sql.Close();

                txtMaSV.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateNgaySinh.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            txtNamHoc.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            txtMaSV.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            txtHocKy.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            cbTenNhom.SelectedValue = dataGridView1[5, e.RowIndex].Value.ToString();
            txtTenSV.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            cbLop.SelectedValue = dataGridView1[6, e.RowIndex].Value.ToString();            
        }
    }
}
