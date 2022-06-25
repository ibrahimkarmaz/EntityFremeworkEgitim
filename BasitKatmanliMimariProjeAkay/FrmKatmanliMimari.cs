using BasitKatmanliMimariProjeAkay.DataAccessL;
using BasitKatmanliMimariProjeAkay.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BasitKatmanliMimariProjeAkay
{
    public partial class FrmKatmanliMimari : Form
    {
        public FrmKatmanliMimari()
        {
            InitializeComponent();
        }
        ViewPersonelBirimDAL vpbdal = new ViewPersonelBirimDAL();
        public void Yenile()
        {
            gridControl1.DataSource =vpbdal.GetList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void TxeAramaKonusu_EditValueChanged(object sender, EventArgs e)
        {/*ARAMA İŞLEMİNDE ALANIN İÇERİĞİNDE ARAMA YAPILACAĞI İÇİN CONTAİNT KULLANULUR TEK VERİ ÇEKMEYİ SAĞLAR.*/
            gridControl1.DataSource = vpbdal.GetList(x => x.AdSoyad.Contains(TxeAramaKonusu.Text));
        }
    }
}
