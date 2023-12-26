using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TodoList
{
    // Form1 is the presentation layer for the TodoList application.
    public partial class Form1 : Form
    {
        // TaskManager handles the business logic for task operations.
        private readonly TaskManager taskManager = new TaskManager();

        // Constructor for Form1.
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for form load. Updates the task list box with existing tasks.
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTaskListBox();
        }

        // Event handler for the 'Add' button click.
        // Adds a new task to the TaskManager and updates the task list box.
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            string taskDescription = taskInputBox.Text.Trim();
            if (!string.IsNullOrEmpty(taskDescription))
            {
                taskManager.AddTask(taskDescription);
                UpdateTaskListBox();
                taskInputBox.Clear();
            }
        }

        // Event handler for the 'Delete' button click.
        // Removes the selected task from the TaskManager and updates the task list box.
        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                taskManager.RemoveTask(selectedIndex);
                UpdateTaskListBox();
            }
        }

        // Event handler for the 'Update' button click.
        // Updates the selected task's description in the TaskManager and updates the task list box.
        private void updateTaskButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                TaskItem selectedTask = taskListBox.Items[selectedIndex] as TaskItem;
                if (selectedTask != null)
                {
                    string newDescription = Prompt.ShowDialog("Edit Task", "Update Task", selectedTask.Description);
                    if (!string.IsNullOrEmpty(newDescription))
                    {
                        taskManager.UpdateTask(selectedIndex, newDescription);
                        UpdateTaskListBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Updates the taskListBox with the tasks from the TaskManager.
        private void UpdateTaskListBox()
        {
            taskListBox.Items.Clear();
            foreach (var taskItem in taskManager.GetTasks())
            {
                taskListBox.Items.Add(taskItem);
            }
        }

        // Nested TaskItem class within Form1
        public class TaskItem
        {
            public string Description { get; set; }
            public bool IsCompleted { get; set; } // Assuming you want to track completion

            public TaskItem(string description)
            {
                Description = description;
                IsCompleted = false;
            }

            // Override ToString to display the description in the ListBox
            public override string ToString()
            {
                return Description;
            }
        }

        private void af(object sender, EventArgs e)
        {

        }
    }

    // The TaskManager class can stay separate, but it should be aware of the TaskItem class.
    internal class TaskManager
    {
        private List<Form1.TaskItem> tasks = new List<Form1.TaskItem>();

        public void AddTask(string description)
        {
            tasks.Add(new Form1.TaskItem(description));
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public void UpdateTask(int index, string newDescription)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].Description = newDescription;
            }
        }

        public List<Form1.TaskItem> GetTasks()
        {
            return tasks;
        }
    }
}
