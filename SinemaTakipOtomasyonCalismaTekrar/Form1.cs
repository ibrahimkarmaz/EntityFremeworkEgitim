using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SinemaTakipOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBSOSEntities dataBase = new DBSOSEntities();
        private void SBtnListele_Click(object sender, EventArgs e)
        {
            var Tablo = from BiletTablosu in dataBase.Bilet_Tablo
                        select new
                        {
                            BiletTablosu.satisno,
                            BiletTablosu.filmad,
                            BiletTablosu.filmtarih,
                            BiletTablosu.filmseans,
                            BiletTablosu.koltukno,
                            BiletTablosu.ad,
                            BiletTablosu.soyad,
                            BiletTablosu.ucret
                        };
            if (TETop.Enabled)
                gridControl1.DataSource = Tablo.ToList().Take(Convert.ToInt32(TETop.Text));
            else
                gridControl1.DataSource = Tablo.ToList();

            gridView1.Columns[0].Caption = "SATIŞ NO";
            gridView1.Columns[1].Caption = "FİLM AD";
            gridView1.Columns[2].Caption = "FİLM TARİH";
            gridView1.Columns[3].Caption = "FİLM SEANS";
            gridView1.Columns[4].Caption = "KOLTUK NO";
            gridView1.Columns[5].Caption = "AD";
            gridView1.Columns[6].Caption = "SOYAD";
            gridView1.Columns[7].Caption = "ÜCRET";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SBtnListele.PerformClick();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
        }
        private void RBTumDeger_CheckedChanged(object sender, EventArgs e)
        {
            TETop.Enabled = false;
        }
        private void RBAdet_CheckedChanged(object sender, EventArgs e)
        {
            TETop.Enabled = true;
        }
        private void SBtnSirala1_Click(object sender, EventArgs e)
        {
            var Tablo = from BiletTablosu in dataBase.Bilet_Tablo
                        select new
                        {
                            BiletTablosu.satisno,
                            BiletTablosu.filmad,
                            BiletTablosu.filmtarih,
                            BiletTablosu.filmseans,
                            BiletTablosu.koltukno,
                            BiletTablosu.ad,
                            BiletTablosu.soyad,
                            BiletTablosu.ucret
                        };
            gridControl1.DataSource = Tablo.OrderBy(x => x.filmad).ToList();
        }
        private void SbtnSirala2_Click(object sender, EventArgs e)
        {
            var Tablo = from BiletTablosu in dataBase.Bilet_Tablo
                        select new
                        {
                            BiletTablosu.satisno,
                            BiletTablosu.filmad,
                            BiletTablosu.filmtarih,
                            BiletTablosu.filmseans,
                            BiletTablosu.koltukno,
                            BiletTablosu.ad,
                            BiletTablosu.soyad,
                            BiletTablosu.ucret
                        };
            gridControl1.DataSource = Tablo.OrderByDescending(x => x.filmad).ToList();
        }
        private void SBtnBiletSayi_Click(object sender, EventArgs e)
        {
            if (dataBase.Bilet_Tablo.Any() == true)
                XtraMessageBox.Show("BİLET SAYISI:" + dataBase.Bilet_Tablo.Count().ToString(), "BİLET İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("BİLET SAYISI:" + 0, "BİLET İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SBtnBul_Click(object sender, EventArgs e)
        {
            var Tablo = from BiletTablosu in dataBase.Bilet_Tablo
                        select new
                        {
                            BiletTablosu.satisno,
                            BiletTablosu.filmad,
                            BiletTablosu.filmtarih,
                            BiletTablosu.filmseans,
                            BiletTablosu.koltukno,
                            BiletTablosu.ad,
                            BiletTablosu.soyad,
                            BiletTablosu.ucret
                        };
            if (RBAdEsit.Checked)
                gridControl1.DataSource = Tablo.ToList().Where(x => x.ad == TEAd.Text);
            else if (RBAdBasla.Checked)
                gridControl1.DataSource = Tablo.ToList().Where(x => x.ad.StartsWith(TEAd.Text));
            else if (RBAdSon.Checked)
                gridControl1.DataSource = Tablo.ToList().Where(x => x.ad.EndsWith(TEAd.Text));
            else if (AdicindekiDeger.Checked)
                gridControl1.DataSource = Tablo.ToList().Where(x => x.ad.Contains(TEAd.Text));
        }

        private void SBtnKaydet_Click(object sender, EventArgs e)
        {
            Bilet_Tablo Ekle = new Bilet_Tablo();
            Ekle.filmad = TEFilmAd.Text;
            Ekle.filmtarih = TEFilmTarih.Text;
            Ekle.filmseans = TEFilmSeans.Text;
            Ekle.koltukno = TEKoltuk.Text;
            Ekle.ad = TEAd.Text;
            Ekle.soyad = TeSoyad.Text;
            Ekle.ucret = TEUcret.Text;
            dataBase.Bilet_Tablo.Add(Ekle);
            dataBase.SaveChanges();
            SBtnListele.PerformClick();

            foreach (Control item in groupControl1.Controls)//SADECE BİLET GRUBUNDAKİLERİ KONTROL ETTİK VE SİLDİK
            {
                if (item is TextEdit)
                    item.Text = "";
            }
            XtraMessageBox.Show("BİLET AL İŞLEMİ BAŞARILI", "BİLET İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string satisNo;
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            satisNo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            TEFilmAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            TEFilmTarih.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            TEFilmSeans.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            TEKoltuk.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            TEAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            TeSoyad.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
            TEUcret.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();
        }

        private void SBtnDuzenle_Click(object sender, EventArgs e)
        {
            /*
             *NOT: EĞER ID VAR İSE FİND İLE ARAMA YAPILABİLİR EĞER YOK İSE WHERE,FİRST,VB KOMUTLARLA ARAMA YAPILMALI
             */
            var Duzenle= dataBase.Bilet_Tablo.First(x => x.satisno.ToString() == satisNo);
            Duzenle.filmad = TEFilmAd.Text;
            Duzenle.filmtarih = TEFilmTarih.Text;
            Duzenle.filmseans = TEFilmSeans.Text;
            Duzenle.koltukno = TEKoltuk.Text;
            Duzenle.ad = TEAd.Text;
            Duzenle.soyad = TeSoyad.Text;
            Duzenle.ucret = TEUcret.Text;
            dataBase.SaveChanges();
            SBtnListele.PerformClick();
            foreach (Control MetinKutulari in groupControl1.Controls)
            {
                if (MetinKutulari is TextEdit)
                    MetinKutulari.Text = "";
            }
            XtraMessageBox.Show("BİLET DÜZENLEME İŞLEMİ BAŞARILI", "BİLET İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SBtnSil_Click(object sender, EventArgs e)
        {
            dataBase.Bilet_Tablo.Remove(dataBase.Bilet_Tablo.First(x=>x.satisno.ToString()==satisNo));
            dataBase.SaveChanges();
            SBtnListele.PerformClick();
            foreach (Control TextKutuSil in groupControl1.Controls)
            {
                if (TextKutuSil is TextEdit)
                    TextKutuSil.Text = "";
            }
            XtraMessageBox.Show("BİLET SİLME İŞLEMİ BAŞARILI", "BİLET İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
