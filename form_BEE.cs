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
    public partial class form_BEE : Form
    {
        private calculator cal;
        
        public form_BEE(calculator cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            double cm, kg, age,bee;
            if (double.TryParse(heightText.Text, out cm) && double.TryParse(weightText.Text, out kg) && double.TryParse(ageText.Text, out age)
                && cm > 0 && kg > 0 && age > 0){
                if (male_Rbtn.Checked)
                {
                    bee = 88.362 + (13.397 * kg) + (4.799 * cm) - (5.677 * age);
                }
                else
                {
                    bee = 447.593 + (9.247 * kg) + (3.098 * cm) - (4.330 * age);
                }
                cal.setResult(bee,"bee");
                
                this.Close();
            } else if(male_Rbtn.Checked == false && female_Rbtn.Checked == false)
            {
                MessageBox.Show("성별을 선택하세요");
            }
            else 
            {
                MessageBox.Show("올바른 값을 입력하세요");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            weightText.Text = "0";
            ageText.Text = "0";
            heightText.Text = "0";
            female_Rbtn.Checked = false;
            male_Rbtn.Checked = false;
            
        }

        private void male_Rbtn_Click(object sender, EventArgs e)
        {
            female_Rbtn.Checked = false;
        }

        private void female_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            male_Rbtn.Checked = false;
        }
    }
}
