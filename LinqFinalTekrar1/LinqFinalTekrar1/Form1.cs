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
            gridControl1.DataSource = database.TblPersonel.ToList().OrderBy(x => x.Ad).Skip(3);
        }

        private void accordionControlElement32_Click(object sender, EventArgs e)
        {/*Buranın mantığı;
          *SkipWhile Şartı sağlayan değerler ALINMAZ fakat eğer şart sağlanmadı ise 
          *DEĞERİ SAĞLANAYAN DEĞERDEN İTİBAREN TÜM VERİLERİ ALIR 
          */
            gridControl1.DataSource = database.TblPersonel.ToList().SkipWhile(x => x.Arsiv == false);
        }

        private void accordionControlElement33_Click(object sender, EventArgs e)
        {//Take:Top
            gridControl1.DataSource = database.TblPersonel.ToList().Where(x => x.Arsiv == true).Take(5);//Arşivi sağlayan 5 Değer Göster
        }

        private void accordionControlElement34_Click(object sender, EventArgs e)
        {//Mantığı: Eğer sağlanana kadar değerleri al sağlanınca sağlanan değeri al ve sonlardır.(SkipWhile ise True olanları almıyor false ise dondarip gösteriyor)
            gridControl1.DataSource = database.TblPersonel.ToList().TakeWhile(x => x.Arsiv == true);
        }
        private void accordionControlElement36_Click(object sender, EventArgs e)
        {//1-Personeldeki Personel sayısınını gösteren linq kodu(Aktif personel)
            Console.WriteLine("Personel Sayısı:" + database.TblPersonel.Count(x => x.Arsiv == true));
        }


        private void accordionControlElement38_Click(object sender, EventArgs e)
        {//3-Departman Sayısı linq sorgu
            Console.WriteLine("Departman Sayısı" + database.TblDepartmanlar.Count());
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
            gridControl1.DataSource = database.TblFirmalar.ToList().Where(z => z.ID == (database.TblCagrilar.GroupBy(x => x.CagriFirma).Select(a => new
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
            Console.WriteLine("Aktif Çağrı:{0}", database.TblCagrilar.Count(x => x.Durum == true));
            Console.WriteLine("Pasif Çağrı:{0}", database.TblCagrilar.Count(x => x.Durum == false));
            Console.WriteLine("Toplam Çağrı:{0}", database.TblCagrilar.Count());

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
        Db_YedekParcaOtomasyonSistemiEntities yedekparcadatabase = new Db_YedekParcaOtomasyonSistemiEntities();

        private void accordionControlElement47_Click(object sender, EventArgs e)
        {//1-Musteri Tablosunu getiren linq kodu
            gridControl1.DataSource = yedekparcadatabase.TblMusteri.ToList();
        }

        private void accordionControlElement49_Click(object sender, EventArgs e)
        {//2-Müşteri Sayısını getiren linq sorgu (Aktif pasif toplam)
            Console.WriteLine("Toplam Müşteri Sayısı" + yedekparcadatabase.TblMusteri.Count().ToString());
            Console.WriteLine("Aktif Müşteri Sayısı" + yedekparcadatabase.TblMusteri.Where(x => x.arsiv == true).Count());
            Console.WriteLine("Pasif Müşteri Sayısı" + yedekparcadatabase.TblMusteri.Where(x => x.arsiv == false).Count());
        }

        private void accordionControlElement48_Click(object sender, EventArgs e)
        {//3-Ban yiyen Müşterilerin Listesi
            gridControl1.DataSource = (yedekparcadatabase.TblMusteri.Where(x => x.ban == true).ToList());
        }

        private void accordionControlElement50_Click(object sender, EventArgs e)
        {//4-Müşteri Ad(Ahmet Baş harf büyük),Soyad(YILMAZ Büyük),mail ve telefon bilgisini getiren linq kodu
            gridControl1.DataSource = yedekparcadatabase.TblMusteri.Select(x => new
            {
                AdSoyad = x.ad.Substring(0, 1) + x.ad.Substring(1, x.ad.Count()).ToLower() + " " + x.soyad.ToUpper(),
                Mail = x.eposta,
                Telefon = x.cep_telefonu
            }).ToList();

        }

        private void accordionControlElement51_Click(object sender, EventArgs e)
        {//5-Müşterinin aldığı yedek parçaya göre Müşteri bilgisini ve yedek parçalar gelecek.
            gridControl1.DataSource = yedekparcadatabase.TblMusteri.SelectMany(x => yedekparcadatabase.MusteriYedekParcaListesi.Where(a => a.TCNO == x.tcno), (x, a) => new
            {
                x.ad,
                x.soyad,
                a.YedekParcaKod,
                a.alis_adet
            }).ToList();

        }

        private void accordionControlElement52_Click(object sender, EventArgs e)
        {//6-Yedek Parça Listesi
            gridControl1.DataSource = yedekparcadatabase.TblYedekParca.ToList();
        }

        private void accordionControlElement53_Click(object sender, EventArgs e)
        {//7-Yedek parçaların aktif olanlarını kategori olarak sayısını listeleme
            gridControl1.DataSource = yedekparcadatabase.TblYedekParca.Where(a => a.Arsiv == true).GroupBy(x => x.YedekParcaKategori).Select(c => new { Katgori = c.Key, KategoriSayisi = c.Count() }).ToList();

        }

        private void accordionControlElement54_Click(object sender, EventArgs e)
        {//8-En fazla para ödeyen müşterinin bilgilerini getiren linq sorgusu
            //(yedekparcadatabase.MusteriYedekParcaListesi.GroupBy(x => x.TCNO).Select(c=>new {c.Key,Toplam=c.Sum(d=>d.toplam_fiyat)})).OrderByDescending(k=>k.Toplam).ToList();
            gridControl1.DataSource = (from musteri in yedekparcadatabase.TblMusteri
                                       join birlestir in ((yedekparcadatabase.MusteriYedekParcaListesi.GroupBy(x => x.TCNO).Select(c => new { c.Key, Toplam = c.Sum(d => d.toplam_fiyat) })).OrderByDescending(k => k.Toplam))
                                       on musteri.tcno equals birlestir.Key
                                       select new  
                                       {
                                           musteri.ad,
                                           musteri.soyad,
                                           birlestir.Toplam
                                       }).ToList();
        }

        private void accordionControlElement55_Click(object sender, EventArgs e)
        {//9-En fazla yedek parça alan müşterilerin listesini getiren linq sorgu

            gridControl1.DataSource = (from musteri in yedekparcadatabase.TblMusteri
                                       join parcasayisilari in (yedekparcadatabase.MusteriYedekParcaListesi.GroupBy(a => a.TCNO).Select(b => new
                                       {
                                           TC = b.Key,
                                           ParcaSayisi = b.Sum(c => c.alis_adet)
                                       })).OrderByDescending(d => d.ParcaSayisi)
                                       on musteri.tcno equals parcasayisilari.TC
                                       select new
                                       {
                                           musteri.ad,
                                           musteri.soyad,
                                           musteri.cep_telefonu,
                                           musteri.ev_adresi
                                       }).ToList();

        }

        bool PathList = true; int customerCount = 0;
        private void accordionControlElement56_Click(object sender, EventArgs e)
        {//10-Tüm müşterileri ikiye ayırarak listele 10 adet müşteri için 1-5'e kadar 1 5-10'a kadar 2. parça olacaktır.
            if (PathList)
            {
                customerCount = yedekparcadatabase.TblMusteri.Count();
                gridControl1.DataSource = (yedekparcadatabase.TblMusteri.OrderBy(x=>x.ad).Take(customerCount / 2).ToList());
                PathList = false;
            }
            else
            {
                gridControl1.DataSource = (yedekparcadatabase.TblMusteri.OrderBy(x=>x.ad).Skip(customerCount / 2).Take(customerCount-(customerCount / 2)).ToList());
                PathList=true;
            }
        }

        private void accordionControlElement57_Click(object sender, EventArgs e)
        {//11-Yedek parçaları kategoriye göre sırala daha sonra parça adına göre sırala
            gridControl1.DataSource = (yedekparcadatabase.TblYedekParca.OrderBy(x => x.YedekParcaKategori).ThenBy(y => y.YedekParcaAd).ToList());

        }

        private void accordionControlElement58_Click(object sender, EventArgs e)
        {//12-En az fiyata sahip yedek parcayi gösteren linq kodu
            gridControl1.DataSource = (yedekparcadatabase.MusteriYedekParcaListesi.OrderBy(x => x.alis_adet).Take(1).ToList());

        }

        private void accordionControlElement59_Click(object sender, EventArgs e)
        {//13-Müşteri Hıç Alişveriş yaptı mı ? yapmayanlarin listesi
        }

        private void accordionControlElement60_Click(object sender, EventArgs e)
        {//14-Yedek parçaya ait aliş, satış, kar ve yüzdelik ve diğer bilgileri listeleyen linq kodu
            gridControl1.DataSource = (from x in yedekparcadatabase.TblYedekParca
                                       join y in yedekparcadatabase.TblParcaAlisBilgi
                                       on x.YedekParcaKod equals y.YedekParcaKod
                                       select new
                                       {
                                           x.YedekParcaKod,
                                           x.YedekParcaAd,
                                           AlisFiyati = y.AlisFiyat,
                                           SatisFiyati = x.YedekParcaSatisFiyat,
                                           Kar = (x.YedekParcaSatisFiyat - y.AlisFiyat),
                                           YuzdeKar = ((x.YedekParcaSatisFiyat * 100) / y.AlisFiyat) - 100
                                       }).ToList();
        }

        private void accordionControlElement61_Click(object sender, EventArgs e)
        {//15-Alış tarihine göre yedek parçayı sıralama
            gridControl1.DataSource = (from yedekparca in yedekparcadatabase.TblYedekParca
                                       join alisbilgi in yedekparcadatabase.TblParcaAlisBilgi
                                       on yedekparca.YedekParcaKod equals alisbilgi.YedekParcaKod
                                       select new
                                       {
                                           yedekparca.YedekParcaAd,
                                           yedekparca.YedekParcaAdet,
                                           yedekparca.YedekParcaSatisFiyat,
                                           yedekparca.YedekParcaKategori,
                                           alisbilgi.AlisTarih
                                       }).OrderByDescending(x => x.AlisTarih).ToList();
        }

        private void accordionControlElement62_Click(object sender, EventArgs e)
        {//16-Markanın yedek parça sayısı
            gridControl1.DataSource = (from a in yedekparcadatabase.TblYedekParca.GroupBy(x => x.MarkaModelID).Select(y => new
            {
                MMID = y.Key,
                ToplamAdet = y.Sum(z => z.YedekParcaAdet)
            })
                                       join b in yedekparcadatabase.TblMarkaModel
                                       on a.MMID equals b.ID
                                       select new
                                       {
                                           b.Marka,
                                           a.ToplamAdet
                                       }).ToList();
                
        }

        private void accordionControlElement63_Click(object sender, EventArgs e)
        {//17-İthalat firma sayısı
            Console.WriteLine("Firma Sayısı"+yedekparcadatabase.Tblithalat.Count().ToString());
        }

        private void accordionControlElement64_Click(object sender, EventArgs e)
        {//18-İthalat firmasinin Listesi
            gridControl1.DataSource = yedekparcadatabase.Tblithalat.ToList();
        }

        private void accordionControlElement65_Click(object sender, EventArgs e)
        {//19-Ortalama fiyattan yüksek yedek parça listesi
            gridControl1.DataSource = yedekparcadatabase.TblYedekParca.Where(x => x.YedekParcaSatisFiyat > yedekparcadatabase.TblYedekParca.Average(y => y.YedekParcaSatisFiyat)).ToList();
        }

        private void accordionControlElement66_Click(object sender, EventArgs e)
        {//20-Hangi ithalat firmasidem hangi parça alındığı listesi.
            gridControl1.DataSource = (from ithalat in yedekparcadatabase.Tblithalat
                                       join alisbilgisi in yedekparcadatabase.TblParcaAlisBilgi
                                       on ithalat.IthalatID equals alisbilgisi.IthalatID
                                       join yedekparca in yedekparcadatabase.TblYedekParca
                                       on alisbilgisi.YedekParcaKod equals yedekparca.YedekParcaKod
                                       select new
                                       {
                                           ithalat.IthalatUnvan,
                                           yedekparca.YedekParcaAd,
                                           yedekparca.YedekParcaAdet,
                                           yedekparca.YedekParcaKategori,
                                           alisbilgisi.AlisTarih,
                                           alisbilgisi.AlisAdeti
                                       }).ToList();
        }
    }
}
