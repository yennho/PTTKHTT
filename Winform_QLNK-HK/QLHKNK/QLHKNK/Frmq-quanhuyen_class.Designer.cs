namespace QLHKNK
{
    partial class Frmq_quanhuyen_class
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
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_quanHuyen = new System.Windows.Forms.DataGridView();
            this.txt_maQuanHuyen = new System.Windows.Forms.TextBox();
            this.txt_tenQuanHuyen = new System.Windows.Forms.TextBox();
            mAQ_HLabel = new System.Windows.Forms.Label();
            tENQ_HLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanHuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(18, 217);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lamMoi.TabIndex = 23;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(266, 217);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(185, 217);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(104, 217);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_quanHuyen
            // 
            this.dgv_quanHuyen.AllowUserToAddRows = false;
            this.dgv_quanHuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanHuyen.Location = new System.Drawing.Point(50, 100);
            this.dgv_quanHuyen.Name = "dgv_quanHuyen";
            this.dgv_quanHuyen.ReadOnly = true;
            this.dgv_quanHuyen.Size = new System.Drawing.Size(247, 92);
            this.dgv_quanHuyen.TabIndex = 19;
            // 
            // mAQ_HLabel
            // 
            mAQ_HLabel.AutoSize = true;
            mAQ_HLabel.Location = new System.Drawing.Point(73, 29);
            mAQ_HLabel.Name = "mAQ_HLabel";
            mAQ_HLabel.Size = new System.Drawing.Size(81, 13);
            mAQ_HLabel.TabIndex = 15;
            mAQ_HLabel.Text = "Mã quận huyện";
            // 
            // txt_maQuanHuyen
            // 
            this.txt_maQuanHuyen.Location = new System.Drawing.Point(160, 22);
            this.txt_maQuanHuyen.Name = "txt_maQuanHuyen";
            this.txt_maQuanHuyen.Size = new System.Drawing.Size(118, 20);
            this.txt_maQuanHuyen.TabIndex = 16;
            this.txt_maQuanHuyen.TextChanged += new System.EventHandler(this.txt_maQuanHuyen_TextChanged);
            // 
            // tENQ_HLabel
            // 
            tENQ_HLabel.AutoSize = true;
            tENQ_HLabel.Location = new System.Drawing.Point(69, 55);
            tENQ_HLabel.Name = "tENQ_HLabel";
            tENQ_HLabel.Size = new System.Drawing.Size(85, 13);
            tENQ_HLabel.TabIndex = 17;
            tENQ_HLabel.Text = "Tên quận huyện";
            // 
            // txt_tenQuanHuyen
            // 
            this.txt_tenQuanHuyen.Location = new System.Drawing.Point(160, 52);
            this.txt_tenQuanHuyen.Name = "txt_tenQuanHuyen";
            this.txt_tenQuanHuyen.Size = new System.Drawing.Size(118, 20);
            this.txt_tenQuanHuyen.TabIndex = 18;
            this.txt_tenQuanHuyen.TextChanged += new System.EventHandler(this.txt_tenQuanHuyen_TextChanged);
            // 
            // Frmq_quanhuyen_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 270);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_quanHuyen);
            this.Controls.Add(mAQ_HLabel);
            this.Controls.Add(this.txt_maQuanHuyen);
            this.Controls.Add(tENQ_HLabel);
            this.Controls.Add(this.txt_tenQuanHuyen);
            this.Name = "Frmq_quanhuyen_class";
            this.Text = "Frmq_quanhuyen_class";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanHuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_quanHuyen;
        private System.Windows.Forms.TextBox txt_maQuanHuyen;
        private System.Windows.Forms.TextBox txt_tenQuanHuyen;
    }
}