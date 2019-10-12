namespace файловый_менеджер
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
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.copy1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.move1 = new System.Windows.Forms.Button();
            this.Drivers1 = new System.Windows.Forms.ComboBox();
            this.Poisk1 = new System.Windows.Forms.TextBox();
            this.Poisk2 = new System.Windows.Forms.TextBox();
            this.Drivers2 = new System.Windows.Forms.ComboBox();
            this.way1 = new System.Windows.Forms.TextBox();
            this.way2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.back1 = new System.Windows.Forms.Button();
            this.back2 = new System.Windows.Forms.Button();
            this.insert1 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.insert2 = new System.Windows.Forms.Button();
            this.move2 = new System.Windows.Forms.Button();
            this.copy2 = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.Button();
            this.search2 = new System.Windows.Forms.Button();
            this.Compress1 = new System.Windows.Forms.Button();
            this.Compress2 = new System.Windows.Forms.Button();
            this.forward1 = new System.Windows.Forms.Button();
            this.forward2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(2, 53);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(335, 355);
            this.List1.TabIndex = 0;
            this.List1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List1_MouseDoubleClick);
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.Location = new System.Drawing.Point(335, 53);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(338, 355);
            this.List2.TabIndex = 1;
            this.List2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List2_MouseDoubleClick);
            // 
            // copy1
            // 
            this.copy1.Location = new System.Drawing.Point(2, 414);
            this.copy1.Name = "copy1";
            this.copy1.Size = new System.Drawing.Size(77, 28);
            this.copy1.TabIndex = 2;
            this.copy1.Text = "copy1";
            this.copy1.UseVisualStyleBackColor = true;
            this.copy1.Click += new System.EventHandler(this.copy1_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(246, 414);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(72, 28);
            this.delete1.TabIndex = 3;
            this.delete1.Text = "delete1";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // move1
            // 
            this.move1.Location = new System.Drawing.Point(86, 414);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(75, 27);
            this.move1.TabIndex = 4;
            this.move1.Text = "move1";
            this.move1.UseVisualStyleBackColor = true;
            this.move1.Click += new System.EventHandler(this.move1_Click);
            // 
            // Drivers1
            // 
            this.Drivers1.FormattingEnabled = true;
            this.Drivers1.Location = new System.Drawing.Point(2, 27);
            this.Drivers1.Name = "Drivers1";
            this.Drivers1.Size = new System.Drawing.Size(121, 21);
            this.Drivers1.TabIndex = 5;
            this.Drivers1.SelectedIndexChanged += new System.EventHandler(this.Drivers1_SelectedIndexChanged);
            // 
            // Poisk1
            // 
            this.Poisk1.Location = new System.Drawing.Point(2, 490);
            this.Poisk1.Name = "Poisk1";
            this.Poisk1.Size = new System.Drawing.Size(327, 20);
            this.Poisk1.TabIndex = 6;
            this.Poisk1.TextChanged += new System.EventHandler(this.Poisk1_TextChanged);
            // 
            // Poisk2
            // 
            this.Poisk2.Location = new System.Drawing.Point(335, 491);
            this.Poisk2.Name = "Poisk2";
            this.Poisk2.Size = new System.Drawing.Size(327, 20);
            this.Poisk2.TabIndex = 8;
            this.Poisk2.TextChanged += new System.EventHandler(this.Poisk2_TextChanged);
            // 
            // Drivers2
            // 
            this.Drivers2.FormattingEnabled = true;
            this.Drivers2.Location = new System.Drawing.Point(338, 26);
            this.Drivers2.Name = "Drivers2";
            this.Drivers2.Size = new System.Drawing.Size(121, 21);
            this.Drivers2.TabIndex = 7;
            this.Drivers2.SelectedIndexChanged += new System.EventHandler(this.Drivers2_SelectedIndexChanged);
            // 
            // way1
            // 
            this.way1.Location = new System.Drawing.Point(2, 1);
            this.way1.Name = "way1";
            this.way1.Size = new System.Drawing.Size(335, 20);
            this.way1.TabIndex = 9;
            this.way1.TextChanged += new System.EventHandler(this.way1_TextChanged);
            // 
            // way2
            // 
            this.way2.Location = new System.Drawing.Point(338, 1);
            this.way2.Name = "way2";
            this.way2.Size = new System.Drawing.Size(335, 20);
            this.way2.TabIndex = 10;
            this.way2.TextChanged += new System.EventHandler(this.way2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 516);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(335, 517);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(129, 27);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(81, 23);
            this.back1.TabIndex = 13;
            this.back1.Text = "назад";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // back2
            // 
            this.back2.Location = new System.Drawing.Point(465, 24);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(81, 23);
            this.back2.TabIndex = 14;
            this.back2.Text = "назад";
            this.back2.UseVisualStyleBackColor = true;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // insert1
            // 
            this.insert1.Location = new System.Drawing.Point(166, 414);
            this.insert1.Name = "insert1";
            this.insert1.Size = new System.Drawing.Size(74, 28);
            this.insert1.TabIndex = 15;
            this.insert1.Text = "insert1";
            this.insert1.UseVisualStyleBackColor = true;
            this.insert1.Click += new System.EventHandler(this.insert1_Click);
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(587, 414);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(85, 28);
            this.delete2.TabIndex = 16;
            this.delete2.Text = "delete2";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // insert2
            // 
            this.insert2.Location = new System.Drawing.Point(348, 414);
            this.insert2.Name = "insert2";
            this.insert2.Size = new System.Drawing.Size(77, 28);
            this.insert2.TabIndex = 17;
            this.insert2.Text = "insert2";
            this.insert2.UseVisualStyleBackColor = true;
            this.insert2.Click += new System.EventHandler(this.insert2_Click);
            // 
            // move2
            // 
            this.move2.Location = new System.Drawing.Point(431, 414);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(72, 28);
            this.move2.TabIndex = 18;
            this.move2.Text = "move2";
            this.move2.UseVisualStyleBackColor = true;
            this.move2.Click += new System.EventHandler(this.move2_Click);
            // 
            // copy2
            // 
            this.copy2.Location = new System.Drawing.Point(509, 414);
            this.copy2.Name = "copy2";
            this.copy2.Size = new System.Drawing.Size(72, 28);
            this.copy2.TabIndex = 19;
            this.copy2.Text = "copy2";
            this.copy2.UseVisualStyleBackColor = true;
            this.copy2.Click += new System.EventHandler(this.copy2_Click);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(129, 516);
            this.search1.Margin = new System.Windows.Forms.Padding(2);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(81, 21);
            this.search1.TabIndex = 20;
            this.search1.Text = "search1";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(465, 517);
            this.search2.Margin = new System.Windows.Forms.Padding(2);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(81, 21);
            this.search2.TabIndex = 21;
            this.search2.Text = "search2";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // Compress1
            // 
            this.Compress1.Location = new System.Drawing.Point(3, 448);
            this.Compress1.Name = "Compress1";
            this.Compress1.Size = new System.Drawing.Size(77, 28);
            this.Compress1.TabIndex = 22;
            this.Compress1.Text = "Compress1";
            this.Compress1.UseVisualStyleBackColor = true;
            this.Compress1.Click += new System.EventHandler(this.Compress1_Click);
            // 
            // Compress2
            // 
            this.Compress2.Location = new System.Drawing.Point(348, 448);
            this.Compress2.Name = "Compress2";
            this.Compress2.Size = new System.Drawing.Size(77, 28);
            this.Compress2.TabIndex = 23;
            this.Compress2.Text = "Compress2";
            this.Compress2.UseVisualStyleBackColor = true;
            this.Compress2.Click += new System.EventHandler(this.Compress2_Click);
            // 
            // forward1
            // 
            this.forward1.Location = new System.Drawing.Point(216, 27);
            this.forward1.Name = "forward1";
            this.forward1.Size = new System.Drawing.Size(81, 23);
            this.forward1.TabIndex = 24;
            this.forward1.Text = "вперед";
            this.forward1.UseVisualStyleBackColor = true;
            this.forward1.Click += new System.EventHandler(this.forward1_Click);
            // 
            // forward2
            // 
            this.forward2.Location = new System.Drawing.Point(552, 24);
            this.forward2.Name = "forward2";
            this.forward2.Size = new System.Drawing.Size(81, 23);
            this.forward2.TabIndex = 25;
            this.forward2.Text = "вперед";
            this.forward2.UseVisualStyleBackColor = true;
            this.forward2.Click += new System.EventHandler(this.forward2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 646);
            this.Controls.Add(this.forward2);
            this.Controls.Add(this.forward1);
            this.Controls.Add(this.Compress2);
            this.Controls.Add(this.Compress1);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.copy2);
            this.Controls.Add(this.move2);
            this.Controls.Add(this.insert2);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.insert1);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.way2);
            this.Controls.Add(this.way1);
            this.Controls.Add(this.Poisk2);
            this.Controls.Add(this.Drivers2);
            this.Controls.Add(this.Poisk1);
            this.Controls.Add(this.Drivers1);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.copy1);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.Button copy1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button move1;
        private System.Windows.Forms.ComboBox Drivers1;
        private System.Windows.Forms.TextBox Poisk1;
        private System.Windows.Forms.TextBox Poisk2;
        private System.Windows.Forms.ComboBox Drivers2;
        private System.Windows.Forms.TextBox way1;
        private System.Windows.Forms.TextBox way2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Button insert1;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button insert2;
        private System.Windows.Forms.Button move2;
        private System.Windows.Forms.Button copy2;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Button Compress1;
        private System.Windows.Forms.Button Compress2;
        private System.Windows.Forms.Button forward1;
        private System.Windows.Forms.Button forward2;
    }
}

