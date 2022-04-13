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
using DevExpress.XtraEditors;

namespace Kutuphane_SSAL.Page
{
    public partial class frmYaptirim : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        void OgrenciListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID', ograd as 'Ad',ogrsoyad as 'Soyad', ogrno as 'No',ogrtelno as 'Telefon' from ogrenciler where ograktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void AktifYaptirimlar()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',ogrid as 'Öğrenci ID', ogradsoyad as 'İsim', ogrno as 'No',ogrtelno as 'Telefon',cezatur as 'Tür',cezabirim as 'Birim', cezatarih as 'Veriliş Tarih', cezasontarih as 'Son Tarih',aciklama as 'Aciklama' from cezalar where aktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        public frmYaptirim()
        {
            InitializeComponent();
        }

        private void frmYaptirim_Load(object sender, EventArgs e)
        {
            OgrenciListele();
            AktifYaptirimlar();
            DateTime suan = DateTime.Now;
            string formatlanmis = suan.ToString("dd/MM/yyyy");
            lbltarih.Text = formatlanmis;
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (lblid.Text != "Öğrenci ID")
            {
                if (toggleSwitch1.IsOn)
                {
                    SqlCommand komut = new SqlCommand("update cezalar set aktif=0 where id=@p1 ", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", lblcezaid.Text);
                    komut.ExecuteNonQuery();
                    AktifYaptirimlar();
                    OgrenciListele();
                    XtraMessageBox.Show("Ceza öğrenciden kaldırıldı!", "Kayıt Başarılı", MessageBoxButtons.OK);
                    lblid.Text = "";
                    txtAciklama.Text = "";
                    txtAd.Text = "";
                    txtBitisTarih.Text = "";
                    txtCezaBirim.Text = "";
                    txtCezaTur.Text = "";
                    txtNo.Text = "";
                    txtTelNo.Text = "";
                }
                else
                {
                    if (XtraMessageBox.Show("Seçili öğrenciye ceza uygulanacaktır onaylıyor musunuz? ", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        SqlCommand komut = new SqlCommand("insert into cezalar (ogrid,ogradsoyad,ogrno,ogrtelno,cezatur,cezabirim,cezatarih,cezasontarih" +
                            ",aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", lblid.Text);
                        komut.Parameters.AddWithValue("@p2", txtAd.Text);
                        komut.Parameters.AddWithValue("@p3", txtNo.Text);
                        komut.Parameters.AddWithValue("@p4", txtTelNo.Text);
                        komut.Parameters.AddWithValue("@p5", txtCezaTur.Text);
                        komut.Parameters.AddWithValue("@p6", txtCezaBirim.Text);
                        komut.Parameters.AddWithValue("@p7", lbltarih.Text);
                        komut.Parameters.AddWithValue("@p8", txtBitisTarih.Text);
                        komut.Parameters.AddWithValue("@p9", txtAciklama.Text);
                        komut.ExecuteNonQuery();
                        AktifYaptirimlar();
                        OgrenciListele();
                        XtraMessageBox.Show("Ceza öğrenciye uygulandı!", "Kayıt Başarılı", MessageBoxButtons.OK);

                        lblid.Text = "";
                        txtAciklama.Text = "";
                        txtAd.Text = "";
                        txtBitisTarih.Text = "";
                        txtCezaBirim.Text = "";
                        txtCezaTur.Text = "";
                        txtNo.Text = "";
                        txtTelNo.Text = "";

                    }


                }
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void gridView1_Click(object sender, EventArgs e)
        {


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblid.Text = dr["ID"].ToString();
                txtAd.Text = dr["Ad"] + " " + dr["Soyad"].ToString();
                txtNo.Text = dr["No"].ToString();
                txtTelNo.Text = dr["Telefon"].ToString();

            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                lblcezaid.Text = dr["ID"].ToString();
                lblid.Text = dr["Öğrenci ID"].ToString();
                txtAd.Text = dr["İsim"].ToString();
                txtNo.Text = dr["No"].ToString();
                txtTelNo.Text = dr["Telefon"].ToString();
                txtCezaTur.Text = dr["Tür"].ToString();
                txtCezaBirim.Text = dr["Birim"].ToString();
                txtBitisTarih.Text = dr["Son Tarih"].ToString();
                txtAciklama.Text = dr["Aciklama"].ToString();

            }
        }
    }
}
