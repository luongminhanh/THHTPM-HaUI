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

namespace On
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        public static string path = "../../dskh.xml";
        private void loadcb()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cbChiNhanh.DataSource = dts.Tables["khachhang"];
            cbChiNhanh.DisplayMember = "chinhanh";
        }
        private void hienthi()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            DataTable dt = dts.Tables["khachhang"];

            dt.Columns["chinhanh"].SetOrdinal(0);
            dt.Columns["makh"].SetOrdinal(1);
            dt.Columns["hoten"].SetOrdinal(2);
            dt.Columns["diachi"].SetOrdinal(3);

            dataGridView1.DataSource = dt;
            custom("makh", "Mã khách hàng");
            custom("chinhanh", "Chi nhánh");
            custom("hoten", "Họ tên");
            custom("diachi", "Địa chỉ");
            custom("sodt", "Số điện thoại");
        }
        public void custom(string a, string b)
        {
            dataGridView1.Columns[a].HeaderText = b;
            dataGridView1.Columns[a].Width = 160;
            dataGridView1.Columns[a].HeaderCell.Style.Padding = new Padding(7);
            dataGridView1.Columns[a].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlAttribute ma, chinhanh;
            XmlElement hoten, sdt, diachi, kh;
            kh = doc.CreateElement("khachhang");
            hoten = doc.CreateElement("hoten");
            diachi = doc.CreateElement("diachi");
            sdt = doc.CreateElement("sodt");
            ma = doc.CreateAttribute("makh");
            chinhanh = doc.CreateAttribute("chinhanh");
            hoten.InnerText = txtTen.Text;
            diachi.InnerText = txtDiaChi.Text;
            sdt.InnerText = txtSDT.Text;
            ma.InnerText = txtMaKH.Text;
            chinhanh.InnerText = cbChiNhanh.Text;
            kh.AppendChild(hoten);
            kh.AppendChild(diachi);
            kh.AppendChild(sdt);
            kh.SetAttributeNode(ma);
            kh.SetAttributeNode(chinhanh);
            doc.DocumentElement.AppendChild(kh);
            doc.Save(path);
            hienthi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcb();
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[sodt='" + txtSDT.Text + "']");
            if (node != null)
            {
                node.ChildNodes[0].InnerText = txtTen.Text;
                node.ChildNodes[1].InnerText = txtDiaChi.Text;
                node.ChildNodes[2].InnerText = txtSDT.Text;
                node.Attributes[0].InnerText = txtMaKH.Text;
                node.Attributes[1].InnerText = cbChiNhanh.Text;
                doc.Save(path);
            }
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[sodt='" + txtSDT.Text + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                hienthi();
            }
        }
    }
}
