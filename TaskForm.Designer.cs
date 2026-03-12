namespace TODOLIST
{
    partial class TaskForm
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
            lstTasks = new ListBox();
            btnEditTask = new Button();
            lblStatus = new Label();
            btnDeleteTask = new Button();
            btnMarkComplete = new Button();
            btnBackToMainForm = new Button();
            btnShowCompleted = new Button();
            SuspendLayout();
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(33, 57);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(679, 264);
            lstTasks.TabIndex = 0;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(33, 343);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(94, 29);
            btnEditTask.TabIndex = 1;
            btnEditTask.Text = "Edit task";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(33, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 2;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(193, 343);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(94, 29);
            btnDeleteTask.TabIndex = 3;
            btnDeleteTask.Text = "Delete task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.Location = new Point(353, 343);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(165, 29);
            btnMarkComplete.TabIndex = 4;
            btnMarkComplete.Text = "Mark as completed";
            btnMarkComplete.UseVisualStyleBackColor = true;
            btnMarkComplete.Click += btnMarkComplete_Click;
            // 
            // btnBackToMainForm
            // 
            btnBackToMainForm.Location = new Point(584, 440);
            btnBackToMainForm.Name = "btnBackToMainForm";
            btnBackToMainForm.Size = new Size(128, 29);
            btnBackToMainForm.TabIndex = 5;
            btnBackToMainForm.Text = "Add a new task";
            btnBackToMainForm.UseVisualStyleBackColor = true;
            btnBackToMainForm.Click += btnBackToMainForm_Click;
            // 
            // btnShowCompleted
            // 
            btnShowCompleted.Location = new Point(561, 343);
            btnShowCompleted.Name = "btnShowCompleted";
            btnShowCompleted.Size = new Size(151, 29);
            btnShowCompleted.TabIndex = 6;
            btnShowCompleted.Text = "Show completed";
            btnShowCompleted.UseVisualStyleBackColor = true;
            btnShowCompleted.Click += btnShowCompleted_Click;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 481);
            Controls.Add(btnShowCompleted);
            Controls.Add(btnBackToMainForm);
            Controls.Add(btnMarkComplete);
            Controls.Add(btnDeleteTask);
            Controls.Add(lblStatus);
            Controls.Add(btnEditTask);
            Controls.Add(lstTasks);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTasks;
        private Button btnEditTask;
        private Label lblStatus;
        private Button btnDeleteTask;
        private Button btnMarkComplete;
        private Button btnBackToMainForm;
        private Button btnShowCompleted;
    }
}