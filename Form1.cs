using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    
    public partial class Form1 : Form
    {
        BindingList<TaskItem> taskItems;
        Utils utils = new Utils();
        

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
            
                if (task.DueTime < DateTime.Now && !task.IsComplete)
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
                utils.ChangeTaskCompletion(taskItems[e.RowIndex].IsComplete, taskItems[e.RowIndex].DueTime);
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
                    --utils.CompletTask;
                }
                UpdateCompletedTaskLAbel();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            taskItems.Clear();
            utils.DeleteAll();
            UpdateCompletedTaskLAbel();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            taskItems = SortAndFilter.Sort(taskItems, SortBox.SelectedItem.ToString());
            taskTable.DataSource = taskItems;
        }

        internal void UpdateCompletedTaskLAbel()
        {
            CompletedTaskLAbel.Text = $"Выполненые задания - {utils.CompletTask}\nНе выполненые задания - {utils.UnCompleteTask}\nСреднее время до делайна - {utils.UntilDeadLine}\nСреднее время просрочки - {utils.AfterDeadLine}";
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            string json = JsonSerializer.Serialize(taskItems);
            await FileWork.SaveFile(filePath, json);
        }

        private async void ImportBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            string json = await FileWork.ImportFile(filePath);
            List<TaskItemStruct> taskItemStruct = JsonSerializer.Deserialize<List<TaskItemStruct>>(json); //Танцы с бубном потому что я хочу сохранить приватность но init не работает из-за C# 7.3
            utils.AddImportItems(taskItemStruct, taskItems);
            UpdateCompletedTaskLAbel();
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
    }
    
}
