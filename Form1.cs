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
    using static Utils;
    public partial class Form1 : Form
    {
        BindingList<TaskItem> taskItems;

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
                taskItems.Add( new TaskItem(titleBox.Text, descripBox.Text, (Priority)priorityBox.SelectedItem, dueTimeBox.Value.Date));

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
