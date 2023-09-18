using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var islem = listBox1.SelectedIndex;
            var sayi1 = Convert.ToInt32(textBox1.Text);
            var sayi2 = Convert.ToInt32(textBox2.Text);

            if(islem == 0)
            {
                var sonuc = sayi1 + sayi2;
                label1.Text = Convert.ToString(sonuc);

            }
            else if (islem == 1)
            {
                var sonuc = sayi1 - sayi2;
                label1.Text = Convert.ToString(sonuc);

            }
            else if (islem == 2)
            {
                var sonuc = sayi1 * sayi2;
                label1.Text = Convert.ToString(sonuc);

            }
            else if (islem == 3)
            {
                var sonuc = sayi1 / sayi2;
                label1.Text = Convert.ToString(sonuc);


            }

        }
    }
}
