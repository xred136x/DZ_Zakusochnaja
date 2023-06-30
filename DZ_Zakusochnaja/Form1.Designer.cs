namespace DZ_Zakusochnaja
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
            this.first_course = new System.Windows.Forms.ListBox();
            this.salads = new System.Windows.Forms.ListBox();
            this.desserts = new System.Windows.Forms.ListBox();
            this.drinks = new System.Windows.Forms.ListBox();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSalates = new System.Windows.Forms.Label();
            this.labelDesserts = new System.Windows.Forms.Label();
            this.labelDrinks = new System.Windows.Forms.Label();
            this.checkBoxZucker = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLime = new System.Windows.Forms.RadioButton();
            this.radioButtonMilk = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_course
            // 
            this.first_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_course.FormattingEnabled = true;
            this.first_course.ItemHeight = 20;
            this.first_course.Items.AddRange(new object[] {
            "Суп",
            "Картофель жареный ",
            "Рагу мясное"});
            this.first_course.Location = new System.Drawing.Point(12, 50);
            this.first_course.Name = "first_course";
            this.first_course.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.first_course.Size = new System.Drawing.Size(177, 84);
            this.first_course.TabIndex = 0;
            this.first_course.SelectedIndexChanged += new System.EventHandler(this.Первое_SelectedIndexChanged);
            // 
            // salads
            // 
            this.salads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salads.FormattingEnabled = true;
            this.salads.ItemHeight = 20;
            this.salads.Items.AddRange(new object[] {
            "цезарь",
            "мемоза",
            "витаминный"});
            this.salads.Location = new System.Drawing.Point(195, 50);
            this.salads.Name = "salads";
            this.salads.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.salads.Size = new System.Drawing.Size(177, 84);
            this.salads.TabIndex = 0;
            // 
            // desserts
            // 
            this.desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desserts.FormattingEnabled = true;
            this.desserts.ItemHeight = 20;
            this.desserts.Items.AddRange(new object[] {
            "эклер",
            "чизкейк",
            "наполеон"});
            this.desserts.Location = new System.Drawing.Point(378, 50);
            this.desserts.Name = "desserts";
            this.desserts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.desserts.Size = new System.Drawing.Size(177, 84);
            this.desserts.TabIndex = 0;
            // 
            // drinks
            // 
            this.drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinks.FormattingEnabled = true;
            this.drinks.ItemHeight = 20;
            this.drinks.Items.AddRange(new object[] {
            "пепси",
            "сок",
            "чай",
            "кофе"});
            this.drinks.Location = new System.Drawing.Point(561, 50);
            this.drinks.Name = "drinks";
            this.drinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.drinks.Size = new System.Drawing.Size(177, 84);
            this.drinks.TabIndex = 0;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirst.Location = new System.Drawing.Point(12, 9);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(86, 25);
            this.labelFirst.TabIndex = 1;
            this.labelFirst.Text = "Первое";
            // 
            // labelSalates
            // 
            this.labelSalates.AutoSize = true;
            this.labelSalates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalates.Location = new System.Drawing.Point(190, 9);
            this.labelSalates.Name = "labelSalates";
            this.labelSalates.Size = new System.Drawing.Size(88, 25);
            this.labelSalates.TabIndex = 1;
            this.labelSalates.Text = "Салаты";
            // 
            // labelDesserts
            // 
            this.labelDesserts.AutoSize = true;
            this.labelDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesserts.Location = new System.Drawing.Point(373, 9);
            this.labelDesserts.Name = "labelDesserts";
            this.labelDesserts.Size = new System.Drawing.Size(100, 25);
            this.labelDesserts.TabIndex = 1;
            this.labelDesserts.Text = "Десерты";
            // 
            // labelDrinks
            // 
            this.labelDrinks.AutoSize = true;
            this.labelDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinks.Location = new System.Drawing.Point(556, 9);
            this.labelDrinks.Name = "labelDrinks";
            this.labelDrinks.Size = new System.Drawing.Size(96, 25);
            this.labelDrinks.TabIndex = 1;
            this.labelDrinks.Text = "Напитки";
            // 
            // checkBoxZucker
            // 
            this.checkBoxZucker.AutoSize = true;
            this.checkBoxZucker.Location = new System.Drawing.Point(7, 84);
            this.checkBoxZucker.Name = "checkBoxZucker";
            this.checkBoxZucker.Size = new System.Drawing.Size(73, 24);
            this.checkBoxZucker.TabIndex = 2;
            this.checkBoxZucker.Text = "Сахар";
            this.checkBoxZucker.UseVisualStyleBackColor = true;
            this.checkBoxZucker.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMilk);
            this.groupBox1.Controls.Add(this.radioButtonLime);
            this.groupBox1.Controls.Add(this.checkBoxZucker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(744, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительно к напиткам";
            // 
            // radioButtonLime
            // 
            this.radioButtonLime.AutoSize = true;
            this.radioButtonLime.Location = new System.Drawing.Point(7, 26);
            this.radioButtonLime.Name = "radioButtonLime";
            this.radioButtonLime.Size = new System.Drawing.Size(77, 24);
            this.radioButtonLime.TabIndex = 3;
            this.radioButtonLime.TabStop = true;
            this.radioButtonLime.Text = "Лимон";
            this.radioButtonLime.UseVisualStyleBackColor = true;
            // 
            // radioButtonMilk
            // 
            this.radioButtonMilk.AutoSize = true;
            this.radioButtonMilk.Location = new System.Drawing.Point(6, 54);
            this.radioButtonMilk.Name = "radioButtonMilk";
            this.radioButtonMilk.Size = new System.Drawing.Size(85, 24);
            this.radioButtonMilk.TabIndex = 3;
            this.radioButtonMilk.TabStop = true;
            this.radioButtonMilk.Text = "Молоко";
            this.radioButtonMilk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDrinks);
            this.Controls.Add(this.labelDesserts);
            this.Controls.Add(this.labelSalates);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.desserts);
            this.Controls.Add(this.salads);
            this.Controls.Add(this.first_course);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox first_course;
        private System.Windows.Forms.ListBox salads;
        private System.Windows.Forms.ListBox desserts;
        private System.Windows.Forms.ListBox drinks;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSalates;
        private System.Windows.Forms.Label labelDesserts;
        private System.Windows.Forms.Label labelDrinks;
        private System.Windows.Forms.CheckBox checkBoxZucker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMilk;
        private System.Windows.Forms.RadioButton radioButtonLime;
    }
}

