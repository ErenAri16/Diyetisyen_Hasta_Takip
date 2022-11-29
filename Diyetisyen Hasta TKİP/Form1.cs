using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo = Convert.ToDouble(textBox1.Text);
            double boy = Convert.ToDouble(textBox2.Text);
            double boykare = Math.Pow(boy,2);

            double Sonuç = kilo / boykare;
            label8.Text = Sonuç.ToString();

            if (Sonuç < 18)
            {
                label7.Text = "İdeal kilonuzun altındasınız, kilo almanız sağlınız için iyi olur";
                    label7.ForeColor = Color.Green;
            }
            else if (Sonuç < 25 && Sonuç > 18)
            {
                label7.Text = "İdeal kilodasınız";
                    label7.ForeColor= Color.Green;
            }
            else if (Sonuç < 30 && Sonuç > 25)
            {
                label7.Text = "İdeal kilonuzun biraz üstündesiniz, beslenmenize dikkat edin";
                    label7.ForeColor=(Color)Color.Yellow;
            }
            else if (Sonuç < 35 && Sonuç > 30)
            {
                label7.Text = "Obezsiniz sağlık kurumuna başvurmanız gerekiyor";
                    label7.ForeColor= Color.Orange;
            }
            else if (Sonuç > 35)
            {
                label7.Text = "Morbid obezsiniz, Acilen bir sağlık kurumuna başvurun";
                label7.ForeColor = Color.Red;
            }
        }

    }
}
