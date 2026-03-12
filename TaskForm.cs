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
    public partial class TaskForm : Form
    {
        public List<string> Tasks { get; set; } = new List<string>();
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            RefreshTaskList();
        }
        private void RefreshTaskList()
        {
            lstTasks.Items.Clear();
            foreach (var task in Tasks)
            {
                lstTasks.Items.Add(task);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Choose a task to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = lstTasks.SelectedIndex;
            string selectedTask = Tasks[selectedIndex];
            string[] parts = selectedTask.Split(new string[] { " - " }, StringSplitOptions.None);
            string taskText = parts[0];
            string taskDeadline = parts.Length > 1 ? parts[1] : "";

            EditTaskForm editTaskForm = new EditTaskForm(taskText, taskDeadline);

            if (editTaskForm.ShowDialog() == DialogResult.OK)
            {
                Tasks[selectedIndex] = $"{editTaskForm.EditedTask} - {editTaskForm.EditedDeadline}";
                RefreshTaskList();
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = lstTasks.SelectedIndex;
            Tasks.RemoveAt(selectedIndex);
            RefreshTaskList();
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = lstTasks.SelectedIndex;
            string currentTask = Tasks[selectedIndex];

            if (currentTask.EndsWith("(Completed)"))
            {
                Tasks[selectedIndex] = currentTask.Replace(" (Completed)", "");
            }
            else
            {
                Tasks[selectedIndex] = currentTask + " (Completed)";
            }

            RefreshTaskList();
        }

        private bool showingCompleted = false;
        private void btnShowCompleted_Click(object sender, EventArgs e)
        {
            if (showingCompleted)
            {
                RefreshTaskList();
                btnShowCompleted.Text = "Show Completed"; 
                showingCompleted = false;
            }
            else
            {
                var completedTasks = Tasks.Where(task => task.EndsWith("(Completed)")).ToList();
                lstTasks.Items.Clear();
                foreach (var task in completedTasks)
                {
                    lstTasks.Items.Add(task);
                }

                btnShowCompleted.Text = "Show All";
                showingCompleted = true;
            }
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
