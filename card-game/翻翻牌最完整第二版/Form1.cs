using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 翻翻牌最完整第二版
{
    public partial class Form1 : Form
    {
        PictureBox[] pp = new PictureBox[16];
        Image[] pic = new Image[16];
        Random rd = new Random();
        Image img = Image.FromFile(@"C:\Users\USER\Pictures\1-4.jpg");
        PictureBox[] ppic = new PictureBox[16];
        //string str = "";
        int place = 1;//名次
        int one = 0;//第幾個成績
        int ht = 0;//判斷第二次以後會跳出輸入名字
        int[] a = new int[16];//亂數
        int hmany = 0;//圖片翻完會結束
        int times;//時間
        int[] score = new int[100];//分數
        int c;     //照片的位置
        float sum = 0;//典籍次數
        int[] point = new int[100];//把分數存進裡面
        string[] name = new string[100];//使用者輸入的名字
        int x;
        public Form1()
        {       
            InitializeComponent();
            pp[0] = pictureBox1;
            pp[1] = pictureBox2;
            pp[2] = pictureBox3;
            pp[3] = pictureBox4;
            pp[4] = pictureBox5;
            pp[5] = pictureBox6;
            pp[6] = pictureBox7;
            pp[7] = pictureBox8;
            pp[8] = pictureBox9;
            pp[9] = pictureBox10;
            pp[10] = pictureBox11;
            pp[11] = pictureBox12;
            pp[12] = pictureBox13;
            pp[13] = pictureBox14;
            pp[14] = pictureBox15;
            pp[15] = pictureBox16;
        }

        private void 開始ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                pp[i].Enabled = true;
            }
            Image mypic = Image.FromFile(@"C:\Users\USER\Pictures\1-2.jpg");
            Image mypic2 = Image.FromFile(@"C:\Users\USER\Pictures\1-3.JPG");
            Image mypic3 = Image.FromFile(@"C:\Users\USER\Pictures\1-5.JPG");
            Image mypic4 = Image.FromFile(@"C:\Users\USER\Pictures\1-6.JPG");
            Image mypic5 = Image.FromFile(@"C:\Users\USER\Pictures\1-7.JPG");
            Image mypic6 = Image.FromFile(@"C:\Users\USER\Pictures\1-8.JPG");
            Image mypic7 = Image.FromFile(@"C:\Users\USER\Pictures\1-1.JPG");
            Image mypic8 = Image.FromFile(@"C:\Users\USER\Pictures\1-9.JPG");
            pic[0] = mypic;
            pic[1] = mypic;
            pic[2] = mypic2;
            pic[3] = mypic2;
            pic[4] = mypic3;
            pic[5] = mypic3;
            pic[6] = mypic4;
            pic[7] = mypic4;
            pic[8] = mypic5;
            pic[9] = mypic5;
            pic[10] = mypic6;
            pic[11] = mypic6;
            pic[12] = mypic7;
            pic[13] = mypic7;
            pic[14] = mypic8;
            pic[15] = mypic8;
            for (int i = 0; i < 16; i++)
            {
                a[i] = rd.Next(16);
                for (int j = 0; j < i; j++)
                {
                    while (a[i] == a[j])
                    {
                        a[i] = rd.Next(16);
                        j = 0;
                    }
                }
                this.pp[a[i]].BackgroundImage = pic[i];
                pp[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
            開始ToolStripMenuItem1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = BackgroundImage;
           
            textBox1.Text = sum.ToString() + "\n";
            x = 0;
            timer1.Enabled = true;
            sum += 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 1;
            timer1.Enabled = true;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.pictureBox3.Image = BackgroundImage;
            sum += 1;
           textBox1.Text = sum.ToString() + "\n";
            x = 2;
            timer1.Enabled = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBox4.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 3;
            timer1.Enabled = true;
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.pictureBox5.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 4;
            timer1.Enabled = true;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.pictureBox6.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 5;
            timer1.Enabled = true;
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.pictureBox7.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 6;
            timer1.Enabled = true;
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.pictureBox8.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 7;
            timer1.Enabled = true;
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.pictureBox9.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 8;
            timer1.Enabled = true;
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.pictureBox10.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 9;
            timer1.Enabled = true;
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.pictureBox11.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 10;
            timer1.Enabled = true;
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.pictureBox12.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 11;
            timer1.Enabled = true;
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.pictureBox13.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 12;
            timer1.Enabled = true;
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.pictureBox14.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            timer1.Enabled = true;
            x = 13;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.pictureBox15.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 14;
            timer1.Enabled = true;
           
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.pictureBox16.Image = BackgroundImage;
            sum += 1;
            textBox1.Text = sum.ToString() + "\n";
            x = 15;
            timer1.Enabled = true;          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {        
            pp[x].Enabled = false;
            while (sum > 1 && sum % 2 <= 0)
            {
                if (pp[x].BackgroundImage == pp[c].BackgroundImage)
                {
                    score[one] = score[one] + 5;
                    textBox3.Text = score[one].ToString();                   
                    textBox2.Text = c.ToString();
                    textBox4.Text = x.ToString();
                    timer1.Enabled = false;
                    pp[c].Enabled = false;
                    pp[x].Enabled = false;
                    hmany = hmany + 1;
                    c = x;
                    return;
                }
                if (pp[x].BackgroundImage != pp[c].BackgroundImage)
                {
                    if (score[one] > 0)
                    {
                        score[one] = score[one] - 1;
                        textBox3.Text = score[one].ToString();
                    }
                    pp[x].Image = img;
                    pp[c].Image = img;
                    pp[x].BackgroundImageLayout = ImageLayout.Zoom;
                    pp[c].BackgroundImageLayout = ImageLayout.Zoom;
                    pp[x].Enabled = true;
                    textBox2.Text = c.ToString() + "\n";
                    pp[c].Enabled = true;
                    c = x;
                    timer1.Enabled = false;                
                    return;
                }
            }
            c =x;
            textBox2.Text = c.ToString() + "\n";
            textBox4.Text = x.ToString();
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<16;i++)
            {
                pp[i].Enabled = false;
            }
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void 暫停ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            times--;
            textBox5.Text = times.ToString();
            if(times<=0)
            {
                timer2.Enabled = false;
                MessageBox.Show("成績");
            }
        }
        private void tim2()
        {
            timer2.Enabled = true;
        }
        private void 一級ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            times = 60;
            panel1.Visible = true;
            tim2();
        }

        private void 二級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            times = 45;
            panel1.Visible = true;
            tim2();
        }

        private void 三級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            times = 30;
            panel1.Visible = true;
            tim2();
        }
    }
}
