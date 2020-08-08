using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rost;
            if (Double.TryParse(textBox_rost.Text, out rost))
            {
                double ves;
                if (Double.TryParse(textBox_ves.Text, out ves))
                {
                    double bmi = ves / ((rost / 100) * (rost / 100));
                    if (bmi <= 18.5)
                    {
                        label3.Text = "Ниже нормального веса";
                        label3.BackColor = System.Drawing.Color.Red;
                    }
                    else if (bmi >= 18.5 && bmi < 25)
                    {
                        label3.Text = "Нормальный вес";
                        label3.BackColor = System.Drawing.Color.LightGreen;
                    }
                    else if (bmi >= 25 && bmi < 30)
                    {
                        label3.Text = "Избыточный вес";
                        label3.BackColor = System.Drawing.Color.Yellow;
                    }
                    else if (bmi >= 30 && bmi < 35)
                    {
                        label3.Text = "Ожирение I степени";
                        label3.BackColor = System.Drawing.Color.Orange;
                    }
                    else if (bmi >= 35 && bmi < 40)
                    {
                        label3.Text = "Ожирение II степени";
                        label3.BackColor = System.Drawing.Color.OrangeRed;
                    }
                    else if (bmi >= 40)
                    {
                        label3.Text = "Ожирение III степени";
                        label3.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
    }
}
