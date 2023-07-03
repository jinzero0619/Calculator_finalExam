
namespace HCI_Programming
{
    partial class form_WHR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waist_text = new System.Windows.Forms.TextBox();
            this.hip_text = new System.Windows.Forms.TextBox();
            this.cal_Btn = new System.Windows.Forms.Button();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.male_Rbtn = new System.Windows.Forms.RadioButton();
            this.female_Rbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "허리 둘레(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "엉덩이 둘레(cm)";
            // 
            // waist_text
            // 
            this.waist_text.Location = new System.Drawing.Point(15, 119);
            this.waist_text.Name = "waist_text";
            this.waist_text.Size = new System.Drawing.Size(170, 21);
            this.waist_text.TabIndex = 2;
            // 
            // hip_text
            // 
            this.hip_text.Location = new System.Drawing.Point(15, 184);
            this.hip_text.Name = "hip_text";
            this.hip_text.Size = new System.Drawing.Size(170, 21);
            this.hip_text.TabIndex = 3;
            // 
            // cal_Btn
            // 
            this.cal_Btn.Location = new System.Drawing.Point(12, 211);
            this.cal_Btn.Name = "cal_Btn";
            this.cal_Btn.Size = new System.Drawing.Size(75, 23);
            this.cal_Btn.TabIndex = 4;
            this.cal_Btn.Text = "계산";
            this.cal_Btn.UseVisualStyleBackColor = true;
            this.cal_Btn.Click += new System.EventHandler(this.cal_Btn_Click);
            // 
            // clear_Btn
            // 
            this.clear_Btn.Location = new System.Drawing.Point(110, 211);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(75, 23);
            this.clear_Btn.TabIndex = 5;
            this.clear_Btn.Text = "초기화";
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // male_Rbtn
            // 
            this.male_Rbtn.AutoSize = true;
            this.male_Rbtn.Location = new System.Drawing.Point(40, 45);
            this.male_Rbtn.Name = "male_Rbtn";
            this.male_Rbtn.Size = new System.Drawing.Size(47, 16);
            this.male_Rbtn.TabIndex = 6;
            this.male_Rbtn.Text = "남성";
            this.male_Rbtn.UseVisualStyleBackColor = true;
            this.male_Rbtn.CheckedChanged += new System.EventHandler(this.male_Rbtn_CheckedChanged);
            // 
            // female_Rbtn
            // 
            this.female_Rbtn.AutoSize = true;
            this.female_Rbtn.Location = new System.Drawing.Point(119, 45);
            this.female_Rbtn.Name = "female_Rbtn";
            this.female_Rbtn.Size = new System.Drawing.Size(47, 16);
            this.female_Rbtn.TabIndex = 7;
            this.female_Rbtn.Text = "여성";
            this.female_Rbtn.UseVisualStyleBackColor = true;
            this.female_Rbtn.CheckedChanged += new System.EventHandler(this.female_Rbtn_CheckedChanged);
            // 
            // form_WHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 246);
            this.Controls.Add(this.female_Rbtn);
            this.Controls.Add(this.male_Rbtn);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.cal_Btn);
            this.Controls.Add(this.hip_text);
            this.Controls.Add(this.waist_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_WHR";
            this.Text = "from_WSH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox waist_text;
        private System.Windows.Forms.TextBox hip_text;
        private System.Windows.Forms.Button cal_Btn;
        private System.Windows.Forms.Button clear_Btn;
        private System.Windows.Forms.RadioButton male_Rbtn;
        private System.Windows.Forms.RadioButton female_Rbtn;
    }
}