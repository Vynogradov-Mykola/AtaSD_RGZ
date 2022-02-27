namespace LR6
{
    partial class LR6
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
            this.DIJ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.f_e = new System.Windows.Forms.TextBox();
            this.s_e = new System.Windows.Forms.TextBox();
            this.value_e = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.g_create = new System.Windows.Forms.Button();
            this.vertex_count = new System.Windows.Forms.TextBox();
            this.Adder = new System.Windows.Forms.Button();
            this.F_USH = new System.Windows.Forms.Button();
            this.In_vertex = new System.Windows.Forms.TextBox();
            this.Ford = new System.Windows.Forms.Button();
            this.start_ford = new System.Windows.Forms.TextBox();
            this.First_quest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Ex2_1 = new System.Windows.Forms.TextBox();
            this.Ex2_2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Town = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DIJ
            // 
            this.DIJ.Location = new System.Drawing.Point(193, 13);
            this.DIJ.Name = "DIJ";
            this.DIJ.Size = new System.Drawing.Size(75, 23);
            this.DIJ.TabIndex = 0;
            this.DIJ.Text = "Dikstra";
            this.DIJ.UseVisualStyleBackColor = true;
            this.DIJ.Click += new System.EventHandler(this.DIJ_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 383);
            this.textBox1.TabIndex = 1;
            // 
            // f_e
            // 
            this.f_e.Location = new System.Drawing.Point(193, 42);
            this.f_e.Name = "f_e";
            this.f_e.Size = new System.Drawing.Size(22, 22);
            this.f_e.TabIndex = 2;
            // 
            // s_e
            // 
            this.s_e.Location = new System.Drawing.Point(193, 70);
            this.s_e.Name = "s_e";
            this.s_e.Size = new System.Drawing.Size(22, 22);
            this.s_e.TabIndex = 3;
            // 
            // value_e
            // 
            this.value_e.Location = new System.Drawing.Point(193, 98);
            this.value_e.Name = "value_e";
            this.value_e.Size = new System.Drawing.Size(22, 22);
            this.value_e.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "first vertex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "second vertex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "value of edge";
            // 
            // g_create
            // 
            this.g_create.Location = new System.Drawing.Point(317, 12);
            this.g_create.Name = "g_create";
            this.g_create.Size = new System.Drawing.Size(75, 23);
            this.g_create.TabIndex = 8;
            this.g_create.Text = "Create";
            this.g_create.UseVisualStyleBackColor = true;
            this.g_create.Click += new System.EventHandler(this.g_create_Click);
            // 
            // vertex_count
            // 
            this.vertex_count.Location = new System.Drawing.Point(399, 13);
            this.vertex_count.Name = "vertex_count";
            this.vertex_count.Size = new System.Drawing.Size(100, 22);
            this.vertex_count.TabIndex = 9;
            // 
            // Adder
            // 
            this.Adder.Location = new System.Drawing.Point(193, 127);
            this.Adder.Name = "Adder";
            this.Adder.Size = new System.Drawing.Size(75, 53);
            this.Adder.TabIndex = 10;
            this.Adder.Text = "Edge add";
            this.Adder.UseVisualStyleBackColor = true;
            this.Adder.Click += new System.EventHandler(this.Adder_Click);
            // 
            // F_USH
            // 
            this.F_USH.Location = new System.Drawing.Point(193, 187);
            this.F_USH.Name = "F_USH";
            this.F_USH.Size = new System.Drawing.Size(75, 23);
            this.F_USH.TabIndex = 11;
            this.F_USH.Text = "Floid";
            this.F_USH.UseVisualStyleBackColor = true;
            this.F_USH.Click += new System.EventHandler(this.F_USH_Click);
            // 
            // In_vertex
            // 
            this.In_vertex.Location = new System.Drawing.Point(274, 12);
            this.In_vertex.Name = "In_vertex";
            this.In_vertex.Size = new System.Drawing.Size(20, 22);
            this.In_vertex.TabIndex = 12;
            // 
            // Ford
            // 
            this.Ford.Location = new System.Drawing.Point(194, 217);
            this.Ford.Name = "Ford";
            this.Ford.Size = new System.Drawing.Size(75, 23);
            this.Ford.TabIndex = 13;
            this.Ford.Text = "Ford";
            this.Ford.UseVisualStyleBackColor = true;
            this.Ford.Click += new System.EventHandler(this.Ford_Click);
            // 
            // start_ford
            // 
            this.start_ford.Location = new System.Drawing.Point(273, 217);
            this.start_ford.Name = "start_ford";
            this.start_ford.Size = new System.Drawing.Size(20, 22);
            this.start_ford.TabIndex = 14;
            // 
            // First_quest
            // 
            this.First_quest.Location = new System.Drawing.Point(194, 247);
            this.First_quest.Name = "First_quest";
            this.First_quest.Size = new System.Drawing.Size(75, 23);
            this.First_quest.TabIndex = 15;
            this.First_quest.Text = "Ex_1";
            this.First_quest.UseVisualStyleBackColor = true;
            this.First_quest.Click += new System.EventHandler(this.First_quest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ex 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ex2_1
            // 
            this.Ex2_1.Location = new System.Drawing.Point(273, 307);
            this.Ex2_1.Name = "Ex2_1";
            this.Ex2_1.Size = new System.Drawing.Size(19, 22);
            this.Ex2_1.TabIndex = 17;
            // 
            // Ex2_2
            // 
            this.Ex2_2.Location = new System.Drawing.Point(298, 307);
            this.Ex2_2.Name = "Ex2_2";
            this.Ex2_2.Size = new System.Drawing.Size(19, 22);
            this.Ex2_2.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(317, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "With Towns";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Town
            // 
            this.Town.Location = new System.Drawing.Point(274, 127);
            this.Town.Multiline = true;
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(225, 53);
            this.Town.TabIndex = 20;
            this.Town.Text = "Town here";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Ex_2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "From Kyiv to Stokgolm";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "All towns";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LR6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 402);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Town);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Ex2_2);
            this.Controls.Add(this.Ex2_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.First_quest);
            this.Controls.Add(this.start_ford);
            this.Controls.Add(this.Ford);
            this.Controls.Add(this.In_vertex);
            this.Controls.Add(this.F_USH);
            this.Controls.Add(this.Adder);
            this.Controls.Add(this.vertex_count);
            this.Controls.Add(this.g_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value_e);
            this.Controls.Add(this.s_e);
            this.Controls.Add(this.f_e);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DIJ);
            this.Name = "LR6";
            this.Text = "LR6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DIJ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox f_e;
        private System.Windows.Forms.TextBox s_e;
        private System.Windows.Forms.TextBox value_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button g_create;
        private System.Windows.Forms.TextBox vertex_count;
        private System.Windows.Forms.Button Adder;
        private System.Windows.Forms.Button F_USH;
        private System.Windows.Forms.TextBox In_vertex;
        private System.Windows.Forms.Button Ford;
        private System.Windows.Forms.TextBox start_ford;
        private System.Windows.Forms.Button First_quest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Ex2_1;
        private System.Windows.Forms.TextBox Ex2_2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Town;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

