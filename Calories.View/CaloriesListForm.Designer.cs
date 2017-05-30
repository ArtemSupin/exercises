namespace Calories.View
{
    partial class CaloriesListForm
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
            this.dataGridViewCalories = new System.Windows.Forms.DataGridView();
            this.ColumnNameExercises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxWeightHuman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRecalculate = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.exerControl = new Calories.View.Controls.ExerControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalories)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCalories
            // 
            this.dataGridViewCalories.AllowUserToAddRows = false;
            this.dataGridViewCalories.AllowUserToDeleteRows = false;
            this.dataGridViewCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCalories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCalories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameExercises,
            this.ColumnCalories});
            this.dataGridViewCalories.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewCalories.Name = "dataGridViewCalories";
            this.dataGridViewCalories.ReadOnly = true;
            this.dataGridViewCalories.RowTemplate.Height = 24;
            this.dataGridViewCalories.ShowCellErrors = false;
            this.dataGridViewCalories.Size = new System.Drawing.Size(833, 419);
            this.dataGridViewCalories.TabIndex = 0;
            this.dataGridViewCalories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCalories_RowHeaderMouseClick);
            // 
            // ColumnNameExercises
            // 
            this.ColumnNameExercises.HeaderText = "Name Exercises";
            this.ColumnNameExercises.Name = "ColumnNameExercises";
            this.ColumnNameExercises.ReadOnly = true;
            // 
            // ColumnCalories
            // 
            this.ColumnCalories.HeaderText = "Calories";
            this.ColumnCalories.Name = "ColumnCalories";
            this.ColumnCalories.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 469);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(93, 469);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(174, 469);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxWeightHuman
            // 
            this.textBoxWeightHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWeightHuman.Location = new System.Drawing.Point(745, 469);
            this.textBoxWeightHuman.Name = "textBoxWeightHuman";
            this.textBoxWeightHuman.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeightHuman.TabIndex = 4;
            this.textBoxWeightHuman.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Weight Human";
            // 
            // buttonRecalculate
            // 
            this.buttonRecalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecalculate.Location = new System.Drawing.Point(638, 468);
            this.buttonRecalculate.Name = "buttonRecalculate";
            this.buttonRecalculate.Size = new System.Drawing.Size(101, 23);
            this.buttonRecalculate.TabIndex = 6;
            this.buttonRecalculate.Text = "Recalculate";
            this.buttonRecalculate.UseVisualStyleBackColor = true;
            this.buttonRecalculate.Click += new System.EventHandler(this.buttonRecalculate_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRandom.Location = new System.Drawing.Point(442, 469);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 7;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.Location = new System.Drawing.Point(255, 468);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // exerControl
            // 
            this.exerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exerControl.Exercises = null;
            this.exerControl.Location = new System.Drawing.Point(851, 26);
            this.exerControl.Name = "exerControl";
            this.exerControl.Size = new System.Drawing.Size(147, 243);
            this.exerControl.TabIndex = 10;
            // 
            // CaloriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 515);
            this.Controls.Add(this.exerControl);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonRecalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeightHuman);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewCalories);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CaloriesList";
            this.Text = "Calories";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalories)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalories;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameExercises;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalories;
        private System.Windows.Forms.TextBox textBoxWeightHuman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRecalculate;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button buttonSearch;
        private Controls.ExerControl exerControl;
    }
}

