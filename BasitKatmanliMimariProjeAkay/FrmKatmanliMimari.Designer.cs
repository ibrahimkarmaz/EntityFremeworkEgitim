
namespace BasitKatmanliMimariProjeAkay
{
    partial class FrmKatmanliMimari
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
            this.PersonelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adsoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aDRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxeAramaKonusu = new DevExpress.XtraEditors.TextEdit();
            this.TePersonelID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TeTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TeAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TeMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.CeBirim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CeDurum = new DevExpress.XtraEditors.CheckEdit();
            this.DTTarih = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.SBtnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SbtnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxeAramaKonusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TePersonelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(783, 248);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PersonelID,
            this.BirimAd,
            this.Adsoyad,
            this.Telefon,
            this.aDRES,
            this.Email,
            this.Tarih,
            this.IsActive,
            this.BirimID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // PersonelID
            // 
            this.PersonelID.Caption = "Personel ID";
            this.PersonelID.FieldName = "PersonelID";
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Visible = true;
            this.PersonelID.VisibleIndex = 0;
            // 
            // BirimAd
            // 
            this.BirimAd.Caption = "Birim Adı";
            this.BirimAd.FieldName = "BirimAd";
            this.BirimAd.Name = "BirimAd";
            this.BirimAd.Visible = true;
            this.BirimAd.VisibleIndex = 1;
            // 
            // Adsoyad
            // 
            this.Adsoyad.Caption = "Adı Soyadı";
            this.Adsoyad.FieldName = "AdSoyad";
            this.Adsoyad.Name = "Adsoyad";
            this.Adsoyad.Visible = true;
            this.Adsoyad.VisibleIndex = 2;
            // 
            // Telefon
            // 
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 3;
            // 
            // aDRES
            // 
            this.aDRES.Caption = "Adres";
            this.aDRES.FieldName = "aDRES";
            this.aDRES.Name = "aDRES";
            this.aDRES.Visible = true;
            this.aDRES.VisibleIndex = 4;
            // 
            // Email
            // 
            this.Email.Caption = "E-Posta";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 5;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 6;
            // 
            // IsActive
            // 
            this.IsActive.Caption = "IsActive";
            this.IsActive.FieldName = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = true;
            this.IsActive.VisibleIndex = 7;
            // 
            // BirimID
            // 
            this.BirimID.Caption = "Birim ID";
            this.BirimID.FieldName = "BirimID";
            this.BirimID.Name = "BirimID";
            this.BirimID.Visible = true;
            this.BirimID.VisibleIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Personel Ara:";
            // 
            // TxeAramaKonusu
            // 
            this.TxeAramaKonusu.Location = new System.Drawing.Point(83, 9);
            this.TxeAramaKonusu.Name = "TxeAramaKonusu";
            this.TxeAramaKonusu.Size = new System.Drawing.Size(176, 20);
            this.TxeAramaKonusu.TabIndex = 2;
            this.TxeAramaKonusu.EditValueChanged += new System.EventHandler(this.TxeAramaKonusu_EditValueChanged);
            // 
            // TePersonelID
            // 
            this.TePersonelID.Location = new System.Drawing.Point(83, 312);
            this.TePersonelID.Name = "TePersonelID";
            this.TePersonelID.Size = new System.Drawing.Size(176, 20);
            this.TePersonelID.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 315);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Personel ID:";
            // 
            // TeAdSoyad
            // 
            this.TeAdSoyad.Location = new System.Drawing.Point(83, 338);
            this.TeAdSoyad.Name = "TeAdSoyad";
            this.TeAdSoyad.Size = new System.Drawing.Size(176, 20);
            this.TeAdSoyad.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 341);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ad Soyad:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 367);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Birim:";
            // 
            // TeTelefon
            // 
            this.TeTelefon.Location = new System.Drawing.Point(83, 390);
            this.TeTelefon.Name = "TeTelefon";
            this.TeTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TeTelefon.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TeTelefon.Properties.MaskSettings.Set("mask", "(000) 000 00 00");
            this.TeTelefon.Size = new System.Drawing.Size(176, 20);
            this.TeTelefon.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 393);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Telefon:";
            // 
            // TeAdres
            // 
            this.TeAdres.Location = new System.Drawing.Point(303, 316);
            this.TeAdres.Name = "TeAdres";
            this.TeAdres.Properties.AutoHeight = false;
            this.TeAdres.Size = new System.Drawing.Size(467, 107);
            this.TeAdres.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(265, 319);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Adres:";
            // 
            // TeMail
            // 
            this.TeMail.Location = new System.Drawing.Point(83, 416);
            this.TeMail.Name = "TeMail";
            this.TeMail.Size = new System.Drawing.Size(176, 20);
            this.TeMail.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 419);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "E-Mail:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 445);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Tarih:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 289);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Aktif Mi:";
            // 
            // CeBirim
            // 
            this.CeBirim.Location = new System.Drawing.Point(83, 364);
            this.CeBirim.Name = "CeBirim";
            this.CeBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CeBirim.Properties.NullValuePrompt = "Birim Seçiniz...";
            this.CeBirim.Properties.Tag = "";
            this.CeBirim.Size = new System.Drawing.Size(176, 20);
            this.CeBirim.TabIndex = 19;
            // 
            // CeDurum
            // 
            this.CeDurum.Location = new System.Drawing.Point(83, 286);
            this.CeDurum.Name = "CeDurum";
            this.CeDurum.Properties.Caption = "";
            this.CeDurum.Size = new System.Drawing.Size(22, 20);
            this.CeDurum.TabIndex = 20;
            // 
            // DTTarih
            // 
            this.DTTarih.EditValue = null;
            this.DTTarih.Location = new System.Drawing.Point(83, 442);
            this.DTTarih.Name = "DTTarih";
            this.DTTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTTarih.Size = new System.Drawing.Size(176, 20);
            this.DTTarih.TabIndex = 21;
            // 
            // SBtnYeni
            // 
            this.SBtnYeni.ImageOptions.Image = global::BasitKatmanliMimariProjeAkay.Properties.Resources.newcustomers_32x32;
            this.SBtnYeni.Location = new System.Drawing.Point(395, 429);
            this.SBtnYeni.Name = "SBtnYeni";
            this.SBtnYeni.Size = new System.Drawing.Size(121, 34);
            this.SBtnYeni.TabIndex = 22;
            this.SBtnYeni.Text = "Yeni";
            this.SBtnYeni.Click += new System.EventHandler(this.SBtnYeni_Click);
            // 
            // SBtnKaydet
            // 
            this.SBtnKaydet.ImageOptions.Image = global::BasitKatmanliMimariProjeAkay.Properties.Resources.add_32x32;
            this.SBtnKaydet.Location = new System.Drawing.Point(522, 429);
            this.SBtnKaydet.Name = "SBtnKaydet";
            this.SBtnKaydet.Size = new System.Drawing.Size(121, 34);
            this.SBtnKaydet.TabIndex = 23;
            this.SBtnKaydet.Text = "Kaydet";
            // 
            // SbtnSil
            // 
            this.SbtnSil.ImageOptions.Image = global::BasitKatmanliMimariProjeAkay.Properties.Resources.clear_32x32;
            this.SbtnSil.Location = new System.Drawing.Point(649, 428);
            this.SbtnSil.Name = "SbtnSil";
            this.SbtnSil.Size = new System.Drawing.Size(121, 34);
            this.SbtnSil.TabIndex = 24;
            this.SbtnSil.Text = "Sil";
            // 
            // FrmKatmanliMimari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 474);
            this.Controls.Add(this.SbtnSil);
            this.Controls.Add(this.SBtnKaydet);
            this.Controls.Add(this.SBtnYeni);
            this.Controls.Add(this.DTTarih);
            this.Controls.Add(this.CeDurum);
            this.Controls.Add(this.CeBirim);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.TeMail);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TeAdres);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TeTelefon);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TeAdSoyad);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TePersonelID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxeAramaKonusu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKatmanliMimari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basit Katmanlı Mimari Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxeAramaKonusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TePersonelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxeAramaKonusu;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelID;
        private DevExpress.XtraGrid.Columns.GridColumn BirimAd;
        private DevExpress.XtraGrid.Columns.GridColumn Adsoyad;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn aDRES;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn IsActive;
        private DevExpress.XtraGrid.Columns.GridColumn BirimID;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraEditors.TextEdit TePersonelID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TeTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TeAdres;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TeMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit CeBirim;
        private DevExpress.XtraEditors.CheckEdit CeDurum;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DTTarih;
        private DevExpress.XtraEditors.SimpleButton SBtnYeni;
        private DevExpress.XtraEditors.SimpleButton SBtnKaydet;
        private DevExpress.XtraEditors.SimpleButton SbtnSil;
    }
}

