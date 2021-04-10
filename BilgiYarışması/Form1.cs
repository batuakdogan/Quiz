using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnkSonraki.Enabled = true;



            label4.Text = BtnD.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnkSonraki.Enabled = true;



            label4.Text = BtnC.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        


        int soruno = 0, dogru=0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnkSonraki.Enabled = true;



            label4.Text = BtnB.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;


            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {


            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnkSonraki.Enabled = true;



            label4.Text = BtnA.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }



        }

        private void BtnkSonraki_Click(object sender, EventArgs e)
        {


            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnkSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


           



            soruno++;
            LblSoruNo.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet ne zaman ilan edildi?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label3.Text = "1923";
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir ege bölgemizde bulunmaz";
                BtnA.Text = "İzmir";
                BtnB.Text = "Ankara";
                BtnC.Text = "Kocaeli";
                BtnD.Text = "Uşak";
                label3.Text = "İzmir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazara aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Atila İlhan";
                BtnD.Text = "Ömer Seyfettin";
                label3.Text = "Sait Faik";
                BtnkSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnkSonraki.Enabled = false;

                MessageBox.Show("Doğru: " + dogru + " " + "Yanlis" + " "+ yanlis); 

            }
        }
    }
}
