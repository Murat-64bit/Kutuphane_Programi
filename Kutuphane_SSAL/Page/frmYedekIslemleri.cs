using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_SSAL.Page
{
    public partial class frmYedekIslemleri : Form
    {
        public frmYedekIslemleri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void checkButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKayitAl_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Program Files\SSALKutuphane\YedekKayit\KayitPanel.exe");
            Application.Exit();


        }
        bool aktifMi = true;
        private void frmYedekIslemleri_Load(object sender, EventArgs e)
        {
            string fbd = @"C:\Program Files\SSALKutuphane\Yedekler";
            string[] subdirs = Directory.GetDirectories(fbd);
            gridControl1.DataSource = subdirs;
            
            SqlCommand komut2 = new SqlCommand("select yedek from digerler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                aktifMi = (bool)dr2[0];
                if (aktifMi == true)
                {
                    chkBtn.Checked = true;
                }
                else
                {
                    chkBtn.Checked= false;
                }
            }
        }

        private void chkBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBtn.Checked == true)
            {
                SqlCommand komut = new SqlCommand("update digerler set yedek=1",bgl.baglanti());
                komut.ExecuteNonQuery();
            }    
            if (chkBtn.Checked == false)
            {
                SqlCommand komut1 = new SqlCommand("update digerler set yedek=0",bgl.baglanti());
                komut1.ExecuteNonQuery();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\SSALKutuphane\Yedekler");

        }
    }
}
