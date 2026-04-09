using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    static internal class SortAndFilter
    {
        static internal BindingList<TaskItem> Sort(BindingList<TaskItem> taskItems, string nameColumns)
        {
            BindingList<TaskItem> newItems;

            if (nameColumns == "Id")
            {
                newItems = new BindingList<TaskItem>(taskItems.OrderBy(x => x.Id).ToList());

            }
            else if (nameColumns == "Title")
            {
                newItems = new BindingList<TaskItem>(taskItems.OrderBy(x => x.Title).ToList());

            }
            else if (nameColumns == "Description")
            {
                newItems = new BindingList<TaskItem>(taskItems.OrderBy(x => x.Description).ToList());

            }
            else if (nameColumns == "Priority")
            {
                newItems = new BindingList<TaskItem>(taskItems.OrderBy(x => x.Priority).ToList());

            }
            else if (nameColumns == "DueTime")
            {
                newItems = new BindingList<TaskItem>(taskItems.OrderBy(x => x.DueTime).ToList());

            }
            else if (nameColumns == "IsComplete")
            {
                newItems = new BindingList<TaskItem>(taskItems.OrderBy(x => x.IsComplete).ToList());

            }
            else
            {
                throw new Exception("Wrong name");
            }
            
            return newItems;

        }
        static internal BindingList<TaskItem> Filter(BindingList<TaskItem> taskItems, string nameColumns, string inner)
        {
            BindingList<TaskItem> newItems;

            if (nameColumns == "Id")
            {
                newItems = new BindingList<TaskItem>(taskItems.Where(x => x.Id.ToString().Contains(inner)).ToList());

            }
            else if (nameColumns == "Title")
            {
                newItems = new BindingList<TaskItem>(taskItems.Where(x => x.Title.Contains(inner)).ToList());

            }
            else if (nameColumns == "Description")
            {
                newItems = new BindingList<TaskItem>(taskItems.Where(x => x.Description.Contains(inner)).ToList());

            }
            else if (nameColumns == "Priority")
            {
                newItems = new BindingList<TaskItem>(taskItems.Where(x => x.Priority.ToString().Contains(inner)).ToList());

            }
            else if (nameColumns == "DueTime")
            {
                newItems = new BindingList<TaskItem>(taskItems.Where(x => x.DueTime.ToString().Contains(inner)).ToList());

            }
            else
            {
                throw new Exception("Wrong name");
            }

            return newItems;
        }

        static internal void FullStatistic(Label label, Utils utils, BindingList<TaskItem> taskItems)
        {
            if (taskItems.Count > 0)
            {
                Double PersentComplete = (Convert.ToDouble(utils.CompletTask)  / taskItems.Count) * 100;
                
                int highCount = taskItems.Where(x => x.Priority == Priority.High && !x.IsComplete).Count();
                int lowCount = taskItems.Where(x => x.Priority == Priority.Low && !x.IsComplete).Count();
                int mediumCount = taskItems.Where(x => x.Priority == Priority.Medium && !x.IsComplete).Count();

                int UntilCountDay;
                int UntilCount;
                {
                    var TempList = taskItems.Where(x => x.DueTime <= DateTime.Now.Date && !x.IsComplete);
                    UntilCount = TempList.Count();
                    UntilCountDay = TempList.Sum((x) => (DateTime.Now.Date - x.DueTime).Days);
                }
                int AfterCountDay;
                int AfterCount;
                {
                    var TempList = taskItems.Where(x => x.DueTime > DateTime.Now.Date && !x.IsComplete);
                    AfterCountDay = TempList.Sum((x) => (x.DueTime - DateTime.Now.Date).Days);
                    AfterCount = TempList.Count();
                }
                if (AfterCount == 0)
                {
                    AfterCount = 1;
                    AfterCountDay = 0;
                }
                if (UntilCount == 0)
                {
                    UntilCount = 1;
                    UntilCountDay = 0;
                }

                label.Text = $"\nПрофент выполнения - {Convert.ToInt32(PersentComplete)}%\nКоличесво приоритета high - {highCount}\nКоличесво приоритета medium - {mediumCount}\nКоличесво приоритета low - {lowCount}\nСреднее время просрочки - {AfterCountDay / AfterCount}\nСреднее время просрочки - {UntilCountDay / UntilCount}";

            }
            else
            {
                label.Text = "Нет данных";
            }
        }
    }
}
