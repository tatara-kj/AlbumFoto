using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumFoto
{
    public partial class Form1: Form
    {
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
          
        }

       
        private void zmien_obraz(int miejsce)
        {
            switch (miejsce)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.europe1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.europe2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.europe3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.africa1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.africa4;
                    break;
            }
        }

        private void zmien_napis(int miejsce)
        {
            switch (miejsce)
            {
                case 0:
                    label1.Text = "Herkulanum to kolejne z miast zniszczonych podczas erupcji Wezuwiusza. W porównaniu do Pompejów tutejsze ruiny zachowały się w lepszym stanie, bo zostały zalane i zakonserwowane lawą, a nie pokryte popiołem.";
                    break;
                case 1:
                    label1.Text = "Wieża Eiffla – najbardziej znany obiekt architektoniczny Paryża, uznawany za symbol tego miasta i niekiedy całej Francji. Jest najwyższą budowlą w Paryżu";
                    break;
                case 2:
                    label1.Text = "Monumentalny gmach Reichstagu jest obecnie siedzibą drugiej izby niemieckiego Parlamentu. To również świadek trudniej historii kraju oraz istotny punkt na turystycznej mapie Berlina";
                    break;
                case 3:
                    label1.Text = "Na zdjęciu widać różnorodną faunę Afryki – stado słoni przechodzi przez sawannę, a w oddali można dostrzec biegające zebry i gazele. Wszystko to w otoczeniu rozgrzanego, afrykańskiego krajobrazu.";
                    break;
                case 4:
                    label1.Text = "Na zdjęciu widać grupę wielbłądów, które powoli przemierzają rozległą pustynię. Ich sylwetki rysują się na tle bezkresnego, piaszczystego krajobrazu, a w tle widać delikatne, falujące piaski pod wpływem gorącego słońca.";
                    break;
            }
        }
        int miejsce = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            miejsce = (miejsce +4) % 5;

           zmien_obraz(miejsce);
            zmien_napis(miejsce);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miejsce = (miejsce + 6) % 5;
            zmien_napis(miejsce);
            zmien_obraz(miejsce);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
