using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_SSAL.Page
{
    public partial class FrmKitapGecmis : Form
    {
        public FrmKitapGecmis()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',kitapad as 'Kitap Adı', kitapyazar as 'Yazar', kitapsayfa as 'Sayfa', barkod as 'Barkod',dolasim as 'Dolaşım',aktif as 'Aktiflik Durumu' from kitaplar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmKitapGecmis_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblid.Text = dr["ID"].ToString();
                
            }

            SqlCommand komut2 = new SqlCommand("select dolasim from kitaplar where id=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                lblDolasim.Text = dr2[0].ToString();
            }
            
            SqlCommand komut3 = new SqlCommand("select count(ogrid) as 'Okuyanlar' from dolasim where kitapid=@t1 and aktif=1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@t1", lblid.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            if (dr3.Read())
            {
                lblToplamOkuma.Text = dr3[0].ToString();
            }

            if (lblDolasim.Text == "True")
            {
                lblDolasim.ForeColor = Color.Green;
                lblDolasim.Text = "Pozitif";
            }
            else
            {
                lblDolasim.ForeColor = Color.Red;
                lblDolasim.Text = "Negatif";

            }
            // HATA VERİYOR ONU DÜZELTEECZ
            SqlCommand komut4 = new SqlCommand("select ogradsoyad as 'Ad Soyad',ogrno as 'No',alimtarih as 'Alım Tarihi' from dolasim where kitapid=@s1 and aktif=1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@s1", lblid.Text);
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = komut4;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;


        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
