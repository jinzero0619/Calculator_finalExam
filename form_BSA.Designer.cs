
namespace HCI_Programming
{
    partial class form_BSA
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
            this.Mt_heightText = new System.Windows.Forms.TextBox();
            this.Mt_weightText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mt_clearBtn = new System.Windows.Forms.Button();
            this.Mt_calBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DB_calBtn = new System.Windows.Forms.Button();
            this.DB_clearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DB_weightText = new System.Windows.Forms.TextBox();
            this.DB_heightText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "신장(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "체중(kg)";
            // 
            // Mt_heightText
            // 
            this.Mt_heightText.Location = new System.Drawing.Point(6, 45);
            this.Mt_heightText.Name = "Mt_heightText";
            this.Mt_heightText.Size = new System.Drawing.Size(100, 21);
            this.Mt_heightText.TabIndex = 2;
            this.Mt_heightText.Text = "0";
            this.Mt_heightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Mt_weightText
            // 
            this.Mt_weightText.Location = new System.Drawing.Point(6, 88);
            this.Mt_weightText.Name = "Mt_weightText";
            this.Mt_weightText.Size = new System.Drawing.Size(100, 21);
            this.Mt_weightText.TabIndex = 3;
            this.Mt_weightText.Text = "0";
            this.Mt_weightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mt_clearBtn);
            this.groupBox1.Controls.Add(this.Mt_calBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Mt_weightText);
            this.groupBox1.Controls.Add(this.Mt_heightText);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mosteller공식";
            // 
            // Mt_clearBtn
            // 
            this.Mt_clearBtn.Location = new System.Drawing.Point(6, 168);
            this.Mt_clearBtn.Name = "Mt_clearBtn";
            this.Mt_clearBtn.Size = new System.Drawing.Size(100, 23);
            this.Mt_clearBtn.TabIndex = 5;
            this.Mt_clearBtn.Text = "초기화";
            this.Mt_clearBtn.UseVisualStyleBackColor = true;
            this.Mt_clearBtn.Click += new System.EventHandler(this.Mt_clearBtn_Click);
            // 
            // Mt_calBtn
            // 
            this.Mt_calBtn.Location = new System.Drawing.Point(6, 127);
            this.Mt_calBtn.Name = "Mt_calBtn";
            this.Mt_calBtn.Size = new System.Drawing.Size(100, 23);
            this.Mt_calBtn.TabIndex = 4;
            this.Mt_calBtn.Text = "계산";
            this.Mt_calBtn.UseVisualStyleBackColor = true;
            this.Mt_calBtn.Click += new System.EventHandler(this.Mt_calBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DB_calBtn);
            this.groupBox2.Controls.Add(this.DB_clearBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DB_weightText);
            this.groupBox2.Controls.Add(this.DB_heightText);
            this.groupBox2.Location = new System.Drawing.Point(195, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Du Bois공식";
            // 
            // DB_calBtn
            // 
            this.DB_calBtn.Location = new System.Drawing.Point(6, 125);
            this.DB_calBtn.Name = "DB_calBtn";
            this.DB_calBtn.Size = new System.Drawing.Size(98, 23);
            this.DB_calBtn.TabIndex = 6;
            this.DB_calBtn.Text = "계산";
            this.DB_calBtn.UseVisualStyleBackColor = true;
            this.DB_calBtn.Click += new System.EventHandler(this.DB_calBtn_Click);
            // 
            // DB_clearBtn
            // 
            this.DB_clearBtn.Location = new System.Drawing.Point(6, 168);
            this.DB_clearBtn.Name = "DB_clearBtn";
            this.DB_clearBtn.Size = new System.Drawing.Size(98, 23);
            this.DB_clearBtn.TabIndex = 7;
            this.DB_clearBtn.Text = "초기화";
            this.DB_clearBtn.UseVisualStyleBackColor = true;
            this.DB_clearBtn.Click += new System.EventHandler(this.DB_clearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "신장(m)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "체중(kg)";
            // 
            // DB_weightText
            // 
            this.DB_weightText.Location = new System.Drawing.Point(6, 88);
            this.DB_weightText.Name = "DB_weightText";
            this.DB_weightText.Size = new System.Drawing.Size(100, 21);
            this.DB_weightText.TabIndex = 3;
            this.DB_weightText.Text = "0";
            this.DB_weightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DB_heightText
            // 
            this.DB_heightText.Location = new System.Drawing.Point(6, 45);
            this.DB_heightText.Name = "DB_heightText";
            this.DB_heightText.Size = new System.Drawing.Size(100, 21);
            this.DB_heightText.TabIndex = 2;
            this.DB_heightText.Text = "0";
            this.DB_heightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // form_BSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 222);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_BSA";
            this.Text = "form_BSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mt_heightText;
        private System.Windows.Forms.TextBox Mt_weightText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Mt_clearBtn;
        private System.Windows.Forms.Button Mt_calBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DB_calBtn;
        private System.Windows.Forms.Button DB_clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DB_weightText;
        private System.Windows.Forms.TextBox DB_heightText;
    }
}