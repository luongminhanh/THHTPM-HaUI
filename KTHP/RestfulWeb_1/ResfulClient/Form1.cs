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

namespace ResfulClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loaddgv()
        {
            string link = "http://localhost:91/hocrestful/api/sanpham";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataGridView1.DataSource = arr;
        }
        public void loadcbo()
        {
            string link = "http://localhost:91/hocrestful/api/danhmuc";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] arr = data as DanhMuc[];
            cboDM.DataSource = arr;
            cboDM.ValueMember = "MaDanhMuc";
            cboDM.DisplayMember = "TenDanhMuc";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMa.Text, txtTen.Text, 
            txtGia.Text, cboDM.SelectedValue);
            string link = "http://localhost:91/hocrestful/api/sanpham" + postString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loaddgv();
                MessageBox.Show("Thêm sp thành công");
            }
            else
            {
                MessageBox.Show("Thêm sp ko thành công");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddgv();
            loadcbo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            string link = "http://localhost:91/hocrestful/api/sanpham?madm=" + madm;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataGridView1.DataSource = arr;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMa.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            cboDM.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMa.Text, txtTen.Text,
            txtGia.Text, cboDM.SelectedValue);
            string link = "http://localhost:91/hocrestful/api/sanpham" + putString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loaddgv();
                MessageBox.Show("Sửa sp thành công");
            }
            else
            {
                MessageBox.Show("Sửa sp ko thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteString = string.Format("?ma={0}", txtMa.Text);
            string link = "http://localhost:91/hocrestful/api/sanpham" + deleteString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "DELETE";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loaddgv();
                MessageBox.Show("Xóa sp thành công");
            }
            else
            {
                MessageBox.Show("Xóa sp ko thành công");
            }
        }
    }
}
