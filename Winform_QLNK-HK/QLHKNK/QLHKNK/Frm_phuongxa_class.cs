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
    public partial class Frm_phuongxa_class : Form
    {
        SqlDataAdapter boDocGhi;
        int i;
        public Frm_phuongxa_class()
        {
            InitializeComponent();
        }

        CKetNoiDuLieu ketnoi = new CKetNoiDuLieu();
        DataTable bangPhuongXa = new DataTable();
        // hien thi luoi
        private void hienThiLuoi()
        {
            string sql = "select * from XA_PHUONG";
            //
            bangPhuongXa = ketnoi.Doc_Du_Lieu(sql);
            boDocGhi = ketnoi.bodocghi;
            dgv_phuongXa.DataSource = ketnoi.Doc_Du_Lieu(sql);
        }

        DataTable bangQuanHuyen = new DataTable();
        private void hienCombobox()
        {
            string sql = "SELECT * FROM QUAN_HUYEN";
            bangQuanHuyen = ketnoi.Doc_Du_Lieu(sql);
            cbb_tenQuanHuyen.DataSource = bangQuanHuyen;
            cbb_tenQuanHuyen.DisplayMember = "TENQ_H";
            cbb_tenQuanHuyen.ValueMember = "MAQ_H";
        }

        private void txt_maPhuongXa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maPhuongXa.Clear();
            txt_tenPhuongXa.Clear();
            txt_maPhuongXa.Enabled = true;
        }

        private void Frm_phuongxa_class_Load(object sender, EventArgs e)
        {
            hienThiLuoi();
            hienCombobox();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow dongmoi = bangPhuongXa.NewRow();
            dongmoi[0] = txt_maPhuongXa.Text;
            dongmoi[1] = cbb_tenQuanHuyen.SelectedValue.ToString();
            dongmoi[2] = txt_tenPhuongXa.Text;
            bangPhuongXa.Rows.Add(dongmoi);

            ketnoi.Cap_Nhat(bangPhuongXa, boDocGhi);
            bangPhuongXa.Clear();
            hienThiLuoi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangPhuongXa.Rows[i][0] = txt_maPhuongXa.Text;
            bangPhuongXa.Rows[i][1] = cbb_tenQuanHuyen.SelectedValue;
            bangPhuongXa.Rows[i][2] = txt_tenPhuongXa.Text;
            ketnoi.Cap_Nhat(bangPhuongXa, boDocGhi);
            bangPhuongXa.Clear();
            hienThiLuoi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bangPhuongXa.Rows[i].Delete();
            try
            {
                ketnoi.Cap_Nhat(bangPhuongXa, boDocGhi);
                bangPhuongXa.Clear();
                hienThiLuoi();
            }
            catch
            {
                bangPhuongXa.Clear();
                hienThiLuoi();
            }
        }
    }
}
