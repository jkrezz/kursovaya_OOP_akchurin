namespace OOP_Ali
{
    partial class DataBaseClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseClientForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnIdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName});
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(319, 846);
            this.dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя пользователя";
            this.ColumnName.MinimumWidth = 9;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.элементыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБазуДанныхToolStripMenuItem,
            this.открытьБазуДанныхToolStripMenuItem,
            this.сохранитьБазуДанныхToolStripMenuItem,
            this.удалитьТекущуюБазуДанныхToolStripMenuItem,
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьБазуДанныхToolStripMenuItem
            // 
            this.создатьБазуДанныхToolStripMenuItem.Name = "создатьБазуДанныхToolStripMenuItem";
            this.создатьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(471, 40);
            this.создатьБазуДанныхToolStripMenuItem.Text = "Создать базу данных";
            создатьБазуДанныхToolStripMenuItem.Click += создатьБазуДанныхToolStripMenuItem_Click;

            // 
            // открытьБазуДанныхToolStripMenuItem
            // 
            this.открытьБазуДанныхToolStripMenuItem.Name = "открытьБазуДанныхToolStripMenuItem";
            this.открытьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(471, 40);
            this.открытьБазуДанныхToolStripMenuItem.Text = "Открыть базу данных";
            открытьБазуДанныхToolStripMenuItem.Click += открытьБазуДанныхToolStripMenuItem_Click;

            // 
            // сохранитьБазуДанныхToolStripMenuItem
            // 
            this.сохранитьБазуДанныхToolStripMenuItem.Name = "сохранитьБазуДанныхToolStripMenuItem";
            this.сохранитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(471, 40);
            this.сохранитьБазуДанныхToolStripMenuItem.Text = "Сохранить базу данных";
            сохранитьБазуДанныхToolStripMenuItem.Click += сохранитьБазуДанныхToolStripMenuItem_Click;

            // 
            // удалитьТекущуюБазуДанныхToolStripMenuItem
            // 
            this.удалитьТекущуюБазуДанныхToolStripMenuItem.Name = "удалитьТекущуюБазуДанныхToolStripMenuItem";
            this.удалитьТекущуюБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(471, 40);
            this.удалитьТекущуюБазуДанныхToolStripMenuItem.Text = "Удалить текущую базу данных";
            удалитьТекущуюБазуДанныхToolStripMenuItem.Click += удалитьТекущуюБазуДанныхToolStripMenuItem_Click;

            // 
            // переключитьсяНаИзменениеПользователейToolStripMenuItem
            // 
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem.Name = "переключитьсяНаИзменениеПользователейToolStripMenuItem";
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem.Size = new System.Drawing.Size(471, 40);
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem.Text = "Переключиться на изменение книг";
            переключитьсяНаИзменениеПользователейToolStripMenuItem.Click += переключитьсяНаИзменениеПользователейToolStripMenuItem_Click;

            // 
            // элементыToolStripMenuItem
            // 
            this.элементыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКнигуToolStripMenuItem,
            this.редактироватьЭлементToolStripMenuItem,
            this.удалитьЭлементToolStripMenuItem});
            this.элементыToolStripMenuItem.Name = "элементыToolStripMenuItem";
            this.элементыToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.элементыToolStripMenuItem.Text = "Изменить";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(358, 40);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить элемент";
            добавитьКнигуToolStripMenuItem.Click += добавитьКнигуToolStripMenuItem_Click;

            // 
            // редактироватьЭлементToolStripMenuItem
            // 
            this.редактироватьЭлементToolStripMenuItem.Name = "редактироватьЭлементToolStripMenuItem";
            this.редактироватьЭлементToolStripMenuItem.Size = new System.Drawing.Size(358, 40);
            this.редактироватьЭлементToolStripMenuItem.Text = "Редактировать элемент";
            редактироватьЭлементToolStripMenuItem.Click += редактироватьЭлементToolStripMenuItem_Click;

            // 
            // удалитьЭлементToolStripMenuItem
            // 
            this.удалитьЭлементToolStripMenuItem.Name = "удалитьЭлементToolStripMenuItem";
            this.удалитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(358, 40);
            this.удалитьЭлементToolStripMenuItem.Text = "Удалить элемент";
            удалитьЭлементToolStripMenuItem.Click += удалитьЭлементToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdBook,
            this.ColumnDateOfTaken,
            this.ColumnDateOfDelivered});
            this.dataGridView2.Location = new System.Drawing.Point(350, 54);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1073, 846);
            this.dataGridView2.TabIndex = 2;
            // 
            // ColumnIdBook
            // 
            this.ColumnIdBook.HeaderText = "Код книги";
            this.ColumnIdBook.MinimumWidth = 9;
            this.ColumnIdBook.Name = "ColumnIdBook";
            this.ColumnIdBook.ReadOnly = true;
            // 
            // ColumnDateOfTaken
            // 
            this.ColumnDateOfTaken.HeaderText = "Дата взятия книги";
            this.ColumnDateOfTaken.MinimumWidth = 9;
            this.ColumnDateOfTaken.Name = "ColumnDateOfTaken";
            this.ColumnDateOfTaken.ReadOnly = true;
            // 
            // ColumnDateOfDelivered
            // 
            this.ColumnDateOfDelivered.HeaderText = "Дата когда нужно вернуть книгу";
            this.ColumnDateOfDelivered.MinimumWidth = 9;
            this.ColumnDateOfDelivered.Name = "ColumnDateOfDelivered";
            this.ColumnDateOfDelivered.ReadOnly = true;
            // 
            // DataBaseClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 924);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1454, 938);
            this.Name = "DataBaseClientForm";
            this.Text = "База данных \"Клиенты\"";
            Load += DataBaseClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem открытьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem сохранитьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem удалитьТекущуюБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem переключитьсяНаИзменениеПользователейToolStripMenuItem;
        private ToolStripMenuItem элементыToolStripMenuItem;
        private ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private ToolStripMenuItem редактироватьЭлементToolStripMenuItem;
        private ToolStripMenuItem удалитьЭлементToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnIdBook;
        private DataGridViewTextBoxColumn ColumnDateOfTaken;
        private DataGridViewTextBoxColumn ColumnDateOfDelivered;
    }
}