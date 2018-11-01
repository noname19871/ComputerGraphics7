namespace ComputerGraphics7
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
            this.PerspectiveBox = new System.Windows.Forms.PictureBox();
            this.OrthographicBox = new System.Windows.Forms.PictureBox();
            this.OrthographicLabel = new System.Windows.Forms.Label();
            this.PerspectiveLabel = new System.Windows.Forms.Label();
            this.ApplyOrthographic = new System.Windows.Forms.Button();
            this.ApplyPerspective = new System.Windows.Forms.Button();
            this.OrthographicComboBox = new System.Windows.Forms.ComboBox();
            this.PerspectiveComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyAffin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ApplyPrimitive = new System.Windows.Forms.Button();
            this.PrimitiveLabel = new System.Windows.Forms.Label();
            this.PrimitiveComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PerspectiveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrthographicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PerspectiveBox
            // 
            this.PerspectiveBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PerspectiveBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PerspectiveBox.Location = new System.Drawing.Point(12, 12);
            this.PerspectiveBox.Name = "PerspectiveBox";
            this.PerspectiveBox.Size = new System.Drawing.Size(700, 325);
            this.PerspectiveBox.TabIndex = 1;
            this.PerspectiveBox.TabStop = false;
            // 
            // OrthographicBox
            // 
            this.OrthographicBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrthographicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrthographicBox.Location = new System.Drawing.Point(12, 344);
            this.OrthographicBox.Name = "OrthographicBox";
            this.OrthographicBox.Size = new System.Drawing.Size(700, 325);
            this.OrthographicBox.TabIndex = 2;
            this.OrthographicBox.TabStop = false;
            // 
            // OrthographicLabel
            // 
            this.OrthographicLabel.AutoSize = true;
            this.OrthographicLabel.Location = new System.Drawing.Point(718, 551);
            this.OrthographicLabel.Name = "OrthographicLabel";
            this.OrthographicLabel.Size = new System.Drawing.Size(149, 19);
            this.OrthographicLabel.TabIndex = 14;
            this.OrthographicLabel.Text = "Выберите проекцию";
            // 
            // PerspectiveLabel
            // 
            this.PerspectiveLabel.AutoSize = true;
            this.PerspectiveLabel.Location = new System.Drawing.Point(718, 220);
            this.PerspectiveLabel.Name = "PerspectiveLabel";
            this.PerspectiveLabel.Size = new System.Drawing.Size(149, 19);
            this.PerspectiveLabel.TabIndex = 13;
            this.PerspectiveLabel.Text = "Выберите проекцию";
            // 
            // ApplyOrthographic
            // 
            this.ApplyOrthographic.Location = new System.Drawing.Point(718, 606);
            this.ApplyOrthographic.Name = "ApplyOrthographic";
            this.ApplyOrthographic.Size = new System.Drawing.Size(190, 62);
            this.ApplyOrthographic.TabIndex = 12;
            this.ApplyOrthographic.Text = "Применить";
            this.ApplyOrthographic.UseVisualStyleBackColor = true;
            this.ApplyOrthographic.Click += new System.EventHandler(this.ApplyOrthographic_Click);
            // 
            // ApplyPerspective
            // 
            this.ApplyPerspective.Location = new System.Drawing.Point(718, 275);
            this.ApplyPerspective.Name = "ApplyPerspective";
            this.ApplyPerspective.Size = new System.Drawing.Size(190, 62);
            this.ApplyPerspective.TabIndex = 11;
            this.ApplyPerspective.Text = "Применить";
            this.ApplyPerspective.UseVisualStyleBackColor = true;
            this.ApplyPerspective.Click += new System.EventHandler(this.ApplyPerspective_Click);
            // 
            // OrthographicComboBox
            // 
            this.OrthographicComboBox.FormattingEnabled = true;
            this.OrthographicComboBox.Items.AddRange(new object[] {
            "Ортографическая XY",
            "Ортографическая XZ",
            "Ортографическая YZ"});
            this.OrthographicComboBox.Location = new System.Drawing.Point(718, 573);
            this.OrthographicComboBox.Name = "OrthographicComboBox";
            this.OrthographicComboBox.Size = new System.Drawing.Size(190, 27);
            this.OrthographicComboBox.TabIndex = 10;
            // 
            // PerspectiveComboBox
            // 
            this.PerspectiveComboBox.FormattingEnabled = true;
            this.PerspectiveComboBox.Items.AddRange(new object[] {
            "Перспективная",
            "Изометрическая"});
            this.PerspectiveComboBox.Location = new System.Drawing.Point(718, 242);
            this.PerspectiveComboBox.Name = "PerspectiveComboBox";
            this.PerspectiveComboBox.Size = new System.Drawing.Size(190, 27);
            this.PerspectiveComboBox.TabIndex = 9;
            // 
            // ApplyAffin
            // 
            this.ApplyAffin.Location = new System.Drawing.Point(1062, 231);
            this.ApplyAffin.Name = "ApplyAffin";
            this.ApplyAffin.Size = new System.Drawing.Size(190, 38);
            this.ApplyAffin.TabIndex = 42;
            this.ApplyAffin.Text = "Применить";
            this.ApplyAffin.UseVisualStyleBackColor = true;
            this.ApplyAffin.Click += new System.EventHandler(this.ApplyAffin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(976, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Масштаб";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(976, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Поворот";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DecimalPlaces = 1;
            this.numericUpDown7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown7.Location = new System.Drawing.Point(1064, 199);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(54, 26);
            this.numericUpDown7.TabIndex = 39;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DecimalPlaces = 1;
            this.numericUpDown8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown8.Location = new System.Drawing.Point(1124, 199);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown8.TabIndex = 38;
            this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.DecimalPlaces = 1;
            this.numericUpDown9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown9.Location = new System.Drawing.Point(1186, 199);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown9.TabIndex = 37;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(1064, 167);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(54, 26);
            this.numericUpDown4.TabIndex = 36;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Location = new System.Drawing.Point(1124, 167);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown5.TabIndex = 35;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown6.Location = new System.Drawing.Point(1186, 167);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown6.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(976, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Смещение";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(1186, 135);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(54, 26);
            this.numericUpDown3.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(1124, 135);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown2.TabIndex = 31;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(1062, 135);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown1.TabIndex = 30;
            // 
            // ApplyPrimitive
            // 
            this.ApplyPrimitive.Location = new System.Drawing.Point(1062, 72);
            this.ApplyPrimitive.Name = "ApplyPrimitive";
            this.ApplyPrimitive.Size = new System.Drawing.Size(190, 38);
            this.ApplyPrimitive.TabIndex = 29;
            this.ApplyPrimitive.Text = "Применить";
            this.ApplyPrimitive.UseVisualStyleBackColor = true;
            this.ApplyPrimitive.Click += new System.EventHandler(this.ApplyPrimitive_Click);
            // 
            // PrimitiveLabel
            // 
            this.PrimitiveLabel.AutoSize = true;
            this.PrimitiveLabel.Location = new System.Drawing.Point(1058, 8);
            this.PrimitiveLabel.Name = "PrimitiveLabel";
            this.PrimitiveLabel.Size = new System.Drawing.Size(149, 19);
            this.PrimitiveLabel.TabIndex = 28;
            this.PrimitiveLabel.Text = "Выберите примитив";
            // 
            // PrimitiveComboBox
            // 
            this.PrimitiveComboBox.FormattingEnabled = true;
            this.PrimitiveComboBox.Items.AddRange(new object[] {
            "Тетраэдр",
            "Гексаэдр",
            "Октаэдр",
            "Икосаэдр"});
            this.PrimitiveComboBox.Location = new System.Drawing.Point(1062, 39);
            this.PrimitiveComboBox.Name = "PrimitiveComboBox";
            this.PrimitiveComboBox.Size = new System.Drawing.Size(190, 27);
            this.PrimitiveComboBox.TabIndex = 27;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1062, 275);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(190, 38);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1062, 319);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(190, 38);
            this.LoadButton.TabIndex = 44;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ApplyAffin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.numericUpDown9);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ApplyPrimitive);
            this.Controls.Add(this.PrimitiveLabel);
            this.Controls.Add(this.PrimitiveComboBox);
            this.Controls.Add(this.OrthographicLabel);
            this.Controls.Add(this.PerspectiveLabel);
            this.Controls.Add(this.ApplyOrthographic);
            this.Controls.Add(this.ApplyPerspective);
            this.Controls.Add(this.OrthographicComboBox);
            this.Controls.Add(this.PerspectiveComboBox);
            this.Controls.Add(this.OrthographicBox);
            this.Controls.Add(this.PerspectiveBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PerspectiveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrthographicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PerspectiveBox;
        private System.Windows.Forms.PictureBox OrthographicBox;
        private System.Windows.Forms.Label OrthographicLabel;
        private System.Windows.Forms.Label PerspectiveLabel;
        private System.Windows.Forms.Button ApplyOrthographic;
        private System.Windows.Forms.Button ApplyPerspective;
        private System.Windows.Forms.ComboBox OrthographicComboBox;
        private System.Windows.Forms.ComboBox PerspectiveComboBox;
        private System.Windows.Forms.Button ApplyAffin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ApplyPrimitive;
        private System.Windows.Forms.Label PrimitiveLabel;
        private System.Windows.Forms.ComboBox PrimitiveComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

