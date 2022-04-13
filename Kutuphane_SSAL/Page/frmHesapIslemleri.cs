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
    public partial class frmHesapIslemleri : Form
    {
        public frmHesapIslemleri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from yetkili", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void barHeaderItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        bool adminMi;

        private void frmHesapIslemleri_Click(object sender, EventArgs e)
        {
            Listele();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" || txtAdSoyad.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into yetkili (adsoyad,kad,ksifre,admin) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtKAd.Text);
                komut.Parameters.AddWithValue("@p3", txtSifre.Text);
                komut.Parameters.AddWithValue("@p4", adminMi);
                komut.ExecuteNonQuery();
                Listele();
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchAdmin_Toggled(object sender, EventArgs e)
        {
            if (switchAdmin.IsOn)
            {
                adminMi = true;
            }
            else
            {
                adminMi = false;
            }
        }

        private void frmHesapIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblid.Text = dr["id"].ToString();
                txtAdSoyad.Text = dr["adsoyad"].ToString();
                txtKAd.Text = dr["kad"].ToString();
                txtSifre.Text = dr["ksifre"].ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string ids = "";
            if (XtraMessageBox.Show("Seçili yetkiliyi silmek istediğinize emin misiniz? ", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    ids = dr["id"].ToString();

                }
                SqlCommand komut = new SqlCommand("delete from yetkili where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", ids);
                komut.ExecuteNonQuery();
                Listele();
                XtraMessageBox.Show("Seçili yetkili başarı ile silindi", "Başarılı", MessageBoxButtons.OK);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçili yetkiliyi güncellemek istediğinize emin misiniz? ", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
            {

                SqlCommand komut = new SqlCommand("update yetkili set adsoyad=@p1,kad=@p2,ksifre=@p3,admin=@p4 where id=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtKAd.Text);
                komut.Parameters.AddWithValue("@p3", txtSifre.Text);
                komut.Parameters.AddWithValue("@p4", adminMi);
                komut.Parameters.AddWithValue("@p5", lblid.Text);
                komut.ExecuteNonQuery();
                Listele();
                XtraMessageBox.Show("Seçili yetkili başarı ile güncellendi", "Başarılı", MessageBoxButtons.OK);
            }
        }
    }
}
