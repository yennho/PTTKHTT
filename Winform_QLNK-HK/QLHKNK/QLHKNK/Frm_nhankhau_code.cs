using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLHKNK
{
    public partial class Frm_nhankhau_code : Form
    {
        public Frm_nhankhau_code()
        {
            InitializeComponent();
        }

        private void nSINHDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter boDocGhi;
        DataTable bangNhanKhau = new DataTable();
        SqlCommandBuilder capNhat;
        int i;

        private void ketNoiDuLieu()
        {
            string chuoiKetNoi = "Data Source=.;Initial Catalog=qlht;Integrated Security=True";
            conn.ConnectionString = chuoiKetNoi;
        }

        private void hienThiLuoi()
        {
            ketNoiDuLieu();
            string sql = "SELECT * FROM NHANKHAU";
            boDocGhi = new SqlDataAdapter(sql, conn);
            boDocGhi.Fill(bangNhanKhau);
            dgv_nhanKhau.DataSource = bangNhanKhau;

        }

        private void Frm_nhankhau_code_Load(object sender, EventArgs e)
        {
            hienThiLuoi();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // kiem tra khoa chinh
            string sql = "select * from NHANKHAU where STTNHANKHAU = '" +txt_sttNhanKhau.Text+ "'";
            SqlDataAdapter bodoctam = new SqlDataAdapter(sql, conn);
            DataTable bangtam = new DataTable();
            bodoctam.Fill(bangtam);
            if (bangtam.Rows.Count > 0)
            {
                MessageBox.Show("STT nhân khẩu đã tồn tại! Vui lòng nhập lại!");

            }
            else
            {
                DataRow dongmoi = bangNhanKhau.NewRow();
                dongmoi[0] = txt_sttNhanKhau.Text;
                dongmoi[1] = txt_soSo.Text;
                dongmoi[2] = txt_hoTenNhanKhau.Text;
                dongmoi[3] = txt_gioiTinh.Text;
                dongmoi[4] = dtp_ngaySinh.Text;

               bangNhanKhau.Rows.Add(dongmoi);

                capNhat = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(bangNhanKhau);
                bangNhanKhau.Clear();
                hienThiLuoi();
            }
        }

        private void txt_hoTenNhanKhau_TextChanged(object sender, EventArgs e)
        {
        
        }
        // sua
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangNhanKhau.Rows[i][0] = txt_sttNhanKhau.Text;
            bangNhanKhau.Rows[i][1] = txt_soSo.Text;
            bangNhanKhau.Rows[i][2] = txt_hoTenNhanKhau.Text;
            bangNhanKhau.Rows[i][3] = txt_gioiTinh.Text;
            bangNhanKhau.Rows[i][4] = dtp_ngaySinh.Text;

            capNhat = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(bangNhanKhau);
            bangNhanKhau.Clear();
            hienThiLuoi();
        }
        // lam moi
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_sttNhanKhau.Clear();
            txt_soSo.Clear();
            txt_hoTenNhanKhau.Clear();
            txt_gioiTinh.Clear();     
        
        }
        }
}



      