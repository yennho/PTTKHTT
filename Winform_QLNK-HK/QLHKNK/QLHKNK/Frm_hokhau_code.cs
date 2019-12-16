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
    public partial class Frm_hokhau_code : Form
    {
        public Frm_hokhau_code()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter boDocGhi;
        DataTable bangHoKhau = new DataTable();
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
            string sql = "SELECT * FROM HKHAU";
            boDocGhi = new SqlDataAdapter(sql, conn);
            boDocGhi.Fill(bangHoKhau);
            dgv_hoKhau.DataSource = bangHoKhau;

        }
        private void Frm_hokhau_code_Load(object sender, EventArgs e)
        {
            hienThiLuoi();
        }
        // lam moi
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_khuPho.Clear();
            txt_maPhuongXa.Clear();
            txt_soNha.Clear();
            txt_soSo.Clear();
            txt_tenChuHo.Clear();
            txt_tenDuongPho.Clear();
            txt_soSo.Enabled = true;
        }
        // them
        private void btn_them_Click(object sender, EventArgs e)
        {
            // kiem tra khoa chinh
            string sql = "select * from HKHAU where SOSO = '" +txt_soSo.Text + "'";
            SqlDataAdapter bodoctam = new SqlDataAdapter(sql, conn);
            DataTable bangtam = new DataTable();
            bodoctam.Fill(bangtam);
            if (bangtam.Rows.Count > 0)
            {
                MessageBox.Show("Số sổ đã tồn tại! Vui lòng nhập lại!");

            }
            else
            {
                DataRow dongmoi = bangHoKhau.NewRow();
                dongmoi[0] = txt_soSo.Text;
                dongmoi[1] = txt_maPhuongXa.Text;
                dongmoi[2] = txt_tenChuHo.Text;
                dongmoi[3] = txt_soNha.Text;
                dongmoi[4] = txt_tenDuongPho.Text;
                dongmoi[5] = txt_khuPho.Text;

                bangHoKhau.Rows.Add(dongmoi);

                capNhat = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(bangHoKhau);
                bangHoKhau.Clear();
                hienThiLuoi();
            }
        }

        private void txt_maPhuongXa_TextChanged(object sender, EventArgs e)
        {

        }
        // sua
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangHoKhau.Rows[i][0] = txt_soSo.Text;
            bangHoKhau.Rows[i][1] = txt_maPhuongXa.Text;
            bangHoKhau.Rows[i][3] = txt_tenChuHo.Text;
            bangHoKhau.Rows[i][4] = txt_soNha.Text;
            bangHoKhau.Rows[i][5] = txt_khuPho.Text;
           
            capNhat = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(bangHoKhau);
            bangHoKhau.Clear();
            hienThiLuoi();
        }
        // xóa
        private void btn_xóa_Click(object sender, EventArgs e)
        {
          bangHoKhau.Rows[i].Delete();
            try
            {
                capNhat = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(bangHoKhau);
                bangHoKhau.Clear();
                hienThiLuoi();
            }
            catch
            {
                bangHoKhau.Clear();
                hienThiLuoi();
            }
        }
    }
}
