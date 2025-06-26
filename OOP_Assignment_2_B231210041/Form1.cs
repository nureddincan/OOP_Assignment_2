/****************************************************************************
**					    SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					   2024-2025 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖÐRENCÝ ADI............: Nureddin Can ERDEÐER
**				ÖÐRENCÝ NUMARASI.......: B231210041
**              DERSÝN ALINDIÐI GRUP...: C
****************************************************************************/

namespace OOP_Assignment_2_B231210041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baslatButton.Enabled = false; // Baþlat butonunu baþlangýçta devre dýþý býrakýyoruz
            string currentDirectory = Application.StartupPath;
            string[] txtFiles = Directory.GetFiles(currentDirectory, "*.txt");

            foreach (string filePath in txtFiles)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath); // uzantýsýz dosya adý
                sozlukComboBox.Items.Add(fileNameWithoutExtension);
            }

            if (sozlukComboBox.Items.Count > 0)
                sozlukComboBox.SelectedIndex = 0;
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void baslatButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); // Diðer form kilitlenir, sadece form2 açýk kalýr
        }

        private void yukleButton_Click(object sender, EventArgs e)
        {
            Lists.SozlukKelimeleri.Clear(); // Önce listeyi temizle

            string dosyaAdi = sozlukComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(dosyaAdi))
            {
                MessageBox.Show("Lütfen bir sözlük dosyasý seçin.");
                return;
            }

            string dosyaYolu = Path.Combine(Application.StartupPath, dosyaAdi + ".txt");

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Seçilen dosya bulunamadý.");
                return;
            }

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            if (satirlar.Length == 0)
            {
                MessageBox.Show("Dosya boþ.");
                return;
            }

            foreach (string satir in satirlar)
            {
                if (satir.Contains('\t'))
                {
                    Lists.SozlukKelimeleri.Add(satir.Trim()); // "\t" ile ayrýlmýþ satýrlarý ekle
                }
            }

            if (Lists.SozlukKelimeleri.Count > 0)
            {
                MessageBox.Show("Yükleme baþarýlý.");
                baslatButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Geçerli veri bulunamadý.");
            }
        }
    }
}