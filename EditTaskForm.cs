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
    public partial class EditTaskForm : Form
    {
        public string EditedTask => txtTaskName.Text;
        public string EditedDeadline => dateTimePickerDeadline.Value.ToString("dd.MM.yyyy");

        public EditTaskForm(string taskText, string taskDeadline)
        {
            InitializeComponent();
            txtTaskName.Text = taskText;

            if (DateTime.TryParse(taskDeadline, out DateTime deadline))
            {
                dateTimePickerDeadline.Value = deadline;
            }
            else
            {
                dateTimePickerDeadline.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Task cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
