namespace WindowsFormsApp19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeButton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userTextLable = new System.Windows.Forms.Label();
            this.readTextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.Black;
            this.closeButton1.ForeColor = System.Drawing.Color.White;
            this.closeButton1.Location = new System.Drawing.Point(626, 406);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(149, 32);
            this.closeButton1.TabIndex = 0;
            this.closeButton1.Text = "close";
            this.closeButton1.UseVisualStyleBackColor = false;
            this.closeButton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 320);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Ваш Текст";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // userTextLable
            // 
            this.userTextLable.AutoSize = true;
            this.userTextLable.Location = new System.Drawing.Point(321, 9);
            this.userTextLable.Name = "userTextLable";
            this.userTextLable.Size = new System.Drawing.Size(91, 13);
            this.userTextLable.TabIndex = 2;
            this.userTextLable.Text = "ваш коментарий";
            this.userTextLable.Click += new System.EventHandler(this.userTextLable_Click);
            // 
            // readTextButton
            // 
            this.readTextButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.readTextButton.Location = new System.Drawing.Point(324, 368);
            this.readTextButton.Name = "readTextButton";
            this.readTextButton.Size = new System.Drawing.Size(124, 23);
            this.readTextButton.TabIndex = 3;
            this.readTextButton.Text = "Добавить ";
            this.readTextButton.UseVisualStyleBackColor = true;
            this.readTextButton.Click += new System.EventHandler(this.readTextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 323);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Показать ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.readTextButton);
            this.Controls.Add(this.userTextLable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.closeButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "програ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userTextLable;
        private System.Windows.Forms.Button readTextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

