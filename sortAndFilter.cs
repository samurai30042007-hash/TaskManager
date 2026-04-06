using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
    }
}
