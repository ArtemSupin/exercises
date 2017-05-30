namespace Calories.View.Controls
{
    partial class RunControl
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
            this.textBoxDistanceRun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIntence = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDistanceRun
            // 
            this.textBoxDistanceRun.Location = new System.Drawing.Point(3, 92);
            this.textBoxDistanceRun.Name = "textBoxDistanceRun";
            this.textBoxDistanceRun.Size = new System.Drawing.Size(121, 22);
            this.textBoxDistanceRun.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distance";
            // 
            // comboBoxIntence
            // 
            this.comboBoxIntence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIntence.FormattingEnabled = true;
            this.comboBoxIntence.Items.AddRange(new object[] {
            "Slow",
            "Middle",
            "Fast"});
            this.comboBoxIntence.Location = new System.Drawing.Point(3, 45);
            this.comboBoxIntence.Name = "comboBoxIntence";
            this.comboBoxIntence.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIntence.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Intence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Run";
            // 
            // RunControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDistanceRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIntence);
            this.Controls.Add(this.label1);
            this.Name = "RunControl";
            this.Size = new System.Drawing.Size(131, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDistanceRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIntence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
