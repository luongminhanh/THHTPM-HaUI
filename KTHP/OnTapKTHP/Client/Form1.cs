using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loaddgv()
        {
            string link = "http://localhost:91/hocrestful_ontap/api/sanpham";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] a = (SanPham[])data;
            dataGridView1.DataSource = a;
        }
        public void loadcb()
        {
            string link = "http://localhost:91/hocrestful_ontap/api/danhmuc";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] a = (DanhMuc[])data;
            cboDM.DataSource = a;
            cboDM.ValueMember = "MaDanhMuc";
            cboDM.DisplayMember = "TenDanhMuc";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddgv();
            loadcb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = string.Format("http://localhost:91/hocrestful_ontap/api/sanpham?ma={0}&ten={1}&gia={2}&madm={3}", 
                txtMa.Text, txtTen.Text, txtGia.Text, cboDM.SelectedValue);
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loaddgv();
                MessageBox.Show("Thêm thành công");
            } else
            {
                MessageBox.Show("Thêm ko thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = string.Format("http://localhost:91/hocrestful_ontap/api/sanpham?ma={0}&ten={1}&gia={2}&madm={3}",
                txtMa.Text, txtTen.Text, txtGia.Text, cboDM.SelectedValue);
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loaddgv();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa ko thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string link = string.Format("http://localhost:91/hocrestful_ontap/api/sanpham?ma={0}",
                txtMa.Text);
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "DELETE";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loaddgv();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa ko thành công");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMa.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            cboDM.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
        }
        public void customheader(string a, string b)
        {
            dataGridView1.Columns[a].HeaderText = b;
            dataGridView1.Columns[a].Width = 100;
        }
    }
}
