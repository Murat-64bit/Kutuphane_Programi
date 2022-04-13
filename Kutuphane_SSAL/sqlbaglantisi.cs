using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kutuphane_SSAL
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True; AttachDbFileName='C:\Program Files\SSALKutuphane\Program\Data\DbKutuphane.mdf';");
            baglan.Open();
            return baglan;
        }
    }
}
