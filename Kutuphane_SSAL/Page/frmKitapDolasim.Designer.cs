
namespace Kutuphane_SSAL.Page
{
    partial class frmKitapDolasim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapDolasim));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncel = new DevExpress.XtraEditors.SimpleButton();
            this.btnGecmis = new DevExpress.XtraEditors.SimpleButton();
            this.lblYetkili = new DevExpress.XtraEditors.LabelControl();
            this.lblBugun = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeriAlim = new DevExpress.XtraEditors.SimpleButton();
            this.txtOgrAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(985, 551);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnGuncel);
            this.panel1.Controls.Add(this.btnGecmis);
            this.panel1.Controls.Add(this.lblYetkili);
            this.panel1.Controls.Add(this.lblBugun);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGeriAlim);
            this.panel1.Controls.Add(this.txtOgrAd);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtKad);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtKid);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(985, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 551);
            this.panel1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(19, 498);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(202, 41);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Dışa Aktar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(122, 452);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(99, 41);
            this.btnGuncel.TabIndex = 16;
            this.btnGuncel.Text = "Güncel Dolaşım";
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnGecmis
            // 
            this.btnGecmis.Location = new System.Drawing.Point(19, 452);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(99, 41);
            this.btnGecmis.TabIndex = 15;
            this.btnGecmis.Text = "Geçmiş Dolaşım";
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // lblYetkili
            // 
            this.lblYetkili.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkili.Appearance.Options.UseFont = true;
            this.lblYetkili.Location = new System.Drawing.Point(89, 12);
            this.lblYetkili.Name = "lblYetkili";
            this.lblYetkili.Size = new System.Drawing.Size(101, 21);
            this.lblYetkili.TabIndex = 14;
            this.lblYetkili.Text = "Selda Bağcan";
            this.lblYetkili.Visible = false;
            // 
            // lblBugun
            // 
            this.lblBugun.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBugun.Appearance.Options.UseFont = true;
            this.lblBugun.Location = new System.Drawing.Point(89, 35);
            this.lblBugun.Name = "lblBugun";
            this.lblBugun.Size = new System.Drawing.Size(38, 21);
            this.lblBugun.TabIndex = 13;
            this.lblBugun.Text = "Tarih";
            this.lblBugun.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(19, 75);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(202, 28);
            this.txtid.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 21);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "ID";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(19, 405);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(202, 41);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Kayıdı Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriAlim
            // 
            this.btnGeriAlim.Location = new System.Drawing.Point(19, 358);
            this.btnGeriAlim.Name = "btnGeriAlim";
            this.btnGeriAlim.Size = new System.Drawing.Size(202, 41);
            this.btnGeriAlim.TabIndex = 8;
            this.btnGeriAlim.Text = "Geri Alım";
            this.btnGeriAlim.Click += new System.EventHandler(this.btnGeriAlim_Click);
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Enabled = false;
            this.txtOgrAd.Location = new System.Drawing.Point(19, 260);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtOgrAd.Properties.Appearance.Options.UseFont = true;
            this.txtOgrAd.Size = new System.Drawing.Size(202, 28);
            this.txtOgrAd.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 233);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Öğrenci Ad";
            // 
            // txtKad
            // 
            this.txtKad.Enabled = false;
            this.txtKad.Location = new System.Drawing.Point(19, 197);
            this.txtKad.Name = "txtKad";
            this.txtKad.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtKad.Properties.Appearance.Options.UseFont = true;
            this.txtKad.Size = new System.Drawing.Size(202, 28);
            this.txtKad.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 170);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kitap Ad";
            // 
            // txtKid
            // 
            this.txtKid.Enabled = false;
            this.txtKid.Location = new System.Drawing.Point(19, 136);
            this.txtKid.Name = "txtKid";
            this.txtKid.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtKid.Properties.Appearance.Options.UseFont = true;
            this.txtKid.Size = new System.Drawing.Size(202, 28);
            this.txtKid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap ID";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(19, 311);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(39, 41);
            this.simpleButton2.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(64, 325);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Kısayol ENTER tuşu";
            // 
            // frmKitapDolasim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 551);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKitapDolasim";
            this.Text = "frmKitapDolasim";
            this.Load += new System.EventHandler(this.frmKitapDolasim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGeriAlim;
        private DevExpress.XtraEditors.TextEdit txtOgrAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblBugun;
        private DevExpress.XtraEditors.LabelControl lblYetkili;
        private DevExpress.XtraEditors.SimpleButton btnGecmis;
        private DevExpress.XtraEditors.SimpleButton btnGuncel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}