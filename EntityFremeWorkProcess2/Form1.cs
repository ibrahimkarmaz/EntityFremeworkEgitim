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
namespace EntityFremeWorkProcess2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinemaTakipOtomasyoSistemiEntities STO = new SinemaTakipOtomasyoSistemiEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = STO.TblFilmlers.ToList();
            gridView1.OptionsBehavior.Editable = false;//TABLODA DEĞİŞİK YAPILMASINI ENGELLEME

        }

        private void SBtnEkle_Click(object sender, EventArgs e)
        {
            TblFilmler Ekle = new TblFilmler();
            Ekle.FilmAd = adtext.Text;
            Ekle.FilmYonetmen = yonetmentext.Text;
            Ekle.FilmKonu = Konutext.Text;
            STO.TblFilmlers.Add(Ekle);
            STO.SaveChanges();

            XtraMessageBox.Show("EKLEME İŞLEMİ BAŞARILI","FİLMLER",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //İSTENİLEN CONTROL ÜZERİNDE METİN SİLME VB İŞLEMLER İÇİN
            foreach (Control item in Controls)
            {
                if (item is TextEdit || item is MemoEdit) item.Text = "";
            }
            gridControl1.DataSource = STO.TblFilmlers.ToList();
        }

        private void SBtnGuncelle_Click(object sender, EventArgs e)
        {
            TblFilmler Duzenle = STO.TblFilmlers.First(f=>f.FilmID==id);
            Duzenle.FilmAd = adtext.Text;
            Duzenle.FilmYonetmen = yonetmentext.Text;
            Duzenle.FilmKonu = Konutext.Text;
            STO.SaveChanges();

            XtraMessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI", "FİLMLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in Controls)
            {
                if (item is TextEdit || item is MemoEdit) item.Text = "";
            }
            gridControl1.DataSource = STO.TblFilmlers.ToList();
        }
        int id;
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {//GRİDVİEW ÜZERİNDEN VERİ ÇEKME YÖNTEMİ
            id=Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
            adtext.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            yonetmentext.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            Konutext.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
        }

        private void SBtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = STO.TblFilmlers.ToList();
        }

        private void SBtnSil_Click(object sender, EventArgs e)
        {
            TblFilmler sil = STO.TblFilmlers.First(s=>s.FilmID==id);
            STO.TblFilmlers.Remove(sil);
            STO.SaveChanges();
            gridControl1.DataSource = STO.TblFilmlers.ToList();
        }
    }
}
