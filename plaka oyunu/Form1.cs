using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plaka_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 60;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int plaka = rnd.Next(1,82); 
            label1.Text = plaka.ToString();
            label2.Text = "";
            timer1.Enabled=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                label2.Text = "Adana";
            }
            if (label1.Text == "2") 
            {
                label2.Text = "adıyaman";

            }
            if(label1.Text == "3")
            {
                label2.Text = "Afyon karahisar";

            }
            if (label1.Text == "4")
            {
                label2.Text = "Ağrı";
            }
            if (label1.Text == "5")
            { 
                label2.Text = " Amasya";
            }
            if (label1.Text == "6")
            {
                label2.Text = "Ankara";
            }
            if (label1.Text == "7")
            {
                label2.Text = "Antalya";
            }
            if (label1.Text == "8")
            {
                label2.Text = "Artvin";
            }
            if (label1.Text == "9")
            {
                label2.Text = " Aydın";
            }
            if (label1.Text == "10")
            {
                label2.Text = "Balıkesir";
            }
            if (label1.Text == "11")
            {
                label2.Text = " Bilecik";
            }
            if (label1.Text == "12")
            {
                label2.Text = "Bingöl ";
            }
            if (label1.Text == "13")
            {
                label2.Text = " Bitlis ";
            }
            if (label1.Text == "14")
            {
                label2.Text = "Bolu ";
            }
            if (label1.Text == "15")
            {
                label2.Text = "Burdur ";
            }
            if (label1.Text == "16")
            {
                label2.Text = "Bursa ";
            }
            if (label1.Text == "17")
            {
                label2.Text = "Çanakkale ";
            }
            if (label1.Text == "18")
            {
                label2.Text = "Çankırı ";
            }
            if (label1.Text == "19")
            {
                label2.Text = "Çorum ";
            }
            if (label1.Text == "20")
            {
                label2.Text = "Denizli ";
            }
            if (label1.Text == "21")
            {
                label2.Text = "Diyarbakır ";
            }
            if (label1.Text == "22")
            {
                label2.Text = "Edirne ";
            }
            if (label1.Text == "23")
            {
                label2.Text = "Elazığ ";
            }
            if (label1.Text == "24")
            {
                label2.Text = "Erzincan ";
            }
            if (label1.Text == "25")
            {
                label2.Text = "Erzurum ";
            }
            if (label1.Text == "26")
            {
                label2.Text = "Eskişehir ";
            }
            if (label1.Text == "27")
            {
                label2.Text = " Gaziantep ";
            }
            if (label1.Text == "28")
            {
                label2.Text = "Giresun ";
            }
            if (label1.Text == "29")
            {
                label2.Text = "Gümüşhane ";
            }
            if (label1.Text == "30")
            {
                label2.Text = "Hakkari ";
            }
            if (label1.Text == "31")
            {
                label2.Text = " Hatay ";
            }
            if (label1.Text == "32")
            {
                label2.Text = "Isparta ";
            }
            if (label1.Text == "33")
            {
                label2.Text = " Mersin ";
            }
            if (label1.Text == "34")
            {
                label2.Text = " İstanbul ";
            }
            if (label1.Text == "35")
            {
                label2.Text = "İzmir ";
            }
            if (label1.Text == "36")
            {
                label2.Text = "Kars ";
            }
            if (label1.Text == "37")
            {
                label2.Text = " Kastamonu ";
            }
            if (label1.Text == "38")
            {
                label2.Text = "Kayseri ";
            }
            if (label1.Text == "39")
            {
                label2.Text = "Kırklareli ";
            }
            if (label1.Text == "40")
            {
                label2.Text = " Kırşehir ";
            }
            if (label1.Text == "41")
            {
                label2.Text = "Kocaeli ";
            }
            if (label1.Text == "42")
            {
                label2.Text = "Konya ";
            }
            if (label1.Text == "43")
            {
                label2.Text = "Kütahya ";
            }
            if (label1.Text == "44")
            {
                label2.Text = "Malatya ";
            }
            if (label1.Text == "45")
            {
                label2.Text = "Manisa ";
            }
            if (label1.Text == "46")
            {
                label2.Text = " Kahramanmaraş ";
            }
            if (label1.Text == "47")
            {
                label2.Text = "Mardin ";
            }
            if (label1.Text == "48")
            {
                label2.Text = "Muğla ";
            }
            if (label1.Text == "49")
            {
                label2.Text = "Muş ";
            }
            if (label1.Text == "50")
            {
                label2.Text = "Nevşehir ";
            }
            if (label1.Text == "51")
            {
                label2.Text = "Niğde ";
            }
            if (label1.Text == "52")
            {
                label2.Text = "Ordu ";
            }
            if (label1.Text == "53")
            {
                label2.Text = "Rize ";
            }
            if (label1.Text == "54")
            {
                label2.Text = "Sakarya ";
            }
            if (label1.Text == "55")
            {
                label2.Text = " Samsun ";
            }
            if (label1.Text == "56")
            {
                label2.Text = "Siirt ";
            }
            if (label1.Text == "57")
            {
                label2.Text = "Sinop ";
            }
            if (label1.Text == "58")
            {
                label2.Text = "Sivas ";
            }
            if (label1.Text == "59")
            {
                label2.Text = "Tekirdağ ";
            }
            if (label1.Text == "60")
            {
                label2.Text = "Tokat ";
               
            }
            if (label1.Text == "61")
            {
                label2.Text = "Trabzon ";
            }
            if (label1.Text == "62")
            {
                label2.Text = "Tunceli ";
            }
            if (label1.Text == "63")
            {
                label2.Text = "Şanlıurfa ";
            }
            if (label1.Text == "64")
            {
                label2.Text = " Uşak ";
            }
            if (label1.Text == "65")
            {
                label2.Text = " Van ";
            }
            if (label1.Text == "66")
            {
                label2.Text = "Yozgat ";
            }
            if (label1.Text == "67")
            {
                label2.Text = " Zonguldak ";
            }
            if (label1.Text == "68")
            {
                label2.Text = "Aksaray ";
            }
            if (label1.Text == "69")
            {
                label2.Text = " Bayburt ";
            }
            if (label1.Text == "70")
            {
                label2.Text = " Karaman ";
            }
            if (label1.Text == "71")
            {
                label2.Text = "Kırıkkale ";
            }
            if (label1.Text == "72")
            {
                label2.Text = "Batman ";
            }
            if (label1.Text == "73")
            {
                label2.Text = "Şırnak ";
            }
            if (label1.Text == "74")
            {
                label2.Text = "Bartın ";
            }
            if (label1.Text == "75")
            {
                label2.Text = "Ardahan ";
            }
            if (label1.Text == "76")
            {
                label2.Text = " Iğdır ";
            }
            if (label1.Text == "77")
            {
                label2.Text = "Yalova ";
            }
            if (label1.Text == "78")
            {
                label2.Text = "Karabük ";
            }
            if (label1.Text == "79")
            {
                label2.Text = " Kilis ";
            }
            if (label1.Text == "80")
            {
                label2.Text = " Osmaniye ";
            }
            if (label1.Text == "81")
            {
                label2.Text = "Düzce ";
            }
            timer1.Enabled = false;
            sayac = 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label4.Text = sayac.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
