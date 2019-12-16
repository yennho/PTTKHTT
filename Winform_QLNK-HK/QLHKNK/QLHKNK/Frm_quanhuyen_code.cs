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
    public partial class Frm_quanhuyen_code : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter boDocGhi;
        DataTable bangQuanHuyen = new DataTable();
        SqlCommandBuilder capNhat;
        int i;
        public Frm_quanhuyen_code()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dongmoi = bangQuanHuyen.NewRow();
            dongmoi[0] = txt_maQuanHuyen.Text;
            dongmoi[1] = txt_tenQuanHuyen.Text;
            bangQuanHuyen.Rows.Add(dongmoi);

            capNhat = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(bangQuanHuyen);
            bangQuanHuyen.Clear();
            hienThiLuoi();

        }

        private void qUAN_HUYENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void ketNoiDuLieu ()
        {
            string chuoiKetNoi = "Data Source=.;Initial Catalog=qlht;Integrated Security=True";
            conn.ConnectionString = chuoiKetNoi;
        }

        private void hienThiLuoi()
        {
            ketNoiDuLieu();
            string sql = "SELECT * FROM QUAN_HUYEN";
            boDocGhi = new SqlDataAdapter(sql, conn);
            boDocGhi.Fill(bangQuanHuyen);
            dgv_quanHuyen.DataSource = bangQuanHuyen;
            
        }
        private void Frm_quanhuyen_code_Load(object sender, EventArgs e)
        {
            hienThiLuoi();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maQuanHuyen.Clear();
            txt_tenQuanHuyen.Clear();
            txt_maQuanHuyen.Enabled = true;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bangQuanHuyen.Rows[i].Delete();
            try
            {
                capNhat = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(bangQuanHuyen);
                bangQuanHuyen.Clear();
                hienThiLuoi();
            }
            catch
            {
                bangQuanHuyen.Clear();
                hienThiLuoi();
            }
            
        }

        private void dgv_quanHuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if(i>=0)
            {
                txt_maQuanHuyen.Text = bangQuanHuyen.Rows[i][0].ToString();
                txt_tenQuanHuyen.Text = bangQuanHuyen.Rows[i][1].ToString();
                txt_maQuanHuyen.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangQuanHuyen.Rows[i][0] = txt_maQuanHuyen.Text;
            bangQuanHuyen.Rows[i][1] = txt_tenQuanHuyen.Text;
            capNhat = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(bangQuanHuyen);
            bangQuanHuyen.Clear();
            hienThiLuoi();
        }

        private void txt_maQuanHuyen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
