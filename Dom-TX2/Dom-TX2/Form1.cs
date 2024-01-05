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

namespace Dom_TX2
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
            cboChiNhanh.DataSource = dts.Tables["cuocgoi"];
            cboChiNhanh.DisplayMember = "chinhanh";
            cboSoGoiDi.DataSource = dts.Tables["cuocgoi"];
            cboSoGoiDi.DisplayMember = "sodien";
        }
        private void hienthi()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);

            DataTable dt = dts.Tables["cuocgoi"];
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có gì để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNgayGoi.Text == "" || txtSoGoiDen.Text == "" || txtSoPhut.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                } else
                {
                    them();
                    hienthi(); 
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra, ko thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_combobox();
            hienthi();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                if (selectedRow != null)
                {
                    DataGridViewCellCollection cells = selectedRow.Cells;
                    if (cells.Count >= 5)
                    {
                        cboChiNhanh.Text = cells[4].Value?.ToString();
                        cboSoGoiDi.Text = cells[3].Value?.ToString();
                        txtSoGoiDen.Text = cells[0].Value?.ToString();
                        txtNgayGoi.Text = cells[1].Value?.ToString();
                        txtSoPhut.Text = cells[2].Value?.ToString();
                    }
                }
            }
        }
        private void them()
        {
            doc.Load(path);
            XmlElement cuocgoi, sogoiden, ngaygoi, sophut;
            XmlAttribute chinhanh, sodien;
            cuocgoi = doc.CreateElement("cuocgoi");
            chinhanh = doc.CreateAttribute("chinhanh");
            sodien = doc.CreateAttribute("sodien");
            sogoiden = doc.CreateElement("sogoiden");
            ngaygoi = doc.CreateElement("ngaygoi");
            sophut = doc.CreateElement("sophut");
            chinhanh.InnerText = cboChiNhanh.Text;
            sodien.InnerText = cboSoGoiDi.Text;
            sogoiden.InnerText = txtSoGoiDen.Text;
            ngaygoi.InnerText = txtNgayGoi.Text;
            sophut.InnerText = txtSoPhut.Text;
            cuocgoi.SetAttributeNode(chinhanh);
            cuocgoi.SetAttributeNode(sodien);
            cuocgoi.AppendChild(sogoiden);
            cuocgoi.AppendChild(ngaygoi);
            cuocgoi.AppendChild(sophut);
            doc.DocumentElement.AppendChild(cuocgoi);
            doc.Save(path);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + (txtSoGoiDen.Text).Trim() + "']");
            if (node != null)
            {
                node.Attributes[0].InnerText = cboSoGoiDi.Text;
                node.Attributes[1].InnerText = cboChiNhanh.Text;
                node.ChildNodes[1].InnerText = txtNgayGoi.Text;
                node.ChildNodes[2].InnerText = txtSoPhut.Text;
                doc.Save(path);
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Số gọi đến ko tồn tại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
                {
                    MessageBox.Show("Nhập số gọi đến muốn sửa!");
                }
                else
                {
                    sua();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + (txtSoGoiDen.Text).Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Số gọi đến ko tồn tại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
                {
                    MessageBox.Show("Nhập số gọi đến muốn sửa!");
                }
                else
                {
                    xoa();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
