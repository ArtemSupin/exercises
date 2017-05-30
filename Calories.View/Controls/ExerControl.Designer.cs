namespace Calories.View.Controls
{
    partial class ExerControl
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
            this.comboBoxExercises = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.swimmingControl = new Calories.View.Controls.SwimmingControl();
            this.runControl = new Calories.View.Controls.RunControl();
            this.pressControl = new Calories.View.Controls.PressControl();
            this.SuspendLayout();
            // 
            // comboBoxExercises
            // 
            this.comboBoxExercises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExercises.FormattingEnabled = true;
            this.comboBoxExercises.Items.AddRange(new object[] {
            "Run",
            "Swimming",
            "Press"});
            this.comboBoxExercises.Location = new System.Drawing.Point(3, 30);
            this.comboBoxExercises.Name = "comboBoxExercises";
            this.comboBoxExercises.Size = new System.Drawing.Size(121, 24);
            this.comboBoxExercises.TabIndex = 3;
            this.comboBoxExercises.SelectedIndexChanged += new System.EventHandler(this.comboBoxExercises_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exercises";
            // 
            // swimmingControl
            // 
            this.swimmingControl.Location = new System.Drawing.Point(2, 69);
            this.swimmingControl.Name = "swimmingControl";
            this.swimmingControl.Size = new System.Drawing.Size(137, 139);
            this.swimmingControl.TabIndex = 2;
            // 
            // runControl
            // 
            this.runControl.Location = new System.Drawing.Point(7, 77);
            this.runControl.Name = "runControl";
            this.runControl.Size = new System.Drawing.Size(137, 131);
            this.runControl.TabIndex = 1;
            // 
            // pressControl
            // 
            this.pressControl.Location = new System.Drawing.Point(3, 77);
            this.pressControl.Name = "pressControl";
            this.pressControl.Size = new System.Drawing.Size(147, 170);
            this.pressControl.TabIndex = 0;
            // 
            // ExerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExercises);
            this.Controls.Add(this.swimmingControl);
            this.Controls.Add(this.runControl);
            this.Controls.Add(this.pressControl);
            this.Name = "ExerControl";
            this.Size = new System.Drawing.Size(147, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PressControl pressControl;
        private RunControl runControl;
        private SwimmingControl swimmingControl;
        private System.Windows.Forms.ComboBox comboBoxExercises;
        private System.Windows.Forms.Label label1;
    }
}
