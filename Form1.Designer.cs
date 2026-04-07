namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.descripBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dueTimeBox = new System.Windows.Forms.DateTimePicker();
            this.Sender = new System.Windows.Forms.Button();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.taskTable = new System.Windows.Forms.DataGridView();
            this.dealeatChosen = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.CompletedTaskLAbel = new System.Windows.Forms.Label();
            this.taskItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taskTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(788, 61);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(110, 22);
            this.titleBox.TabIndex = 3;
            // 
            // descripBox
            // 
            this.descripBox.Location = new System.Drawing.Point(988, 61);
            this.descripBox.Multiline = true;
            this.descripBox.Name = "descripBox";
            this.descripBox.Size = new System.Drawing.Size(159, 42);
            this.descripBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(785, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Title input box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(985, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description input box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(794, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Priority input box";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "*Due Time input box";
            // 
            // dueTimeBox
            // 
            this.dueTimeBox.Location = new System.Drawing.Point(988, 141);
            this.dueTimeBox.Name = "dueTimeBox";
            this.dueTimeBox.Size = new System.Drawing.Size(167, 22);
            this.dueTimeBox.TabIndex = 14;
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(1053, 212);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(94, 36);
            this.Sender.TabIndex = 15;
            this.Sender.Text = "Оправить";
            this.Sender.UseVisualStyleBackColor = true;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(788, 139);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(110, 24);
            this.priorityBox.TabIndex = 16;
            // 
            // taskTable
            // 
            this.taskTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskTable.Location = new System.Drawing.Point(13, 13);
            this.taskTable.Name = "taskTable";
            this.taskTable.RowHeadersWidth = 51;
            this.taskTable.RowTemplate.Height = 24;
            this.taskTable.Size = new System.Drawing.Size(725, 288);
            this.taskTable.TabIndex = 17;
            this.taskTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskTable_CellContentClick);
            // 
            // dealeatChosen
            // 
            this.dealeatChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dealeatChosen.Location = new System.Drawing.Point(788, 212);
            this.dealeatChosen.Name = "dealeatChosen";
            this.dealeatChosen.Size = new System.Drawing.Size(94, 36);
            this.dealeatChosen.TabIndex = 18;
            this.dealeatChosen.Text = "Удалить сделанное";
            this.dealeatChosen.UseVisualStyleBackColor = true;
            this.dealeatChosen.Click += new System.EventHandler(this.dealeatChosen_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAll.Location = new System.Drawing.Point(917, 212);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(91, 36);
            this.DeleteAll.TabIndex = 19;
            this.DeleteAll.Text = "Удалить все";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // SortBox
            // 
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Location = new System.Drawing.Point(219, 363);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(121, 24);
            this.SortBox.TabIndex = 20;
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sort by";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(13, 442);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(149, 22);
            this.FilterTextBox.TabIndex = 22;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Filter by";
            // 
            // FilterBox
            // 
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Location = new System.Drawing.Point(13, 363);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(121, 24);
            this.FilterBox.TabIndex = 24;
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Location = new System.Drawing.Point(13, 406);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(132, 16);
            this.LabelFilter.TabIndex = 26;
            this.LabelFilter.Text = "Не отфильтровано";
            // 
            // CompletedTaskLAbel
            // 
            this.CompletedTaskLAbel.AutoSize = true;
            this.CompletedTaskLAbel.Location = new System.Drawing.Point(216, 406);
            this.CompletedTaskLAbel.Name = "CompletedTaskLAbel";
            this.CompletedTaskLAbel.Size = new System.Drawing.Size(40, 16);
            this.CompletedTaskLAbel.TabIndex = 28;
            this.CompletedTaskLAbel.Text = "None";
            // 
            // taskItemBindingSource
            // 
            this.taskItemBindingSource.DataSource = typeof(TaskManager.TaskItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 617);
            this.Controls.Add(this.CompletedTaskLAbel);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.dealeatChosen);
            this.Controls.Add(this.taskTable);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.dueTimeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripBox);
            this.Controls.Add(this.titleBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox descripBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource taskItemBindingSource;
        private System.Windows.Forms.DateTimePicker dueTimeBox;
        private System.Windows.Forms.Button Sender;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.DataGridView taskTable;
        private System.Windows.Forms.Button dealeatChosen;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.Label LabelFilter;
        private System.Windows.Forms.Label CompletedTaskLAbel;
    }
}

