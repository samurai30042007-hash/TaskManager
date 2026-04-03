using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    using static Utils;
    internal class TaskItem
    {

        static private int count = 1;

        public int id { get; private set; }
        private string title;
        private string description; // Если ставлю string?  то компилятор жалуется говорит, что на net 7.3 нет null
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != "" || value != null)
                {
                    description = value;
                }
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!titleHash.Add(value) || value == "" || value == null)
                {
                    throw new Exception("Wrong title name");
                }
                title = value;
            }

        }
        static private HashSet<string> titleHash = new HashSet<string>();
        public Priority priority { get; private set; }
        public DateTime dueTime { get; private set; }
        public bool isComlite { get; private set; }

        

        internal TaskItem(string title, string description, Priority priority, DateTime dueTime, bool isComplite = false)
        {
            id = count++;
            this.title= title;
            this.description = description;
            this.priority = priority;
            this.dueTime = dueTime;
            this.isComlite = isComplite;
        }
        
    }

    internal class Utils
    {
        internal enum Priority
        {
            Low,
            Medium,
            High
        }
    }
}
