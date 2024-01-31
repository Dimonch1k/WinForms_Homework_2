using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2_WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            add_task_btn.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove_task_btn.Enabled = true;

            completed_task_btn.Enabled = true;  
        }



        // Add task if the user input in textBox something
        private void Add_Task_Button(object sender, EventArgs e)
        {
            ListBox1.Items.Add($"{ListBox1.Items.Count + 1}. {input_task_textBox.Text} ({input_desc_textBox.Text})");
            input_task_textBox.Clear();
            input_desc_textBox.Clear();
        }

        // Remove task by selected in listBox
        private void Remove_Task_Button(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);

            if (ListBox1.SelectedItem == null)
            {
                remove_task_btn.Enabled = false;
            }
        }


        // Set the task's text as "Task completed"
        private void Complete_Task_Button(object sender, EventArgs e)
        {
            int index = ListBox1.SelectedIndex;
            ListBox1.Items.RemoveAt(index);
            ListBox1.Items.Insert(index, "Task completed");
            
            if (ListBox1.SelectedItem == null)
            {
                completed_task_btn.Enabled = false;
                remove_task_btn.Enabled = false;
            }
        }



        // Controlling if the textBoxes are filled and if true -> button enabled

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (input_task_textBox.Text.Length > 0 && input_desc_textBox.Text.Length > 0)
            {
                fill_fields_label.Visible = false;
                add_task_btn.Show();
                return;
            }
            fill_fields_label.Visible = true;
            add_task_btn.Hide();
        }




        // Labels

        private void Tasks_Label_Click(object sender, EventArgs e)
        {
            tasks_label.Visible = true;
        }
        private void Input_Task_Label_Click(object sender, EventArgs e)
        {
            input_task_label.Visible = true;
        }
        private void Input_Desc_Label_Click(object sender, EventArgs e)
        {
            input_desc_label.Visible = true;
        }
        private void Fill_fields_label_Click(object sender, EventArgs e)
        {
            fill_fields_label.Visible = true;
        }
    }
}
