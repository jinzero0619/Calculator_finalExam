using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Programming
{
  
    public partial class form_BSA : Form
    {
        private calculator cal;
        private double m, kg;
        public form_BSA(calculator cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        private void Mt_calBtn_Click(object sender, EventArgs e)
        {
            string height_text = Mt_heightText.Text;
            string weight_text = Mt_weightText.Text;
            if (double.TryParse(height_text, out m) && double.TryParse(weight_text, out kg) && m > 0 && kg > 0)
            {
                double bsa = Math.Sqrt((m * kg) / 3600);
                cal.setResult(bsa,"bsa");
                this.Close();
            }
            else
            {
                MessageBox.Show("올바른 값을 입력하세요");
            }
        }

        private void DB_calBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(DB_heightText.Text, out m) && double.TryParse(DB_weightText.Text, out kg) && m > 0 && kg > 0)
            {
                m /= 100; // cm >> m^2
                double bsa = 0.20247 * Math.Pow(m, 0.725) * Math.Pow(kg, 0.425);
                cal.setResult(bsa,"bsa");
                this.Close();
            }
            else
            {
                MessageBox.Show("올바른 값을 입력하세요");
            }
        }

        private void Mt_clearBtn_Click(object sender, EventArgs e)
        {
            Mt_heightText.Text = "0";
            Mt_weightText.Text = "0";
        }


        private void DB_clearBtn_Click(object sender, EventArgs e)
        {
            DB_heightText.Text = "0";
            DB_weightText.Text = "0";
        }
    }
}
