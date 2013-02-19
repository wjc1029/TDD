using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDdemo
{
    public class Box
    {
        private Dictionary<string, int> tasks = new Dictionary<string, int>();

        public void Push(string taskName, int priority)
        {
            tasks.Add(taskName, priority);
        }

        public string Pop()
        {
            string taskName = "Doesn't exist any task.";
            int priority = int.MinValue;
            foreach (KeyValuePair<string, int> task in tasks)
            {
                if (priority < task.Value)
                {
                    priority = task.Value;
                    taskName = task.Key;
                }
            }

            return taskName;
        }

        public void List()
        {
            var items = from pair in tasks
                        orderby pair.Value descending
                        select pair;
            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("TaskName: {0} - Priority: {1}", pair.Key, pair.Value);
            }
        }

        public int Count()
        {
            return this.tasks.Count;
        }
    }
}
