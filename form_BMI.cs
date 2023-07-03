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
    public partial class form_BMI : Form
    {
        private calculator cal;
       
        public form_BMI(calculator cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        // 계산 버튼 클릭 
        private void calculation_btn_Click(object sender, EventArgs e)
        {
            string height_text = height.Text;
            string weight_text = weight.Text;
            double m, kg;

            // 유효성 검사
            if (double.TryParse(height_text, out m) && double.TryParse(weight_text, out kg) && m > 0  && kg > 0)
            {
                m /= 100;
                Double bmi = kg / (m * m);
                cal.setResult(bmi,"bmi");
                if (bmi < 18.5)
                {
                    MessageBox.Show("저체중");
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                     MessageBox.Show("정상체중");
                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    MessageBox.Show("과체중");
                }
                else
                {
                    MessageBox.Show("비만");
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("올바른 숫자를 입력하세요.");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            height.Text = "0";
            weight.Text = "0";
        }
    }
}
