
namespace EntityFremeWorkProcess2
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.adtext = new DevExpress.XtraEditors.TextEdit();
            this.yonetmentext = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Konutext = new DevExpress.XtraEditors.MemoEdit();
            this.SBtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListele = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetmentext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Konutext.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(572, 316);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 334);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Film Ad:";
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(121, 331);
            this.adtext.Name = "adtext";
            this.adtext.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtext.Properties.Appearance.Options.UseFont = true;
            this.adtext.Size = new System.Drawing.Size(202, 24);
            this.adtext.TabIndex = 2;
            // 
            // yonetmentext
            // 
            this.yonetmentext.Location = new System.Drawing.Point(121, 361);
            this.yonetmentext.Name = "yonetmentext";
            this.yonetmentext.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetmentext.Properties.Appearance.Options.UseFont = true;
            this.yonetmentext.Size = new System.Drawing.Size(202, 24);
            this.yonetmentext.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 364);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Film Yönetmen:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 394);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Film Konu:";
            // 
            // Konutext
            // 
            this.Konutext.Location = new System.Drawing.Point(121, 393);
            this.Konutext.Name = "Konutext";
            this.Konutext.Size = new System.Drawing.Size(202, 104);
            this.Konutext.TabIndex = 6;
            // 
            // SBtnEkle
            // 
            this.SBtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnEkle.Appearance.Options.UseFont = true;
            this.SBtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnEkle.ImageOptions.Image = global::EntityFremeWorkProcess2.Properties.Resources.add_32x32;
            this.SBtnEkle.Location = new System.Drawing.Point(329, 334);
            this.SBtnEkle.Name = "SBtnEkle";
            this.SBtnEkle.Size = new System.Drawing.Size(255, 36);
            this.SBtnEkle.TabIndex = 7;
            this.SBtnEkle.Text = "Ekle";
            this.SBtnEkle.Click += new System.EventHandler(this.SBtnEkle_Click);
            // 
            // SBtnGuncelle
            // 
            this.SBtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnGuncelle.Appearance.Options.UseFont = true;
            this.SBtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnGuncelle.ImageOptions.Image = global::EntityFremeWorkProcess2.Properties.Resources.refreshallpivottable_32x32;
            this.SBtnGuncelle.Location = new System.Drawing.Point(329, 376);
            this.SBtnGuncelle.Name = "SBtnGuncelle";
            this.SBtnGuncelle.Size = new System.Drawing.Size(255, 36);
            this.SBtnGuncelle.TabIndex = 8;
            this.SBtnGuncelle.Text = "Güncelle";
            this.SBtnGuncelle.Click += new System.EventHandler(this.SBtnGuncelle_Click);
            // 
            // SBtnSil
            // 
            this.SBtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnSil.Appearance.Options.UseFont = true;
            this.SBtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSil.ImageOptions.Image = global::EntityFremeWorkProcess2.Properties.Resources.remove_32x32;
            this.SBtnSil.Location = new System.Drawing.Point(329, 418);
            this.SBtnSil.Name = "SBtnSil";
            this.SBtnSil.Size = new System.Drawing.Size(255, 36);
            this.SBtnSil.TabIndex = 9;
            this.SBtnSil.Text = "Seçili Fİlmi Sil";
            this.SBtnSil.Click += new System.EventHandler(this.SBtnSil_Click);
            // 
            // SBtnListele
            // 
            this.SBtnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SBtnListele.Appearance.Options.UseFont = true;
            this.SBtnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnListele.ImageOptions.Image = global::EntityFremeWorkProcess2.Properties.Resources.listbox_32x32;
            this.SBtnListele.Location = new System.Drawing.Point(329, 460);
            this.SBtnListele.Name = "SBtnListele";
            this.SBtnListele.Size = new System.Drawing.Size(255, 36);
            this.SBtnListele.TabIndex = 10;
            this.SBtnListele.Text = "Listele";
            this.SBtnListele.Click += new System.EventHandler(this.SBtnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 509);
            this.Controls.Add(this.SBtnListele);
            this.Controls.Add(this.SBtnSil);
            this.Controls.Add(this.SBtnGuncelle);
            this.Controls.Add(this.SBtnEkle);
            this.Controls.Add(this.Konutext);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.yonetmentext);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.adtext);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetmentext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Konutext.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit adtext;
        private DevExpress.XtraEditors.TextEdit yonetmentext;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit Konutext;
        private DevExpress.XtraEditors.SimpleButton SBtnEkle;
        private DevExpress.XtraEditors.SimpleButton SBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton SBtnSil;
        private DevExpress.XtraEditors.SimpleButton SBtnListele;
    }
}

