using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Utils
    {
        private int _count = 0;
        private HashSet<string> _titelsSet = new HashSet<string>();


        internal TaskItem CreateTaskItem(string title, string description, Priority priority, DateTime dueTime)
        {
            if (!(_titelsSet.Add(title)))
            {
                throw new Exception("Title repeat");
            }
            return new TaskItem(++_count, title, description, priority, dueTime);
        }

        internal void DeleatTaskItem(string item)
        {
            if (!_titelsSet.Remove(item))
            {
                throw new Exception("Wrong title to deleat");
            }
        }
    }
}
