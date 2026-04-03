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
        Utils utils = new Utils();

        public Form1()
        {
            InitializeComponent();

            taskItems  = new BindingList<TaskItem>();
            priorityBox.DataSource = Enum.GetValues(typeof(Priority));
            taskTable.DataSource = taskItems;

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
            
            taskItems.Remove();

        }
    }
    
}
