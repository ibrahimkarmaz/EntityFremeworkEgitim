using BasitKatmanliMimariProjeAkay.DataAccessL;
using BasitKatmanliMimariProjeAkay.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BasitKatmanliMimariProjeAkay
{
    public partial class FrmKatmanliMimari : Form
    {
        public FrmKatmanliMimari()
        {
            InitializeComponent();
        }
        ViewPersonelBirimDAL vpbdal = new ViewPersonelBirimDAL();
        BirimDAL bd = new BirimDAL();
        Personeller p = new Personeller();//Veri kaynağı
        PersonelDAL pdal = new PersonelDAL();
        public void Yenile()
        {
            gridControl1.DataSource =vpbdal.GetList();

            /*NOT: Hoca burada ComboBox kullandığı için datasource getlist mantıyla aldı ve alan adını birimad olarak göster
             Biz ise: ComboBoxEdit kullandığımız için ilk birimleri oluşturduk sonra listeyi ve column(Birimad) Listeye ekledik bu listeyide comboboxedit'in içine.*/
            List<string> Birimler = new List<string>();
            foreach (var item in bd.GetList())
            {
                Birimler.Add(item.BirimAd);
            }
            CeBirim.Properties.Items.AddRange(Birimler);
        }
        void  ClearDataBinding()//Bağlanma verileri temizleme
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Personeller person)//person1
        {
            this.p = person;
            ClearDataBinding();
            TePersonelID.DataBindings.Add("Text",p,"PersonelID");
            TeAdSoyad.DataBindings.Add("Text",p, "AdSoyad");
            TeTelefon.DataBindings.Add("Text",p, "Telefon");
            TeAdres.DataBindings.Add("Text",p, "aDRES");
            TeMail.DataBindings.Add("Text",p, "Email");
           // CeBirim.DataBindings.Add("SelectedValue",p, "BirimID",true);
            DTTarih.DataBindings.Add("Text",p, "Tarih");
            CeDurum.DataBindings.Add("CheckState",p, "IsActive", true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
            Data_Binding(new Personeller());
            gridView1.OptionsBehavior.ReadOnly = true;
            // Izgarayı salt okunur yap.
            gridView1.OptionsBehavior.Editable = false;
            // Odaklanılan hücrenin vurgulanmasını engelle.
           //gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Tüm satırın etrafına noktalı bir odak dikdörtgeni çizin.
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }

        private void TxeAramaKonusu_EditValueChanged(object sender, EventArgs e)
        {/*ARAMA İŞLEMİNDE ALANIN İÇERİĞİNDE ARAMA YAPILACAĞI İÇİN CONTAİNT KULLANULUR TEK VERİ ÇEKMEYİ SAĞLAR.*/
            gridControl1.DataSource = vpbdal.GetList(x => x.AdSoyad.Contains(TxeAramaKonusu.Text));
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            int personelid = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["PersonelID"]).ToString());
            Data_Binding(pdal.GetByFilter(x=>x.PersonelID==personelid));
        }

        private void SBtnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Personeller());
        }
    }
}
