
namespace ModelFistEntityFrameWork1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeID = new DevExpress.XtraEditors.TextEdit();
            this.TeAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TeSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TeSehir = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TeMaas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSehir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(305, 17);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(57, 48);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(368, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(210, 33);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Personel İşlemleri";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // TeID
            // 
            this.TeID.Location = new System.Drawing.Point(88, 89);
            this.TeID.Name = "TeID";
            this.TeID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeID.Properties.Appearance.Options.UseFont = true;
            this.TeID.Size = new System.Drawing.Size(185, 22);
            this.TeID.TabIndex = 3;
            // 
            // TeAd
            // 
            this.TeAd.Location = new System.Drawing.Point(88, 117);
            this.TeAd.Name = "TeAd";
            this.TeAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeAd.Properties.Appearance.Options.UseFont = true;
            this.TeAd.Size = new System.Drawing.Size(185, 22);
            this.TeAd.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ad";
            // 
            // TeSoyad
            // 
            this.TeSoyad.Location = new System.Drawing.Point(88, 145);
            this.TeSoyad.Name = "TeSoyad";
            this.TeSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeSoyad.Properties.Appearance.Options.UseFont = true;
            this.TeSoyad.Size = new System.Drawing.Size(185, 22);
            this.TeSoyad.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Soyad:";
            // 
            // TeSehir
            // 
            this.TeSehir.Location = new System.Drawing.Point(88, 173);
            this.TeSehir.Name = "TeSehir";
            this.TeSehir.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeSehir.Properties.Appearance.Options.UseFont = true;
            this.TeSehir.Size = new System.Drawing.Size(185, 22);
            this.TeSehir.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 176);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Şehir:";
            // 
            // TeMaas
            // 
            this.TeMaas.Location = new System.Drawing.Point(88, 201);
            this.TeMaas.Name = "TeMaas";
            this.TeMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeMaas.Properties.Appearance.Options.UseFont = true;
            this.TeMaas.Size = new System.Drawing.Size(185, 22);
            this.TeMaas.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Maaş:";
            // 
            // SBtnEkle
            // 
            this.SBtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnEkle.Appearance.Options.UseFont = true;
            this.SBtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnEkle.Location = new System.Drawing.Point(12, 239);
            this.SBtnEkle.Name = "SBtnEkle";
            this.SBtnEkle.Size = new System.Drawing.Size(261, 37);
            this.SBtnEkle.TabIndex = 12;
            this.SBtnEkle.Text = "Ekle";
            this.SBtnEkle.Click += new System.EventHandler(this.SBtnEkle_Click);
            // 
            // SBtnListele
            // 
            this.SBtnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnListele.Appearance.Options.UseFont = true;
            this.SBtnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnListele.Location = new System.Drawing.Point(12, 368);
            this.SBtnListele.Name = "SBtnListele";
            this.SBtnListele.Size = new System.Drawing.Size(261, 37);
            this.SBtnListele.TabIndex = 13;
            this.SBtnListele.Text = "Listele";
            this.SBtnListele.Click += new System.EventHandler(this.SBtnListele_Click);
            // 
            // SBtnSil
            // 
            this.SBtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnSil.Appearance.Options.UseFont = true;
            this.SBtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSil.Location = new System.Drawing.Point(12, 325);
            this.SBtnSil.Name = "SBtnSil";
            this.SBtnSil.Size = new System.Drawing.Size(261, 37);
            this.SBtnSil.TabIndex = 14;
            this.SBtnSil.Text = "Sil";
            this.SBtnSil.Click += new System.EventHandler(this.SBtnSil_Click);
            // 
            // SBtnGuncelle
            // 
            this.SBtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnGuncelle.Appearance.Options.UseFont = true;
            this.SBtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnGuncelle.Location = new System.Drawing.Point(12, 282);
            this.SBtnGuncelle.Name = "SBtnGuncelle";
            this.SBtnGuncelle.Size = new System.Drawing.Size(261, 37);
            this.SBtnGuncelle.TabIndex = 15;
            this.SBtnGuncelle.Text = "Güncelle";
            this.SBtnGuncelle.Click += new System.EventHandler(this.SBtnGuncelle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(279, 92);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(632, 313);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(584, 17);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(57, 48);
            this.pictureEdit2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 421);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.SBtnGuncelle);
            this.Controls.Add(this.SBtnSil);
            this.Controls.Add(this.SBtnListele);
            this.Controls.Add(this.SBtnEkle);
            this.Controls.Add(this.TeMaas);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TeSehir);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TeSoyad);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TeAd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TeID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSehir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeID;
        private DevExpress.XtraEditors.TextEdit TeAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TeSehir;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TeMaas;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SBtnEkle;
        private DevExpress.XtraEditors.SimpleButton SBtnListele;
        private DevExpress.XtraEditors.SimpleButton SBtnSil;
        private DevExpress.XtraEditors.SimpleButton SBtnGuncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}

