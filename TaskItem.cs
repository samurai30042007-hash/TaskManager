using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TaskItem
    {


        public int Id { get; private set; }
        private string _title;
        private string _description; // Если ставлю string?  то компилятор жалуется говорит, что на net 7.3 нет null

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Wrong title name");
                }
                _title = value;
            }

        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != "" || value != null)
                {
                    _description = value;
                }
            }
        }
        
        public Priority Priority { get; private set; }
        public DateTime DueTime { get; private set; }
        private bool _isComplete;



        public bool IsComplete
        {
            get
            {
                return _isComplete;
            }

            set 
            {
                _isComplete = value;
            }
        }
        

        internal TaskItem(int id, string title, string description, Priority priority, DateTime dueTime, bool isComplite = false)
        {
            this.Id = id;
            this.Title= title;
            this.Description = description;
            this.Priority = priority;
            this.DueTime = dueTime;
            this.IsComplete = isComplite;
        }
        
    }

    


    internal enum Priority
    {
        Low,
        Medium,
        High
    }
    
}
