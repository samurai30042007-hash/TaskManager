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
            this.taskItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.taskItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTable)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(844, 61);
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
            this.label2.Location = new System.Drawing.Point(841, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Title input box";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label4.Location = new System.Drawing.Point(850, 106);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dueTimeBox
            // 
            this.dueTimeBox.Location = new System.Drawing.Point(988, 141);
            this.dueTimeBox.Name = "dueTimeBox";
            this.dueTimeBox.Size = new System.Drawing.Size(149, 22);
            this.dueTimeBox.TabIndex = 14;
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(929, 212);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(92, 34);
            this.Sender.TabIndex = 15;
            this.Sender.Text = "Оправить";
            this.Sender.UseVisualStyleBackColor = true;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(844, 139);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(110, 24);
            this.priorityBox.TabIndex = 16;
            // 
            // taskItemBindingSource
            // 
            this.taskItemBindingSource.DataSource = typeof(TaskManager.TaskItem);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 617);
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
            ((System.ComponentModel.ISupportInitialize)(this.taskItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTable)).EndInit();
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
    }
}

