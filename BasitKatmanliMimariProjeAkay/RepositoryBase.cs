using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasitKatmanliMimariProjeAkay
{/*BURASI ANLADIĞIM KADARIYLA BİRİM OLUŞTURDUĞUMUZ MODELLERİ ÇAĞRICAĞIMIZ VE İŞLEM YAPACAĞIMIZ YERDİR
  Where Entitiy:class,new()
    Entitiy Sınıflar ile çalışacağını belirtiyor yeni sınıf.
  Where Context:DbContext,new()
    bağlam ma işlemleri yapılacak fakat dbcontextten buda veritabani işlemlerini yapmamınızı sağlıyor.



    ENG-TR:
    ContexT: Bağlam
    EntityState: Varlık Durumu
    Expression: ifade
    Func: İşlev
  */
    public class RepositoryBase<Entity,Context> where Entity:class,new() where Context:DbContext,new()
    {
        Context db = new Context();
        public void AddorUpdate(Entity entitiy)//Ekleme ve güncelleme metodu
        {
            db.Set<Entity>().AddOrUpdate(entitiy);
        }
        public void Delete(EntityState entity,Expression<Func<Entity,bool>>obj)//silme metodu
        {/*obj kısmı şart verileri*/
            var model = db.Set<Entity>().FirstOrDefault(obj);//Silme kritelerini belirtiyoruz.
            db.Set<Entity>().Remove(model);
        }
        public List<Entity> GetList(Entity entity, Expression<Func<Entity, bool>> obj=null)//Listeleme Metodu Parametre kullanımı yapılabilir.
        {/*obj kısmı şart verileri*/
            List<Entity> liste;
            if (obj==null)
               liste= db.Set<Entity>().ToList();
            else
                liste = db.Set<Entity>().Where(obj).ToList();
            return liste;
        }
        public Entity GetByFilter(Entity entity, Expression<Func<Entity, bool>> obj)//PARAMETRE KULLANIMINA BAĞLI TEK KAYIT GETİRME
        {
            return db.Set<Entity>().FirstOrDefault(obj);
        }
        public void Save()//kayıt metodu
        {
            db.SaveChanges();
        }



    }
}
