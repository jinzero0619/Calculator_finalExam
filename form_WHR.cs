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
    public partial class form_WHR : Form
    {
        private calculator cal;
        public form_WHR(calculator cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        private void cal_Btn_Click(object sender, EventArgs e)
        {
            double waist, hip, whr;
            if (double.TryParse(hip_text.Text, out waist) && double.TryParse(waist_text.Text, out hip) && waist > 0 && hip > 0 && (female_Rbtn.Checked || male_Rbtn.Checked))
            {
                whr = waist / hip;
                cal.setResult(whr,"whr");
                if(male_Rbtn.Checked && whr <= 0.9)
                {
                    MessageBox.Show("정상");
                } else if (female_Rbtn.Checked && whr <= 0.7)
                {
                    MessageBox.Show("정상");
                }
                this.Close();
            } else if (female_Rbtn.Checked == false && male_Rbtn.Checked == false)
            {
                MessageBox.Show("성별을 선택하세요");
            }
            else
            {
                MessageBox.Show("올바른 값을 입력하세요");
            }
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            hip_text.Text = "0";
            waist_text.Text = "0";
        }

        private void male_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            female_Rbtn.Checked = false;
        }

        private void female_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            male_Rbtn.Checked = false;
        }
    }
}
