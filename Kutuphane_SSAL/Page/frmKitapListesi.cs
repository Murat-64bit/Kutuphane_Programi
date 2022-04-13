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
using ExcelDataReader;
using System.IO;
using Z.Dapper.Plus;
using System.Diagnostics;
using DevExpress.XtraGrid;

namespace Kutuphane_SSAL.Page
{
    public partial class frmKitapListesi : Form
    {
        public frmKitapListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id,kitapad, kitapyazar, kitapsayfa, barkod,dolasim from kitaplar where aktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmKitapListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into kitaplar (kitapad,kitapyazar,kitapsayfa,barkod,dolasim,aktif) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtYazar.Text);
                komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
                komut.Parameters.AddWithValue("@p4", txtBarkod.Text);
                komut.Parameters.AddWithValue("@p5", false);
                komut.Parameters.AddWithValue("@p6", true);
                komut.ExecuteNonQuery();
                listele();
                XtraMessageBox.Show("Kitap başarıyla kayıt edildi!", "Kayıt Başarılı", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["id"].ToString();
                txtAd.Text = dr["kitapad"].ToString();
                txtYazar.Text = dr["kitapyazar"].ToString();
                txtSayfa.Text = dr["kitapsayfa"].ToString();
                txtBarkod.Text = dr["barkod"].ToString();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (XtraMessageBox.Show("Kitap kayıt bilgilerini değiştirmek istediğinize emin misiniz?", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    SqlCommand komut = new SqlCommand("update kitaplar set kitapad=@p1,kitapyazar=@p2,kitapsayfa=@p3,barkod=@p4 where id=@p5", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p5", txtid.Text);
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtYazar.Text);
                    komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
                    komut.Parameters.AddWithValue("@p4", txtBarkod.Text);
                    komut.ExecuteNonQuery();
                    listele();
                    XtraMessageBox.Show("Kitap kayıt bilgisi değiştirildi!", "Güncelleme Başarılı", MessageBoxButtons.OK);

                }
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btbnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Kitap kayıt adresini silmek istediğinize emin misiniz?", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                SqlCommand komut = new SqlCommand("update kitaplar set aktif=0 where id=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p5", txtid.Text);
                komut.ExecuteNonQuery();
                listele();

            }
        }
        DataTableCollection tableCollection;
        string sheet = "kitaplar";
        private void btnAktar_Click(object sender, EventArgs e)
        {

            if (btnAktar.Text != "İşlemi Onayla")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook |*.xls|Excel Workbook|*.xlsx" })
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        txtFileName.Text = openFileDialog1.FileName;
                        btnAktar.Text = "İşlemi Onayla";
                        using (var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                foreach (DataTable table in tableCollection)
                                {
                                    sheet = table.TableName;
                                }
                                DataTable dt = tableCollection[sheet];
                                //    gridControl1.DataSource = dt;
                                if (dt != null)
                                {
                                    List<kitaplar> kitaplar = new List<kitaplar>();
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        kitaplar kitap = new kitaplar();
                                        kitap.kitapad = dt.Rows[i]["kitapad"].ToString();
                                        kitap.kitapyazar = dt.Rows[i]["kitapyazar"].ToString();
                                        kitap.kitapsayfa = dt.Rows[i]["kitapsayfa"].ToString();
                                        kitap.barkod = dt.Rows[i]["barkod"].ToString();
                                        kitaplar.Add(kitap);
                                    }
                                    gridControl1.DataSource = kitaplar;
                                }
                            }
                        }
                    }
                }
            }
            else if (btnAktar.Text == "İşlemi Onayla")
            {
                try
                {
                    string connectionString = @"Data Source=(LocalDB)\v11.0;Integrated Security=True; AttachDbFileName='C:\Program Files\SSALKutuphane\Program\Data\DbKutuphane.mdf'";
                    DapperPlusManager.Entity<kitaplar>().Table("kitaplar");
                    List<kitaplar> kitap = gridControl1.DataSource as List<kitaplar>;
                    if (kitap != null)
                    {
                        using (IDbConnection db = new SqlConnection(connectionString))
                        {
                            db.BulkInsert(kitap);
                        }
                    }
                    XtraMessageBox.Show("İşlem başarılı tüm öğrenciler içeri akatrıldı", "Başarılı", MessageBoxButtons.OK);
                    listele();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDisari_Click(object sender, EventArgs e)
        {
            string path = "kitaplar.xlsx";
            gridControl1.ExportToXlsx(path);
            Process.Start(path);
        }
        // EĞER BİRDEN DAH FAZLA KİTAP VARSA BİR PANEL ÇIKACAK VE SEÇİMİ İSTENECEK
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarkod;

            try
            {
                lblbekle.Text = "Bekleniyor...";
                if (lblbekle.Text == "Bekleniyor..." && txtBarkod.Text != "")
                {
                    SqlCommand komut2 = new SqlCommand("select kitapad,kitapyazar,kitapsayfa from kitaplar where barkod=@t1", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@t1", txtBarkod.Text);
                    SqlDataReader dr2 = komut2.ExecuteReader();
                    if (dr2.Read())
                    {
                        txtAd.Text = dr2[0].ToString();
                        txtYazar.Text = dr2[1].ToString();
                        txtSayfa.Text = dr2[2].ToString();

                        lblbekle.Text = "Kısayol ENTER tuşu";
                    }
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hata", "Girdiğiniz barkod kodu yanlış veya hatalı lütfen tekrar deneyin.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           


        }
    }
}
