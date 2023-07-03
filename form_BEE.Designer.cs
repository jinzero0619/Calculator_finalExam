
namespace HCI_Programming
{
    partial class form_BEE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.heightText = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.male_Rbtn = new System.Windows.Forms.RadioButton();
            this.female_Rbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.female_Rbtn);
            this.groupBox1.Controls.Add(this.male_Rbtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageText);
            this.groupBox1.Controls.Add(this.weightText);
            this.groupBox1.Controls.Add(this.heightText);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.calBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BEE";
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(29, 252);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(75, 23);
            this.calBtn.TabIndex = 0;
            this.calBtn.Text = "계산";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(145, 252);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "초기화";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(29, 109);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(191, 21);
            this.heightText.TabIndex = 2;
            this.heightText.Text = "0";
            this.heightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(29, 161);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(191, 21);
            this.weightText.TabIndex = 3;
            this.weightText.Text = "0";
            this.weightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(29, 212);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(191, 21);
            this.ageText.TabIndex = 4;
            this.ageText.Text = "0";
            this.ageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "신장(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "체중(kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "나이(age)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "성별";
            // 
            // male_Rbtn
            // 
            this.male_Rbtn.AutoSize = true;
            this.male_Rbtn.Location = new System.Drawing.Point(29, 62);
            this.male_Rbtn.Name = "male_Rbtn";
            this.male_Rbtn.Size = new System.Drawing.Size(85, 16);
            this.male_Rbtn.TabIndex = 11;
            this.male_Rbtn.TabStop = true;
            this.male_Rbtn.Text = "남성(male)";
            this.male_Rbtn.UseVisualStyleBackColor = true;
            this.male_Rbtn.Click += new System.EventHandler(this.male_Rbtn_Click);
            // 
            // female_Rbtn
            // 
            this.female_Rbtn.AutoSize = true;
            this.female_Rbtn.Location = new System.Drawing.Point(125, 62);
            this.female_Rbtn.Name = "female_Rbtn";
            this.female_Rbtn.Size = new System.Drawing.Size(95, 16);
            this.female_Rbtn.TabIndex = 12;
            this.female_Rbtn.TabStop = true;
            this.female_Rbtn.Text = "여성(female)";
            this.female_Rbtn.UseVisualStyleBackColor = true;
            this.female_Rbtn.CheckedChanged += new System.EventHandler(this.female_Rbtn_CheckedChanged);
            // 
            // form_BEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 312);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_BEE";
            this.Text = "form_BEE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.RadioButton female_Rbtn;
        private System.Windows.Forms.RadioButton male_Rbtn;
        private System.Windows.Forms.Label label4;
    }
}