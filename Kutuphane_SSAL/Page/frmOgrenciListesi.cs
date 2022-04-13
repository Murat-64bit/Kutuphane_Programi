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
using System.IO;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Diagnostics;
using DevExpress.XtraGrid;

namespace Kutuphane_SSAL.Page
{
    public partial class frmOgrenciListesi : Form
    {
        public frmOgrenciListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id,ograd,ogrsoyad,ogrno,ogrtelno from ogrenciler where ograktif=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            /*  SqlDataAdapter da = new SqlDataAdapter("select id as 'ID', ograd as 'Ad',ogrsoyad as 'Soyad', ogrno as 'No',ogrtelno as 'Telefon' from ogrenciler where ograktif=1",bgl.baglanti());
              DataTable dt = new DataTable();
              da.Fill(dt);
              gridControl1.DataSource = dt; */
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" || txtSoyad.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into ogrenciler (ograd,ogrsoyad,ogrno,ogrtelno,ograktif) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtNo.Text);
                komut.Parameters.AddWithValue("@p4", txtTelNo.Text);
                komut.Parameters.AddWithValue("@p5", true);

                komut.ExecuteNonQuery();
                Listele();
                XtraMessageBox.Show("Öğrenci başarıyla kayıt edildi!", "Kayıt Başarılı", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Eksik ve ya hatalı işlem yapıldı", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmOgrenciListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btbnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Öğrenci kayıdını silmek istediğinize emin misiniz?", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                SqlCommand komut = new SqlCommand("update ogrenciler set ograktif=0 where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                Listele();
                XtraMessageBox.Show("Öğrenci başarı ile sistemden silindi!", "Silme Başarılı", MessageBoxButtons.OK);
            }
        }
        string sheet = "ogrenciler";

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" )
            {
                if (XtraMessageBox.Show("Öğrenci kayıt bilgilerini değiştirmek istediğinize emin misiniz?", "Onaylama", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    SqlCommand komut = new SqlCommand("update ogrenciler set ograd=@p1,ogrsoyad=@p2,ogrno=@p3,ogrtelno=@p4 where id=@p5", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p5", txtid.Text);
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", txtNo.Text);
                    komut.Parameters.AddWithValue("@p4", txtTelNo.Text);
                    komut.ExecuteNonQuery();
                    Listele();

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
                txtid.Text = dr["id"].ToString();
                txtAd.Text = dr["ograd"].ToString();
                txtSoyad.Text = dr["ogrsoyad"].ToString();
                txtNo.Text = dr["ogrno"].ToString();
                txtTelNo.Text = dr["ogrtelno"].ToString();
            }
        }
        DataTableCollection tableCollection;
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
                                    List<ogrenciler> ogrenciler = new List<ogrenciler>();
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        ogrenciler ogrenci = new ogrenciler();
                                        ogrenci.ograd = dt.Rows[i]["ograd"].ToString();
                                        ogrenci.ogrsoyad = dt.Rows[i]["ogrsoyad"].ToString();
                                        ogrenci.ogrno = dt.Rows[i]["ogrno"].ToString();
                                        ogrenci.ogrtelno = dt.Rows[i]["ogrtelno"].ToString();
                                        ogrenciler.Add(ogrenci);
                                    }
                                    gridControl1.DataSource = ogrenciler;
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
                    DapperPlusManager.Entity<ogrenciler>().Table("ogrenciler");
                    List<ogrenciler> ogrenci = gridControl1.DataSource as List<ogrenciler>;
                    if (ogrenci !=null)
                    {
                        using(IDbConnection db = new SqlConnection(connectionString))
                        {
                            db.BulkInsert(ogrenci);
                        }
                    }
                    XtraMessageBox.Show("İşlem başarılı tüm öğrenciler içeri akatrıldı", "Başarılı", MessageBoxButtons.OK);
                    Listele(); 
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
           
        }

        private void btnAktar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "ogrenciler.xlsx";
            gridControl1.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
