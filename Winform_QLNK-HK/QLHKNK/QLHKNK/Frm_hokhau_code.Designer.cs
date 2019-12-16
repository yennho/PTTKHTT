namespace QLHKNK
{
    partial class Frm_hokhau_code
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label sOSOLabel;
            System.Windows.Forms.Label mAX_PLabel;
            System.Windows.Forms.Label tENCHLabel;
            System.Windows.Forms.Label sONHALabel;
            System.Windows.Forms.Label tENDPLabel;
            System.Windows.Forms.Label kHUPHOLabel;
            this.txt_soSo = new System.Windows.Forms.TextBox();
            this.txt_maPhuongXa = new System.Windows.Forms.TextBox();
            this.txt_tenChuHo = new System.Windows.Forms.TextBox();
            this.txt_soNha = new System.Windows.Forms.TextBox();
            this.txt_tenDuongPho = new System.Windows.Forms.TextBox();
            this.txt_khuPho = new System.Windows.Forms.TextBox();
            this.btn_xóa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_hoKhau = new System.Windows.Forms.DataGridView();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            sOSOLabel = new System.Windows.Forms.Label();
            mAX_PLabel = new System.Windows.Forms.Label();
            tENCHLabel = new System.Windows.Forms.Label();
            sONHALabel = new System.Windows.Forms.Label();
            tENDPLabel = new System.Windows.Forms.Label();
            kHUPHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // sOSOLabel
            // 
            sOSOLabel.AutoSize = true;
            sOSOLabel.Location = new System.Drawing.Point(98, 13);
            sOSOLabel.Name = "sOSOLabel";
            sOSOLabel.Size = new System.Drawing.Size(34, 13);
            sOSOLabel.TabIndex = 13;
            sOSOLabel.Text = "Số sổ";
            // 
            // mAX_PLabel
            // 
            mAX_PLabel.AutoSize = true;
            mAX_PLabel.Location = new System.Drawing.Point(57, 39);
            mAX_PLabel.Name = "mAX_PLabel";
            mAX_PLabel.Size = new System.Drawing.Size(75, 13);
            mAX_PLabel.TabIndex = 15;
            mAX_PLabel.Text = "Mã phường xã";
            // 
            // tENCHLabel
            // 
            tENCHLabel.AutoSize = true;
            tENCHLabel.Location = new System.Drawing.Point(70, 65);
            tENCHLabel.Name = "tENCHLabel";
            tENCHLabel.Size = new System.Drawing.Size(62, 13);
            tENCHLabel.TabIndex = 17;
            tENCHLabel.Text = "Tên chủ hộ";
            // 
            // sONHALabel
            // 
            sONHALabel.AutoSize = true;
            sONHALabel.Location = new System.Drawing.Point(91, 91);
            sONHALabel.Name = "sONHALabel";
            sONHALabel.Size = new System.Drawing.Size(41, 13);
            sONHALabel.TabIndex = 19;
            sONHALabel.Text = "Số nhà";
            // 
            // tENDPLabel
            // 
            tENDPLabel.AutoSize = true;
            tENDPLabel.Location = new System.Drawing.Point(51, 117);
            tENDPLabel.Name = "tENDPLabel";
            tENDPLabel.Size = new System.Drawing.Size(81, 13);
            tENDPLabel.TabIndex = 21;
            tENDPLabel.Text = "Tên đường phố";
            // 
            // kHUPHOLabel
            // 
            kHUPHOLabel.AutoSize = true;
            kHUPHOLabel.Location = new System.Drawing.Point(85, 143);
            kHUPHOLabel.Name = "kHUPHOLabel";
            kHUPHOLabel.Size = new System.Drawing.Size(47, 13);
            kHUPHOLabel.TabIndex = 23;
            kHUPHOLabel.Text = "Khu phố";
            // 
            // txt_soSo
            // 
            this.txt_soSo.Location = new System.Drawing.Point(147, 10);
            this.txt_soSo.Name = "txt_soSo";
            this.txt_soSo.Size = new System.Drawing.Size(156, 20);
            this.txt_soSo.TabIndex = 14;
            // 
            // txt_maPhuongXa
            // 
            this.txt_maPhuongXa.Location = new System.Drawing.Point(147, 36);
            this.txt_maPhuongXa.Name = "txt_maPhuongXa";
            this.txt_maPhuongXa.Size = new System.Drawing.Size(156, 20);
            this.txt_maPhuongXa.TabIndex = 16;
            this.txt_maPhuongXa.TextChanged += new System.EventHandler(this.txt_maPhuongXa_TextChanged);
            // 
            // txt_tenChuHo
            // 
            this.txt_tenChuHo.Location = new System.Drawing.Point(147, 62);
            this.txt_tenChuHo.Name = "txt_tenChuHo";
            this.txt_tenChuHo.Size = new System.Drawing.Size(156, 20);
            this.txt_tenChuHo.TabIndex = 18;
            // 
            // txt_soNha
            // 
            this.txt_soNha.Location = new System.Drawing.Point(147, 88);
            this.txt_soNha.Name = "txt_soNha";
            this.txt_soNha.Size = new System.Drawing.Size(156, 20);
            this.txt_soNha.TabIndex = 20;
            // 
            // txt_tenDuongPho
            // 
            this.txt_tenDuongPho.Location = new System.Drawing.Point(147, 114);
            this.txt_tenDuongPho.Name = "txt_tenDuongPho";
            this.txt_tenDuongPho.Size = new System.Drawing.Size(156, 20);
            this.txt_tenDuongPho.TabIndex = 22;
            // 
            // txt_khuPho
            // 
            this.txt_khuPho.Location = new System.Drawing.Point(147, 140);
            this.txt_khuPho.Name = "txt_khuPho";
            this.txt_khuPho.Size = new System.Drawing.Size(156, 20);
            this.txt_khuPho.TabIndex = 24;
            // 
            // btn_xóa
            // 
            this.btn_xóa.Location = new System.Drawing.Point(289, 279);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(75, 23);
            this.btn_xóa.TabIndex = 28;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(194, 279);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(101, 279);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_hoKhau
            // 
            this.dgv_hoKhau.AllowUserToAddRows = false;
            this.dgv_hoKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoKhau.Location = new System.Drawing.Point(37, 168);
            this.dgv_hoKhau.Name = "dgv_hoKhau";
            this.dgv_hoKhau.ReadOnly = true;
            this.dgv_hoKhau.Size = new System.Drawing.Size(295, 92);
            this.dgv_hoKhau.TabIndex = 25;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(12, 279);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lamMoi.TabIndex = 29;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // Frm_hokhau_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 327);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_hoKhau);
            this.Controls.Add(sOSOLabel);
            this.Controls.Add(this.txt_soSo);
            this.Controls.Add(mAX_PLabel);
            this.Controls.Add(this.txt_maPhuongXa);
            this.Controls.Add(tENCHLabel);
            this.Controls.Add(this.txt_tenChuHo);
            this.Controls.Add(sONHALabel);
            this.Controls.Add(this.txt_soNha);
            this.Controls.Add(tENDPLabel);
            this.Controls.Add(this.txt_tenDuongPho);
            this.Controls.Add(kHUPHOLabel);
            this.Controls.Add(this.txt_khuPho);
            this.Name = "Frm_hokhau_code";
            this.Text = "Frm_hokhau_code";
            this.Load += new System.EventHandler(this.Frm_hokhau_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_soSo;
        private System.Windows.Forms.TextBox txt_maPhuongXa;
        private System.Windows.Forms.TextBox txt_tenChuHo;
        private System.Windows.Forms.TextBox txt_soNha;
        private System.Windows.Forms.TextBox txt_tenDuongPho;
        private System.Windows.Forms.TextBox txt_khuPho;
        private System.Windows.Forms.Button btn_xóa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_hoKhau;
        private System.Windows.Forms.Button btn_lamMoi;
    }
}