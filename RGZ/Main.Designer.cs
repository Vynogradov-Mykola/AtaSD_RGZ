namespace RGZ
{
    partial class RGZ
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
            this.Lr1 = new System.Windows.Forms.Button();
            this.Lr2 = new System.Windows.Forms.Button();
            this.Lr3 = new System.Windows.Forms.Button();
            this.Lr4 = new System.Windows.Forms.Button();
            this.LR5 = new System.Windows.Forms.Button();
            this.LR6 = new System.Windows.Forms.Button();
            this.LR7 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Lr1
            // 
            this.Lr1.Location = new System.Drawing.Point(13, 13);
            this.Lr1.Name = "Lr1";
            this.Lr1.Size = new System.Drawing.Size(306, 40);
            this.Lr1.TabIndex = 0;
            this.Lr1.Text = "Пірамідальне сортування";
            this.Lr1.UseVisualStyleBackColor = true;
            this.Lr1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lr2
            // 
            this.Lr2.Location = new System.Drawing.Point(13, 59);
            this.Lr2.Name = "Lr2";
            this.Lr2.Size = new System.Drawing.Size(306, 40);
            this.Lr2.TabIndex = 1;
            this.Lr2.Text = "Структури даних";
            this.Lr2.UseVisualStyleBackColor = true;
            this.Lr2.Click += new System.EventHandler(this.Lr2_Click);
            // 
            // Lr3
            // 
            this.Lr3.Location = new System.Drawing.Point(13, 105);
            this.Lr3.Name = "Lr3";
            this.Lr3.Size = new System.Drawing.Size(306, 40);
            this.Lr3.TabIndex = 2;
            this.Lr3.Text = "Жадібні алгоритми";
            this.Lr3.UseVisualStyleBackColor = true;
            this.Lr3.Click += new System.EventHandler(this.Lr3_Click);
            // 
            // Lr4
            // 
            this.Lr4.Location = new System.Drawing.Point(13, 151);
            this.Lr4.Name = "Lr4";
            this.Lr4.Size = new System.Drawing.Size(306, 40);
            this.Lr4.TabIndex = 3;
            this.Lr4.Text = "Динамічне програмування";
            this.Lr4.UseVisualStyleBackColor = true;
            this.Lr4.Click += new System.EventHandler(this.Lr4_Click);
            // 
            // LR5
            // 
            this.LR5.Location = new System.Drawing.Point(13, 197);
            this.LR5.Name = "LR5";
            this.LR5.Size = new System.Drawing.Size(306, 40);
            this.LR5.TabIndex = 4;
            this.LR5.Text = "Алгоритми обходу графів";
            this.LR5.UseVisualStyleBackColor = true;
            this.LR5.Click += new System.EventHandler(this.LR5_Click);
            // 
            // LR6
            // 
            this.LR6.Location = new System.Drawing.Point(13, 243);
            this.LR6.Name = "LR6";
            this.LR6.Size = new System.Drawing.Size(306, 40);
            this.LR6.TabIndex = 5;
            this.LR6.Text = "Алгоритми пошуку найкоротших шляхів";
            this.LR6.UseVisualStyleBackColor = true;
            this.LR6.Click += new System.EventHandler(this.LR6_Click);
            // 
            // LR7
            // 
            this.LR7.Location = new System.Drawing.Point(13, 289);
            this.LR7.Name = "LR7";
            this.LR7.Size = new System.Drawing.Size(306, 40);
            this.LR7.TabIndex = 6;
            this.LR7.Text = "Моделювання транспортної мережі";
            this.LR7.UseVisualStyleBackColor = true;
            this.LR7.Click += new System.EventHandler(this.LR7_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(124, 332);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RGZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 359);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LR7);
            this.Controls.Add(this.LR6);
            this.Controls.Add(this.LR5);
            this.Controls.Add(this.Lr4);
            this.Controls.Add(this.Lr3);
            this.Controls.Add(this.Lr2);
            this.Controls.Add(this.Lr1);
            this.Name = "RGZ";
            this.Text = "RGZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lr1;
        private System.Windows.Forms.Button Lr2;
        private System.Windows.Forms.Button Lr3;
        private System.Windows.Forms.Button Lr4;
        private System.Windows.Forms.Button LR5;
        private System.Windows.Forms.Button LR6;
        private System.Windows.Forms.Button LR7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

