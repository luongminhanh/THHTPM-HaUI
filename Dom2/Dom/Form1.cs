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
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            cbChiNhanh.DataSource = ds.Tables[0];
            cbChiNhanh.DisplayMember = "chinhanh";
            cbGoiDi.DataSource = ds.Tables[0];
            cbGoiDi.DisplayMember = "sodien";
        }
        private void hienthi()
        {
            lvCuocGoi.Items.Clear();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.ReadXml(path);            
            dt = ds.Tables["cuocgoi"];
            if (dt.Rows.Count > 0)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem lv = new ListViewItem(dt.Rows[i]["chinhanh"].ToString());
                    lv.SubItems.Add(dt.Rows[i]["sodien"].ToString());
                    lv.SubItems.Add(dt.Rows[i]["sogoiden"].ToString());
                    lv.SubItems.Add(dt.Rows[i]["ngaygoi"].ToString());
                    lv.SubItems.Add(dt.Rows[i]["sophut"].ToString());
                    i++;
                    lvCuocGoi.Items.Add(lv);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_combobox();
            hienthi();
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
            sophut = doc.CreateElement("sophut");
            ngaygoi = doc.CreateElement("ngaygoi");
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
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='"+(txtGoiDen.Text).Trim() + "']");
            if (node != null)
            {
                node.Attributes[0].InnerText = cbGoiDi.Text;
                node.Attributes[1].InnerText = cbChiNhanh.Text;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='"+(txtGoiDen.Text).Trim() + "']");
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

        private void lvCuocGoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in  lvCuocGoi.SelectedItems)
            {
                cbChiNhanh.Text = item.SubItems[0].Text;
                cbGoiDi.Text = item.SubItems[1].Text;
                txtGoiDen.Text = item.SubItems[2].Text;
                txtNgayGoi.Text = item.SubItems[3].Text;
                txtSoPhut.Text = item.SubItems[4].Text;
            }
        }
    }
}
