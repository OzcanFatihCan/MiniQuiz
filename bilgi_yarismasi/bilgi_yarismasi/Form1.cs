using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnKapa();
            BtnSonra.Text = "Başla";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        void BtnKapa()
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnB_Click(object sender, EventArgs e)
        {

            BtnKapa();

            LblCevap.Text = BtnB.Text;

            if (LblDCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblCevap.Text = "Cevabınız: " + BtnB.Text + " Doğru";
                this.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblCevap.Text = "Cevabınız: " + BtnB.Text + " Yanlış";
                this.BackColor = Color.Red;
            }
            BtnSonra.Enabled = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnKapa();

            LblCevap.Text = BtnC.Text;

            if (LblDCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblCevap.Text = "Cevabınız: " + BtnC.Text + " Doğru";
                this.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblCevap.Text = "Cevabınız: " + BtnC.Text + " Yanlış";
                this.BackColor = Color.Red;
            }
            BtnSonra.Enabled = true;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnKapa();

            LblCevap.Text = BtnD.Text;

            if (LblDCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblCevap.Text = "Cevabınız: " + BtnD.Text + " Doğru";
                this.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblCevap.Text = "Cevabınız: " + BtnD.Text + " Yanlış";
                this.BackColor = Color.Red;
            }
            BtnSonra.Enabled = true;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnKapa();

            LblCevap.Text =BtnA.Text;

            if (LblDCevap.Text==LblCevap.Text)
            {
                dogru++;
                LblDogru.Text =dogru.ToString();
                LblCevap.Text = "Cevabınız: " + BtnA.Text + " Doğru";
                this.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblCevap.Text = "Cevabınız: " + BtnA.Text + " Yanlış";
                this.BackColor = Color.Red;
            }
            BtnSonra.Enabled = true;
        }

        private void BtnSonra_Click(object sender, EventArgs e)
        {
            LblCevap.Text = "";
            BtnSonra.Text = "Sonraki";
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonra.Enabled = false;
            soruno++;
            LblSoruno.Text = soruno.ToString();
            this.BackColor = Color.SteelBlue;
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                LblDCevap.Text = "1923";
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir marmara bölgesinde bulunmaz?";
                BtnA.Text = "Tekirdağ";
                BtnB.Text = "Kocaeli";
                BtnC.Text = "Uşak";
                BtnD.Text = "Balıkesir";
                LblDCevap.Text = "Uşak";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Çocukluğun sonu kitabı hangi yazara aittir?";
                BtnA.Text = "Arthur C.Clarke";
                BtnB.Text = "Isaac Asimov";
                BtnC.Text = "Andrzej Sapkowski";
                BtnD.Text = "Lev Tolstoy";
                LblDCevap.Text = "Arthur C.Clarke";
                
            }
            if (soruno==4)
            {
                richTextBox1.Text = "Tarihin sıfır noktası olarak bilinen, insanlık tarihinin ilk somut kalıntılarının bulunduğu Göbekli tepe hangi ilimizdedir?";
                BtnA.Text = "Adana";
                BtnB.Text = "Şanlıurfa";
                BtnC.Text = "Hatay";
                BtnD.Text = "Diyarbakır";
                LblDCevap.Text = "Şanlıurfa";
            }
            if (soruno==5)
            {
                richTextBox1.Text = "En uzun gecenin yaşandığı tarih hangisidir?";
                BtnA.Text = "30 Temmuz";
                BtnB.Text = "14 Aralık";
                BtnC.Text = "21 Aralık";
                BtnD.Text = "12 Ocak";
                LblDCevap.Text = "21 Aralık";
            }
            if (soruno==6)
            {
                richTextBox1.Text = "George Orwell'in \"Bin Dokuz Yüz Seksen Dört\" romanındaki baş kararakter hangisidir?";
                BtnA.Text = "Benedict Cumberbatch";
                BtnB.Text = "Holden Caufield";
                BtnC.Text = "Raistlin Majere";
                BtnD.Text = "Winston Smith";
                LblDCevap.Text = "Winston Smith";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Evrende görebildiğimiz en uzak gök cisimleri hangileridir?";
                BtnA.Text = "Nötron yıldızı";
                BtnB.Text = "Kuasar";
                BtnC.Text = "Oort bulutu";
                BtnD.Text = "Süpernova";
                LblDCevap.Text = "Kuasar";
                BtnSonra.Text = "Sonuçlar";
            }
            if (soruno>7)
            {
                LblSoruno.Text = "-";
                BtnSonra.Text = "Sonuçlar";
                richTextBox1.Text = "Cevaplama işlemi tamamlanmıştır.";
                BtnKapa();
                BtnSonra.Enabled = false;
                BtnA.Text = "A";
                BtnB.Text = "B";
                BtnC.Text = "C";
                BtnD.Text = "D";
                LblCevap.Visible = false;
                MessageBox.Show("Sonuçlarınız\n"+"Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        

        }
    }
}

