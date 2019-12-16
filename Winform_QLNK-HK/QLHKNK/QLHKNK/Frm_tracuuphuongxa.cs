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
    public partial class Frm_tracuuphuongxa : Form
    {
        public Frm_tracuuphuongxa()
        {
            InitializeComponent();
        }
        CKetNoiDuLieu ketnoi = new CKetNoiDuLieu();

        private void Tim()
        {
            string sql = "select tenx_p,tenq_h from XA_PHUONG xp,QUAN_HUYEN qh where xp.maq_h = qh.maq_h and tenx_p = '" + txt_tenPhuongXa.Text + "'" ;
            dgv_phuongXa.DataSource = ketnoi.Doc_Du_Lieu(sql);
        }

        private void txt_maPhuongXa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_tracuuphuongxa_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tim();
        }
    }
}
