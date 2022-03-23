using QLMuaBanLinhKien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanLinhKien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string tk = edtTaiKhoan.Text;
            if (tk == "ql")
            {
                MenuQuanLy a = new MenuQuanLy();
                a.Show();
            }
            else
            {
                MenuNhanVien a = new MenuNhanVien();
                a.Show();
            }
        }
    }
}
