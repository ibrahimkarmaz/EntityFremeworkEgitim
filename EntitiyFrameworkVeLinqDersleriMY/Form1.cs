﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EntitiyFrameworkVeLinqDersleriMY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
        }
        DbSinavOgrenciEntities Database = new DbSinavOgrenciEntities();
        private void SBtnDersListe_Click(object sender, EventArgs e)
        {
            /*//1.YÖNTEM
            gridControl1.DataSource = Database.TBLDERSLER.ToList();
            gridView1.Columns[2].Visible=false;*/

            //.YÖNTEM
            var Query = from DersTablo in Database.TBLDERSLER
                        select new
                        {
                            DersTablo.DERSID,
                            DersTablo.DERSAD
                        };
            gridControl1.DataSource = Query.ToList();
        }

        private void SBtnOgrenciListe_Click(object sender, EventArgs e)
        {//1.YÖNTEM
            /* gridControl1.DataSource = Database.TBLOGRENCI.ToList();
             gridView1.Columns[3].Visible = false;
             gridView1.Columns[4].Visible = false;*/

            //2.YÖNTEM
            var sorgu = from OgrenciTablo in Database.TBLOGRENCI
                        select new
                        {
                            OgrenciTablo.ID,
                            OgrenciTablo.AD,
                            OgrenciTablo.SOYAD
                        };

            gridControl1.DataSource = sorgu.ToList();
        } 

        private void SBtnNotListe_Click(object sender, EventArgs e)
        {
            var query = from item in Database.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.OGR,
                            item.DERS,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };

            gridControl1.DataSource = query.ToList();
            //gridControl1.DataSource = Database.TBLNOTLAR.ToList();
        }

        private void SBtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI t = new TBLOGRENCI();
            t.AD = TeOgrenciAd.Text;
            t.SOYAD = TeOgrenciSoyad.Text;
            Database.TBLOGRENCI.Add(t);
            Database.SaveChanges();
            XtraMessageBox.Show("ÖĞRENCİ BAŞARILI BİR ŞEKİLDE EKLENDI.","ÖĞRENCİ İŞLEMLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SBtnDersKayit_Click(object sender, EventArgs e)
        {
            TBLDERSLER tabloDers = new TBLDERSLER();
            tabloDers.DERSAD = TeDersAd.Text;
            Database.TBLDERSLER.Add(tabloDers);
            Database.SaveChanges();
            XtraMessageBox.Show("DERS BAŞARILI BİR ŞEKİLDE EKLENDI.", "DERS İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        private void SBtnSil_Click(object sender, EventArgs e)
        {
            var x = Database.TBLOGRENCI.Find(Convert.ToInt16(TeOgrenciID.Text));
            Database.TBLOGRENCI.Remove(x);
            Database.SaveChanges();
            XtraMessageBox.Show("ÖĞRENCİ BAŞARILI BİR ŞEKİLDE SİLİNDİ.", "ÖĞRENCİ İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SBtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TeOgrenciID.Text);
            var x = Database.TBLOGRENCI.Find(id);
            x.AD = TeOgrenciAd.Text;
            x.SOYAD = TeOgrenciSoyad.Text;
            x.FOTOGRAF = TeFotograf.Text;
            Database.SaveChanges();
            XtraMessageBox.Show("ÖĞRENCİ GÜNCELLEME BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ", "ÖĞRENCİ İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SBtnProcedureNotListesi_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = Database.NOTLISTESI();
        }

        private void SBtnBul_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = Database.TBLOGRENCI.Where(x=> x.AD==TeOgrenciAd.Text & x.SOYAD==TeOgrenciSoyad.Text).ToList();
        }

        private void TeOgrenciAd_EditValueChanged(object sender, EventArgs e)
        {
            string aranan = TeOgrenciAd.Text;
            var query = from s in Database.TBLOGRENCI
                        where s.AD.Contains(aranan)
                        select s;
            gridControl1.DataSource = query.ToList();
        }

        private void SBtnEntitiy_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                List<TBLOGRENCI> liste1 = Database.TBLOGRENCI.OrderBy(p=>p.AD).ToList();
                gridControl1.DataSource = liste1;
            }
            if (radioButton2.Checked)
            {
                List<TBLOGRENCI> liste2 = Database.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
                gridControl1.DataSource = liste2;
            }
            if (radioButton3.Checked)
            {
                List<TBLOGRENCI> liste3 = Database.TBLOGRENCI.OrderBy(p => p.AD).Take(3).ToList();
                gridControl1.DataSource = liste3;
            }
            if (radioButton4.Checked)
            {
                List<TBLOGRENCI> liste4 = Database.TBLOGRENCI.Where(p => p.ID == 5).ToList();
                gridControl1.DataSource = liste4;
            }
            if (radioButton5.Checked)
            {
                List<TBLOGRENCI> liste5 = Database.TBLOGRENCI.Where(p => p.AD.StartsWith("a")).ToList();
                gridControl1.DataSource = liste5;
            }
            if (radioButton6.Checked)
            {
                List<TBLOGRENCI> liste6 = Database.TBLOGRENCI.Where(p => p.AD.EndsWith("a")).ToList();
                gridControl1.DataSource = liste6;
            }
            if (radioButton7.Checked)
            {
                bool deger = Database.TBLKULUPLER.Any();
                XtraMessageBox.Show("DEĞER VAR MI ? \nCEVAP:"+(deger==true ?"VAR":"YOK"),"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (radioButton8.Checked)
            {
                int OgrenciSayi = Database.TBLOGRENCI.Count();
                XtraMessageBox.Show(OgrenciSayi.ToString());
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}