using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    
    public partial class Form1 : Form
    {
        BindingList<TaskItem> taskItems;
        DateTime NowDate = DateTime.Now.Date;
        Utils utils = new Utils(0);
        int CompletTask = 0, UnCompleteTask = 0;
        TimeSpan UntilDeadLine = TimeSpan.Zero, AfterDeadLine = TimeSpan.Zero; 

        public Form1()
        {
            InitializeComponent();

            taskItems  = new BindingList<TaskItem>();
            priorityBox.DataSource = Enum.GetValues(typeof(Priority));
            taskTable.DataSource = taskItems;
            SortBox.DataSource = new List<string> {"Id", "Title", "Description", "Priority", "IsComplete", "DueTime" };
            FilterBox.DataSource = new List<string> { "Id", "Title", "Description", "Priority", "DueTime" };
            taskTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            taskTable.CellFormatting += taskTable_CellFormatting;
            UpdateCompletedTaskLAbel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sender_Click(object sender, EventArgs e)
        {
            if (titleBox.Text == string.Empty)
            {
                MessageBox.Show("Заполните обязательные блоки *", "Ошибка ввода" );
            }
            else
            {
                try
                {
                    taskItems.Add(utils.CreateTaskItem(titleBox.Text, descripBox.Text, (Priority)priorityBox.SelectedItem, dueTimeBox.Value.Date));
                    titleBox.Text = "";
                    descripBox.Text = "";
                    ++UnCompleteTask;
                    if (dueTimeBox.Value.Date <= NowDate)
                    {
                        AfterDeadLine += NowDate - dueTimeBox.Value.Date;
                    }
                    else
                    {
                        UntilDeadLine += dueTimeBox.Value.Date - NowDate;

                    }
                    UpdateCompletedTaskLAbel();
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "Ошибка ввода");
                }

            }
        }

        private void taskTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            TaskItem task = taskTable.Rows[e.RowIndex].DataBoundItem as TaskItem;

            if (task != null) { 
            
                if (task.DueTime < NowDate && !task.IsComplete)
                {
                    taskTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    
                    taskTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void taskTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (taskTable.Columns[e.ColumnIndex].HeaderText == "IsComplete")
            {
                if (taskItems[e.RowIndex].IsComplete)
                { // Статистику не делал через linq  так как слишком жирно каждый раз пробегать по всем эллементам и смотреть кто выполнен а кто нет, моя реализация не требует много вычислений                
                    ++UnCompleteTask;
                    --CompletTask;
                    if (taskItems[e.RowIndex].DueTime <= NowDate)
                    {
                        AfterDeadLine -= taskItems[e.RowIndex].DueTime - NowDate;
                    }
                    else
                    {
                        UntilDeadLine -= NowDate - taskItems[e.RowIndex].DueTime;

                    }
                }
                else
                {
                    --UnCompleteTask;
                    ++CompletTask;
                    if (taskItems[e.RowIndex].DueTime <= NowDate)
                    {
                        AfterDeadLine += taskItems[e.RowIndex].DueTime - NowDate;
                    }
                    else
                    {
                        UntilDeadLine += NowDate - taskItems[e.RowIndex].DueTime;

                    }
                }
                UpdateCompletedTaskLAbel();
                taskItems[e.RowIndex].IsComplete = !taskItems[e.RowIndex].IsComplete;
            }
        }

        private void dealeatChosen_Click(object sender, EventArgs e)
        {

            for (int i  = taskItems.Count - 1; i >= 0 ; --i)
            {
                if (taskItems[i].IsComplete == true)
                {
                    utils.DeleteTaskItem(taskItems[i].Title);
                    taskItems.RemoveAt(i);
                    --CompletTask;
                }
                UpdateCompletedTaskLAbel();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            taskItems.Clear();
            utils.DeleteAll();
            UntilDeadLine = TimeSpan.Zero;
            AfterDeadLine = TimeSpan.Zero;
            CompletTask = 0;
            UnCompleteTask = 0;
            UpdateCompletedTaskLAbel();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            taskItems = SortAndFilter.Sort(taskItems, SortBox.SelectedItem.ToString());
            taskTable.DataSource = taskItems;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void UpdateCompletedTaskLAbel()
        {
            CompletedTaskLAbel.Text = $"Выполненые задания - {CompletTask}\nНе выполненые задания - {UnCompleteTask}\nСреднее время до делайна - {UntilDeadLine}\nСреднее время просрочки - {AfterDeadLine}";
        }
        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {

            taskTable.DataSource = SortAndFilter.Filter(taskItems, FilterBox.SelectedItem.ToString() , FilterTextBox.Text);
            LabelFilter.Text = "Отфильтровано";
            if (string.IsNullOrEmpty(FilterTextBox.Text))
            {
                LabelFilter.Text = "Не отфильтровано";
                taskTable.DataSource = taskItems;
            }


        }

        private void Highlight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {

            }
        }
    }
    
}
