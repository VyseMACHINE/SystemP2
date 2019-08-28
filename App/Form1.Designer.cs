namespace T9App
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
            this.writingTB = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnUseWord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writingTB
            // 
            this.writingTB.Location = new System.Drawing.Point(12, 12);
            this.writingTB.Multiline = true;
            this.writingTB.Name = "writingTB";
            this.writingTB.Size = new System.Drawing.Size(149, 76);
            this.writingTB.TabIndex = 0;
            this.writingTB.TextChanged += new System.EventHandler(this.writingTB_TextChanged);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 162);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(149, 20);
            this.log.TabIndex = 1;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(12, 103);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(149, 23);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Добавить в словарь";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnUseWord
            // 
            this.btnUseWord.Location = new System.Drawing.Point(12, 189);
            this.btnUseWord.Name = "btnUseWord";
            this.btnUseWord.Size = new System.Drawing.Size(149, 23);
            this.btnUseWord.TabIndex = 3;
            this.btnUseWord.Text = "Использовать слово";
            this.btnUseWord.UseVisualStyleBackColor = true;
            this.btnUseWord.Click += new System.EventHandler(this.btnUseWord_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 248);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUseWord);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.log);
            this.Controls.Add(this.writingTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox writingTB;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnUseWord;
        private System.Windows.Forms.Button btnClose;
    }
}

