
using System;

namespace HCI_Programming
{
    partial class calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.result_text = new System.Windows.Forms.TextBox();
            this.whr_btn = new System.Windows.Forms.Button();
            this.bee_btn = new System.Windows.Forms.Button();
            this.bsa_btn = new System.Windows.Forms.Button();
            this.bmi_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whr_info = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bee_info = new System.Windows.Forms.Label();
            this.bsa_info = new System.Windows.Forms.Label();
            this.bmi_info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bmi_fig = new System.Windows.Forms.Label();
            this.whr_fig = new System.Windows.Forms.Label();
            this.else_fig = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Controls.Add(this.result_text);
            this.groupBox1.Controls.Add(this.whr_btn);
            this.groupBox1.Controls.Add(this.bee_btn);
            this.groupBox1.Controls.Add(this.bsa_btn);
            this.groupBox1.Controls.Add(this.bmi_btn);
            this.groupBox1.Location = new System.Drawing.Point(18, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "공식 계산기";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("굴림", 11F);
            this.resultLabel.Location = new System.Drawing.Point(11, 104);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 15);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "결과";
            // 
            // result_text
            // 
            this.result_text.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.result_text.Location = new System.Drawing.Point(15, 127);
            this.result_text.Name = "result_text";
            this.result_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result_text.Size = new System.Drawing.Size(337, 21);
            this.result_text.TabIndex = 5;
            this.result_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // whr_btn
            // 
            this.whr_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.whr_btn.Location = new System.Drawing.Point(282, 34);
            this.whr_btn.Name = "whr_btn";
            this.whr_btn.Size = new System.Drawing.Size(70, 54);
            this.whr_btn.TabIndex = 4;
            this.whr_btn.Text = "WHR";
            this.whr_btn.UseVisualStyleBackColor = true;
            this.whr_btn.Click += new System.EventHandler(this.whr_btn_Click);
            // 
            // bee_btn
            // 
            this.bee_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bee_btn.Location = new System.Drawing.Point(192, 34);
            this.bee_btn.Name = "bee_btn";
            this.bee_btn.Size = new System.Drawing.Size(70, 54);
            this.bee_btn.TabIndex = 3;
            this.bee_btn.Text = "BEE";
            this.bee_btn.UseVisualStyleBackColor = true;
            this.bee_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // bsa_btn
            // 
            this.bsa_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bsa_btn.Location = new System.Drawing.Point(106, 34);
            this.bsa_btn.Name = "bsa_btn";
            this.bsa_btn.Size = new System.Drawing.Size(70, 54);
            this.bsa_btn.TabIndex = 2;
            this.bsa_btn.Text = "BSA";
            this.bsa_btn.UseVisualStyleBackColor = true;
            this.bsa_btn.Click += new System.EventHandler(this.bsa_btn_Click);
            // 
            // bmi_btn
            // 
            this.bmi_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bmi_btn.Location = new System.Drawing.Point(15, 34);
            this.bmi_btn.Name = "bmi_btn";
            this.bmi_btn.Size = new System.Drawing.Size(70, 54);
            this.bmi_btn.TabIndex = 1;
            this.bmi_btn.Text = "BMI";
            this.bmi_btn.UseVisualStyleBackColor = true;
            this.bmi_btn.Click += new System.EventHandler(this.bmi_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Controls.Add(this.whr_info);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bee_info);
            this.groupBox2.Controls.Add(this.bsa_info);
            this.groupBox2.Controls.Add(this.bmi_info);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(407, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 408);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "정보";
            // 
            // whr_info
            // 
            this.whr_info.Location = new System.Drawing.Point(17, 350);
            this.whr_info.Name = "whr_info";
            this.whr_info.Size = new System.Drawing.Size(344, 43);
            this.whr_info.TabIndex = 7;
            this.whr_info.Text = "허리둘레와 엉덩이둘레의 비율로 계산되는 지표다. WHR은 복부 비만의 정도를 평가하는 데 사용되며, 심혈관 질환 및 대사 증후군의 위험을 예측하는" +
    " 데 도움된다.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "[ WHR ]";
            // 
            // bee_info
            // 
            this.bee_info.Location = new System.Drawing.Point(17, 242);
            this.bee_info.Name = "bee_info";
            this.bee_info.Size = new System.Drawing.Size(344, 43);
            this.bee_info.TabIndex = 5;
            this.bee_info.Text = "기저 대사 소모량으로, 몸이 휴식 상태에서 소비하는 최소한의 에너지 양을 의미한다. BEE는 개인의 성별, 신장, 체중, 나이에 따라 다르게 계산" +
    "된다.";
            // 
            // bsa_info
            // 
            this.bsa_info.Location = new System.Drawing.Point(17, 152);
            this.bsa_info.Name = "bsa_info";
            this.bsa_info.Size = new System.Drawing.Size(345, 26);
            this.bsa_info.TabIndex = 4;
            this.bsa_info.Text = "신체 표현 면적을 나타내는 지표로, 약물 투여량, 방사선 치료, 수액치료등에 사용된다.";
            // 
            // bmi_info
            // 
            this.bmi_info.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bmi_info.Location = new System.Drawing.Point(17, 71);
            this.bmi_info.Name = "bmi_info";
            this.bmi_info.Size = new System.Drawing.Size(335, 30);
            this.bmi_info.TabIndex = 3;
            this.bmi_info.Text = "체질량 지수로, 개인의 체중과 신장 사이 값을 통해 계산하며, 체중관리와 비만의 지표로 쓰인다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "[ BEE ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "[ BSA ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "[ BMI ]";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Controls.Add(this.bmi_fig);
            this.groupBox3.Controls.Add(this.whr_fig);
            this.groupBox3.Controls.Add(this.else_fig);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(18, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 238);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수치 확인";
            // 
            // bmi_fig
            // 
            this.bmi_fig.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bmi_fig.Location = new System.Drawing.Point(13, 53);
            this.bmi_fig.Name = "bmi_fig";
            this.bmi_fig.Size = new System.Drawing.Size(350, 40);
            this.bmi_fig.TabIndex = 11;
            this.bmi_fig.Text = "[ 저체중 ] 18.5 ↓ [ 정상체중 ] 18.5~24.9  \r\r[ 과체중 ] 25~29.9  [ 비만 ] 30 ↑";
            // 
            // whr_fig
            // 
            this.whr_fig.ForeColor = System.Drawing.SystemColors.Desktop;
            this.whr_fig.Location = new System.Drawing.Point(13, 126);
            this.whr_fig.Name = "whr_fig";
            this.whr_fig.Size = new System.Drawing.Size(350, 30);
            this.whr_fig.TabIndex = 10;
            this.whr_fig.Text = "[여성]  0.7 ↓ 건강 \r[남성]  0.9 ↓ 건강";
            // 
            // else_fig
            // 
            this.else_fig.ForeColor = System.Drawing.SystemColors.Desktop;
            this.else_fig.Location = new System.Drawing.Point(12, 193);
            this.else_fig.Name = "else_fig";
            this.else_fig.Size = new System.Drawing.Size(350, 30);
            this.else_fig.TabIndex = 8;
            this.else_fig.Text = "신체조건과 활동수준, 나이에 따라 다르기 때문에 정확한 평균값 제시가 어렵습니다";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(12, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "[ WHR ]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(13, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "[ BSA, BEE ]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(13, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "[ BMI ]";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "calculator";
            this.Text = "바이오헬스 계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button whr_btn;
        private System.Windows.Forms.Button bee_btn;
        private System.Windows.Forms.Button bsa_btn;
        private System.Windows.Forms.Button bmi_btn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label bee_info;
        private System.Windows.Forms.Label bsa_info;
        private System.Windows.Forms.Label bmi_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label whr_info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label else_fig;
        private System.Windows.Forms.Label whr_fig;
        private System.Windows.Forms.Label bmi_fig;
    }
}

