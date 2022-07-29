using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer.Entities;
using System.Data.Entity;

namespace PersonelTakipSistemi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelManager PersonelIslemleri = new PersonelManager();
        DepartmanManager DepartmanIslemleri = new DepartmanManager();
        Personel personel;
        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelListele();
            DepartmanListele();
        }
        
        private void PersonelListele()
        {
            gridControl1.DataSource = PersonelIslemleri.PersonelListele();
        } 
        private void DepartmanListele()
        {
            lookUpEdit1.Properties.DataSource = DepartmanIslemleri.DepartmanListele();
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns[2].Visible = false;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            personel = new Personel();
            personel.Ad = textEdit1.Text;
            personel.Soyad = textEdit2.Text;
            personel.Cinsiyet = Convert.ToBoolean(comboBoxEdit1.SelectedIndex);
            personel.DepartmanID = Convert.ToInt32(lookUpEdit1.EditValue);
            PersonelIslemleri.PersonelEkle(personel);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            personel = new Personel();
            personel.ID = id;
            personel.Ad = textEdit1.Text;
            personel.Soyad = textEdit2.Text;
            personel.Cinsiyet = Convert.ToBoolean(comboBoxEdit1.SelectedIndex);
            personel.DepartmanID = Convert.ToInt32(lookUpEdit1.EditValue);
            PersonelIslemleri.PersonelUpdate(personel);
        }
        int id;
       
        private void gridView1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
            textEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            textEdit2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString()=="ERKEK")
            {
                comboBoxEdit1.SelectedIndex = 1;
            }
            else
            {
                comboBoxEdit1.SelectedIndex = 0;
            }
            lookUpEdit1.Text=(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString());
            //ÜSTEKİ KOD DOĞRU ÇALIŞMAMAKTADIR TAM VERİYİ ALMAK İÇİN VERİTABANINA BAĞLANMAK GEREKİYOR ARAŞTIRMA YAPILIYOR GÜNCELLENECEK.
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PersonelIslemleri.PersonelSil(id);
        }
    }
}
