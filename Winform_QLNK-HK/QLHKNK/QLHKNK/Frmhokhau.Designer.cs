namespace QLHKNK
{
    partial class Frmhokhau
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
            this.dgv_hoKhau = new System.Windows.Forms.DataGridView();
            this.txt_soSo = new System.Windows.Forms.TextBox();
            this.txt_maPhuongXa = new System.Windows.Forms.TextBox();
            this.txt_tenChuHo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            sOSOLabel = new System.Windows.Forms.Label();
            mAX_PLabel = new System.Windows.Forms.Label();
            tENCHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoKhau
            // 
            this.dgv_hoKhau.AllowUserToAddRows = false;
            this.dgv_hoKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoKhau.Location = new System.Drawing.Point(22, 131);
            this.dgv_hoKhau.Name = "dgv_hoKhau";
            this.dgv_hoKhau.ReadOnly = true;
            this.dgv_hoKhau.Size = new System.Drawing.Size(488, 133);
            this.dgv_hoKhau.TabIndex = 38;
            // 
            // sOSOLabel
            // 
            sOSOLabel.AutoSize = true;
            sOSOLabel.Location = new System.Drawing.Point(48, 15);
            sOSOLabel.Name = "sOSOLabel";
            sOSOLabel.Size = new System.Drawing.Size(34, 13);
            sOSOLabel.TabIndex = 26;
            sOSOLabel.Text = "Số sổ";
            // 
            // txt_soSo
            // 
            this.txt_soSo.Location = new System.Drawing.Point(160, 12);
            this.txt_soSo.Name = "txt_soSo";
            this.txt_soSo.Size = new System.Drawing.Size(299, 20);
            this.txt_soSo.TabIndex = 27;
            // 
            // mAX_PLabel
            // 
            mAX_PLabel.AutoSize = true;
            mAX_PLabel.Location = new System.Drawing.Point(48, 57);
            mAX_PLabel.Name = "mAX_PLabel";
            mAX_PLabel.Size = new System.Drawing.Size(75, 13);
            mAX_PLabel.TabIndex = 28;
            mAX_PLabel.Text = "Mã phường xã";
            // 
            // txt_maPhuongXa
            // 
            this.txt_maPhuongXa.Location = new System.Drawing.Point(160, 54);
            this.txt_maPhuongXa.Name = "txt_maPhuongXa";
            this.txt_maPhuongXa.Size = new System.Drawing.Size(299, 20);
            this.txt_maPhuongXa.TabIndex = 29;
            // 
            // tENCHLabel
            // 
            tENCHLabel.AutoSize = true;
            tENCHLabel.Location = new System.Drawing.Point(48, 93);
            tENCHLabel.Name = "tENCHLabel";
            tENCHLabel.Size = new System.Drawing.Size(62, 13);
            tENCHLabel.TabIndex = 30;
            tENCHLabel.Text = "Tên chủ hộ";
            // 
            // txt_tenChuHo
            // 
            this.txt_tenChuHo.Location = new System.Drawing.Point(160, 90);
            this.txt_tenChuHo.Name = "txt_tenChuHo";
            this.txt_tenChuHo.Size = new System.Drawing.Size(299, 20);
            this.txt_tenChuHo.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frmhokhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_hoKhau);
            this.Controls.Add(sOSOLabel);
            this.Controls.Add(this.txt_soSo);
            this.Controls.Add(mAX_PLabel);
            this.Controls.Add(this.txt_maPhuongXa);
            this.Controls.Add(tENCHLabel);
            this.Controls.Add(this.txt_tenChuHo);
            this.Name = "Frmhokhau";
            this.Text = "Frmhokhau";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hoKhau;
        private System.Windows.Forms.TextBox txt_soSo;
        private System.Windows.Forms.TextBox txt_maPhuongXa;
        private System.Windows.Forms.TextBox txt_tenChuHo;
        private System.Windows.Forms.Button button1;
    }
}