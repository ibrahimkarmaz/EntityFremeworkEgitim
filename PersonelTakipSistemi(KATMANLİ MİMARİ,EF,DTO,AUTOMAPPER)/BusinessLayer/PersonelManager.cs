using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class PersonelManager
    {
        Repository<Personel> repositoryPersonel = new Repository<Personel>();
        PersonelDAL PDAL = new PersonelDAL();
        public int PersonelEkle(Personel p)
        {
            if (p==null)
            {
                return -1;
            }
            return repositoryPersonel.Insert(p);
        }

        public int PersonelSil(int id)
        {
            if (id!=0)
            {
                return repositoryPersonel.Delete(repositoryPersonel.GetById(id));
            }
            return -1;
        }
        public int PersonelUpdate(Personel p)//Yeni değerleri alıyoruz
        {
            Personel EskiPersonelBilgisi = repositoryPersonel.Find(x=>x.ID==p.ID);
            EskiPersonelBilgisi.Ad = p.Ad;
            EskiPersonelBilgisi.Soyad = p.Soyad;
            EskiPersonelBilgisi.Cinsiyet = p.Cinsiyet;
            EskiPersonelBilgisi.Departmans = p.Departmans;
            return repositoryPersonel.Update(EskiPersonelBilgisi); //Eski Değerlerin üzerine yazıldıktan sonra eski değeri gönderiyoruz.
        }
        public List<Personel> PersonelAramaYap(string Konu)
        {
            return repositoryPersonel.GetByFilter(x => x.Ad == Konu);
        }
        public List<PersonelListDTO> PersonelListele()
        {
            return PDAL.PersonelListesi();
        }
    }
}
