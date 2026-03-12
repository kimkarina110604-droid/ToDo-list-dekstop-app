namespace TODOLIST
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddTask = new Button();
            label1 = new Label();
            txtTaskName = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            label2 = new Label();
            btnOpenTaskForm = new Button();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(157, 211);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 76);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Set Task";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(157, 99);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(250, 27);
            txtTaskName.TabIndex = 2;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(157, 164);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(250, 27);
            dateTimePickerDeadline.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 141);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Set Deadline";
            // 
            // btnOpenTaskForm
            // 
            btnOpenTaskForm.Location = new Point(313, 211);
            btnOpenTaskForm.Name = "btnOpenTaskForm";
            btnOpenTaskForm.Size = new Size(94, 29);
            btnOpenTaskForm.TabIndex = 5;
            btnOpenTaskForm.Text = "Go to Tasks";
            btnOpenTaskForm.UseVisualStyleBackColor = true;
            btnOpenTaskForm.Click += btnOpenTaskForm_Click;
            // 
            // MainForn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 352);
            Controls.Add(btnOpenTaskForm);
            Controls.Add(label2);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(txtTaskName);
            Controls.Add(label1);
            Controls.Add(btnAddTask);
            Name = "MainForn";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTask;
        private Label label1;
        private TextBox txtTaskName;
        private DateTimePicker dateTimePickerDeadline;
        private Label label2;
        private Button btnOpenTaskForm;
    }
}
