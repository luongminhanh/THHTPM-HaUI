using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;

namespace Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        public static string path = "../../cuocgoi.xml";
        private void load_combobox()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cbChiNhanh.DataSource = dts.Tables["cuocgoi"];
            cbChiNhanh.DisplayMember = "chinhanh";
            cbGoiDi.DataSource = dts.Tables["cuocgoi"];
            cbGoiDi.DisplayMember = "sodien";
        }
        private void hienthi()
        {                     
            // Đọc tệp XML vào DataSet
            DataSet dts = new DataSet();
            dts.ReadXml(path);

            // Lấy DataTable từ DataSet
            DataTable dt = dts.Tables["cuocgoi"];
            
            // Thiết lập DataTable làm nguồn dữ liệu cho DataGridView
            dgv1.DataSource = dt;
            customheader("sodien", "Số điện");
            customheader("sophut", "Số phút");
            customheader("chinhanh", "Chi nhánh");
            customheader("sogoiden", "Số gọi đến");
            customheader("ngaygoi", "Ngày gọi");
            //foreach (DataGridViewColumn column in dgv1.Columns)
            //{
            //    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    column.DefaultCellStyle.Padding = new Padding(7); 
            //    dgv1.DefaultCellStyle.WrapMode = DataGridViewTriState.True; 
            //    dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //}
        }

        private void customheader(string name, string text)
        {
            dgv1.Columns[name].HeaderText = text;
            dgv1.Columns[name].Width = 150;
            dgv1.Columns[name].HeaderCell.Style.Padding = new Padding(7);
            dgv1.Columns[name].HeaderCell.Style.Font = new Font(dgv1.Font, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
            load_combobox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlAttribute sodien, chinhanh;
            XmlElement cuocgoi, sogoiden, ngaygoi, sophut;
            cuocgoi = doc.CreateElement("cuocgoi");
            sogoiden = doc.CreateElement("sogoiden");
            ngaygoi = doc.CreateElement("ngaygoi");
            sophut = doc.CreateElement("sophut");
            chinhanh = doc.CreateAttribute("chinhanh");
            sodien = doc.CreateAttribute("sodien");
            chinhanh.InnerText = cbChiNhanh.Text;
            sodien.InnerText = cbGoiDi.Text;
            sogoiden.InnerText = txtGoiDen.Text;
            ngaygoi.InnerText = txtNgayGoi.Text;
            sophut.InnerText = txtSoPhut.Text;
            cuocgoi.SetAttributeNode(chinhanh);
            cuocgoi.SetAttributeNode(sodien);
            cuocgoi.AppendChild(sogoiden);
            cuocgoi.AppendChild(ngaygoi);
            cuocgoi.AppendChild(sophut);
            doc.DocumentElement.AppendChild(cuocgoi);
            doc.Save(path);
            MessageBox.Show("Thêm thành công");
            hienthi();
        }

        private void dgv1_SelectedCellsChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgv1.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow != null)
                {
                    DataGridViewCellCollection cells = selectedRow.Cells;

                    if (cells.Count >= 5)
                    {
                        cbChiNhanh.Text = cells[4].Value?.ToString();
                        cbGoiDi.Text = cells[3].Value?.ToString();
                        txtGoiDen.Text = cells[0].Value?.ToString();
                        txtNgayGoi.Text = cells[1].Value?.ToString();
                        txtSoPhut.Text = cells[2].Value?.ToString();
                    }
                }
            }
        }

      

        private void btnXoa_Click(object sender, EventArgs e)
        {

            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + (txtGoiDen.Text).Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xóa thành công");
                hienthi();
            }
            else
            {
                MessageBox.Show("Số gọi đến không có trong danh sách");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[@sodien='" + (cbGoiDi.Text).Trim() + "']");
            if (node != null)
            {
                //node.Attributes[0].InnerText = cbGoiDi.Text;
                //node.Attributes[1].InnerText = cbChiNhanh.Text;
                node.ChildNodes[1].InnerText = txtNgayGoi.Text;
                node.ChildNodes[2].InnerText = txtSoPhut.Text;
                doc.Save(path);
                MessageBox.Show("Sửa thành công");
                hienthi();
            }
            else
            {
                MessageBox.Show("Số gọi đến không có trong danh sách");
            }
        }
    }
}
