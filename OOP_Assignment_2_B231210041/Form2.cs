/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					   2024-2025 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Nureddin Can ERDEĞER
**				ÖĞRENCİ NUMARASI.......: B231210041
**              DERSİN ALINDIĞI GRUP...: C
****************************************************************************/

using System.Windows.Forms;

namespace OOP_Assignment_2_B231210041
{
    public partial class Form2 : Form
    {
        private int skor = 0;
        private int aktifSoru = 0;
        private int toplamSoru = 0;
        private string dogruCevap = "";
        private bool cevapVerildi = false;
        private List<string> sorular = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sorular = Lists.SozlukKelimeleri.OrderBy(x => Guid.NewGuid()).ToList(); // Rastgele sırala
            toplamSoru = sorular.Count;
            YeniSoru();
        }

        private void YeniSoru()
        {
            if (aktifSoru >= toplamSoru)
            {
                MessageBox.Show("Tebrikler! Tüm sorular tamamlandı.\nToplam Puan: " + skor);
                Close();
                return;
            }

            // Renkleri sıfırla
            option1Button.BackColor = option2Button.BackColor =
            option3Button.BackColor = option4Button.BackColor = SystemColors.Control;

            cevapVerildi = false;

            // Şu anki satırı al
            string satir = sorular[aktifSoru];
            string[] parca = satir.Split('\t');
            string ingilizce = parca[0];
            string turkceDogru = parca[1];
            dogruCevap = turkceDogru;

            // Etiketleri güncelle
            wordLabel.Text = ingilizce;
            progressLabel.Text = $"{aktifSoru + 1}/{toplamSoru}";
            scoreLabel.Text = skor.ToString();

            // 3 yanlış + 1 doğru şık hazırla
            List<string> secenekler = Lists.SozlukKelimeleri
                .Where(s => s != satir)
                .OrderBy(x => Guid.NewGuid())
                .Take(3)
                .Select(s => s.Split('\t')[1])
                .ToList();

            secenekler.Add(turkceDogru);
            secenekler = secenekler.OrderBy(x => Guid.NewGuid()).ToList();

            // Butonlara yerleştir
            option1Button.Text = secenekler[0];
            option2Button.Text = secenekler[1];
            option3Button.Text = secenekler[2];
            option4Button.Text = secenekler[3];
        }

        private void Secenek_Click(object sender, EventArgs e)
        {
            Button secilen = sender as Button;

            if (secilen.Text == dogruCevap)
            {
                secilen.BackColor = Color.LightGreen;

                if (!cevapVerildi)
                    skor += 10;

                cevapVerildi = true;
                aktifSoru++;

                scoreLabel.Text = skor.ToString();

                // 1 saniye sonra yeni soruya geç
                Task.Delay(1000).ContinueWith(_ =>
                {
                    Invoke(new Action(() =>
                    {
                        YeniSoru();
                    }));
                });
            }
            else
            {
                secilen.BackColor = Color.IndianRed;
                cevapVerildi = true;
            }
        }
    }
}