using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_While_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhileDongusu_Click(object sender, EventArgs e)
        {
            int i = 10;
            while (i < 20)
            {
                // NOT : şart ifadesindeki değişkenin değeri scope içinde değiştirilmelidir. yoksa sürekli true sonuç üretileceği içimn, sonsuz döngü olur.
                listBox1.Items.Add("merhaba");
                i++;
            }
        }

        private void btnDoWhileDongusu_Click(object sender, EventArgs e)
        {
            //do
            //{
            //} while (true);
            //// NOT : do while döngüsünde, döngünün dönmeye devam edip etmeyeceği, en sonda kontrol edilir.
            //en sondaki while ifadesinin şart sonucu true ise döngü döner, false ise devam etmez.
            int i = 0;
            do
            {
                listBox1.Items.Add("a");
            } while (i < 0);

            while (i < 0)
            {
                listBox1.Items.Add("b");
            }
            // NOT : do while döngüsünde, ilk defa çalışırken giriş için kontrol yapılmadığından dolayı,
            //ekrana 1 kere a yazacaktır. while da ise girişte kontrol yapılacak, sonuç false olacağı için föndü çalışmayacak ve ekrana b yazılmayaxcaktır. Yani do while döngüsü EN AZ 1 KERE ÇALIŞIR.
        }
        int sayac_a, sayac_b;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIcIceDongu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("a");
                sayac_a++;
                for (int j = 2; j < 15; j += 3)
                {
                    listBox1.Items.Add("b");
                    sayac_b++;
                }
                listBox1.Items.Add("c");
            }
            MessageBox.Show("a : " + sayac_a + " b : " + sayac_b);
            // NOT : İçteki döngünün çalışması bitmeden, dıştaki döngü devam etmez.

        }
    }
}
