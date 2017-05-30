namespace Calories.View.Controls
{
    partial class SwimmingControl
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
            this.textBoxDistanceSwimming = new System.Windows.Forms.TextBox();
            this.comboBoxStyleSwimming = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDistanceSwimming
            // 
            this.textBoxDistanceSwimming.Location = new System.Drawing.Point(8, 96);
            this.textBoxDistanceSwimming.Name = "textBoxDistanceSwimming";
            this.textBoxDistanceSwimming.Size = new System.Drawing.Size(119, 22);
            this.textBoxDistanceSwimming.TabIndex = 10;
            // 
            // comboBoxStyleSwimming
            // 
            this.comboBoxStyleSwimming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyleSwimming.FormattingEnabled = true;
            this.comboBoxStyleSwimming.Items.AddRange(new object[] {
            "Bangle",
            "Butterfly",
            "Freestyle",
            "Backswim"});
            this.comboBoxStyleSwimming.Location = new System.Drawing.Point(6, 49);
            this.comboBoxStyleSwimming.Name = "comboBoxStyleSwimming";
            this.comboBoxStyleSwimming.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStyleSwimming.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Style Swimming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Swimming";
            // 
            // SwimmingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDistanceSwimming);
            this.Controls.Add(this.comboBoxStyleSwimming);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SwimmingControl";
            this.Size = new System.Drawing.Size(137, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDistanceSwimming;
        private System.Windows.Forms.ComboBox comboBoxStyleSwimming;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
