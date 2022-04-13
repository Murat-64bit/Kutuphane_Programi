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
    public partial class frmIslemGecmis : Form
    {
        public frmIslemGecmis()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Yaptirimlar()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',ogrid as 'Öğrenci ID', ogradsoyad as 'İsim', ogrno as 'No',ogrtelno as 'Telefon',cezatur as 'Tür',cezabirim as 'Birim', cezatarih as 'Veriliş Tarih', cezasontarih as 'Son Tarih',aciklama as 'Aciklama' from cezalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmIslemGecmis_Load(object sender, EventArgs e)
        {
            Yaptirimlar();
        }
    }
}
