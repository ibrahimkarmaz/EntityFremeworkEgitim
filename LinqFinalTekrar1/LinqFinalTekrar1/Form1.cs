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
            gridControl1.DataSource = database.TblPersonel.ToList();
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
            gridControl1.DataSource = database.TblPersonel.OrderBy(x => x.Soyad).ThenBy(y => y.DepartmanID).ToList();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            //gridControl1.DataSource = database.TblPersonel.GroupBy(x => x.DepartmanID).ToList();
            gridControl1.DataSource = database.TblPersonel.GroupBy(x => x.DepartmanID).Select(a => new
            {
                DepartmanID = a.Key,
                Sayisi = a.Count()
            }).ToList();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {/*DİKKAT:SADECE YÖNTEM SÖZDİZİLİMİ İLE KULLANILIR*/
            gridControl1.DataSource = database.TblPersonel.ToLookup(x => x.DepartmanID).Select(y => new
            {
                ID = y.Key,
                Sayisi = y.Count()
            }).OrderByDescending(b => b.Sayisi).ToList();
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
            Console.WriteLine("Aktif Personel Sayısı:" + (database.TblPersonel.Count(x => x.Arsiv == true)).ToString());
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aktif Personel Sayısı:" + (database.TblPersonel.Sum(x => x.DepartmanID)).ToString());
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

        private void accordionControlElement25_Click(object sender, EventArgs e)
        {//SADECE SIRALI DEĞERLERDE 1,2,3,4 ALİ MEHMET GİBİ İŞLEMLERDE KULLANILIR.
         // Console.WriteLine(database.TblPersonel.ElementAt(1));
        }

        private void accordionControlElement26_Click(object sender, EventArgs e)
        {//System.NullReferenceException: 'Nesne başvurusu bir nesnenin örneğine ayarlanmadı.' (EĞER DEĞER YOKSA NULL DÖNER HATASI)
            var a = database.TblPersonel.FirstOrDefault(x => x.Ad == "Ezgi");
            if (a != null)
            {
                Console.WriteLine(a.Ad);
            }

        }


        private void accordionControlElement27_Click(object sender, EventArgs e)
        {//Eğer Değer Yoksa hata döndürür sırada öğe yok
            try//HATA KONTROL
            {
                Console.WriteLine(database.TblPersonel.First(x => x.Ad == "Ezgix").Ad);
            }
            catch (Exception) { }

        }

        private void accordionControlElement28_Click(object sender, EventArgs e)
        {//First'in tersi en sonda ki değeri alir ve istisna varsa null döndürür
            try
            {
                var a = database.TblDepartmanlar.LastOrDefault(x => x.ID == 1);
                if (a != null)
                {
                    Console.WriteLine(a.Ad);
                }
            }
            catch (Exception)
            {
            }


        }

        private void accordionControlElement29_Click(object sender, EventArgs e)
        {//First'in tersi en sonda ki değeri alir ve istisna varsa Hata döndürür
            try//HATA KONTROL
            {
                Console.WriteLine(database.TblPersonel.Last(x => x.Ad == "Ezgi").Ad);
            }
            catch (Exception) { }
        }

        private void accordionControlElement31_Click(object sender, EventArgs e)
        {//Skip Atlamak anlamına gelir belirli bir sayıyna kdar değeri al denir.
            //Dikkat: ilk eleman yani 1'den başlar ve n kadar gider n!=index
            gridControl1.DataSource = database.TblPersonel.ToList().OrderBy(x=>x.Ad).Skip(3);
        }

        private void accordionControlElement32_Click(object sender, EventArgs e)
        {/*Buranın mantığı;
          *SkipWhile Şartı sağlayan değerler ALINMAZ fakat eğer şart sağlanmadı ise 
          *DEĞERİ SAĞLANAYAN DEĞERDEN İTİBAREN TÜM VERİLERİ ALIR 
          */
            gridControl1.DataSource = database.TblPersonel.ToList().SkipWhile(x=>x.Arsiv==false);
        }

        private void accordionControlElement33_Click(object sender, EventArgs e)
        {//Take:Top
            gridControl1.DataSource = database.TblPersonel.ToList().Where(x=>x.Arsiv==true).Take(5);//Arşivi sağlayan 5 Değer Göster
        }

        private void accordionControlElement34_Click(object sender, EventArgs e)
        {//Mantığı: Eğer sağlanana kadar değerleri al sağlanınca sağlanan değeri al ve sonlardır.(SkipWhile ise True olanları almıyor false ise dondarip gösteriyor)
            gridControl1.DataSource = database.TblPersonel.ToList().TakeWhile(x=>x.Arsiv==true);
        }
        private void accordionControlElement36_Click(object sender, EventArgs e)
        {//1-Personeldeki Personel sayısınını gösteren linq kodu(Aktif personel)
            Console.WriteLine("Personel Sayısı:"+database.TblPersonel.Count(x=>x.Arsiv==true));
        }


        private void accordionControlElement38_Click(object sender, EventArgs e)
        {//3-Departman Sayısı linq sorgu
            Console.WriteLine("Departman Sayısı"+database.TblDepartmanlar.Count());
        }

        private void accordionControlElement39_Click(object sender, EventArgs e)
        {//4-Firma Bilgilerini Getiren Linq Kodu
            gridControl1.DataSource = database.TblFirmalar.ToList();
        }

        private void accordionControlElement40_Click(object sender, EventArgs e)
        {//5-Firmalara ait ad,yetkili telefefon adres bilgisi linq
            gridControl1.DataSource = database.TblFirmalar.Select(x => new
            {
                x.Ad,
                x.Yetkili,
                x.Telefon,
                x.Adres
            }).ToList();
        }

        private void accordionControlElement41_Click(object sender, EventArgs e)
        {
            //6-En çok çağrıda bulunan firma bilgileri
             gridControl1.DataSource = database.TblFirmalar.ToList().Where(z => z.ID== (database.TblCagrilar.GroupBy(x => x.CagriFirma).Select(a => new
             {
                 a.Key,
                 Sayi = a.Count()
             }).OrderByDescending(c => c.Sayi).First().Key)).ToList();
        }

        private void accordionControlElement37_Click(object sender, EventArgs e)
        {
            //2-Departman adına göre sıralayarak Ahmet YILMAZ (Ad:ilk harf büyük soyad:Tümü büyük) ve Departman Adını gösteren linq
            gridControl1.DataSource = (from pers in database.TblPersonel
                                       join deps in database.TblDepartmanlar
                                       on pers.DepartmanID equals deps.ID
                                       select new
                                       {
                                           AdSoyad = pers.Ad.Substring(0, 1).ToUpper() + pers.Ad.Substring(1, pers.Ad.Length).ToLower() + " " + pers.Soyad.ToUpper(),
                                           DepartmanAd = deps.Ad
                                       }).ToList();
        }

        private void accordionControlElement42_Click(object sender, EventArgs e)
        {//7-AÇIK KAPALI VE TOPLAM ÇAĞRI SAYISI
            Console.WriteLine("Aktif Çağrı:{0}",database.TblCagrilar.Count(x=>x.Durum==true));
            Console.WriteLine("Pasif Çağrı:{0}",database.TblCagrilar.Count(x=>x.Durum==false));
            Console.WriteLine("Toplam Çağrı:{0}",database.TblCagrilar.Count());

        }

        private void accordionControlElement43_Click(object sender, EventArgs e)
        {//8-Çağrıların Sayılarına göre çoktan aza sıralama
          /*  gridControl1.DataSource = database.TblFirmalar.ToList().Where(z => z.ID == (database.TblCagrilar.GroupBy(x => x.CagriFirma).Select(a => new
            {
                a.Key,
                Sayi = a.Count()
            }).OrderByDescending(c => c.Sayi).First().Key)).ToList();*/
        }

        private void accordionControlElement44_Click(object sender, EventArgs e)
        {//9-Firmalari sektore göre gruplama ve sayilari Listeleme
            gridControl1.DataSource = (database.TblFirmalar.GroupBy(x => x.Sektor).Select(a => new { a.Key, sayi = a.Count() })).ToList();
        }

        private void accordionControlElement45_Click(object sender, EventArgs e)
        {//10-Çağrı Tablosunu Düzenle ve Listele
            gridControl1.DataSource = (from cagri in database.TblCagrilar
                                       join firma in database.TblFirmalar
                                       on cagri.ID equals firma.ID
                                       where cagri.Durum == true
                                       select new
                                       {
                                           firma.Ad,
                                           firma.Telefon,
                                           firma.Mail,
                                           firma.Adres,
                                           cagri.Konu,
                                           cagri.Aciklama,
                                           cagri.Tarih
                                       }).ToList();
            
        }
    }
}
