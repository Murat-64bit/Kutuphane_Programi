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

namespace Kutuphane_SSAL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Form1 frm = new Form1();

            SqlCommand komut2 = new SqlCommand("select adsoyad,admin from yetkili where kad=@t1 and ksifre=@t2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@t1", txtAd.Text);
            komut2.Parameters.AddWithValue("@t2", txtSifre.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                frm.adsoyad = dr2[0].ToString();
                frm.admin = (bool)dr2[1];
                frm.Show();
                this.Hide();
                splashScreenManager1.CloseWaitForm();

            }
            else
            {
                splashScreenManager1.CloseWaitForm();

                XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                splashScreenManager1.ShowWaitForm();
                Form1 frm = new Form1();

                SqlCommand komut2 = new SqlCommand("select adsoyad,admin from yetkili where kad=@t1 and ksifre=@t2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@t1", txtAd.Text);
                komut2.Parameters.AddWithValue("@t2", txtSifre.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    frm.adsoyad = dr2[0].ToString();
                    frm.admin = (bool)dr2[1];
                    frm.Show();
                    this.Hide();
                    splashScreenManager1.CloseWaitForm();

                }
                else
                {
                    splashScreenManager1.CloseWaitForm();

                    XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                splashScreenManager1.ShowWaitForm();
                Form1 frm = new Form1();

                SqlCommand komut2 = new SqlCommand("select adsoyad,admin from yetkili where kad=@t1 and ksifre=@t2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@t1", txtAd.Text);
                komut2.Parameters.AddWithValue("@t2", txtSifre.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    frm.adsoyad = dr2[0].ToString();
                    frm.admin = (bool)dr2[1];
                    frm.Show();
                    this.Hide();
                    splashScreenManager1.CloseWaitForm();

                }
                else
                {
                    splashScreenManager1.CloseWaitForm();

                    XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
