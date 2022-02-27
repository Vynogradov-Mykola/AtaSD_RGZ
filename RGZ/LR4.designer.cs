namespace LR4
{
    partial class LR4
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
            this.pol_make = new System.Windows.Forms.Button();
            this.in_text = new System.Windows.Forms.TextBox();
            this.out_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.outtext = new System.Windows.Forms.TextBox();
            this.Show_b = new System.Windows.Forms.Button();
            this.Show_best_b = new System.Windows.Forms.Button();
            this.end_ = new System.Windows.Forms.TextBox();
            this.start_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Rem_but = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.indexer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pol_make
            // 
            this.pol_make.Location = new System.Drawing.Point(12, 12);
            this.pol_make.Name = "pol_make";
            this.pol_make.Size = new System.Drawing.Size(84, 50);
            this.pol_make.TabIndex = 0;
            this.pol_make.Text = "Check";
            this.pol_make.UseVisualStyleBackColor = true;
            this.pol_make.Click += new System.EventHandler(this.pol_make_Click);
            // 
            // in_text
            // 
            this.in_text.Location = new System.Drawing.Point(103, 12);
            this.in_text.Name = "in_text";
            this.in_text.Size = new System.Drawing.Size(212, 22);
            this.in_text.TabIndex = 1;
            // 
            // out_text
            // 
            this.out_text.Location = new System.Drawing.Point(103, 40);
            this.out_text.Name = "out_text";
            this.out_text.Size = new System.Drawing.Size(212, 22);
            this.out_text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(12, 116);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(84, 51);
            this.Add_button.TabIndex = 5;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // outtext
            // 
            this.outtext.Location = new System.Drawing.Point(102, 174);
            this.outtext.Multiline = true;
            this.outtext.Name = "outtext";
            this.outtext.Size = new System.Drawing.Size(213, 105);
            this.outtext.TabIndex = 6;
            // 
            // Show_b
            // 
            this.Show_b.Location = new System.Drawing.Point(12, 174);
            this.Show_b.Name = "Show_b";
            this.Show_b.Size = new System.Drawing.Size(84, 47);
            this.Show_b.TabIndex = 7;
            this.Show_b.Text = "Show";
            this.Show_b.UseVisualStyleBackColor = true;
            this.Show_b.Click += new System.EventHandler(this.Show_b_Click);
            // 
            // Show_best_b
            // 
            this.Show_best_b.Location = new System.Drawing.Point(12, 228);
            this.Show_best_b.Name = "Show_best_b";
            this.Show_best_b.Size = new System.Drawing.Size(84, 51);
            this.Show_best_b.TabIndex = 8;
            this.Show_best_b.Text = "Show Best";
            this.Show_best_b.UseVisualStyleBackColor = true;
            this.Show_best_b.Click += new System.EventHandler(this.Show_best_b_Click);
            // 
            // end_
            // 
            this.end_.Location = new System.Drawing.Point(103, 144);
            this.end_.Name = "end_";
            this.end_.Size = new System.Drawing.Size(212, 22);
            this.end_.TabIndex = 9;
            // 
            // start_
            // 
            this.start_.Location = new System.Drawing.Point(102, 116);
            this.start_.Name = "start_";
            this.start_.Size = new System.Drawing.Size(213, 22);
            this.start_.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Begin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "End";
            // 
            // pricer
            // 
            this.pricer.Location = new System.Drawing.Point(102, 85);
            this.pricer.Name = "pricer";
            this.pricer.Size = new System.Drawing.Size(213, 22);
            this.pricer.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price per hour";
            // 
            // Rem_but
            // 
            this.Rem_but.Location = new System.Drawing.Point(322, 240);
            this.Rem_but.Name = "Rem_but";
            this.Rem_but.Size = new System.Drawing.Size(101, 38);
            this.Rem_but.TabIndex = 16;
            this.Rem_but.Text = "Remove";
            this.Rem_but.UseVisualStyleBackColor = true;
            this.Rem_but.Click += new System.EventHandler(this.Rem_but_Click);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(322, 174);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(101, 32);
            this.Replace.TabIndex = 17;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // indexer
            // 
            this.indexer.Location = new System.Drawing.Point(322, 212);
            this.indexer.Name = "indexer";
            this.indexer.Size = new System.Drawing.Size(101, 22);
            this.indexer.TabIndex = 18;
            // 
            // LR4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 285);
            this.Controls.Add(this.indexer);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Rem_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pricer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_);
            this.Controls.Add(this.end_);
            this.Controls.Add(this.Show_best_b);
            this.Controls.Add(this.Show_b);
            this.Controls.Add(this.outtext);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.out_text);
            this.Controls.Add(this.in_text);
            this.Controls.Add(this.pol_make);
            this.Name = "LR4";
            this.Text = "LR4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pol_make;
        private System.Windows.Forms.TextBox in_text;
        private System.Windows.Forms.TextBox out_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox outtext;
        private System.Windows.Forms.Button Show_b;
        private System.Windows.Forms.Button Show_best_b;
        private System.Windows.Forms.TextBox end_;
        private System.Windows.Forms.TextBox start_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Rem_but;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.TextBox indexer;
    }
}

