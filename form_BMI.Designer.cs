
namespace HCI_Programming
{
    partial class form_BMI
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
            this.calculation_btn = new System.Windows.Forms.Button();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculation_btn
            // 
            this.calculation_btn.Location = new System.Drawing.Point(12, 144);
            this.calculation_btn.Name = "calculation_btn";
            this.calculation_btn.Size = new System.Drawing.Size(162, 23);
            this.calculation_btn.TabIndex = 0;
            this.calculation_btn.Text = "계산";
            this.calculation_btn.UseVisualStyleBackColor = true;
            this.calculation_btn.Click += new System.EventHandler(this.calculation_btn_Click);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(12, 43);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(162, 21);
            this.height.TabIndex = 1;
            this.height.Text = "0";
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(12, 105);
            this.weight.Name = "weight";
            this.weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.weight.Size = new System.Drawing.Size(162, 21);
            this.weight.TabIndex = 2;
            this.weight.Text = "0";
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "신장(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "체중(kg)";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 173);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(162, 23);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "초기화";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // form_BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 209);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.calculation_btn);
            this.Name = "form_BMI";
            this.Text = "form_BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculation_btn;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_btn;
    }
}