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

namespace ModelFistEntityFrameWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        PersonelEntities ent = new PersonelEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ent.TblPersonel.ToList();
        }

        private void SBtnEkle_Click(object sender, EventArgs e)
        {
            TblPersonel Tablo = new TblPersonel();
            Tablo.PerAd = TeAd.Text;
            Tablo.PerSoyad = TeSoyad.Text;
            Tablo.PerSehir = TeSehir.Text;
            Tablo.PerMaas = Convert.ToInt16(TeMaas.Text);
            ent.TblPersonel.Add(Tablo);
            ent.SaveChanges();
            XtraMessageBox.Show("Personel Ekleme Başarılı","Personel",MessageBoxButtons.OK,MessageBoxIcon.Information);
            gridControl1.DataSource = ent.TblPersonel.ToList();
        }

        private void SBtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(TeID.Text);
            TblPersonel tablo = ent.TblPersonel.First(x => x.Perid==id);
            ent.TblPersonel.Remove(tablo);
            ent.SaveChanges();

            XtraMessageBox.Show("Personel Silme Başarılı", "Personel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = ent.TblPersonel.ToList();

        }

        private void SBtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(TeID.Text);
            TblPersonel Tablo = ent.TblPersonel.First(x => x.Perid == id);
            Tablo.PerAd = TeAd.Text;
            Tablo.PerSoyad = TeSoyad.Text;
            Tablo.PerSehir = TeSehir.Text;
            Tablo.PerMaas = Convert.ToInt16(TeMaas.Text);
            ent.SaveChanges();

            XtraMessageBox.Show("Personel Güncelleme Başarılı", "Personel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = ent.TblPersonel.ToList();

        }

        private void SBtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = ent.TblPersonel.ToList();
        }
    }
}
