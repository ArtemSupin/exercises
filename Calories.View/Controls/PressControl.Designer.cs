namespace Calories.View.Controls
{
    partial class PressControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxRepeats = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.comboBoxStylePress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRepeats
            // 
            this.textBoxRepeats.Location = new System.Drawing.Point(6, 135);
            this.textBoxRepeats.Name = "textBoxRepeats";
            this.textBoxRepeats.Size = new System.Drawing.Size(121, 22);
            this.textBoxRepeats.TabIndex = 11;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(6, 90);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 22);
            this.textBoxWeight.TabIndex = 10;
            // 
            // comboBoxStylePress
            // 
            this.comboBoxStylePress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStylePress.FormattingEnabled = true;
            this.comboBoxStylePress.Items.AddRange(new object[] {
            "WithLegs",
            "WithoutLegs"});
            this.comboBoxStylePress.Location = new System.Drawing.Point(6, 44);
            this.comboBoxStylePress.Name = "comboBoxStylePress";
            this.comboBoxStylePress.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStylePress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Repeats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Style Press";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Press";
            // 
            // PressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRepeats);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.comboBoxStylePress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "PressControl";
            this.Size = new System.Drawing.Size(145, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRepeats;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ComboBox comboBoxStylePress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
