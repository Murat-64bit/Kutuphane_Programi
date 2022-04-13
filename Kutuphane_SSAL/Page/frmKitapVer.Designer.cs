
namespace Kutuphane_SSAL.Page
{
    partial class frmKitapVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapVer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnBarkod = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblSonTarih = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtKid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtYazar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtOgrNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSayfa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblYetkili = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayfa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 503);
            this.panel2.TabIndex = 4;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl2.Location = new System.Drawing.Point(625, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(606, 353);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.Click += new System.EventHandler(this.gridView2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(625, 353);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.btnBarkod);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.lblSonTarih);
            this.panel1.Controls.Add(this.txtOgrid);
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.txtBarkod);
            this.panel1.Controls.Add(this.labelControl12);
            this.panel1.Controls.Add(this.txtKid);
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Controls.Add(this.txtYazar);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtOgrNo);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtSayfa);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtOgrAd);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 150);
            this.panel1.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(843, 113);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 13);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Kısayol ENTER tuşu";
            // 
            // btnBarkod
            // 
            this.btnBarkod.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnBarkod.Location = new System.Drawing.Point(941, 97);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(39, 41);
            this.btnBarkod.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(522, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(134, 21);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Son Teslim Tarihi:";
            // 
            // lblSonTarih
            // 
            this.lblSonTarih.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonTarih.Appearance.Options.UseFont = true;
            this.lblSonTarih.Location = new System.Drawing.Point(662, 113);
            this.lblSonTarih.Name = "lblSonTarih";
            this.lblSonTarih.Size = new System.Drawing.Size(80, 21);
            this.lblSonTarih.TabIndex = 13;
            this.lblSonTarih.Text = "00.00.0000";
            // 
            // txtOgrid
            // 
            this.txtOgrid.Enabled = false;
            this.txtOgrid.Location = new System.Drawing.Point(1083, 45);
            this.txtOgrid.Name = "txtOgrid";
            this.txtOgrid.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtOgrid.Properties.Appearance.Options.UseFont = true;
            this.txtOgrid.Size = new System.Drawing.Size(75, 28);
            this.txtOgrid.TabIndex = 18;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(1083, 18);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 21);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Öğrenci ID";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Enabled = false;
            this.txtBarkod.Location = new System.Drawing.Point(756, 45);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtBarkod.Properties.Appearance.Options.UseFont = true;
            this.txtBarkod.Size = new System.Drawing.Size(202, 28);
            this.txtBarkod.TabIndex = 16;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(986, 18);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 21);
            this.labelControl12.TabIndex = 15;
            this.labelControl12.Text = "Kitap ID";
            // 
            // txtKid
            // 
            this.txtKid.Enabled = false;
            this.txtKid.Location = new System.Drawing.Point(986, 45);
            this.txtKid.Name = "txtKid";
            this.txtKid.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtKid.Properties.Appearance.Options.UseFont = true;
            this.txtKid.Size = new System.Drawing.Size(75, 28);
            this.txtKid.TabIndex = 14;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(286, 83);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(88, 21);
            this.labelControl13.TabIndex = 13;
            this.labelControl13.Text = "Öğrenci No:";
            // 
            // txtYazar
            // 
            this.txtYazar.Enabled = false;
            this.txtYazar.Location = new System.Drawing.Point(286, 45);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtYazar.Properties.Appearance.Options.UseFont = true;
            this.txtYazar.Size = new System.Drawing.Size(202, 28);
            this.txtYazar.TabIndex = 12;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(52, 83);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(136, 21);
            this.labelControl14.TabIndex = 11;
            this.labelControl14.Text = "Öğrenci Ad Soyad:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(986, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(176, 41);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Kitap Ver";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(283, 110);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtOgrNo.Properties.Appearance.Options.UseFont = true;
            this.txtOgrNo.Size = new System.Drawing.Size(202, 28);
            this.txtOgrNo.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(756, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 21);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Kitap Barkodu:";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Enabled = false;
            this.txtSayfa.Location = new System.Drawing.Point(519, 45);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtSayfa.Properties.Appearance.Options.UseFont = true;
            this.txtSayfa.Size = new System.Drawing.Size(202, 28);
            this.txtSayfa.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(519, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Kitap Sayfa:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Enabled = false;
            this.txtOgrAd.Location = new System.Drawing.Point(51, 110);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtOgrAd.Properties.Appearance.Options.UseFont = true;
            this.txtOgrAd.Size = new System.Drawing.Size(202, 28);
            this.txtOgrAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(286, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kitap Yazarı:";
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(51, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(202, 28);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap Adı:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.lblYetkili);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(625, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 48);
            this.panel3.TabIndex = 5;
            // 
            // lblYetkili
            // 
            this.lblYetkili.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkili.Appearance.Options.UseFont = true;
            this.lblYetkili.Location = new System.Drawing.Point(83, 15);
            this.lblYetkili.Name = "lblYetkili";
            this.lblYetkili.Size = new System.Drawing.Size(105, 21);
            this.lblYetkili.TabIndex = 12;
            this.lblYetkili.Text = "Polat Alemdar";
            this.lblYetkili.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(259, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(111, 25);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kitap Listesi";
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Location = new System.Drawing.Point(400, 16);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 21);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "tarih";
            this.lblTarih.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.panel4.Controls.Add(this.labelControl7);
            this.panel4.Controls.Add(this.lblTarih);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(625, 48);
            this.panel4.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(226, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(132, 25);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Öğrenci Listesi";
            // 
            // frmKitapVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKitapVer";
            this.Text = "frmKitapVer";
            this.Load += new System.EventHandler(this.frmKitapVer_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayfa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtOgrNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSayfa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOgrAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtOgrid;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtKid;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtYazar;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl lblYetkili;
        private DevExpress.XtraEditors.LabelControl lblSonTarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnBarkod;
    }
}