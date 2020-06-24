namespace Culc_Metr_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCostMetr = new System.Windows.Forms.TextBox();
            this.tbEndCalc = new System.Windows.Forms.TextBox();
            this.tbCost2 = new System.Windows.Forms.TextBox();
            this.tbCost1 = new System.Windows.Forms.TextBox();
            this.tbSectionWidth = new System.Windows.Forms.TextBox();
            this.tbSectionLength = new System.Windows.Forms.TextBox();
            this.tbFabricWidth = new System.Windows.Forms.TextBox();
            this.btMath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCostMetr
            // 
            this.tbCostMetr.Location = new System.Drawing.Point(12, 47);
            this.tbCostMetr.Name = "tbCostMetr";
            this.tbCostMetr.Size = new System.Drawing.Size(123, 20);
            this.tbCostMetr.TabIndex = 0;
            // 
            // tbEndCalc
            // 
            this.tbEndCalc.Location = new System.Drawing.Point(12, 253);
            this.tbEndCalc.Name = "tbEndCalc";
            this.tbEndCalc.Size = new System.Drawing.Size(287, 20);
            this.tbEndCalc.TabIndex = 4;
            // 
            // tbCost2
            // 
            this.tbCost2.Location = new System.Drawing.Point(176, 148);
            this.tbCost2.Name = "tbCost2";
            this.tbCost2.Size = new System.Drawing.Size(123, 20);
            this.tbCost2.TabIndex = 5;
            // 
            // tbCost1
            // 
            this.tbCost1.Location = new System.Drawing.Point(176, 67);
            this.tbCost1.Name = "tbCost1";
            this.tbCost1.Size = new System.Drawing.Size(123, 20);
            this.tbCost1.TabIndex = 6;
            // 
            // tbSectionWidth
            // 
            this.tbSectionWidth.Location = new System.Drawing.Point(12, 164);
            this.tbSectionWidth.Name = "tbSectionWidth";
            this.tbSectionWidth.Size = new System.Drawing.Size(123, 20);
            this.tbSectionWidth.TabIndex = 7;
            // 
            // tbSectionLength
            // 
            this.tbSectionLength.Location = new System.Drawing.Point(12, 125);
            this.tbSectionLength.Name = "tbSectionLength";
            this.tbSectionLength.Size = new System.Drawing.Size(123, 20);
            this.tbSectionLength.TabIndex = 8;
            // 
            // tbFabricWidth
            // 
            this.tbFabricWidth.Location = new System.Drawing.Point(12, 86);
            this.tbFabricWidth.Name = "tbFabricWidth";
            this.tbFabricWidth.Size = new System.Drawing.Size(123, 20);
            this.tbFabricWidth.TabIndex = 9;
            // 
            // btMath
            // 
            this.btMath.Location = new System.Drawing.Point(85, 223);
            this.btMath.Name = "btMath";
            this.btMath.Size = new System.Drawing.Size(123, 24);
            this.btMath.TabIndex = 10;
            this.btMath.Text = "Рассчитать";
            this.btMath.UseVisualStyleBackColor = true;
            this.btMath.Click += new System.EventHandler(this.btMath_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Рассчет Цены по Квадратным Сантиметрам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Цена Погонного Метра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ширина Ткани";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Длина Отрезка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Цена Квадратного Сантиметра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(196, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Площадь Куска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ширина Отрезка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(121, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Итог";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 319);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMath);
            this.Controls.Add(this.tbFabricWidth);
            this.Controls.Add(this.tbSectionLength);
            this.Controls.Add(this.tbSectionWidth);
            this.Controls.Add(this.tbCost1);
            this.Controls.Add(this.tbCost2);
            this.Controls.Add(this.tbEndCalc);
            this.Controls.Add(this.tbCostMetr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCostMetr;
        private System.Windows.Forms.TextBox tbEndCalc;
        private System.Windows.Forms.TextBox tbCost2;
        private System.Windows.Forms.TextBox tbCost1;
        private System.Windows.Forms.TextBox tbSectionWidth;
        private System.Windows.Forms.TextBox tbSectionLength;
        private System.Windows.Forms.TextBox tbFabricWidth;
        private System.Windows.Forms.Button btMath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

