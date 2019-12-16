namespace QLHKNK
{
    partial class Frm_quanhuyen_code
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
            this.dgv_quanHuyen = new System.Windows.Forms.DataGridView();
            this.txt_maQuanHuyen = new System.Windows.Forms.TextBox();
            this.txt_tenQuanHuyen = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            mAQ_HLabel = new System.Windows.Forms.Label();
            tENQ_HLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanHuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // mAQ_HLabel
            // 
            mAQ_HLabel.AutoSize = true;
            mAQ_HLabel.Location = new System.Drawing.Point(67, 28);
            mAQ_HLabel.Name = "mAQ_HLabel";
            mAQ_HLabel.Size = new System.Drawing.Size(81, 13);
            mAQ_HLabel.TabIndex = 6;
            mAQ_HLabel.Text = "Mã quận huyện";
            // 
            // tENQ_HLabel
            // 
            tENQ_HLabel.AutoSize = true;
            tENQ_HLabel.Location = new System.Drawing.Point(63, 54);
            tENQ_HLabel.Name = "tENQ_HLabel";
            tENQ_HLabel.Size = new System.Drawing.Size(85, 13);
            tENQ_HLabel.TabIndex = 8;
            tENQ_HLabel.Text = "Tên quận huyện";
            // 
            // dgv_quanHuyen
            // 
            this.dgv_quanHuyen.AllowUserToAddRows = false;
            this.dgv_quanHuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanHuyen.Location = new System.Drawing.Point(44, 99);
            this.dgv_quanHuyen.Name = "dgv_quanHuyen";
            this.dgv_quanHuyen.ReadOnly = true;
            this.dgv_quanHuyen.Size = new System.Drawing.Size(247, 92);
            this.dgv_quanHuyen.TabIndex = 10;
            this.dgv_quanHuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quanHuyen_CellClick);
            this.dgv_quanHuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qUAN_HUYENDataGridView_CellContentClick);
            // 
            // txt_maQuanHuyen
            // 
            this.txt_maQuanHuyen.Location = new System.Drawing.Point(154, 21);
            this.txt_maQuanHuyen.Name = "txt_maQuanHuyen";
            this.txt_maQuanHuyen.Size = new System.Drawing.Size(118, 20);
            this.txt_maQuanHuyen.TabIndex = 7;
            this.txt_maQuanHuyen.TextChanged += new System.EventHandler(this.txt_maQuanHuyen_TextChanged);
            // 
            // txt_tenQuanHuyen
            // 
            this.txt_tenQuanHuyen.Location = new System.Drawing.Point(154, 51);
            this.txt_tenQuanHuyen.Name = "txt_tenQuanHuyen";
            this.txt_tenQuanHuyen.Size = new System.Drawing.Size(118, 20);
            this.txt_tenQuanHuyen.TabIndex = 9;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(98, 216);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(179, 216);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(260, 216);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(12, 216);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lamMoi.TabIndex = 14;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // Frm_quanhuyen_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 293);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_quanHuyen);
            this.Controls.Add(mAQ_HLabel);
            this.Controls.Add(this.txt_maQuanHuyen);
            this.Controls.Add(tENQ_HLabel);
            this.Controls.Add(this.txt_tenQuanHuyen);
            this.Name = "Frm_quanhuyen_code";
            this.Text = "Frm_quanhuyen_code";
            this.Load += new System.EventHandler(this.Frm_quanhuyen_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanHuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_quanHuyen;
        private System.Windows.Forms.TextBox txt_maQuanHuyen;
        private System.Windows.Forms.TextBox txt_tenQuanHuyen;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lamMoi;
    }
}