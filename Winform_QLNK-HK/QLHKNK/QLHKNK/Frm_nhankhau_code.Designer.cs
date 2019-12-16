namespace QLHKNK
{
    partial class Frm_nhankhau_code
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
            System.Windows.Forms.Label sTTNHANKHAULabel;
            System.Windows.Forms.Label sOSOLabel;
            System.Windows.Forms.Label hOTENNKLabel;
            System.Windows.Forms.Label gTINHLabel;
            System.Windows.Forms.Label nSINHLabel;
            this.txt_sttNhanKhau = new System.Windows.Forms.TextBox();
            this.txt_soSo = new System.Windows.Forms.TextBox();
            this.txt_hoTenNhanKhau = new System.Windows.Forms.TextBox();
            this.txt_gioiTinh = new System.Windows.Forms.TextBox();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgv_nhanKhau = new System.Windows.Forms.DataGridView();
            this.btn_xóa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            sTTNHANKHAULabel = new System.Windows.Forms.Label();
            sOSOLabel = new System.Windows.Forms.Label();
            hOTENNKLabel = new System.Windows.Forms.Label();
            gTINHLabel = new System.Windows.Forms.Label();
            nSINHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // sTTNHANKHAULabel
            // 
            sTTNHANKHAULabel.AutoSize = true;
            sTTNHANKHAULabel.Location = new System.Drawing.Point(31, 23);
            sTTNHANKHAULabel.Name = "sTTNHANKHAULabel";
            sTTNHANKHAULabel.Size = new System.Drawing.Size(82, 13);
            sTTNHANKHAULabel.TabIndex = 11;
            sTTNHANKHAULabel.Text = "STT nhân khẩu";
            // 
            // sOSOLabel
            // 
            sOSOLabel.AutoSize = true;
            sOSOLabel.Location = new System.Drawing.Point(79, 49);
            sOSOLabel.Name = "sOSOLabel";
            sOSOLabel.Size = new System.Drawing.Size(34, 13);
            sOSOLabel.TabIndex = 13;
            sOSOLabel.Text = "Sổ sổ";
            // 
            // hOTENNKLabel
            // 
            hOTENNKLabel.AutoSize = true;
            hOTENNKLabel.Location = new System.Drawing.Point(20, 75);
            hOTENNKLabel.Name = "hOTENNKLabel";
            hOTENNKLabel.Size = new System.Drawing.Size(93, 13);
            hOTENNKLabel.TabIndex = 15;
            hOTENNKLabel.Text = "Họ tên nhân khẩu";
            // 
            // gTINHLabel
            // 
            gTINHLabel.AutoSize = true;
            gTINHLabel.Location = new System.Drawing.Point(66, 101);
            gTINHLabel.Name = "gTINHLabel";
            gTINHLabel.Size = new System.Drawing.Size(47, 13);
            gTINHLabel.TabIndex = 17;
            gTINHLabel.Text = "Giới tính";
            // 
            // nSINHLabel
            // 
            nSINHLabel.AutoSize = true;
            nSINHLabel.Location = new System.Drawing.Point(59, 130);
            nSINHLabel.Name = "nSINHLabel";
            nSINHLabel.Size = new System.Drawing.Size(54, 13);
            nSINHLabel.TabIndex = 19;
            nSINHLabel.Text = "Ngày sinh";
            // 
            // txt_sttNhanKhau
            // 
            this.txt_sttNhanKhau.Location = new System.Drawing.Point(129, 20);
            this.txt_sttNhanKhau.Name = "txt_sttNhanKhau";
            this.txt_sttNhanKhau.Size = new System.Drawing.Size(184, 20);
            this.txt_sttNhanKhau.TabIndex = 12;
            this.txt_sttNhanKhau.Text = "111";
            // 
            // txt_soSo
            // 
            this.txt_soSo.Location = new System.Drawing.Point(129, 46);
            this.txt_soSo.Name = "txt_soSo";
            this.txt_soSo.Size = new System.Drawing.Size(184, 20);
            this.txt_soSo.TabIndex = 14;
            // 
            // txt_hoTenNhanKhau
            // 
            this.txt_hoTenNhanKhau.Location = new System.Drawing.Point(129, 72);
            this.txt_hoTenNhanKhau.Name = "txt_hoTenNhanKhau";
            this.txt_hoTenNhanKhau.Size = new System.Drawing.Size(184, 20);
            this.txt_hoTenNhanKhau.TabIndex = 16;
            this.txt_hoTenNhanKhau.TextChanged += new System.EventHandler(this.txt_hoTenNhanKhau_TextChanged);
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.Location = new System.Drawing.Point(129, 98);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(184, 20);
            this.txt_gioiTinh.TabIndex = 18;
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.Location = new System.Drawing.Point(129, 124);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(184, 20);
            this.dtp_ngaySinh.TabIndex = 20;
            this.dtp_ngaySinh.ValueChanged += new System.EventHandler(this.nSINHDateTimePicker_ValueChanged);
            // 
            // dgv_nhanKhau
            // 
            this.dgv_nhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanKhau.Location = new System.Drawing.Point(23, 159);
            this.dgv_nhanKhau.Name = "dgv_nhanKhau";
            this.dgv_nhanKhau.Size = new System.Drawing.Size(424, 92);
            this.dgv_nhanKhau.TabIndex = 21;
            // 
            // btn_xóa
            // 
            this.btn_xóa.Location = new System.Drawing.Point(360, 270);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(75, 23);
            this.btn_xóa.TabIndex = 24;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(238, 270);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 23;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(119, 270);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(12, 270);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.TabIndex = 25;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // Frm_nhankhau_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_nhanKhau);
            this.Controls.Add(sTTNHANKHAULabel);
            this.Controls.Add(this.txt_sttNhanKhau);
            this.Controls.Add(sOSOLabel);
            this.Controls.Add(this.txt_soSo);
            this.Controls.Add(hOTENNKLabel);
            this.Controls.Add(this.txt_hoTenNhanKhau);
            this.Controls.Add(gTINHLabel);
            this.Controls.Add(this.txt_gioiTinh);
            this.Controls.Add(nSINHLabel);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Name = "Frm_nhankhau_code";
            this.Text = "Frm_nhankhau_code";
            this.Load += new System.EventHandler(this.Frm_nhankhau_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sttNhanKhau;
        private System.Windows.Forms.TextBox txt_soSo;
        private System.Windows.Forms.TextBox txt_hoTenNhanKhau;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.DataGridView dgv_nhanKhau;
        private System.Windows.Forms.Button btn_xóa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lammoi;
    }
}