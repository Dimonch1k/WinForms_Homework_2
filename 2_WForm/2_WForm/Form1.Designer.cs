namespace _2_WForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.add_task_btn = new System.Windows.Forms.Button();
            this.input_task_textBox = new System.Windows.Forms.TextBox();
            this.input_task_label = new System.Windows.Forms.Label();
            this.tasks_label = new System.Windows.Forms.Label();
            this.remove_task_btn = new System.Windows.Forms.Button();
            this.input_desc_label = new System.Windows.Forms.Label();
            this.input_desc_textBox = new System.Windows.Forms.TextBox();
            this.completed_task_btn = new System.Windows.Forms.Button();
            this.fill_fields_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.Color.Bisque;
            this.ListBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 20;
            this.ListBox1.Location = new System.Drawing.Point(12, 55);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(332, 364);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // add_task_btn
            // 
            this.add_task_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.add_task_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_task_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_task_btn.Location = new System.Drawing.Point(509, 117);
            this.add_task_btn.Name = "add_task_btn";
            this.add_task_btn.Size = new System.Drawing.Size(248, 41);
            this.add_task_btn.TabIndex = 1;
            this.add_task_btn.Text = "Add task";
            this.add_task_btn.UseVisualStyleBackColor = false;
            this.add_task_btn.Click += new System.EventHandler(this.Add_Task_Button);
            // 
            // input_task_textBox
            // 
            this.input_task_textBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_task_textBox.Location = new System.Drawing.Point(510, 27);
            this.input_task_textBox.Name = "input_task_textBox";
            this.input_task_textBox.Size = new System.Drawing.Size(245, 27);
            this.input_task_textBox.TabIndex = 2;
            this.input_task_textBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // input_task_label
            // 
            this.input_task_label.AutoSize = true;
            this.input_task_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.input_task_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_task_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_task_label.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_task_label.Location = new System.Drawing.Point(375, 28);
            this.input_task_label.Name = "input_task_label";
            this.input_task_label.Size = new System.Drawing.Size(106, 25);
            this.input_task_label.TabIndex = 3;
            this.input_task_label.Text = "Input task";
            this.input_task_label.Click += new System.EventHandler(this.Input_Task_Label_Click);
            // 
            // tasks_label
            // 
            this.tasks_label.AutoSize = true;
            this.tasks_label.BackColor = System.Drawing.Color.Tomato;
            this.tasks_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasks_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tasks_label.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_label.Location = new System.Drawing.Point(142, 27);
            this.tasks_label.Name = "tasks_label";
            this.tasks_label.Size = new System.Drawing.Size(67, 25);
            this.tasks_label.TabIndex = 4;
            this.tasks_label.Text = "Tasks";
            this.tasks_label.Click += new System.EventHandler(this.Tasks_Label_Click);
            // 
            // remove_task_btn
            // 
            this.remove_task_btn.BackColor = System.Drawing.Color.LightCoral;
            this.remove_task_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_task_btn.Enabled = false;
            this.remove_task_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove_task_btn.Location = new System.Drawing.Point(359, 261);
            this.remove_task_btn.Name = "remove_task_btn";
            this.remove_task_btn.Size = new System.Drawing.Size(182, 36);
            this.remove_task_btn.TabIndex = 7;
            this.remove_task_btn.Text = "Remove task";
            this.remove_task_btn.UseVisualStyleBackColor = false;
            this.remove_task_btn.Click += new System.EventHandler(this.Remove_Task_Button);
            // 
            // input_desc_label
            // 
            this.input_desc_label.AutoSize = true;
            this.input_desc_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.input_desc_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_desc_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_desc_label.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_desc_label.Location = new System.Drawing.Point(375, 74);
            this.input_desc_label.Name = "input_desc_label";
            this.input_desc_label.Size = new System.Drawing.Size(113, 25);
            this.input_desc_label.TabIndex = 8;
            this.input_desc_label.Text = "Input desc";
            this.input_desc_label.Click += new System.EventHandler(this.Input_Desc_Label_Click);
            // 
            // input_desc_textBox
            // 
            this.input_desc_textBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_desc_textBox.Location = new System.Drawing.Point(509, 74);
            this.input_desc_textBox.Name = "input_desc_textBox";
            this.input_desc_textBox.Size = new System.Drawing.Size(245, 27);
            this.input_desc_textBox.TabIndex = 9;
            this.input_desc_textBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // completed_task_btn
            // 
            this.completed_task_btn.BackColor = System.Drawing.Color.LightGreen;
            this.completed_task_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completed_task_btn.Enabled = false;
            this.completed_task_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completed_task_btn.Location = new System.Drawing.Point(359, 315);
            this.completed_task_btn.Name = "completed_task_btn";
            this.completed_task_btn.Size = new System.Drawing.Size(182, 36);
            this.completed_task_btn.TabIndex = 10;
            this.completed_task_btn.Text = "Task completed";
            this.completed_task_btn.UseVisualStyleBackColor = false;
            this.completed_task_btn.Click += new System.EventHandler(this.Complete_Task_Button);
            // 
            // fill_fields_label
            // 
            this.fill_fields_label.AutoSize = true;
            this.fill_fields_label.BackColor = System.Drawing.Color.OrangeRed;
            this.fill_fields_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fill_fields_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fill_fields_label.Font = new System.Drawing.Font("Century Gothic", 23F);
            this.fill_fields_label.Location = new System.Drawing.Point(509, 117);
            this.fill_fields_label.Name = "fill_fields_label";
            this.fill_fields_label.Size = new System.Drawing.Size(248, 39);
            this.fill_fields_label.TabIndex = 12;
            this.fill_fields_label.Text = "Fill fields above";
            this.fill_fields_label.Click += new System.EventHandler(this.Fill_fields_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.completed_task_btn);
            this.Controls.Add(this.input_desc_textBox);
            this.Controls.Add(this.input_desc_label);
            this.Controls.Add(this.remove_task_btn);
            this.Controls.Add(this.tasks_label);
            this.Controls.Add(this.input_task_label);
            this.Controls.Add(this.input_task_textBox);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.add_task_btn);
            this.Controls.Add(this.fill_fields_label);
            this.Name = "Form1";
            this.Text = "d";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button add_task_btn;
        private System.Windows.Forms.TextBox input_task_textBox;
        private System.Windows.Forms.Label input_task_label;
        private System.Windows.Forms.Label tasks_label;
        private System.Windows.Forms.Button remove_task_btn;
        private System.Windows.Forms.Label input_desc_label;
        private System.Windows.Forms.TextBox input_desc_textBox;
        private System.Windows.Forms.Button completed_task_btn;
        private System.Windows.Forms.Label fill_fields_label;
    }
}

