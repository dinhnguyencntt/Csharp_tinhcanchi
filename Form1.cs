using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhcanchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string can, chi;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2050; i++)
            {
                string chi = "";
                switch (Convert.ToInt32(txtnam.Text)%12)
                {
                    case 0:
                        chi="THÂN";
                        break;
                    case 1:
                        chi="DẬU";
                        break;
                    case 2:
                        chi="TUẤT";
                        break;
                    case 3:
                        chi="HỢI";
                        break;
                    case 4:
                        chi="TÝ";
                        break;
                    case 5:
                        chi="SỬU";
                        break;
                    case 6:
                        chi="DẦN";
                        break;
                    case 7:
                        chi="MẸO";
                        break;
                    case 8:
                        chi="THÌN";
                        break;
                    case 9:
                        chi="TỴ";
                        break;
                    case 10:
                        chi="NGỌ";
                        break;
                    case 11:
                        chi="MÙI";
                        break;
                }
                string can = "";
                switch (Convert.ToInt32(txtnam.Text)%10)
                {
                    case 0:
                        can = "CANH";
                        break;
                    case 1:
                        can = "TÂN";
                        break;
                    case 2:
                        can = "NHÂM";
                        break;
                    case 3:
                        can = "QUÝ";
                        break;
                    case 4:
                        can = "GIÁP";
                        break;
                    case 5:
                        can = "ẤT";
                        break;
                    case 6:
                        can = "BÍNH";
                        break;
                    case 7:
                        can = "ĐINH";
                        break;
                    case 8:
                        can = "MẬU";
                        break;
                    case 9:
                        can = "KỶ";
                        break;
                }
                txtkq.Text = can+""+chi;
            }
        }
    }

}
