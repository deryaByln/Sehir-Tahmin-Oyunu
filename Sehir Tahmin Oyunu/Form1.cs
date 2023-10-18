using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sehir_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        String[] sehirlistesi ={"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};
        String bulunacaksehirismi = "";
        int bulunanharfsayisi = 0;
        int kalanhak = 4;
        Random rastgele;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnYeniOyun_Click(object sender, EventArgs e)
        {
            bulunanharfsayisi = 0;
            BtnHarfGir.Enabled = true;
            BtnTahmineEt.Enabled = true;
            LblGirilenHarfler.Text = "";
            kalanhak = 4;
            YeniSehirSec();
            groupBox1.Controls.Clear();
            for (int i = 0; i < bulunacaksehirismi.Length ; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);  // groupboxa göre konumlandırdık
                label.Text = bulunacaksehirismi[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif",8.50F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte) (162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                groupBox1.Controls.Add(label);






            }

        }

        private void BtnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfVarmi = false;
            if(TxtHarf.Text.Length!=1)
            {
                MessageBox.Show("Lutfen Tek Harf Giriniz");

            }
            else
            {
               if( LblGirilenHarfler.Text.Contains(TxtHarf.Text))
                //Daha önce girildi mi kontrolu yapıyoruz bu harf
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz");
                    TxtHarf.Text = "";
                    TxtHarf.Focus();
                    return;
                }
               foreach(Control item in groupBox1.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        if(label.Text.ToUpper()==TxtHarf.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            harfVarmi = true;
                            bulunanharfsayisi++;
                        
                        }
                    }
                }
            }
            if(!harfVarmi)
            {
                kalanhak--;
                lblkalanhak.Text = kalanhak.ToString();
                if(kalanhak==0)
                {
                    BtnHarfGir.Enabled = false;
                    BtnTahmineEt.Enabled = false;
                    MessageBox.Show("Oyun Bitti Kaybettiniz Yeni oyun için yeni oyun butonuna tıklayınız   "+bulunacaksehirismi);

                }
            }
            LblGirilenHarfler.Text += TxtHarf.Text + " ";
            if (bulunanharfsayisi == bulunacaksehirismi.Length)
            {
                BtnHarfGir.Enabled = false;
                BtnTahmineEt.Enabled = false;
                MessageBox.Show("Oyun Bitti Tebrikler Gayet Başarılıydınız Oyunu Kazandınız");

            }
            TxtHarf.Text = "";
            TxtHarf.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHarfGir.Enabled = false;
            BtnTahmineEt.Enabled = false;
            rastgele = new Random();
            this.AcceptButton = BtnHarfGir;

        }
        private void YeniSehirSec()
        {
            int rastgelesayi = rastgele.Next(0, sehirlistesi.Length);
            bulunacaksehirismi = sehirlistesi[rastgelesayi];
        }

        private void BtnTahmineEt_Click(object sender, EventArgs e)
        {
            if (bulunacaksehirismi.ToUpper()==TxtHarf.Text.ToUpper())

            {
                foreach(Control item in groupBox1.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;


                    }
                }
                MessageBox.Show("Oyun Bitti Tebrikler Kazandınız");
            }
            else
            {
                MessageBox.Show("Oyun Bitti Malesef Kaybettiniz " + bulunacaksehirismi);
            }
            BtnHarfGir.Enabled = false;
            BtnTahmineEt.Enabled = false;
        }
    }
}
