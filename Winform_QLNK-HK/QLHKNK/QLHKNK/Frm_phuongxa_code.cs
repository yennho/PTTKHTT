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
    public partial class Frm_phuongxa_code : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter boDocGhi;
        DataTable bangPhuongXa = new DataTable();
        SqlCommandBuilder capNhat;
        int i;
        SqlDataAdapter boDocQuanHuyen;
        DataTable bangQuanHuyen = new DataTable();
        public Frm_phuongxa_code()
        {
            InitializeComponent();
        }
        // ket noi du lieu
        private void ketNoiDuLieu()
        {
            string chuoiKetNoi = "Data Source=.;Initial Catalog=qlht;Integrated Security=True";
            conn.ConnectionString = chuoiKetNoi;
        }
        // hien thi luoi
        private void hienThiLuoi()
        {
            ketNoiDuLieu();
            string sql = "SELECT * FROM XA_PHUONG";
            boDocGhi = new SqlDataAdapter(sql, conn);
            boDocGhi.Fill(bangPhuongXa);
            dgv_phuongXa.DataSource = bangPhuongXa;

        }
        // hien thi combobox
        private void hienCombobox()
        {
            string sql = "SELECT * FROM QUAN_HUYEN";
            boDocQuanHuyen = new SqlDataAdapter(sql, conn);
            boDocQuanHuyen.Fill(bangQuanHuyen);

            cbb_tenQuanHuyen.DataSource = bangQuanHuyen;
            cbb_tenQuanHuyen.DisplayMember = "TENQ_H";
            cbb_tenQuanHuyen.ValueMember = "MAQ_H";

            
        }
        private void Frm_phuongxa_code_Load(object sender, EventArgs e)
        {
            hienThiLuoi();
            hienCombobox();
        }

        private void mAQ_HLabel_Click(object sender, EventArgs e)
        {

        }
        // them
        private void btn_them_Click(object sender, EventArgs e)
        {
            // kiem tra khoa chinh
            string sql = "select * from XA_PHUONG where max_p = '" + txt_maPhuongXa.Text + "'";
            SqlDataAdapter bodoctam = new SqlDataAdapter(sql, conn);
            DataTable bangtam = new DataTable();
            bodoctam.Fill(bangtam);
            if (bangtam.Rows.Count > 0)
            {
                MessageBox.Show("Mã px đã tồn tại! Vui lòng nhập lại!");

            }
            else
            {
                DataRow dongmoi = bangPhuongXa.NewRow();
                dongmoi[0] = txt_maPhuongXa.Text;
                dongmoi[1] = cbb_tenQuanHuyen.SelectedValue.ToString();
                dongmoi[2] = txt_tenPhuongXa.Text;
                bangPhuongXa.Rows.Add(dongmoi);

                capNhat = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(bangPhuongXa);
                bangPhuongXa.Clear();
                hienThiLuoi();
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
  
        }
        // sua
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangPhuongXa.Rows[i][0] = txt_maPhuongXa.Text;
            bangPhuongXa.Rows[i][1] = cbb_tenQuanHuyen.SelectedValue.ToString();
            bangPhuongXa.Rows[i][2] = txt_tenPhuongXa.Text;
            capNhat = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(bangPhuongXa);
            bangPhuongXa.Clear();
            hienThiLuoi();
        }

        private void dgv_phuongXa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                txt_maPhuongXa.Text = bangPhuongXa.Rows[i][0].ToString();
                txt_tenPhuongXa.Text = bangPhuongXa.Rows[i][2].ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bangPhuongXa.Rows[i].Delete();
            try
            {
                capNhat = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(bangPhuongXa);
                bangPhuongXa.Clear();
                hienThiLuoi();
            }
            catch
            {
                bangPhuongXa.Clear();
                hienThiLuoi();
            }
        }

        private void cbb_tenQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
