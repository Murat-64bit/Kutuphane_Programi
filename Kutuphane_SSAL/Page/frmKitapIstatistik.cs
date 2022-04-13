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
    public partial class frmKitapIstatistik : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmKitapIstatistik()
        {
            InitializeComponent();
        }

        private void frmKitapIstatistik_Load(object sender, EventArgs e)
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
            // En Çok okunanlar
            SqlCommand komut5 = new SqlCommand("select kitapad as 'Adı',count(kitapad) as 'Okunma Sayısı' from dolasim where " +
                "sontarih > '" + format + "' and aktif=1 group by kitapad", bgl.baglanti());
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            gridControl3.DataSource = dt5;
            // En Çok okuyanlar
            SqlCommand komut7 = new SqlCommand("select ogradsoyad as 'Adı',count(kitapad) as 'Okuma Sayısı' from dolasim where " +
                "sontarih > '" + format + "' and aktif=1 group by ogradsoyad", bgl.baglanti());
            SqlDataAdapter da7 = new SqlDataAdapter(komut7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            gridControl4.DataSource = dt7;
        }
    }
}
