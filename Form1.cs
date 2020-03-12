using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASANALIGULTEKIN
{
    public partial class Form1 : Form
    {
       
         private Rectangle txtEkranOrginalRect;
         private Rectangle button1OriginalRect;
         private Rectangle button2OriginalRect;
         private Rectangle button3OriginalRect;
         private Rectangle button4OriginalRect;
         private Rectangle button5OriginalRect;
         private Rectangle button6OriginalRect;
         private Rectangle button7OriginalRect;
         private Rectangle button8OriginalRect;
         private Rectangle button9OriginalRect;
         private Rectangle button10OriginalRect;
         private Rectangle button11OriginalRect;
         private Rectangle button12OriginalRect;

         private Size formOriginalSize;

        Button[] Dugmeler;
        public Form1()
        {
            InitializeComponent();
        }
      

        private void RakamDugme_Click(object sender, EventArgs e)
        {
            Button rakamDugme;
            rakamDugme = (Button)sender;
            txtEkran.Text += rakamDugme.Text;           
        }

        private void IslemDugme_Click(object sender, EventArgs e)
        {
            char[] ayiraclar= new char[] {'+'};
            string[] strSayilar;
            strSayilar = txtEkran.Text.Split(ayiraclar);

            int toplam = 0;
            foreach(string strSayi in strSayilar)
            {
                toplam += Convert.ToInt32(strSayi);
            }
            txtEkran.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dugmeler = new Button[12] {button1,button2,button3,button4,button5,button6,button7,button8,
            button9,button10,button11,button12};

            int bos = 5;
            int penGenislik, penYukseklik;
            int btnGenislik, btnYukseklik;
                        
            txtEkran.TextAlign = HorizontalAlignment.Right;
            
            penGenislik = this.ClientRectangle.Width;
            penYukseklik = this.ClientRectangle.Height;

            btnGenislik = (int)(penGenislik - 5 * bos) / 3;
            btnYukseklik = (int)(penYukseklik - txtEkran.Height - 6 * bos) / 4;

            txtEkran.Left = bos;
            txtEkran.Top = bos;
            txtEkran.Width = penGenislik - 2 * bos;
            for (int i = 0; i < 12; i++)
            {
                Dugmeler[i].Height = btnYukseklik;
                Dugmeler[i].Width = btnGenislik;
                Dugmeler[i].Top = txtEkran.Bottom + bos + (int)(i / 3) * (btnYukseklik + bos);
                Dugmeler[i].Left = txtEkran.Left + bos + (int)(i % 3) * (btnGenislik + bos);              
            }

            formOriginalSize = this.Size;

            txtEkranOrginalRect = new Rectangle(txtEkran.Location.X, txtEkran.Location.Y, txtEkran.Width, txtEkran.Height);
            button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2OriginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3OriginalRect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button4OriginalRect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            button5OriginalRect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            button6OriginalRect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            button7OriginalRect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            button8OriginalRect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            button9OriginalRect = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            button10OriginalRect = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);
            button11OriginalRect = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            button12OriginalRect = new Rectangle(button12.Location.X, button12.Location.Y, button12.Width, button12.Height);
        }
         
        private void resizeChildrenControls()
        {
             resizeControl(txtEkranOrginalRect, txtEkran);
             resizeControl(button1OriginalRect, button1);
             resizeControl(button2OriginalRect, button2);
             resizeControl(button3OriginalRect, button3);
             resizeControl(button4OriginalRect, button4);
             resizeControl(button5OriginalRect, button5);
             resizeControl(button6OriginalRect, button6);
             resizeControl(button7OriginalRect, button7);
             resizeControl(button8OriginalRect, button8);
             resizeControl(button9OriginalRect, button9);
             resizeControl(button10OriginalRect, button10);
             resizeControl(button11OriginalRect, button11);
             resizeControl(button12OriginalRect, button12);
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
         {
            float xRatio= (float)(this.Width)/(float)(formOriginalSize.Width);
            float yRatio= (float)(this.Height)/(float)(formOriginalSize.Height);

            int newX =(int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
         }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
       
    }
}
