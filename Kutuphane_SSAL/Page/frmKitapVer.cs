using DevExpress.XtraEditors;
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
    public partial class frmKitapVer : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Kitaplistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',kitapad as 'Kitap Adı', kitapyazar as 'Yazar', kitapsayfa as 'Sayfa', barkod as 'Barkod',dolasim as 'Dolaşım' from kitaplar where aktif=1 and dolasim=0", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }  
        void OgrenciListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',ograd as 'Öğrenci Adı', ogrsoyad as 'Öğrenci Soyadı', ogrno as 'Okul No', ogrtelno as 'Telefon' from ogrenciler where ograktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            txtAd.Text = "";
            txtBarkod.Text = "";
            txtKid.Text = "";
            txtOgrAd.Text = "";
            txtOgrid.Text = "";
            txtOgrNo.Text = "";
            txtSayfa.Text = "";
            txtYazar.Text = "";
        }
        public frmKitapVer()
        {
            InitializeComponent();
        }
        public string adulas;
        private void frmKitapVer_Load(object sender, EventArgs e)
        {
            DateTime BirYilSonrasi = DateTime.Now.AddDays(15);
            DateTime suan = DateTime.Now;
            string formattedDate = BirYilSonrasi.ToString("dd/MM/yyyy");
            string formatlanmis = suan.ToString("dd/MM/yyyy");
            Form1 frm = new Form1();
            lblYetkili.Text = adulas;

            lblTarih.Text = formatlanmis;
            lblSonTarih.Text = formattedDate;

            Kitaplistele();
            OgrenciListele();
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtKid.Text = dr["ID"].ToString();
                txtAd.Text = dr["Kitap Adı"].ToString();
                txtYazar.Text = dr["Yazar"].ToString();
                txtSayfa.Text = dr["Sayfa"].ToString();
                txtBarkod.Text = dr["Barkod"].ToString();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtOgrid.Text = dr["ID"].ToString();
                txtOgrAd.Text = dr["Öğrenci Adı"]+" "+dr["Öğrenci Soyadı"].ToString();
                txtOgrNo.Text = dr["Okul No"].ToString();
               
            }
        }
        // ÇOK ERKEN YAPTIM BURAYI KAHRETMESİN NEYSE ŞÖYLE OLACAK 
        // 1. ÖĞRENCİYE KİTABI VEREN YETKİLİ GÖZÜKECEK
        // 2. ÖĞRENCİYE VERİLEN KİTAP TESLİMİ İÇİN SÜRE VERİLECEK
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKid.Text != "" || txtOgrid.Text !="")
            {
                if (XtraMessageBox.Show("Seçili öğrenciye kitap verilecektir onaylıyor musunuz? ", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    // Kitabın Dolaşımda olduğu bilgisi
                    SqlCommand komut = new SqlCommand("update kitaplar set dolasim=1 where id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtKid.Text);
                    komut.ExecuteNonQuery();

                    //DOLAŞIM DATASI
                    SqlCommand dolasim = new SqlCommand("insert into dolasim (ogrid,ogradsoyad,ogrno,kitapid,kitapad,kitapyazar,kitapsayfa,alimtarih,sontarih,yetkili,gecmis,aktif) values (@ps,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
                    dolasim.Parameters.AddWithValue("@ps", txtOgrid.Text);
                    dolasim.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                    dolasim.Parameters.AddWithValue("@p3", txtOgrNo.Text);
                    dolasim.Parameters.AddWithValue("@p4", txtKid.Text);
                    dolasim.Parameters.AddWithValue("@p5", txtAd.Text);
                    dolasim.Parameters.AddWithValue("@p6", txtYazar.Text);
                    dolasim.Parameters.AddWithValue("@p7", txtSayfa.Text);
                    dolasim.Parameters.AddWithValue("@p8", lblTarih.Text);
                    dolasim.Parameters.AddWithValue("@p9", lblSonTarih.Text);
                    dolasim.Parameters.AddWithValue("@p10", lblYetkili.Text);
                    dolasim.Parameters.AddWithValue("@p11", false);
                    dolasim.Parameters.AddWithValue("@p12", true);
                    dolasim.ExecuteNonQuery();

                    Temizle();

                    Kitaplistele();
                    OgrenciListele();

                }
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
