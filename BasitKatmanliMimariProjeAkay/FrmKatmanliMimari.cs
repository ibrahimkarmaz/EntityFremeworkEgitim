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
        BirimDAL bd = new BirimDAL();
        public void Yenile()
        {
            gridControl1.DataSource =vpbdal.GetList();

            /*NOT: Hoca burada ComboBox kullandığı için datasource getlist mantıyla aldı ve alan adını birimad olarak göster
             Biz ise: ComboBoxEdit kullandığımız için ilk birimleri oluşturduk sonra listeyi ve column(Birimad) Listeye ekledik bu listeyide comboboxedit'in içine.*/
            List<string> Birimler = new List<string>();
            foreach (var item in bd.GetList())
            {
                Birimler.Add(item.BirimAd);
            }
            CeBirim.Properties.Items.AddRange(Birimler);
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
