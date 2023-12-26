namespace TodoList
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.taskInputBox = new System.Windows.Forms.RichTextBox();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.updateTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(484, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODO LIST";
            // 
            // taskInputBox
            // 
            this.taskInputBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskInputBox.Location = new System.Drawing.Point(68, 135);
            this.taskInputBox.Name = "taskInputBox";
            this.taskInputBox.Size = new System.Drawing.Size(563, 51);
            this.taskInputBox.TabIndex = 1;
            this.taskInputBox.Text = "";
            this.taskInputBox.Click += new System.EventHandler(this.af);
            // 
            // taskListBox
            // 
            this.taskListBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 28;
            this.taskListBox.Location = new System.Drawing.Point(68, 257);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(563, 200);
            this.taskListBox.TabIndex = 2;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addTaskButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTaskButton.Location = new System.Drawing.Point(709, 135);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(152, 51);
            this.addTaskButton.TabIndex = 3;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteTaskButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTaskButton.Location = new System.Drawing.Point(709, 221);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(152, 61);
            this.deleteTaskButton.TabIndex = 4;
            this.deleteTaskButton.Text = "Delete";
            this.deleteTaskButton.UseVisualStyleBackColor = false;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // updateTaskButton
            // 
            this.updateTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateTaskButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateTaskButton.Location = new System.Drawing.Point(709, 316);
            this.updateTaskButton.Name = "updateTaskButton";
            this.updateTaskButton.Size = new System.Drawing.Size(152, 58);
            this.updateTaskButton.TabIndex = 5;
            this.updateTaskButton.Text = "Update";
            this.updateTaskButton.UseVisualStyleBackColor = false;
            this.updateTaskButton.Click += new System.EventHandler(this.updateTaskButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 559);
            this.Controls.Add(this.updateTaskButton);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.taskInputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox taskInputBox;
        private ListBox taskListBox;
        private Button addTaskButton;
        private Button deleteTaskButton;
        private Button updateTaskButton;
    }
}