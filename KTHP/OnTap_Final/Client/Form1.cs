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

        private void button1_Click(object sender, EventArgs e)
        {
            string link = string.Format("http://localhost:91/restful/api/nhanvien?ma={0}&ten={1}&trinhdo={2}&luong={3}",
                txtMa.Text, txtTen.Text, txtTrinhDo.Text, txtLuong.Text);
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

        public void loaddgv()
        {
            string link = "http://localhost:91/restful/api/nhanvien";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] a = (NhanVien[])data;
            dataGridView1.DataSource = a;
            customheader("MaNV", "Mã nhân viên");
            customheader("HoTen", "Họ tên");
            customheader("TrinhDo", "Trình độ");
            customheader("Luong", "Lương");
        }
        public void customheader(string a, string b)
        {
            dataGridView1.Columns[a].HeaderText = b;
            dataGridView1.Columns[a].Width = 150;
            dataGridView1.Columns[a].HeaderCell.Style.Padding = new Padding(7);
            dataGridView1.Columns[a].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = string.Format("http://localhost:91/restful/api/nhanvien?ma={0}",
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
            txtTrinhDo.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txtLuong.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
        }
    }
}
