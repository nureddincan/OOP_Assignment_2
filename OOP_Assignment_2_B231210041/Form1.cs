/****************************************************************************
**					    SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					   2024-2025 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: 2
**				��RENC� ADI............: Nureddin Can ERDE�ER
**				��RENC� NUMARASI.......: B231210041
**              DERS�N ALINDI�I GRUP...: C
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
            baslatButton.Enabled = false; // Ba�lat butonunu ba�lang��ta devre d��� b�rak�yoruz
            string currentDirectory = Application.StartupPath;
            string[] txtFiles = Directory.GetFiles(currentDirectory, "*.txt");

            foreach (string filePath in txtFiles)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath); // uzant�s�z dosya ad�
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
            form2.ShowDialog(); // Di�er form kilitlenir, sadece form2 a��k kal�r
        }

        private void yukleButton_Click(object sender, EventArgs e)
        {
            Lists.SozlukKelimeleri.Clear(); // �nce listeyi temizle

            string dosyaAdi = sozlukComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(dosyaAdi))
            {
                MessageBox.Show("L�tfen bir s�zl�k dosyas� se�in.");
                return;
            }

            string dosyaYolu = Path.Combine(Application.StartupPath, dosyaAdi + ".txt");

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Se�ilen dosya bulunamad�.");
                return;
            }

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            if (satirlar.Length == 0)
            {
                MessageBox.Show("Dosya bo�.");
                return;
            }

            foreach (string satir in satirlar)
            {
                if (satir.Contains('\t'))
                {
                    Lists.SozlukKelimeleri.Add(satir.Trim()); // "\t" ile ayr�lm�� sat�rlar� ekle
                }
            }

            if (Lists.SozlukKelimeleri.Count > 0)
            {
                MessageBox.Show("Y�kleme ba�ar�l�.");
                baslatButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ge�erli veri bulunamad�.");
            }
        }
    }
}