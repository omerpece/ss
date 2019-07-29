using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlarr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MetotluDongu()
        {
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        void Degisiklik()
        {
            this.BackColor = Color.White;
            this.Size = new Size(400, 400);
        }


        private void Btnornek1_Click(object sender, EventArgs e)
        {
            MetotluDongu();
        }

        private void Btnornek2_Click(object sender, EventArgs e)
        {
            Degisiklik();
        }





        private void Button1_Click(object sender, EventArgs e)
        {

        }

        int sayidurum(int s1)
        {
            int sonuc = 0;
            if (s1 == 0)
            {
                sonuc = 0;
            }
            else if (s1 % 2 == 0)
            {
                sonuc = -1;
            }
            else
            {
                sonuc = 1;
            }

            return sonuc;
        }




        private void Button2_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show(sayidurum);
            //}

            string degisim(string metin1, string metin2)
            {
                string isim = $"{metin1.Substring(0, 2).ToUpper()}{metin1.Substring(2).ToLower()}";
                string soyisim = $"{metin2.ToLower().Replace('a', 'e')}";



                return $"{isim}.{soyisim}@hotmail.com";

            }

        }

        Double karekok(int[] sayidizi)
        {
             double toplam = 0;
            for (int i = 0; i < sayidizi.Length; i++)
            {
                toplam += sayidizi[i];
            }
        

            return 0;
        }



        private void Button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5 };
            karekok(sayilar);

            String[] numbers = textBox1.Text.Split(',', '.');
            int[] sayisaldizi = Array.ConvertAll(numbers, Convert.ToInt32);

            double result = karekok(Array.ConvertAll(numbers, Convert.ToInt32));
            MessageBox.Show("işlem sonucu : "+ result);
        }

        Color renkkontrol(Control control)
        {

            return control.BackColor;
        }
        

        private void Button5_Click(object sender, EventArgs e)
        {
            this.BackColor = renkkontrol(button5);
        }
    }
}








