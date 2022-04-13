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
    public partial class frmOgrenciSorgu : Form
    {
        public frmOgrenciSorgu()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID', ograd as 'Ad',ogrsoyad as 'Soyad', ogrno as 'No',ogrtelno as 'Telefon' from ogrenciler where ograktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmOgrenciSorgu_Load(object sender, EventArgs e)
        {

            Listele();
        }
        public string id;
        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                id = dr["ID"].ToString();
            }
            // Okudukları
            SqlCommand komut1 = new SqlCommand("select kitapad as 'Ad',kitapyazar as 'Yazar',kitapsayfa as 'Sayfa',alimtarih as 'Alım Tarihi', teslimtarih as 'Teslim Tarih' from dolasim where ogrid=@s1 and aktif=1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@s1", id);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = komut1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            gridControl2.DataSource = dt1;
            // Cezaları
            SqlCommand komut3 = new SqlCommand("select aciklama as 'Açıklama',cezatur as 'Tür',cezabirim as 'Birim',cezatarih as 'Tarih' from cezalar where ogrid=@s1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@s1", id);
            SqlDataAdapter da3 = new SqlDataAdapter();
            da3.SelectCommand = komut3;
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            gridControl3.DataSource = dt3;
            // Şuna okudukları
            SqlCommand komut2 = new SqlCommand("select kitapad as 'Ad',kitapyazar as 'Yazar',kitapsayfa as 'Sayfa',alimtarih as 'Alım Tarihi', teslimtarih as 'Teslim Tarih' from dolasim where ogrid=@s1 and aktif=1 and gecmis=0", bgl.baglanti());
            komut2.Parameters.AddWithValue("@s1", id);
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = komut2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl4.DataSource = dt2;
        }
    }
}
