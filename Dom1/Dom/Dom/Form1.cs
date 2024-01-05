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
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            dgv1.DataSource = dts.Tables["cuocgoi"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
            load_combobox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

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
                        cbChiNhanh.Text = cells[0].Value?.ToString();
                        cbGoiDi.Text = cells[1].Value?.ToString();
                        txtGoiDen.Text = cells[2].Value?.ToString();
                        txtNgayGoi.Text = cells[3].Value?.ToString();
                        txtSoPhut.Text = cells[4].Value?.ToString();
                    }
                }
            }
        }
    }
}
