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
        private HashSet<string> _titlesSet = new HashSet<string>();

        internal Utils(int count, List<string> titles = null)
        {
            _count = count;
            FillHashSet(titles);
        }
        private void FillHashSet(List<string> strings)
        {
            if (strings != null)
            {
                foreach (string s in strings)
                {
                    if (!_titlesSet.Add(s))
                    {
                        throw new Exception("Title repeat in fill method");
                    }
                }
            }
            
        }

        internal TaskItem CreateTaskItem(string title, string description, Priority priority, DateTime dueTime)
        {
            if (!(_titlesSet.Add(title)))
            {
                throw new Exception("Title repeat");
            }
            return new TaskItem(++_count, title, description, priority, dueTime);
        }

        internal void DeleteAll()
        {
            _titlesSet.Clear(); 
        }

        internal void DeleteTaskItem(string item)
        {
            if (!_titlesSet.Remove(item))
            {
                throw new Exception("Wrong title to Delete");
            }
        }
        
    }
}
