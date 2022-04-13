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
using System.Diagnostics;

namespace Kutuphane_SSAL.Page
{
    public partial class frmKitapDolasim : Form
    {
        public frmKitapDolasim()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string adulas;
        void Dolasim()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'İşlem ID',ogrid as 'Öğrenci ID',ogradsoyad as 'Ad Soyad',ogrno as 'No',kitapid as " +
                "'Kitap ID', kitapad as 'Kitap Ad',kitapyazar as 'Yazar',kitapsayfa as 'Sayfa',alimtarih as 'Alım Tarihi'," +
                "sontarih as 'Son Tarih', yetkili as 'Yetkili' from dolasim where gecmis=0 and aktif=1",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmKitapDolasim_Load(object sender, EventArgs e)
        {
            DateTime suan = DateTime.Now;
            string formatlanmis = suan.ToString("dd/MM/yyyy");
            lblBugun.Text = formatlanmis;
            lblYetkili.Text = adulas;
            Dolasim();
        }

        private void btnGeriAlim_Click(object sender, EventArgs e)
        {
            if (txtKid.Text != "")
            {
                if (XtraMessageBox.Show("Seçili öğrenciden kitap geri alınacaktır onaylıyor musunuz? ", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    // Kitabın Dolaşımda olduğu bilgisi
                    SqlCommand komut = new SqlCommand("update kitaplar set dolasim=0 where id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtKid.Text);
                    komut.ExecuteNonQuery();

                    //DOLAŞIM DATASI
                    SqlCommand dolasim = new SqlCommand("update dolasim set gecmis=1,teslimtarih=@p1,geriyetkili=@p2 where id=@p3", bgl.baglanti());
                    dolasim.Parameters.AddWithValue("@p1", lblBugun.Text);
                    dolasim.Parameters.AddWithValue("@p2", lblYetkili.Text);
                    dolasim.Parameters.AddWithValue("@p3", txtid.Text);
                    dolasim.ExecuteNonQuery();
                    Dolasim();
                    XtraMessageBox.Show("Kitap başarı ile öğrenciden alındı!", "Kayıt Başarılı", MessageBoxButtons.OK);

                }
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtKid.Text = dr["Kitap ID"].ToString();
                txtKad.Text = dr["Kitap Ad"].ToString();
                txtOgrAd.Text = dr["Ad Soyad"].ToString();
                txtid.Text = dr["İşlem ID"].ToString();
             
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (XtraMessageBox.Show("Seçili satır bilgisi silenecektir onaylıyor musunuz? ", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    // Kitabın Dolaşımda olduğu bilgisi
                    SqlCommand komut = new SqlCommand("update dolasim set aktif=0 where id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtid.Text);
                    komut.ExecuteNonQuery();

                    Dolasim();
                    XtraMessageBox.Show("Dolaşım kayıt bilgisi başarı ile silindi!", "Silme Başarılı", MessageBoxButtons.OK);

                }
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'İşlem ID',ogrid as 'Öğrenci ID',ogradsoyad as 'Ad Soyad',ogrno as 'No',kitapid as " +
                "'Kitap ID', kitapad as 'Kitap Ad',kitapyazar as 'Yazar',kitapsayfa as 'Sayfa',alimtarih as 'Alım Tarihi'," +
                "sontarih as 'Son Tarih', yetkili as 'Yetkili' from dolasim where gecmis=1 and aktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            Dolasim();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "kitapdolasim.xlsx";
            gridControl1.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
