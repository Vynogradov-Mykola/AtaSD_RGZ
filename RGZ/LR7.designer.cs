namespace LR7
{
    partial class LR7
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
            this.out_text = new System.Windows.Forms.TextBox();
            this.Graph_create = new System.Windows.Forms.Button();
            this.count_v = new System.Windows.Forms.TextBox();
            this.Edge_add = new System.Windows.Forms.Button();
            this.first_vertex = new System.Windows.Forms.TextBox();
            this.second_vertex = new System.Windows.Forms.TextBox();
            this.value_edge = new System.Windows.Forms.TextBox();
            this.showMatrix = new System.Windows.Forms.Button();
            this.Ford_btn = new System.Windows.Forms.Button();
            this.Ford_2 = new System.Windows.Forms.TextBox();
            this.Ford_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Graph_min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // out_text
            // 
            this.out_text.Location = new System.Drawing.Point(12, 45);
            this.out_text.Multiline = true;
            this.out_text.Name = "out_text";
            this.out_text.Size = new System.Drawing.Size(154, 212);
            this.out_text.TabIndex = 0;
            // 
            // Graph_create
            // 
            this.Graph_create.Location = new System.Drawing.Point(13, 16);
            this.Graph_create.Name = "Graph_create";
            this.Graph_create.Size = new System.Drawing.Size(75, 23);
            this.Graph_create.TabIndex = 1;
            this.Graph_create.Text = "Create";
            this.Graph_create.UseVisualStyleBackColor = true;
            this.Graph_create.Click += new System.EventHandler(this.Graph_create_Click);
            // 
            // count_v
            // 
            this.count_v.Location = new System.Drawing.Point(95, 16);
            this.count_v.Name = "count_v";
            this.count_v.Size = new System.Drawing.Size(71, 22);
            this.count_v.TabIndex = 2;
            // 
            // Edge_add
            // 
            this.Edge_add.Location = new System.Drawing.Point(172, 16);
            this.Edge_add.Name = "Edge_add";
            this.Edge_add.Size = new System.Drawing.Size(75, 42);
            this.Edge_add.TabIndex = 3;
            this.Edge_add.Text = "Add edge";
            this.Edge_add.UseVisualStyleBackColor = true;
            this.Edge_add.Click += new System.EventHandler(this.Edge_add_Click);
            // 
            // first_vertex
            // 
            this.first_vertex.Location = new System.Drawing.Point(172, 65);
            this.first_vertex.Name = "first_vertex";
            this.first_vertex.Size = new System.Drawing.Size(19, 22);
            this.first_vertex.TabIndex = 4;
            // 
            // second_vertex
            // 
            this.second_vertex.Location = new System.Drawing.Point(228, 65);
            this.second_vertex.Name = "second_vertex";
            this.second_vertex.Size = new System.Drawing.Size(19, 22);
            this.second_vertex.TabIndex = 5;
            // 
            // value_edge
            // 
            this.value_edge.Location = new System.Drawing.Point(172, 93);
            this.value_edge.Name = "value_edge";
            this.value_edge.Size = new System.Drawing.Size(75, 22);
            this.value_edge.TabIndex = 6;
            this.value_edge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showMatrix
            // 
            this.showMatrix.Location = new System.Drawing.Point(172, 122);
            this.showMatrix.Name = "showMatrix";
            this.showMatrix.Size = new System.Drawing.Size(75, 23);
            this.showMatrix.TabIndex = 7;
            this.showMatrix.Text = "Matrix";
            this.showMatrix.UseVisualStyleBackColor = true;
            this.showMatrix.Click += new System.EventHandler(this.showMatrix_Click);
            // 
            // Ford_btn
            // 
            this.Ford_btn.Location = new System.Drawing.Point(173, 152);
            this.Ford_btn.Name = "Ford_btn";
            this.Ford_btn.Size = new System.Drawing.Size(75, 23);
            this.Ford_btn.TabIndex = 8;
            this.Ford_btn.Text = "Ford";
            this.Ford_btn.UseVisualStyleBackColor = true;
            this.Ford_btn.Click += new System.EventHandler(this.Ford_btn_Click);
            // 
            // Ford_2
            // 
            this.Ford_2.Location = new System.Drawing.Point(228, 181);
            this.Ford_2.Name = "Ford_2";
            this.Ford_2.Size = new System.Drawing.Size(19, 22);
            this.Ford_2.TabIndex = 10;
            // 
            // Ford_1
            // 
            this.Ford_1.Location = new System.Drawing.Point(172, 181);
            this.Ford_1.Name = "Ford_1";
            this.Ford_1.Size = new System.Drawing.Size(19, 22);
            this.Ford_1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Computers";
            // 
            // Graph_min
            // 
            this.Graph_min.Location = new System.Drawing.Point(172, 232);
            this.Graph_min.Name = "Graph_min";
            this.Graph_min.Size = new System.Drawing.Size(75, 25);
            this.Graph_min.TabIndex = 12;
            this.Graph_min.Text = "Minimal";
            this.Graph_min.UseVisualStyleBackColor = true;
            this.Graph_min.Click += new System.EventHandler(this.Graph_min_Click);
            // 
            // LR7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 267);
            this.Controls.Add(this.Graph_min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ford_2);
            this.Controls.Add(this.Ford_1);
            this.Controls.Add(this.Ford_btn);
            this.Controls.Add(this.showMatrix);
            this.Controls.Add(this.value_edge);
            this.Controls.Add(this.second_vertex);
            this.Controls.Add(this.first_vertex);
            this.Controls.Add(this.Edge_add);
            this.Controls.Add(this.count_v);
            this.Controls.Add(this.Graph_create);
            this.Controls.Add(this.out_text);
            this.Name = "LR7";
            this.Text = "LR7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox out_text;
        private System.Windows.Forms.Button Graph_create;
        private System.Windows.Forms.TextBox count_v;
        private System.Windows.Forms.Button Edge_add;
        private System.Windows.Forms.TextBox first_vertex;
        private System.Windows.Forms.TextBox second_vertex;
        private System.Windows.Forms.TextBox value_edge;
        private System.Windows.Forms.Button showMatrix;
        private System.Windows.Forms.Button Ford_btn;
        private System.Windows.Forms.TextBox Ford_2;
        private System.Windows.Forms.TextBox Ford_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Graph_min;
    }
}

