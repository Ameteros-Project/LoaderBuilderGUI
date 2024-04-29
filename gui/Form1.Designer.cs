namespace LoaderBuilderGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            checkBox4 = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 388);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Суицайд Мод";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(118, 388);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Скрыть файл";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(223, 388);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(113, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Запустить файл";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(170, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(92, 196);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(244, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Скомпилировать (Требуется PyInstaller)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "plz.donate.me/reasons.txt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 120);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 6;
            label1.Text = "Ссылка на скачивание (Прямая)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 52);
            label2.Name = "label2";
            label2.Size = new Size(252, 15);
            label2.TabIndex = 7;
            label2.Text = "Имя файла после скачивания (ex. Ruble.exe)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "VzlomCasino.exe";
            // 
            // button2
            // 
            button2.Location = new Point(155, 221);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 10;
            button2.Text = "Информация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(98, -1);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(238, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.donationalerts.com/r/ametero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 419);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(checkBox4);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Loader Builder GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private CheckBox checkBox4;
        private TextBox textBox1;
        public Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}
