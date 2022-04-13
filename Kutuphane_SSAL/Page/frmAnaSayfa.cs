using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane_SSAL.Page
{
    public partial class frmAnaSayfa : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            DateTime son7 = DateTime.Now.AddDays(7);
            string format = son7.ToString("dd/MM/yyyy");
            DateTime now = DateTime.Now;
            string formatlanmis = now.ToString("dd/MM/yyyy");
            // Süresi Geçenler
            SqlCommand komut = new SqlCommand("select ogradsoyad as 'Ad Soyad',ogrno as 'No',kitapad as 'Kitap Ad',sontarih as 'Son Tarih',yetkili as 'Yetkili' from dolasim where " +
                "convert(datetime,'" + formatlanmis + "', 103) > convert(datetime, sontarih, 103)  and gecmis=0 and aktif=1", bgl.baglanti());
            SqlDataAdapter da3 = new SqlDataAdapter(komut);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            gridControl1.DataSource = dt3;
            // Süresi Yaklaşanlar
            SqlCommand komut2 = new SqlCommand("select ogradsoyad as 'Ad Soyad',ogrno as 'No',kitapad as 'Kitap Ad',sontarih as 'Son Tarih',yetkili as 'Yetkili' from dolasim where " +
                "sontarih > '" + format + "' and gecmis=0 and aktif=1", bgl.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2; 
            // Süresi Yaklaşanlar
            SqlCommand komut4 = new SqlCommand("select ogradsoyad as 'Ad Soyad',ogrno as 'No',kitapad as 'Kitap Ad',sontarih as 'Son Tarih',yetkili as 'Yetkili' from dolasim where " +
                "sontarih = '" + formatlanmis + "' and gecmis=0 and aktif=1", bgl.baglanti());
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            gridControl3.DataSource = dt4;
            // Süresi Yaklaşanlar
            SqlCommand komut5 = new SqlCommand("select aciklama as 'Açıklama',cezatur as 'Tür',cezabirim as 'Birim',cezasontarih as 'Son Tarih' from cezalar where " +
                "cezasontarih > '" + format + "' and aktif=1", bgl.baglanti());
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            gridControl4.DataSource = dt5;
        }
    }
}
