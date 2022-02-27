namespace LR5
{
    partial class LR5
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
            this.in_1 = new System.Windows.Forms.TextBox();
            this.out_1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edge_1 = new System.Windows.Forms.TextBox();
            this.edge_2 = new System.Windows.Forms.TextBox();
            this.btn_add_edge = new System.Windows.Forms.Button();
            this.btn_DFS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Yes_Or = new System.Windows.Forms.RadioButton();
            this.No_or = new System.Windows.Forms.RadioButton();
            this.btn_BFS = new System.Windows.Forms.Button();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_edges = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // in_1
            // 
            this.in_1.Location = new System.Drawing.Point(1, 11);
            this.in_1.Name = "in_1";
            this.in_1.Size = new System.Drawing.Size(30, 22);
            this.in_1.TabIndex = 0;
            // 
            // out_1
            // 
            this.out_1.Location = new System.Drawing.Point(1, 73);
            this.out_1.Multiline = true;
            this.out_1.Name = "out_1";
            this.out_1.Size = new System.Drawing.Size(207, 358);
            this.out_1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edge_1
            // 
            this.edge_1.Location = new System.Drawing.Point(214, 73);
            this.edge_1.Name = "edge_1";
            this.edge_1.Size = new System.Drawing.Size(25, 22);
            this.edge_1.TabIndex = 4;
            // 
            // edge_2
            // 
            this.edge_2.Location = new System.Drawing.Point(264, 73);
            this.edge_2.Name = "edge_2";
            this.edge_2.Size = new System.Drawing.Size(25, 22);
            this.edge_2.TabIndex = 5;
            // 
            // btn_add_edge
            // 
            this.btn_add_edge.Location = new System.Drawing.Point(214, 11);
            this.btn_add_edge.Name = "btn_add_edge";
            this.btn_add_edge.Size = new System.Drawing.Size(75, 56);
            this.btn_add_edge.TabIndex = 6;
            this.btn_add_edge.Text = "Add edge";
            this.btn_add_edge.UseVisualStyleBackColor = true;
            this.btn_add_edge.Click += new System.EventHandler(this.btn_add_edge_Click);
            // 
            // btn_DFS
            // 
            this.btn_DFS.Location = new System.Drawing.Point(214, 101);
            this.btn_DFS.Name = "btn_DFS";
            this.btn_DFS.Size = new System.Drawing.Size(75, 23);
            this.btn_DFS.TabIndex = 7;
            this.btn_DFS.Text = "DFS";
            this.btn_DFS.UseVisualStyleBackColor = true;
            this.btn_DFS.Click += new System.EventHandler(this.btn_DFS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Yes_Or);
            this.groupBox1.Controls.Add(this.No_or);
            this.groupBox1.Location = new System.Drawing.Point(215, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Yes_Or
            // 
            this.Yes_Or.AutoSize = true;
            this.Yes_Or.Checked = true;
            this.Yes_Or.Location = new System.Drawing.Point(11, 48);
            this.Yes_Or.Name = "Yes_Or";
            this.Yes_Or.Size = new System.Drawing.Size(120, 21);
            this.Yes_Or.TabIndex = 1;
            this.Yes_Or.TabStop = true;
            this.Yes_Or.Text = "Орієнтований";
            this.Yes_Or.UseVisualStyleBackColor = true;
            // 
            // No_or
            // 
            this.No_or.AutoSize = true;
            this.No_or.Location = new System.Drawing.Point(11, 21);
            this.No_or.Name = "No_or";
            this.No_or.Size = new System.Drawing.Size(139, 21);
            this.No_or.TabIndex = 0;
            this.No_or.Text = "Не орієнтований";
            this.No_or.UseVisualStyleBackColor = true;
            // 
            // btn_BFS
            // 
            this.btn_BFS.Location = new System.Drawing.Point(215, 131);
            this.btn_BFS.Name = "btn_BFS";
            this.btn_BFS.Size = new System.Drawing.Size(75, 23);
            this.btn_BFS.TabIndex = 9;
            this.btn_BFS.Text = "BFS";
            this.btn_BFS.UseVisualStyleBackColor = true;
            this.btn_BFS.Click += new System.EventHandler(this.btn_BFS_Click);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(296, 100);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(75, 23);
            this.btn_path.TabIndex = 10;
            this.btn_path.Text = "Path";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_edges
            // 
            this.btn_edges.Location = new System.Drawing.Point(296, 11);
            this.btn_edges.Name = "btn_edges";
            this.btn_edges.Size = new System.Drawing.Size(75, 83);
            this.btn_edges.TabIndex = 11;
            this.btn_edges.Text = "Show Edges";
            this.btn_edges.UseVisualStyleBackColor = true;
            this.btn_edges.Click += new System.EventHandler(this.btn_edges_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check for cycle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Academic";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "<- Кількість вершин";
            // 
            // LR5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_edges);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.btn_BFS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DFS);
            this.Controls.Add(this.btn_add_edge);
            this.Controls.Add(this.edge_2);
            this.Controls.Add(this.edge_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_1);
            this.Controls.Add(this.in_1);
            this.Name = "LR5";
            this.Text = "LR5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox in_1;
        private System.Windows.Forms.TextBox out_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edge_1;
        private System.Windows.Forms.TextBox edge_2;
        private System.Windows.Forms.Button btn_add_edge;
        private System.Windows.Forms.Button btn_DFS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Yes_Or;
        private System.Windows.Forms.RadioButton No_or;
        private System.Windows.Forms.Button btn_BFS;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Button btn_edges;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

