
namespace Kutuphane_SSAL.Page
{
    partial class frmYedekIslemleri
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
            this.chkBtn = new DevExpress.XtraEditors.CheckButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnKayitAl = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBtn
            // 
            this.chkBtn.Location = new System.Drawing.Point(21, 12);
            this.chkBtn.Name = "chkBtn";
            this.chkBtn.Size = new System.Drawing.Size(193, 61);
            this.chkBtn.TabIndex = 6;
            this.chkBtn.Text = "Her Çıkışımda Kayıt Al!";
            this.chkBtn.CheckedChanged += new System.EventHandler(this.chkBtn_CheckedChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1234, 472);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnKayitAl
            // 
            this.btnKayitAl.Location = new System.Drawing.Point(220, 12);
            this.btnKayitAl.Name = "btnKayitAl";
            this.btnKayitAl.Size = new System.Drawing.Size(193, 61);
            this.btnKayitAl.TabIndex = 13;
            this.btnKayitAl.Text = "Şimdi Kayıt Al!";
            this.btnKayitAl.Click += new System.EventHandler(this.btnKayitAl_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(419, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(193, 61);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Kayıtlar Klasörü";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmYedekIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1234, 551);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnKayitAl);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYedekIslemleri";
            this.Text = "frmYedekIslemleri";
            this.Load += new System.EventHandler(this.frmYedekIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckButton chkBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnKayitAl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}