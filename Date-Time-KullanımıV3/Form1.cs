using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_KullanımıV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            DateTime sonOdeme = new DateTime(2024, 5, 31, 16, 23, 51, 26);

            label1.Text = "Bugün: " + bugun.ToString();
            label2.Text = "Son Ödeme: " + sonOdeme.ToString();
            TimeSpan tarihFark = sonOdeme - bugun;
            label3.Text = "Gün Farkı: " + tarihFark.Days.ToString();
            label4.Text = "Saat Farkı: " + tarihFark.Hours.ToString();
            label5.Text = "Dakika Farkı: " + tarihFark.Minutes.ToString();
            label6.Text = "Saniye Farkı: " + tarihFark.Seconds.ToString();
            label7.Text = "MiliSaniye Farkı: " + tarihFark.Milliseconds.ToString();
        }


    }
}

