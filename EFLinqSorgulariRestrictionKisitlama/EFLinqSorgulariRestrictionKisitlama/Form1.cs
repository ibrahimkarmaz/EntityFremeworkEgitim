using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFLinqSorgulariRestrictionKisitlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbIsTakipEntities dataBase = new DbIsTakipEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            // GetAll();
        }
        private void GetAll()
        {

            gridControl1.DataSource = (from x in dataBase.TblPersonels
                                       select new
                                       {
                                           x.ID,
                                           x.Ad,
                                           x.Soyad,
                                           x.Mail,
                                       }).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gridControl1.DataSource = (from x in dataBase.TblPersonels
                                           select new
                                           {
                                               x.ID,
                                               Ad = x.Ad.Substring(0, 1).ToUpper() + x.Ad.Substring(1).ToLower(),
                                               Soyad = x.Soyad.ToUpper(),
                                               x.Mail,
                                           }).ToList();
            }

            if (radioButton2.Checked)
            {
                gridControl1.DataSource = (from x in dataBase.TblPersonels
                                           select new
                                           {
                                               x.ID,
                                               Ad = x.Ad.Substring(0, 1).ToUpper() + x.Ad.Substring(1).ToLower(),
                                               Soyad = x.Soyad.ToUpper(),
                                               x.Mail,
                                               Durum = x.Arsiv==true ? "AKTİF":"PASİF"
                                           }).ToList();
            }

            if (radioButton3.Checked)
            {//Select Kullanımları
                gridControl1.DataSource = dataBase.TblPersonels.Select(x => new { DepartmanAd = x.TblDepartmanlar.Ad }).ToList();
            }

            if (radioButton4.Checked)
            {//SelectMany 
                gridControl1.DataSource = (dataBase.TblPersonels.SelectMany(x => dataBase.TblDepartmanlars.Where(y => y.ID == x.DepartmanID), (x, y) => new
                {
                    AdSoyad = x.Ad + " " + x.Soyad,
                    DepartmanAd = y.Ad
                })).ToList();
            }



            if (radioButton5.Checked)
            { //Take:sql top kodu
                gridControl1.DataSource = (dataBase.TblPersonels.OrderBy(x=>x.ID).Take(3).ToList());
            } 
            
            if (radioButton6.Checked)
            { //TersSırala
                gridControl1.DataSource = (dataBase.TblPersonels.OrderByDescending(x=>x.ID).Take(5).ToList());
            }
            if (radioButton7.Checked)
            { //OrderBy
                gridControl1.DataSource = (dataBase.TblPersonels.OrderBy(x => x.Ad).ToList());
            }
            if (radioButton8.Checked)
            { //Skip:Atlama yapar
                gridControl1.DataSource = (dataBase.TblPersonels.OrderBy(x => x.ID).Skip(5).ToList());
            }
            if (radioButton9.Checked)
            { //Then By:Order bydan sonra işlemi alınan yeni siralama türü (Her zaman Order By 1. Sıralamayı yapar sonra 2.Sıralamayı Then By yapar)
                gridControl1.DataSource = (dataBase.TblPersonels.OrderBy(x => x.Soyad).ThenBy(y=>y.Ad).ToList());
            }//Ekstra:ThenByDescending:2.Ters Sıralama

























            if (radioButton10.Checked)
            {
                GetAll();
            }
        }
    }
}
