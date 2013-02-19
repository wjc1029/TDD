using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDdemo
{
    public  class Box
    {
        private Dictionary<string, int> tasks = new Dictionary<string, int>();

        public void Push(string taskName, int priority)
        {
            tasks.Add(taskName,priority);
        }

        public string Pop() {
             throw new NotImplementedException();
        }

        public void List() {
            throw new NotImplementedException();
        }

        public int Count() {
            return this.tasks.Count;
        }
    }
}
