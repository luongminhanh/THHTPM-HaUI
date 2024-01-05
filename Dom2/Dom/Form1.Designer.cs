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
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.cbGoiDi = new System.Windows.Forms.ComboBox();
            this.lvCuocGoi = new System.Windows.Forms.ListView();
            this.txtGoiDen = new System.Windows.Forms.TextBox();
            this.txtNgayGoi = new System.Windows.Forms.TextBox();
            this.txtSoPhut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chinhanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sodien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sogoiden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaygoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sophut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(555, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(555, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(555, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(555, 206);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(276, 43);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(212, 21);
            this.cbChiNhanh.TabIndex = 4;
            // 
            // cbGoiDi
            // 
            this.cbGoiDi.FormattingEnabled = true;
            this.cbGoiDi.Location = new System.Drawing.Point(276, 85);
            this.cbGoiDi.Name = "cbGoiDi";
            this.cbGoiDi.Size = new System.Drawing.Size(212, 21);
            this.cbGoiDi.TabIndex = 5;
            // 
            // lvCuocGoi
            // 
            this.lvCuocGoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCuocGoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvCuocGoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCuocGoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chinhanh,
            this.sodien,
            this.sogoiden,
            this.ngaygoi,
            this.sophut});
            this.lvCuocGoi.ForeColor = System.Drawing.Color.Black;
            this.lvCuocGoi.GridLines = true;
            this.lvCuocGoi.HideSelection = false;
            this.lvCuocGoi.Location = new System.Drawing.Point(88, 273);
            this.lvCuocGoi.Name = "lvCuocGoi";
            this.lvCuocGoi.Size = new System.Drawing.Size(642, 152);
            this.lvCuocGoi.TabIndex = 6;
            this.lvCuocGoi.UseCompatibleStateImageBehavior = false;
            this.lvCuocGoi.View = System.Windows.Forms.View.Details;
            this.lvCuocGoi.SelectedIndexChanged += new System.EventHandler(this.lvCuocGoi_SelectedIndexChanged);
            // 
            // txtGoiDen
            // 
            this.txtGoiDen.Location = new System.Drawing.Point(276, 124);
            this.txtGoiDen.Name = "txtGoiDen";
            this.txtGoiDen.Size = new System.Drawing.Size(211, 20);
            this.txtGoiDen.TabIndex = 7;
            // 
            // txtNgayGoi
            // 
            this.txtNgayGoi.Location = new System.Drawing.Point(277, 161);
            this.txtNgayGoi.Name = "txtNgayGoi";
            this.txtNgayGoi.Size = new System.Drawing.Size(211, 20);
            this.txtNgayGoi.TabIndex = 8;
            // 
            // txtSoPhut
            // 
            this.txtSoPhut.Location = new System.Drawing.Point(277, 206);
            this.txtSoPhut.Name = "txtSoPhut";
            this.txtSoPhut.Size = new System.Drawing.Size(211, 20);
            this.txtSoPhut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // chinhanh
            // 
            this.chinhanh.Text = "Chi nhánh";
            this.chinhanh.Width = 100;
            // 
            // sodien
            // 
            this.sodien.Text = "Số gọi đi";
            this.sodien.Width = 150;
            // 
            // sogoiden
            // 
            this.sogoiden.Text = "Số gọi đến";
            this.sogoiden.Width = 120;
            // 
            // ngaygoi
            // 
            this.ngaygoi.Text = "Ngày gọi";
            this.ngaygoi.Width = 130;
            // 
            // sophut
            // 
            this.sophut.Text = "Số phút";
            this.sophut.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoPhut);
            this.Controls.Add(this.txtNgayGoi);
            this.Controls.Add(this.txtGoiDen);
            this.Controls.Add(this.lvCuocGoi);
            this.Controls.Add(this.cbGoiDi);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.ComboBox cbGoiDi;
        private System.Windows.Forms.ListView lvCuocGoi;
        private System.Windows.Forms.TextBox txtGoiDen;
        private System.Windows.Forms.TextBox txtNgayGoi;
        private System.Windows.Forms.TextBox txtSoPhut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader chinhanh;
        private System.Windows.Forms.ColumnHeader sogoiden;
        private System.Windows.Forms.ColumnHeader ngaygoi;
        private System.Windows.Forms.ColumnHeader sophut;
        private System.Windows.Forms.ColumnHeader sodien;
    }
}

