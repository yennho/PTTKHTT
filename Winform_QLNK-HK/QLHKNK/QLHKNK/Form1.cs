using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHKNK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void nhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hộKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void qHToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void pXToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quậnHuyệncodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_quanhuyen_code qhc = new Frm_quanhuyen_code();
            qhc.Show();
        }

        private void nhânKhẩuCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_nhankhau_code nkc = new Frm_nhankhau_code();
            nkc.Show();
        }

        private void hộKhẩuCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_hokhau_code hkc = new Frm_hokhau_code();
            hkc.Show();
        }

        private void phườngXãCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_phuongxa_code pxc = new Frm_phuongxa_code();
            pxc.Show();
        }

        private void classKNDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void classQuậnHuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmq_quanhuyen_class cqh = new Frmq_quanhuyen_class();
            cqh.Show();
        }

        private void classPhườngXãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_phuongxa_class cpx = new Frm_phuongxa_class();
            cpx.Show();
        }

        private void theoPhườngXãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_tracuuphuongxa frm = new Frm_tracuuphuongxa();
            frm.Show();

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
