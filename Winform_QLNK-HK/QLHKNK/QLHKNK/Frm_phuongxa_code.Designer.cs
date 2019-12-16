namespace QLHKNK
{
    partial class Frm_phuongxa_code
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
            System.Windows.Forms.Label mAQ_HLabel;
            System.Windows.Forms.Label tENQ_HLabel;
            System.Windows.Forms.Label label1;
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_phuongXa = new System.Windows.Forms.DataGridView();
            this.txt_maPhuongXa = new System.Windows.Forms.TextBox();
            this.txt_tenPhuongXa = new System.Windows.Forms.TextBox();
            this.cbb_tenQuanHuyen = new System.Windows.Forms.ComboBox();
            mAQ_HLabel = new System.Windows.Forms.Label();
            tENQ_HLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phuongXa)).BeginInit();
            this.SuspendLayout();
            // 
            // mAQ_HLabel
            // 
            mAQ_HLabel.AutoSize = true;
            mAQ_HLabel.Location = new System.Drawing.Point(63, 16);
            mAQ_HLabel.Name = "mAQ_HLabel";
            mAQ_HLabel.Size = new System.Drawing.Size(75, 13);
            mAQ_HLabel.TabIndex = 15;
            mAQ_HLabel.Text = "Mã phường xã";
            mAQ_HLabel.Click += new System.EventHandler(this.mAQ_HLabel_Click);
            // 
            // tENQ_HLabel
            // 
            tENQ_HLabel.AutoSize = true;
            tENQ_HLabel.Location = new System.Drawing.Point(59, 42);
            tENQ_HLabel.Name = "tENQ_HLabel";
            tENQ_HLabel.Size = new System.Drawing.Size(79, 13);
            tENQ_HLabel.TabIndex = 17;
            tENQ_HLabel.Text = "Tên phường xã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(59, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 25;
            label1.Text = "Tên quận huyện";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(11, 243);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lamMoi.TabIndex = 23;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(259, 243);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(178, 243);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(97, 243);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_phuongXa
            // 
            this.dgv_phuongXa.AllowUserToAddRows = false;
            this.dgv_phuongXa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phuongXa.Location = new System.Drawing.Point(12, 102);
            this.dgv_phuongXa.Name = "dgv_phuongXa";
            this.dgv_phuongXa.ReadOnly = true;
            this.dgv_phuongXa.Size = new System.Drawing.Size(322, 125);
            this.dgv_phuongXa.TabIndex = 19;
            this.dgv_phuongXa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phuongXa_CellClick);
            // 
            // txt_maPhuongXa
            // 
            this.txt_maPhuongXa.Location = new System.Drawing.Point(150, 13);
            this.txt_maPhuongXa.Name = "txt_maPhuongXa";
            this.txt_maPhuongXa.Size = new System.Drawing.Size(118, 20);
            this.txt_maPhuongXa.TabIndex = 16;
            // 
            // txt_tenPhuongXa
            // 
            this.txt_tenPhuongXa.Location = new System.Drawing.Point(150, 39);
            this.txt_tenPhuongXa.Name = "txt_tenPhuongXa";
            this.txt_tenPhuongXa.Size = new System.Drawing.Size(118, 20);
            this.txt_tenPhuongXa.TabIndex = 18;
            // 
            // cbb_tenQuanHuyen
            // 
            this.cbb_tenQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tenQuanHuyen.FormattingEnabled = true;
            this.cbb_tenQuanHuyen.Location = new System.Drawing.Point(150, 65);
            this.cbb_tenQuanHuyen.Name = "cbb_tenQuanHuyen";
            this.cbb_tenQuanHuyen.Size = new System.Drawing.Size(121, 21);
            this.cbb_tenQuanHuyen.TabIndex = 24;
            this.cbb_tenQuanHuyen.SelectedIndexChanged += new System.EventHandler(this.cbb_tenQuanHuyen_SelectedIndexChanged);
            // 
            // Frm_phuongxa_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 293);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbb_tenQuanHuyen);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_phuongXa);
            this.Controls.Add(mAQ_HLabel);
            this.Controls.Add(this.txt_maPhuongXa);
            this.Controls.Add(tENQ_HLabel);
            this.Controls.Add(this.txt_tenPhuongXa);
            this.Name = "Frm_phuongxa_code";
            this.Text = "Frm_phuongxa_code";
            this.Load += new System.EventHandler(this.Frm_phuongxa_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phuongXa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_phuongXa;
        private System.Windows.Forms.TextBox txt_maPhuongXa;
        private System.Windows.Forms.TextBox txt_tenPhuongXa;
        private System.Windows.Forms.ComboBox cbb_tenQuanHuyen;
    }
}