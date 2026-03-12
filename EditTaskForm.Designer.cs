namespace TODOLIST
{
    partial class EditTaskForm
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
            btnSave = new Button();
            label1 = new Label();
            txtTaskName = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(207, 206);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 75);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Change Task";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(146, 98);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(250, 27);
            txtTaskName.TabIndex = 2;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(146, 161);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(250, 27);
            dateTimePickerDeadline.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 138);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "Change Deadline";
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 330);
            Controls.Add(label2);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(txtTaskName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtTaskName;
        private DateTimePicker dateTimePickerDeadline;
        private Label label2;
    }
}