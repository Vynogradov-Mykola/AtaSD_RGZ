namespace LR1
{
    partial class LR1
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
            this.FIND_BY_ID = new System.Windows.Forms.Button();
            this.SHOW_H_T = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SHOW_BACK = new System.Windows.Forms.Button();
            this.REMOVE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.INDEX = new System.Windows.Forms.Label();
            this.F_REM = new System.Windows.Forms.Button();
            this.L_REM = new System.Windows.Forms.Button();
            this.K_ADD = new System.Windows.Forms.Button();
            this.LOAD_BUTTON = new System.Windows.Forms.Button();
            this.SORT = new System.Windows.Forms.Button();
            this.KUCHA_SORT = new System.Windows.Forms.Button();
            this.ADD_FIRST = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.INSIDE = new System.Windows.Forms.Button();
            this.BUILDER = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIND_BY_ID
            // 
            this.FIND_BY_ID.Location = new System.Drawing.Point(13, 140);
            this.FIND_BY_ID.Name = "FIND_BY_ID";
            this.FIND_BY_ID.Size = new System.Drawing.Size(84, 56);
            this.FIND_BY_ID.TabIndex = 2;
            this.FIND_BY_ID.Text = "FIND BY ID";
            this.FIND_BY_ID.UseVisualStyleBackColor = true;
            this.FIND_BY_ID.Click += new System.EventHandler(this.button2_Click);
            // 
            // SHOW_H_T
            // 
            this.SHOW_H_T.Location = new System.Drawing.Point(103, 140);
            this.SHOW_H_T.Name = "SHOW_H_T";
            this.SHOW_H_T.Size = new System.Drawing.Size(86, 56);
            this.SHOW_H_T.TabIndex = 3;
            this.SHOW_H_T.Text = "SHOW";
            this.SHOW_H_T.UseVisualStyleBackColor = true;
            this.SHOW_H_T.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(779, 236);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // SHOW_BACK
            // 
            this.SHOW_BACK.Location = new System.Drawing.Point(103, 87);
            this.SHOW_BACK.Name = "SHOW_BACK";
            this.SHOW_BACK.Size = new System.Drawing.Size(86, 44);
            this.SHOW_BACK.TabIndex = 7;
            this.SHOW_BACK.Text = "SHOW BACK";
            this.SHOW_BACK.UseVisualStyleBackColor = true;
            this.SHOW_BACK.Click += new System.EventHandler(this.SHOW_BACK_Click);
            // 
            // REMOVE
            // 
            this.REMOVE.Location = new System.Drawing.Point(13, 87);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(84, 45);
            this.REMOVE.TabIndex = 8;
            this.REMOVE.Text = "REMOVE";
            this.REMOVE.UseVisualStyleBackColor = true;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 22);
            this.textBox1.TabIndex = 9;
            // 
            // INDEX
            // 
            this.INDEX.AutoSize = true;
            this.INDEX.Location = new System.Drawing.Point(330, 65);
            this.INDEX.Name = "INDEX";
            this.INDEX.Size = new System.Drawing.Size(49, 17);
            this.INDEX.TabIndex = 10;
            this.INDEX.Text = "INDEX";
            // 
            // F_REM
            // 
            this.F_REM.Location = new System.Drawing.Point(103, 38);
            this.F_REM.Name = "F_REM";
            this.F_REM.Size = new System.Drawing.Size(86, 44);
            this.F_REM.TabIndex = 11;
            this.F_REM.Text = "REMOVE FIRST";
            this.F_REM.UseVisualStyleBackColor = true;
            this.F_REM.Click += new System.EventHandler(this.F_REM_Click);
            // 
            // L_REM
            // 
            this.L_REM.Location = new System.Drawing.Point(13, 38);
            this.L_REM.Name = "L_REM";
            this.L_REM.Size = new System.Drawing.Size(84, 42);
            this.L_REM.TabIndex = 12;
            this.L_REM.Text = "REMOVE LAST";
            this.L_REM.UseVisualStyleBackColor = true;
            this.L_REM.Click += new System.EventHandler(this.L_REM_Click);
            // 
            // K_ADD
            // 
            this.K_ADD.Location = new System.Drawing.Point(633, 173);
            this.K_ADD.Name = "K_ADD";
            this.K_ADD.Size = new System.Drawing.Size(158, 23);
            this.K_ADD.TabIndex = 13;
            this.K_ADD.Text = "KUCHA SHOW";
            this.K_ADD.UseVisualStyleBackColor = true;
            this.K_ADD.Click += new System.EventHandler(this.K_ADD_Click);
            // 
            // LOAD_BUTTON
            // 
            this.LOAD_BUTTON.Location = new System.Drawing.Point(333, 38);
            this.LOAD_BUTTON.Name = "LOAD_BUTTON";
            this.LOAD_BUTTON.Size = new System.Drawing.Size(282, 26);
            this.LOAD_BUTTON.TabIndex = 14;
            this.LOAD_BUTTON.Text = "LOAD";
            this.LOAD_BUTTON.UseVisualStyleBackColor = true;
            this.LOAD_BUTTON.Click += new System.EventHandler(this.LOAD_BUTTON_Click);
            // 
            // SORT
            // 
            this.SORT.Location = new System.Drawing.Point(633, 38);
            this.SORT.Name = "SORT";
            this.SORT.Size = new System.Drawing.Size(155, 26);
            this.SORT.TabIndex = 15;
            this.SORT.Text = "P_SORT_DL";
            this.SORT.UseVisualStyleBackColor = true;
            this.SORT.Click += new System.EventHandler(this.SORT_Click);
            // 
            // KUCHA_SORT
            // 
            this.KUCHA_SORT.Location = new System.Drawing.Point(633, 67);
            this.KUCHA_SORT.Name = "KUCHA_SORT";
            this.KUCHA_SORT.Size = new System.Drawing.Size(155, 23);
            this.KUCHA_SORT.TabIndex = 16;
            this.KUCHA_SORT.Text = "P_SORT_KUCHA";
            this.KUCHA_SORT.UseVisualStyleBackColor = true;
            this.KUCHA_SORT.Click += new System.EventHandler(this.KUCHA_SORT_Click);
            // 
            // ADD_FIRST
            // 
            this.ADD_FIRST.Location = new System.Drawing.Point(195, 38);
            this.ADD_FIRST.Name = "ADD_FIRST";
            this.ADD_FIRST.Size = new System.Drawing.Size(129, 42);
            this.ADD_FIRST.TabIndex = 17;
            this.ADD_FIRST.Text = "ADD_FIRST";
            this.ADD_FIRST.UseVisualStyleBackColor = true;
            this.ADD_FIRST.Click += new System.EventHandler(this.ADD_FIRST_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(493, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(333, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(441, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(547, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(46, 22);
            this.textBox6.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pidrozdil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Direktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kolvo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Serednya_ZP";
            // 
            // INSIDE
            // 
            this.INSIDE.Location = new System.Drawing.Point(195, 85);
            this.INSIDE.Name = "INSIDE";
            this.INSIDE.Size = new System.Drawing.Size(129, 46);
            this.INSIDE.TabIndex = 28;
            this.INSIDE.Text = "ADD_INSIDE";
            this.INSIDE.UseVisualStyleBackColor = true;
            this.INSIDE.Click += new System.EventHandler(this.INSIDE_Click);
            // 
            // BUILDER
            // 
            this.BUILDER.Location = new System.Drawing.Point(195, 140);
            this.BUILDER.Name = "BUILDER";
            this.BUILDER.Size = new System.Drawing.Size(129, 56);
            this.BUILDER.TabIndex = 29;
            this.BUILDER.Text = "KUCHA BUILD FROM ARRAY";
            this.BUILDER.UseVisualStyleBackColor = true;
            this.BUILDER.Click += new System.EventHandler(this.BUILDER_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "KUCHA REMOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LR1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BUILDER);
            this.Controls.Add(this.INSIDE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ADD_FIRST);
            this.Controls.Add(this.KUCHA_SORT);
            this.Controls.Add(this.SORT);
            this.Controls.Add(this.LOAD_BUTTON);
            this.Controls.Add(this.K_ADD);
            this.Controls.Add(this.L_REM);
            this.Controls.Add(this.F_REM);
            this.Controls.Add(this.INDEX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.REMOVE);
            this.Controls.Add(this.SHOW_BACK);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SHOW_H_T);
            this.Controls.Add(this.FIND_BY_ID);
            this.Name = "LR1";
            this.Text = "LR1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FIND_BY_ID;
        private System.Windows.Forms.Button SHOW_H_T;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SHOW_BACK;
        private System.Windows.Forms.Button REMOVE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label INDEX;
        private System.Windows.Forms.Button F_REM;
        private System.Windows.Forms.Button L_REM;
        private System.Windows.Forms.Button K_ADD;
        private System.Windows.Forms.Button LOAD_BUTTON;
        private System.Windows.Forms.Button SORT;
        private System.Windows.Forms.Button KUCHA_SORT;
        private System.Windows.Forms.Button ADD_FIRST;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button INSIDE;
        private System.Windows.Forms.Button BUILDER;
        private System.Windows.Forms.Button button1;
    }
}

