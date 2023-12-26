using System.Collections.Generic;

// TaskManager is the application logic layer that manages tasks.
public class TaskManager
{
    private List<string> tasks = new List<string>();

    // Adds a new task.
    public void AddTask(string task)
    {
        if (!string.IsNullOrWhiteSpace(task))
        {
            tasks.Add(task);
        }
    }

    // Removes the task at the specified index.
    public bool RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            return true;
        }
        return false;
    }

    // Retrieves a copy of the list of tasks.
    public List<string> GetTasks()
    {
        return tasks;
    }
}
