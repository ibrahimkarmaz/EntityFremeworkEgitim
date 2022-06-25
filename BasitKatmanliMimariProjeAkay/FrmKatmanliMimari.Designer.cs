
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxeAramaKonusu.Properties)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(783, 295);
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
            // FrmKatmanliMimari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 329);
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
    }
}

