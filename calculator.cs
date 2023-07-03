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
    public partial class calculator : Form
    {

        private Timer colorTimer;
        private Color previousColor;
        Control figure,info;


        public calculator()
        {
            InitializeComponent();
        }
    
        public void setResult(Double result,string type)
        {
            result_text.Text = result.ToString();
            resultLabel.Text = "[" + type + "]" + "결과";

            if(type == "bsa" || type =="bee")
                figure = this.Controls.Find("else" + "_fig", true).FirstOrDefault();
            else
                figure = this.Controls.Find(type + "_fig", true).FirstOrDefault();

            info = this.Controls.Find(type + "_info", true).FirstOrDefault();
            if (figure != null && info != null)
            {
                previousColor = figure.BackColor; // 기존 배경색 저장
                SetResultColor(Color.Yellow, figure, info);
            }

            colorTimer = new Timer();
            colorTimer.Interval = 5000; // 유지하고 싶은 시간 설정, 1000당 1초
            colorTimer.Tick += ColorTimer_Tick;
            colorTimer.Start();
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            colorTimer.Stop();
            colorRollBack();
        }

        private void SetResultColor(Color color, Control figure, Control info)
        {
            figure.BackColor = color;
            info.BackColor = color;
        }

        private void colorRollBack()
        {
            if (figure != null && info != null)
            {
                SetResultColor(previousColor, figure, info);
            }
        }

        private void bmi_btn_Click(object sender, EventArgs e)
        {
            var bmiForm = new form_BMI(this);
            bmiForm.ShowDialog();
        }

        private void bsa_btn_Click(object sender, EventArgs e)
        {
            var bsaForm = new form_BSA(this);
            bsaForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var beeForm = new form_BEE(this);
            beeForm.ShowDialog();
        }

        private void whr_btn_Click(object sender, EventArgs e)
        {
            var whrForm = new form_WHR(this);
            whrForm.ShowDialog();
        }
    }
}
