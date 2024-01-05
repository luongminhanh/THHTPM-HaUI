
namespace Dom
{
    partial class Form1
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.cbGoiDi = new System.Windows.Forms.ComboBox();
            this.txtGoiDen = new System.Windows.Forms.TextBox();
            this.txtNgayGoi = new System.Windows.Forms.TextBox();
            this.txtSoPhut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(742, 70);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(208, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "button1";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(742, 142);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(208, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "button2";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(742, 213);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(208, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "button3";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(742, 288);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(208, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "button4";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(112, 386);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(890, 231);
            this.dgv1.TabIndex = 4;
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(340, 70);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(297, 26);
            this.cbChiNhanh.TabIndex = 5;
            // 
            // cbGoiDi
            // 
            this.cbGoiDi.FormattingEnabled = true;
            this.cbGoiDi.Location = new System.Drawing.Point(340, 120);
            this.cbGoiDi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGoiDi.Name = "cbGoiDi";
            this.cbGoiDi.Size = new System.Drawing.Size(297, 26);
            this.cbGoiDi.TabIndex = 6;
            // 
            // txtGoiDen
            // 
            this.txtGoiDen.Location = new System.Drawing.Point(344, 175);
            this.txtGoiDen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGoiDen.Name = "txtGoiDen";
            this.txtGoiDen.Size = new System.Drawing.Size(292, 24);
            this.txtGoiDen.TabIndex = 7;
            // 
            // txtNgayGoi
            // 
            this.txtNgayGoi.Location = new System.Drawing.Point(346, 237);
            this.txtNgayGoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgayGoi.Name = "txtNgayGoi";
            this.txtNgayGoi.Size = new System.Drawing.Size(292, 24);
            this.txtNgayGoi.TabIndex = 8;
            // 
            // txtSoPhut
            // 
            this.txtSoPhut.Location = new System.Drawing.Point(346, 288);
            this.txtSoPhut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoPhut.Name = "txtSoPhut";
            this.txtSoPhut.Size = new System.Drawing.Size(292, 24);
            this.txtSoPhut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số gọi đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số gọi đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày gọi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số phút";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoPhut);
            this.Controls.Add(this.txtNgayGoi);
            this.Controls.Add(this.txtGoiDen);
            this.Controls.Add(this.cbGoiDi);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.ComboBox cbGoiDi;
        private System.Windows.Forms.TextBox txtGoiDen;
        private System.Windows.Forms.TextBox txtNgayGoi;
        private System.Windows.Forms.TextBox txtSoPhut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

