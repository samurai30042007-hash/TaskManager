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
       Utils utils = new Utils(0);

        public Form1()
        {
            InitializeComponent();

            taskItems  = new BindingList<TaskItem>();
            priorityBox.DataSource = Enum.GetValues(typeof(Priority));
            taskTable.DataSource = taskItems;
            SortBox.DataSource = new List<string> {"Id", "Title", "Description", "Priority", "IsComplete", "DueTime" };
            FilterBox.DataSource = new List<string> { "Id", "Title", "Description", "Priority", "DueTime" };
            taskTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "Ошибка ввода");
                }

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void taskTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (taskTable.Columns[e.ColumnIndex].HeaderText == "IsComplete")
            {
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
                }
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            taskItems.Clear();
            utils.DeleteAll();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            taskItems = SortAndFilter.Sort(taskItems, SortBox.SelectedItem.ToString());
            taskTable.DataSource = taskItems;
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
