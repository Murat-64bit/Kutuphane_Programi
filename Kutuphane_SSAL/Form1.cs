using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kutuphane_SSAL
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public void formGetir(Form frm)
        {
            panel1.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm);
            frm.Show();

        }
        public string adsoyad;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmKitapListesi kitapListesi = new Page.frmKitapListesi();
            formGetir(kitapListesi);
        }
        public bool admin;
        private void Form1_Load(object sender, EventArgs e)
        {

            if (admin ==true)
            {
                ribbonPage7.Visible = true;
            }
            else
            {
                ribbonPage7.Visible = false;
            }
            Page.frmAnaSayfa frmAnaSayfa = new Page.frmAnaSayfa();
            formGetir(frmAnaSayfa);

        }

        private void btnKitapVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Page.frmKitapVer kitapVer = new Page.frmKitapVer();
            kitapVer.adulas = adsoyad;
            
            formGetir(kitapVer);

        }

        private void btnKitapGecmis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.FrmKitapGecmis kitapGecmis = new Page.FrmKitapGecmis();
            formGetir(kitapGecmis);
        }

        private void btnKitapDolasim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmKitapDolasim kitapDolasim = new Page.frmKitapDolasim();
            kitapDolasim.adulas = adsoyad;
            formGetir(kitapDolasim);
        }

        private void btnOgrenciListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmOgrenciListesi ogrenciListesi = new Page.frmOgrenciListesi();
            formGetir(ogrenciListesi);
        }

        private void btnOgrenciSorgu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmOgrenciSorgu OgrenciSorgu = new Page.frmOgrenciSorgu();
            formGetir(OgrenciSorgu);
        }

        private void btnYaptirimlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmYaptirim frmYaptirim = new Page.frmYaptirim();
            formGetir(frmYaptirim);
        }

        private void btnGecmis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmIslemGecmis frmIslemGecmis = new Page.frmIslemGecmis();
            formGetir(frmIslemGecmis);
        }

        private void btnKitapİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmKitapIstatistik frmKitapIstatistik = new Page.frmKitapIstatistik();
            formGetir(frmKitapIstatistik);
        }

        private void btnOgrenciİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmKitapIstatistik2 frmKitapIstatistik2 = new Page.frmKitapIstatistik2();
            formGetir(frmKitapIstatistik2);
        }

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmAnaSayfa frmAnaSayfa = new Page.frmAnaSayfa();
            formGetir(frmAnaSayfa);
        }

        private void btnHesapIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmHesapIslemleri frmHesapIslemleri = new Page.frmHesapIslemleri();
            formGetir(frmHesapIslemleri);
        }

        bool aktifMi = true;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();

        }

        private void btnYedekIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Page.frmYedekIslemleri frmYedekIslemleri = new Page.frmYedekIslemleri();
            formGetir(frmYedekIslemleri);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select yedek from digerler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                aktifMi = (bool)dr2[0];

            }
            if (aktifMi == true)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files\SSALKutuphane\YedekKayit\KayitPanel.exe");

            }
            else
            {
                Application.Exit();

            }
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sirasogutleranadolulisesi.meb.k12.tr/"); 
        }
    }
}
