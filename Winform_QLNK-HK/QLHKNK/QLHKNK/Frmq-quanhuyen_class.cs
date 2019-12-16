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
using System.Data;

namespace QLHKNK
{
    public partial class Frmq_quanhuyen_class : Form
    {
      
        SqlDataAdapter boDocGhi;
       // SqlDataAdapter capnhat;
        int i;
        public Frmq_quanhuyen_class()
        {
            InitializeComponent();
        }
        CKetNoiDuLieu ketnoi = new CKetNoiDuLieu();
        DataTable bangQuanHuyen = new DataTable();
        // hien thi luoi
        private void hienThiLuoi()
        {
            string sql = "select * from QUAN_HUYEN";
            //
            bangQuanHuyen = ketnoi.Doc_Du_Lieu(sql);
            boDocGhi = ketnoi.bodocghi;

            dgv_quanHuyen.DataSource = ketnoi.Doc_Du_Lieu(sql);
        }
        private void txt_maQuanHuyen_TextChanged(object sender, EventArgs e)
        {
            hienThiLuoi();
        }

        private void txt_tenQuanHuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maQuanHuyen.Clear();
            txt_tenQuanHuyen.Clear();
            txt_maQuanHuyen.Enabled = true;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow dongmoi = bangQuanHuyen.NewRow();
            dongmoi[0] = txt_maQuanHuyen.Text;
            dongmoi[1] = txt_tenQuanHuyen.Text;
            bangQuanHuyen.Rows.Add(dongmoi);

            ketnoi.Cap_Nhat(bangQuanHuyen, boDocGhi);
            bangQuanHuyen.Clear();
            hienThiLuoi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangQuanHuyen.Rows[i][0] = txt_maQuanHuyen.Text;
            bangQuanHuyen.Rows[i][1] = txt_tenQuanHuyen.Text;
            ketnoi.Cap_Nhat(bangQuanHuyen, boDocGhi);
            bangQuanHuyen.Clear();
            hienThiLuoi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bangQuanHuyen.Rows[i].Delete();
            try
            {
                ketnoi.Cap_Nhat(bangQuanHuyen, boDocGhi);
                bangQuanHuyen.Clear();
                hienThiLuoi();
            }
            catch
            {
                bangQuanHuyen.Clear();
                hienThiLuoi();
            }
        }
    }
}
