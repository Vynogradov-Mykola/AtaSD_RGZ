namespace LR2
{
    partial class LR2
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
            this.ZADANIE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BPRINT = new System.Windows.Forms.Button();
            this.serch = new System.Windows.Forms.Button();
            this.zadanie_2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Hsearch = new System.Windows.Forms.Button();
            this.KRemove = new System.Windows.Forms.Button();
            this.RELH = new System.Windows.Forms.Button();
            this.aller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZADANIE
            // 
            this.ZADANIE.Location = new System.Drawing.Point(12, 86);
            this.ZADANIE.Name = "ZADANIE";
            this.ZADANIE.Size = new System.Drawing.Size(149, 23);
            this.ZADANIE.TabIndex = 0;
            this.ZADANIE.Text = "show_from_date";
            this.ZADANIE.UseVisualStyleBackColor = true;
            this.ZADANIE.Click += new System.EventHandler(this.ADD_B_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(439, 311);
            this.textBox1.TabIndex = 1;
            // 
            // BPRINT
            // 
            this.BPRINT.Location = new System.Drawing.Point(12, 115);
            this.BPRINT.Name = "BPRINT";
            this.BPRINT.Size = new System.Drawing.Size(149, 23);
            this.BPRINT.TabIndex = 2;
            this.BPRINT.Text = "PRINT";
            this.BPRINT.UseVisualStyleBackColor = true;
            this.BPRINT.Click += new System.EventHandler(this.BPRINT_Click);
            // 
            // serch
            // 
            this.serch.Location = new System.Drawing.Point(12, 144);
            this.serch.Name = "serch";
            this.serch.Size = new System.Drawing.Size(149, 23);
            this.serch.TabIndex = 3;
            this.serch.Text = "Search";
            this.serch.UseVisualStyleBackColor = true;
            this.serch.Click += new System.EventHandler(this.serch_Click);
            // 
            // zadanie_2
            // 
            this.zadanie_2.Location = new System.Drawing.Point(12, 174);
            this.zadanie_2.Name = "zadanie_2";
            this.zadanie_2.Size = new System.Drawing.Size(149, 23);
            this.zadanie_2.TabIndex = 4;
            this.zadanie_2.Text = "Show_month";
            this.zadanie_2.UseVisualStyleBackColor = true;
            this.zadanie_2.Click += new System.EventHandler(this.zadanie_2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show HashT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hsearch
            // 
            this.Hsearch.Location = new System.Drawing.Point(613, 124);
            this.Hsearch.Name = "Hsearch";
            this.Hsearch.Size = new System.Drawing.Size(175, 43);
            this.Hsearch.TabIndex = 6;
            this.Hsearch.Text = "Hash_Search";
            this.Hsearch.UseVisualStyleBackColor = true;
            this.Hsearch.Click += new System.EventHandler(this.Hsearch_Click);
            // 
            // KRemove
            // 
            this.KRemove.Location = new System.Drawing.Point(13, 204);
            this.KRemove.Name = "KRemove";
            this.KRemove.Size = new System.Drawing.Size(148, 23);
            this.KRemove.TabIndex = 7;
            this.KRemove.Text = "Remove Key";
            this.KRemove.UseVisualStyleBackColor = true;
            this.KRemove.Click += new System.EventHandler(this.KRemove_Click);
            // 
            // RELH
            // 
            this.RELH.Location = new System.Drawing.Point(613, 174);
            this.RELH.Name = "RELH";
            this.RELH.Size = new System.Drawing.Size(175, 38);
            this.RELH.TabIndex = 8;
            this.RELH.Text = "Remove_El_H";
            this.RELH.UseVisualStyleBackColor = true;
            this.RELH.Click += new System.EventHandler(this.RELH_Click);
            // 
            // aller
            // 
            this.aller.Location = new System.Drawing.Point(13, 234);
            this.aller.Name = "aller";
            this.aller.Size = new System.Drawing.Size(148, 23);
            this.aller.TabIndex = 9;
            this.aller.Text = "Show ALL";
            this.aller.UseVisualStyleBackColor = true;
            this.aller.Click += new System.EventHandler(this.aller_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aller);
            this.Controls.Add(this.RELH);
            this.Controls.Add(this.KRemove);
            this.Controls.Add(this.Hsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zadanie_2);
            this.Controls.Add(this.serch);
            this.Controls.Add(this.BPRINT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ZADANIE);
            this.Name = "Form1";
            this.Text = "LR2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZADANIE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BPRINT;
        private System.Windows.Forms.Button serch;
        private System.Windows.Forms.Button zadanie_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Hsearch;
        private System.Windows.Forms.Button KRemove;
        private System.Windows.Forms.Button RELH;
        private System.Windows.Forms.Button aller;
    }
}

