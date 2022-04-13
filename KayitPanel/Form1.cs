using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace KayitPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dt = DateTime.Now;
                string zaman = dt.ToString("dd/MM/yyyy") + " " + dt.ToString("hh/mm tt");
                string fileName = "DbKutuphane.mdf"; // Kopyalamak istediğimiz dosya ve uzantısı
                string sourcePath = @"C:\Program Files\SSALKutuphane\Program\Data\"; // dosyamızın bulunduğu klasör konumu
                string targetPath = @"C:\Program Files\SSALKutuphane\Yedekler\" + zaman; // dosyamızı kopyalamak istediğimiz klasörün konumu
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName); // dosya ismi ve konumunu birleştirmek için kullanıyoruz
                string destFile = System.IO.Path.Combine(targetPath, fileName); // kopyalama işleminde hedef dosya tanımlıyoruz ve tam isim ile kopyalamsını sağlıyoruz
                if (!System.IO.Directory.Exists(targetPath)) // if ile kopyalamak istediğimiz dosya konumu doğru olup olmadığını veya öyle bir dosya varmı yokmu kontrol ediyoruz
                {
                    System.IO.Directory.CreateDirectory(targetPath); // if ile kontrol ettiğimiz klasör yok ise oluşturuyoruz
                }
                System.IO.File.Copy(sourceFile, destFile, true); // Dosyamızı hedef klasöre kopyalıyoruz.
                if (System.IO.Directory.Exists(sourcePath)) // Kopyalama işlemini kontrol ediyoruz sorun var ise else bölümüne geciriyoruz
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);
                    foreach (string s in files)
                    {
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                    Application.Exit();

                }
                else
                {
                    MessageBox.Show("Kopyalamadı bir sorun oluştu lütfen dosyanızı kontrol edin, program kapatılıyor...");
                    Application.Exit();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dosyalar üzerinde şuanda işlem yapılamıyor lütfen tekrar deneyiniz.");

            }

        }
    }
}
