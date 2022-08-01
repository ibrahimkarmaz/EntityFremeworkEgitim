using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqFinalTekrar1
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbIsTakipEntities database = new DbIsTakipEntities();
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource=database.TblPersonel.ToList();
        }


        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            gridControl1.DataSource = database.TblPersonel.Where(x => x.Arsiv == true).ToList();

            //Çoklu Where
           /* gridControl1.DataSource = (from x in database.TblPersonel
                                       where x.Arsiv == true
                                       where x.DepartmanID == 1
                                       select new { x.Ad,x.Soyad }).ToList();*/
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = database.TblPersonel.OrderByDescending(x => x.Ad).ToList();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = database.TblPersonel.OrderBy(x => x.Ad).ToList();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = database.TblPersonel.OrderBy(x => x.Soyad).ThenBy(y=>y.DepartmanID).ToList();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            //gridControl1.DataSource = database.TblPersonel.GroupBy(x => x.DepartmanID).ToList();
            gridControl1.DataSource = database.TblPersonel.GroupBy(x => x.DepartmanID).Select(a=> new { 
            DepartmanID=a.Key,
            Sayisi=a.Count()}).ToList();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {/*DİKKAT:SADECE YÖNTEM SÖZDİZİLİMİ İLE KULLANILIR*/
            gridControl1.DataSource = database.TblPersonel.ToLookup(x => x.DepartmanID).Select(y=>new { ID=y.Key,Sayisi=y.Count()
            }).OrderByDescending(b=>b.Sayisi).ToList();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from PersonelTablo in database.TblPersonel
                                       join Departman in database.TblDepartmanlar
                                       on PersonelTablo.DepartmanID equals Departman.ID
                                       select new
                                       {
                                           PersonelTablo.Ad,
                                           PersonelTablo.Soyad,
                                           PersonelTablo.Telefon,
                                           PersonelTablo.Mail,
                                           DepartmanAd = Departman.Ad
                                       }).ToList();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in database.TblPersonel
                                      select x.Ad).ToList();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (database.TblPersonel.SelectMany(x => database.TblDepartmanlar.Where(y => y.ID == x.DepartmanID), (x, y) => new
            {
                x.Ad,
                x.Soyad,
                DepartmanAd = y.Ad
            })).ToList();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {//ALL: ALANDA Kİ TÜM DEĞERLERİ KONTROL EDER EĞER TÜMÜ İSTENİLEN DURUMU KARŞILIYORSA TRUE KARŞILAMIYORSA FALSE DÖNDÜRÜR.
            Console.WriteLine(database.TblPersonel.All(x => x.Arsiv == true));
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {//EĞER KOŞULU ALAN İÇİNDE Kİ DEĞERLERDEN 1 TANESİ BİLE KARŞILIYOR İSE TRUE HIÇ BİRİ KARŞILAMIYORSA FALSE
            Console.WriteLine(database.TblPersonel.Any(x => x.Arsiv == true));
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in database.TblPersonel
             where x.Ad.Contains("Ali")
             select x).ToList();
        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aktif Personel Sayısı:"+(database.TblPersonel.Count(x=>x.Arsiv==true)).ToString());
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aktif Personel Sayısı:" + (database.TblPersonel.Sum(x=>x.DepartmanID)).ToString());
        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aktif Personel Sayısı:" + (database.TblPersonel.Average(x => x.DepartmanID)).ToString());
        }

        private void accordionControlElement22_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aktif Personel Sayısı:" + (database.TblPersonel.Min(x => x.DepartmanID)).ToString());
        }

        private void accordionControlElement23_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aktif Personel Sayısı:" + (database.TblPersonel.Max(x => x.DepartmanID)).ToString());
        }
    }
}
