using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLIST
{
    public partial class MainForm : Form
    {
        public static List<string> Tasks = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Please enter a task name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string taskName = txtTaskName.Text;
            string deadline = dateTimePickerDeadline.Value.ToString("dd.MM.yyyy");

            Tasks.Add($"{taskName} - {deadline}");

            txtTaskName.Clear();
            dateTimePickerDeadline.Value = DateTime.Now;

            MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenTaskForm_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.Tasks = Tasks;
            taskForm.Show();
            this.Hide();
        }
    }
}
