namespace QLHKNK
{
    partial class Frm_tracuuphuongxa
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tENQ_HLabel;
            this.cbb_tenQuanHuyen = new System.Windows.Forms.ComboBox();
            this.dgv_phuongXa = new System.Windows.Forms.DataGridView();
            this.txt_tenPhuongXa = new System.Windows.Forms.TextBox();
            this.bttracuu = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tENQ_HLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phuongXa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(117, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 32;
            label1.Text = "Tên quận huyện";
            // 
            // cbb_tenQuanHuyen
            // 
            this.cbb_tenQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tenQuanHuyen.FormattingEnabled = true;
            this.cbb_tenQuanHuyen.Location = new System.Drawing.Point(208, 68);
            this.cbb_tenQuanHuyen.Name = "cbb_tenQuanHuyen";
            this.cbb_tenQuanHuyen.Size = new System.Drawing.Size(118, 21);
            this.cbb_tenQuanHuyen.TabIndex = 31;
            // 
            // dgv_phuongXa
            // 
            this.dgv_phuongXa.AllowUserToAddRows = false;
            this.dgv_phuongXa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phuongXa.Location = new System.Drawing.Point(50, 113);
            this.dgv_phuongXa.Name = "dgv_phuongXa";
            this.dgv_phuongXa.ReadOnly = true;
            this.dgv_phuongXa.Size = new System.Drawing.Size(370, 125);
            this.dgv_phuongXa.TabIndex = 30;
            // 
            // tENQ_HLabel
            // 
            tENQ_HLabel.AutoSize = true;
            tENQ_HLabel.Location = new System.Drawing.Point(117, 20);
            tENQ_HLabel.Name = "tENQ_HLabel";
            tENQ_HLabel.Size = new System.Drawing.Size(79, 13);
            tENQ_HLabel.TabIndex = 28;
            tENQ_HLabel.Text = "Tên phường xã";
            // 
            // txt_tenPhuongXa
            // 
            this.txt_tenPhuongXa.Location = new System.Drawing.Point(208, 20);
            this.txt_tenPhuongXa.Name = "txt_tenPhuongXa";
            this.txt_tenPhuongXa.Size = new System.Drawing.Size(118, 20);
            this.txt_tenPhuongXa.TabIndex = 29;
            // 
            // bttracuu
            // 
            this.bttracuu.Location = new System.Drawing.Point(304, 257);
            this.bttracuu.Name = "bttracuu";
            this.bttracuu.Size = new System.Drawing.Size(75, 23);
            this.bttracuu.TabIndex = 33;
            this.bttracuu.Text = "Tra cứu";
            this.bttracuu.UseVisualStyleBackColor = true;
            this.bttracuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_tracuuphuongxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 292);
            this.Controls.Add(this.bttracuu);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbb_tenQuanHuyen);
            this.Controls.Add(this.dgv_phuongXa);
            this.Controls.Add(tENQ_HLabel);
            this.Controls.Add(this.txt_tenPhuongXa);
            this.Name = "Frm_tracuuphuongxa";
            this.Text = "Frm_tracuuphuongxa";
            this.Load += new System.EventHandler(this.Frm_tracuuphuongxa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phuongXa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_tenQuanHuyen;
        private System.Windows.Forms.DataGridView dgv_phuongXa;
        private System.Windows.Forms.TextBox txt_tenPhuongXa;
        private System.Windows.Forms.Button bttracuu;
    }
}