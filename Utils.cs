using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    internal class Utils
    {
        private int _curId = 0;
        private HashSet<string> _titlesSet = new HashSet<string>();
        private HashSet<int> _idSet = new HashSet<int>();
        private int _completTask {  get; set; }
        internal int CompletTask
        {
            get { return _completTask; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Negative Value Complete Task");
                }
                _completTask = value;
            }
        }

        private int _unCompleteTask { get;  set; }
        internal int UnCompleteTask
        {
            get { return _unCompleteTask; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative Value Unсomplete Task");
                }
                _unCompleteTask = value;
            }
        }
        internal TimeSpan _untilDeadLine { get; set; }
        internal TimeSpan UntilDeadLine
        {
            get { return _untilDeadLine; }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new Exception("Negative Value UntilDeadLine");
                }
                _untilDeadLine = value;
            }
        }
        internal TimeSpan _afterDeadLine { get; set; }
        internal TimeSpan AfterDeadLine
        {
            get { return _afterDeadLine; }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new Exception("Negative Value UntilDeadLine");
                }
                _afterDeadLine = value;
            }
        }

        internal Utils( List<string> titles = null)
        {
            FillHashSetTitel(titles);
            CompletTask = 0;
            UnCompleteTask = 0;
            UntilDeadLine = TimeSpan.Zero;
            AfterDeadLine = TimeSpan.Zero;
        }
        private void FillHashSetTitel(List<string> strings)
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
            while (!_idSet.Add((++_curId)));
            if (dueTime <= DateTime.Now.Date)
            {
                AfterDeadLine += DateTime.Now.Date - dueTime;
            }
            else
            {
                UntilDeadLine += dueTime - DateTime.Now.Date;

            }
            ++UnCompleteTask;
            return new TaskItem(_curId, title, description, priority, dueTime);
        }
        private TaskItem CreateTaskItem(int Id, string title, string description, Priority priority, DateTime dueTime, bool IsComplete)
        {
            if (!(_titlesSet.Add(title)))
            {
                throw new Exception("Title repeat");
            }
            while (!_idSet.Add((++_curId))) ;
            if (!IsComplete)
            {
                if (dueTime <= DateTime.Now.Date)
                {
                    AfterDeadLine += DateTime.Now.Date - dueTime;
                }
                else
                {
                    UntilDeadLine += dueTime - DateTime.Now.Date;

                }
                ++UnCompleteTask;
            }
            else
            {
                ++CompletTask;
            }
            
            return new TaskItem(Id, title, description, priority, dueTime, IsComplete);
        }
        internal void ChangeTaskCompletion(bool IsComolete,DateTime DueTime)
        {
            if (!IsComolete)
            { // Статистику не делал через linq  так как слишком жирно каждый раз пробегать по всем эллементам и смотреть кто выполнен а кто нет, моя реализация не требует много вычислений                
                --UnCompleteTask;
                ++CompletTask;
                if (DueTime <= DateTime.Now)
                {
                    AfterDeadLine -= DateTime.Now.Date - DueTime;
                }
                else
                {
                    UntilDeadLine -= DueTime - DateTime.Now.Date;

                }
            }
            else
            {
                ++UnCompleteTask;
                --CompletTask;
                if (DueTime <= DateTime.Now)
                {
                    AfterDeadLine += DateTime.Now.Date - DueTime;
                }
                else
                {
                    UntilDeadLine += DueTime - DateTime.Now.Date;

                }
            }
        }

        internal void DeleteAll()
        {
            _titlesSet.Clear();
            UntilDeadLine = TimeSpan.Zero;
            AfterDeadLine = TimeSpan.Zero;
            CompletTask = 0;
            UnCompleteTask = 0;
        }

        internal void DeleteTaskItem(string item)
        {
            if (!_titlesSet.Remove(item))
            {
                throw new Exception("Wrong title to Delete");
            }
        }
        
        internal void AddImportItems(List<TaskItemStruct> ImportItems, BindingList<TaskItem> taskItems) 
        {
            foreach (var item in ImportItems)
            {
                taskItems.Add(CreateTaskItem(item.Id, item.Title, item.Description, item.Priority, item.DueTime, item.IsComplete));
            }
        }
    }
}
