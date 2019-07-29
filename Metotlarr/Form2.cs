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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //parametreli metot



        void Hesapla(int s1, int s2)
        {
            int toplam = s1 + s2;
            int result = Convert.ToInt32(Math.Pow(toplam, 3));

            MessageBox.Show($"işlem sonucu : {result}");

        }







        private void Btnornek1_Click(object sender, EventArgs e)
        {

        }

        private void Btnornek2_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(txtbox1.Text);
            int s2 = int.Parse(txtbox2.Text);
            Hesapla(s1, s2);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RenkDegistir(comboBox1.Text);
        }

        void RenkDegistir(string renk)
        {
            this.BackColor = Color.FromName(renk);

        }

        private void Btnornek7_Click(object sender, EventArgs e)
        {
            //comboboxtan seciilen rengi arka plan olarak ayarlama
            RenkDegistir(comboBox1.Text);
        }

        void MailAyristir(string mails)
        {
            string[] maillers = mails.Split(',' , ';', '.');
            foreach (string mail in maillers)
            {
                listBox1.Items.Add(mail);
            }


        }

       


        private void Btnornek4_Click(object sender, EventArgs e)
        {
            MailAyristir(txtbox1.Text);
        }

        void Kırp (string parametre)
        {
            MessageBox.Show(parametre.Length <= 3 ? parametre : parametre.Substring(parametre.Length - 3));
        }




        private void Btnornek3_Click(object sender, EventArgs e)
        {
            Kırp(txtbox1.Text);
        }



        private void Btnornek5_Click(object sender, EventArgs e)
        {

        }
    }
}
