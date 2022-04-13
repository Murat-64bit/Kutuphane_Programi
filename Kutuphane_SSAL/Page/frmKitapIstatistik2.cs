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
    public partial class frmKitapIstatistik2 : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmKitapIstatistik2()
        {
            InitializeComponent();
        }

        private void frmKitapIstatistik2_Load(object sender, EventArgs e)
        {
            DateTime son7 = DateTime.Now.AddDays(30);
            string format = son7.ToString("dd/MM/yyyy");
            DateTime now = DateTime.Now;
            string formatlanmis = now.ToString("dd/MM/yyyy");
        
            // En Çok okunanlar
            SqlCommand komut1 = new SqlCommand("select kitapad as 'Adı',count(kitapad) as 'Okunma Sayısı' from dolasim where " +
                "sontarih > '" + format + "' and aktif=1 group by kitapad", bgl.baglanti());
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            gridControl2.DataSource = dt1;
            // En Çok okuyanlar
            SqlCommand komut2 = new SqlCommand("select ogradsoyad as 'Adı',count(kitapad) as 'Okuma Sayısı' from dolasim where " +
                "sontarih > '" + format + "' and aktif=1 group by ogradsoyad", bgl.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
            
            // En Çok okunanlar
            SqlCommand komut3 = new SqlCommand("select kitapad as 'Adı',count(kitapad) as 'Okunma Sayısı' from dolasim where " +
                "aktif=1 group by kitapad", bgl.baglanti());
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            gridControl1.DataSource = dt3;
            // En Çok okuyanlar
            SqlCommand komut4 = new SqlCommand("select ogradsoyad as 'Adı',count(kitapad) as 'Okuma Sayısı' from dolasim where " +
                "aktif=1 group by ogradsoyad", bgl.baglanti());
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            gridControl4.DataSource = dt4;
        }
    }
}
