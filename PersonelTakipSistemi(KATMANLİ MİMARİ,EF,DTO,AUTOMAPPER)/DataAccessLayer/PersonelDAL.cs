using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace DataAccessLayer
{
    public class PersonelDAL : Repository<Personel>, IPersonelDAL
    {

        Context database = new Context();
        public List<PersonelListDTO> PersonelListesi()
        {
            return (from x in database.Personels
                    select new PersonelListDTO
                    {
                        ID = x.ID,
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        Cinsiyet = x.Cinsiyet ? "ERKEK" : "KADIN",
                        DepartmanAdi = x.Departmans.DepartmanAd
                    }).ToList();
        }
    }
    public class PersonelListDTO
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string DepartmanAdi { get; set; }
    }
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Personel, PersonelListDTO>()
                  .ForMember(dest => dest.Ad, opt => opt.MapFrom(src => src.Ad));
        }
    }
}
//KAYNAK
//https://mehmetserkanekinci.medium.com/automapper-ve-dto-nedir-ve-nas%C4%B1l-kullan%C4%B1l%C4%B1r-c6c0d6621168