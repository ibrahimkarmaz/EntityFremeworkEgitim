
namespace EntitiyFrameworkVeLinqDersleriMY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SBtnOgrenciListe = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnBul = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TeOgrenciID = new DevExpress.XtraEditors.TextEdit();
            this.TeOgrenciAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeOgrenciSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TeFotograf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TeDersID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TeDersAd = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TeDurum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TeSinav1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TeOrtalama = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TeSinav3 = new DevExpress.XtraEditors.TextEdit();
            this.TeSinav2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnDersListe = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnNotListe = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnDersKayit = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnProcedureNotListesi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeOgrenciID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeOgrenciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeOgrenciSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeFotograf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeDersID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDersAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSinav1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSinav3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSinav2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(732, 191);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SBtnOgrenciListe
            // 
            this.SBtnOgrenciListe.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.user_32x32;
            this.SBtnOgrenciListe.Location = new System.Drawing.Point(152, 7);
            this.SBtnOgrenciListe.Name = "SBtnOgrenciListe";
            this.SBtnOgrenciListe.Size = new System.Drawing.Size(134, 39);
            this.SBtnOgrenciListe.TabIndex = 1;
            this.SBtnOgrenciListe.Text = "Öğrenci Listele";
            this.SBtnOgrenciListe.Click += new System.EventHandler(this.SBtnOgrenciListe_Click);
            // 
            // SBtnKaydet
            // 
            this.SBtnKaydet.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.add_32x32;
            this.SBtnKaydet.Location = new System.Drawing.Point(12, 249);
            this.SBtnKaydet.Name = "SBtnKaydet";
            this.SBtnKaydet.Size = new System.Drawing.Size(134, 39);
            this.SBtnKaydet.TabIndex = 2;
            this.SBtnKaydet.Text = "Kaydet";
            this.SBtnKaydet.Click += new System.EventHandler(this.SBtnKaydet_Click);
            // 
            // SBtnSil
            // 
            this.SBtnSil.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.clear_32x32;
            this.SBtnSil.Location = new System.Drawing.Point(12, 294);
            this.SBtnSil.Name = "SBtnSil";
            this.SBtnSil.Size = new System.Drawing.Size(134, 39);
            this.SBtnSil.TabIndex = 3;
            this.SBtnSil.Text = "Sil";
            this.SBtnSil.Click += new System.EventHandler(this.SBtnSil_Click);
            // 
            // SBtnGuncelle
            // 
            this.SBtnGuncelle.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.reset2_32x32;
            this.SBtnGuncelle.Location = new System.Drawing.Point(12, 339);
            this.SBtnGuncelle.Name = "SBtnGuncelle";
            this.SBtnGuncelle.Size = new System.Drawing.Size(134, 39);
            this.SBtnGuncelle.TabIndex = 4;
            this.SBtnGuncelle.Text = "Güncelle";
            this.SBtnGuncelle.Click += new System.EventHandler(this.SBtnGuncelle_Click);
            // 
            // SBtnBul
            // 
            this.SBtnBul.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.find_32x32;
            this.SBtnBul.Location = new System.Drawing.Point(610, 7);
            this.SBtnBul.Name = "SBtnBul";
            this.SBtnBul.Size = new System.Drawing.Size(134, 39);
            this.SBtnBul.TabIndex = 5;
            this.SBtnBul.Text = "Bul";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "ID:";
            // 
            // TeOgrenciID
            // 
            this.TeOgrenciID.Location = new System.Drawing.Point(110, 26);
            this.TeOgrenciID.Name = "TeOgrenciID";
            this.TeOgrenciID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeOgrenciID.Properties.Appearance.Options.UseFont = true;
            this.TeOgrenciID.Size = new System.Drawing.Size(171, 24);
            this.TeOgrenciID.TabIndex = 7;
            // 
            // TeOgrenciAd
            // 
            this.TeOgrenciAd.Location = new System.Drawing.Point(110, 56);
            this.TeOgrenciAd.Name = "TeOgrenciAd";
            this.TeOgrenciAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeOgrenciAd.Properties.Appearance.Options.UseFont = true;
            this.TeOgrenciAd.Size = new System.Drawing.Size(171, 24);
            this.TeOgrenciAd.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "AD:";
            // 
            // TeOgrenciSoyad
            // 
            this.TeOgrenciSoyad.Location = new System.Drawing.Point(110, 86);
            this.TeOgrenciSoyad.Name = "TeOgrenciSoyad";
            this.TeOgrenciSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeOgrenciSoyad.Properties.Appearance.Options.UseFont = true;
            this.TeOgrenciSoyad.Size = new System.Drawing.Size(171, 24);
            this.TeOgrenciSoyad.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 18);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "SOYAD:";
            // 
            // TeFotograf
            // 
            this.TeFotograf.Location = new System.Drawing.Point(110, 116);
            this.TeFotograf.Name = "TeFotograf";
            this.TeFotograf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeFotograf.Properties.Appearance.Options.UseFont = true;
            this.TeFotograf.Size = new System.Drawing.Size(171, 24);
            this.TeFotograf.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 18);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "FOTOĞRAF:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TeOgrenciID);
            this.groupControl1.Controls.Add(this.TeFotograf);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TeOgrenciSoyad);
            this.groupControl1.Controls.Add(this.TeOgrenciAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(152, 249);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(293, 153);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Öğrenci";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TeDersID);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.TeDersAd);
            this.groupControl2.Location = new System.Drawing.Point(152, 408);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(293, 93);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Dersler";
            // 
            // TeDersID
            // 
            this.TeDersID.Location = new System.Drawing.Point(110, 26);
            this.TeDersID.Name = "TeDersID";
            this.TeDersID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeDersID.Properties.Appearance.Options.UseFont = true;
            this.TeDersID.Size = new System.Drawing.Size(171, 24);
            this.TeDersID.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(21, 18);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "ID:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(9, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 18);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "AD:";
            // 
            // TeDersAd
            // 
            this.TeDersAd.Location = new System.Drawing.Point(110, 56);
            this.TeDersAd.Name = "TeDersAd";
            this.TeDersAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeDersAd.Properties.Appearance.Options.UseFont = true;
            this.TeDersAd.Size = new System.Drawing.Size(171, 24);
            this.TeDersAd.TabIndex = 9;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.TeDurum);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.TeSinav1);
            this.groupControl3.Controls.Add(this.textEdit7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.TeOrtalama);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.TeSinav3);
            this.groupControl3.Controls.Add(this.TeSinav2);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Location = new System.Drawing.Point(451, 249);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(293, 252);
            this.groupControl3.TabIndex = 16;
            this.groupControl3.Text = "Notlar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.refreshallpivottable_32x32;
            this.simpleButton2.Location = new System.Drawing.Point(110, 212);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(171, 30);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Sınav Notu Güncelle";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.calculationoptions_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(110, 176);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(171, 30);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Hesapla";
            // 
            // TeDurum
            // 
            this.TeDurum.Location = new System.Drawing.Point(110, 146);
            this.TeDurum.Name = "TeDurum";
            this.TeDurum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeDurum.Properties.Appearance.Options.UseFont = true;
            this.TeDurum.Size = new System.Drawing.Size(171, 24);
            this.TeDurum.TabIndex = 15;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(9, 149);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(56, 18);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "DURUM:";
            // 
            // TeSinav1
            // 
            this.TeSinav1.Location = new System.Drawing.Point(110, 26);
            this.TeSinav1.Name = "TeSinav1";
            this.TeSinav1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeSinav1.Properties.Appearance.Options.UseFont = true;
            this.TeSinav1.Size = new System.Drawing.Size(171, 24);
            this.TeSinav1.TabIndex = 7;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(110, 116);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Size = new System.Drawing.Size(171, 24);
            this.textEdit7.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(9, 29);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "SINAV 1:";
            // 
            // TeOrtalama
            // 
            this.TeOrtalama.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeOrtalama.Appearance.Options.UseFont = true;
            this.TeOrtalama.Location = new System.Drawing.Point(9, 119);
            this.TeOrtalama.Name = "TeOrtalama";
            this.TeOrtalama.Size = new System.Drawing.Size(81, 18);
            this.TeOrtalama.TabIndex = 12;
            this.TeOrtalama.Text = "ORTALAMA:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(9, 59);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 18);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "SINAV2:";
            // 
            // TeSinav3
            // 
            this.TeSinav3.Location = new System.Drawing.Point(110, 86);
            this.TeSinav3.Name = "TeSinav3";
            this.TeSinav3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeSinav3.Properties.Appearance.Options.UseFont = true;
            this.TeSinav3.Size = new System.Drawing.Size(171, 24);
            this.TeSinav3.TabIndex = 11;
            // 
            // TeSinav2
            // 
            this.TeSinav2.Location = new System.Drawing.Point(110, 56);
            this.TeSinav2.Name = "TeSinav2";
            this.TeSinav2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeSinav2.Properties.Appearance.Options.UseFont = true;
            this.TeSinav2.Size = new System.Drawing.Size(171, 24);
            this.TeSinav2.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(9, 89);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 18);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "SINAV3:";
            // 
            // SBtnDersListe
            // 
            this.SBtnDersListe.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.listbox_32x321;
            this.SBtnDersListe.Location = new System.Drawing.Point(292, 7);
            this.SBtnDersListe.Name = "SBtnDersListe";
            this.SBtnDersListe.Size = new System.Drawing.Size(134, 39);
            this.SBtnDersListe.TabIndex = 17;
            this.SBtnDersListe.Text = "Ders Listesi";
            this.SBtnDersListe.Click += new System.EventHandler(this.SBtnDersListe_Click);
            // 
            // SBtnNotListe
            // 
            this.SBtnNotListe.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.newtablestyle_32x32;
            this.SBtnNotListe.Location = new System.Drawing.Point(12, 7);
            this.SBtnNotListe.Name = "SBtnNotListe";
            this.SBtnNotListe.Size = new System.Drawing.Size(134, 39);
            this.SBtnNotListe.TabIndex = 18;
            this.SBtnNotListe.Text = "Not Listesi";
            this.SBtnNotListe.Click += new System.EventHandler(this.SBtnNotListe_Click);
            // 
            // SBtnDersKayit
            // 
            this.SBtnDersKayit.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.add_32x32;
            this.SBtnDersKayit.Location = new System.Drawing.Point(12, 384);
            this.SBtnDersKayit.Name = "SBtnDersKayit";
            this.SBtnDersKayit.Size = new System.Drawing.Size(134, 39);
            this.SBtnDersKayit.TabIndex = 19;
            this.SBtnDersKayit.Text = "Ders Kaydet";
            this.SBtnDersKayit.Click += new System.EventHandler(this.SBtnDersKayit_Click);
            // 
            // SBtnProcedureNotListesi
            // 
            this.SBtnProcedureNotListesi.ImageOptions.Image = global::EntitiyFrameworkVeLinqDersleriMY.Properties.Resources.protectworkbook_32x32;
            this.SBtnProcedureNotListesi.Location = new System.Drawing.Point(12, 429);
            this.SBtnProcedureNotListesi.Name = "SBtnProcedureNotListesi";
            this.SBtnProcedureNotListesi.Size = new System.Drawing.Size(134, 39);
            this.SBtnProcedureNotListesi.TabIndex = 20;
            this.SBtnProcedureNotListesi.Text = "PROCEDURE İLE\r\nNOT LİSTESİ";
            this.SBtnProcedureNotListesi.Click += new System.EventHandler(this.SBtnProcedureNotListesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 509);
            this.Controls.Add(this.SBtnProcedureNotListesi);
            this.Controls.Add(this.SBtnDersKayit);
            this.Controls.Add(this.SBtnNotListe);
            this.Controls.Add(this.SBtnDersListe);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.SBtnBul);
            this.Controls.Add(this.SBtnGuncelle);
            this.Controls.Add(this.SBtnSil);
            this.Controls.Add(this.SBtnKaydet);
            this.Controls.Add(this.SBtnOgrenciListe);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeOgrenciID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeOgrenciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeOgrenciSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeFotograf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeDersID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDersAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSinav1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSinav3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSinav2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton SBtnOgrenciListe;
        private DevExpress.XtraEditors.SimpleButton SBtnKaydet;
        private DevExpress.XtraEditors.SimpleButton SBtnSil;
        private DevExpress.XtraEditors.SimpleButton SBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton SBtnBul;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TeOgrenciID;
        private DevExpress.XtraEditors.TextEdit TeOgrenciAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeOgrenciSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeFotograf;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit TeDersID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TeDersAd;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit TeDurum;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TeSinav1;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl TeOrtalama;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TeSinav3;
        private DevExpress.XtraEditors.TextEdit TeSinav2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton SBtnDersListe;
        private DevExpress.XtraEditors.SimpleButton SBtnNotListe;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton SBtnDersKayit;
        private DevExpress.XtraEditors.SimpleButton SBtnProcedureNotListesi;
    }
}

