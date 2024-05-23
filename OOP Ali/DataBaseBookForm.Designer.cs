namespace OOP_Ali
{
    partial class DataBaseBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseBookForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
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
            this.фильтроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтроватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnIdAuthor,
            this.ColumnDateCreate,
            this.ColumnJenre,
            this.ColumnCount});
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 527);
            this.dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Код книги";
            this.ColumnId.MinimumWidth = 9;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название книги";
            this.ColumnName.MinimumWidth = 9;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnIdAuthor
            // 
            this.ColumnIdAuthor.HeaderText = "Код автора";
            this.ColumnIdAuthor.MinimumWidth = 9;
            this.ColumnIdAuthor.Name = "ColumnIdAuthor";
            this.ColumnIdAuthor.ReadOnly = true;
            // 
            // ColumnDateCreate
            // 
            this.ColumnDateCreate.HeaderText = "Год издания книги";
            this.ColumnDateCreate.MinimumWidth = 9;
            this.ColumnDateCreate.Name = "ColumnDateCreate";
            this.ColumnDateCreate.ReadOnly = true;
            // 
            // ColumnJenre
            // 
            this.ColumnJenre.HeaderText = "Жанр книги";
            this.ColumnJenre.MinimumWidth = 9;
            this.ColumnJenre.Name = "ColumnJenre";
            this.ColumnJenre.ReadOnly = true;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Колличество Книг";
            this.ColumnCount.MinimumWidth = 9;
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.элементыToolStripMenuItem,
            this.фильтроватьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip2.Size = new System.Drawing.Size(1101, 42);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
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
            this.создатьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(517, 40);
            this.создатьБазуДанныхToolStripMenuItem.Text = "Создать базу данных";
            создатьБазуДанныхToolStripMenuItem.Click += создатьБазуДанныхToolStripMenuItem_Click;

            // 
            // открытьБазуДанныхToolStripMenuItem
            // 
            this.открытьБазуДанныхToolStripMenuItem.Name = "открытьБазуДанныхToolStripMenuItem";
            this.открытьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(517, 40);
            this.открытьБазуДанныхToolStripMenuItem.Text = "Открыть базу данных";
            открытьБазуДанныхToolStripMenuItem.Click += открытьБазуДанныхToolStripMenuItem_Click;
            // 
            // сохранитьБазуДанныхToolStripMenuItem
            // 
            this.сохранитьБазуДанныхToolStripMenuItem.Name = "сохранитьБазуДанныхToolStripMenuItem";
            this.сохранитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(517, 40);
            this.сохранитьБазуДанныхToolStripMenuItem.Text = "Сохранить базу данных";
            сохранитьБазуДанныхToolStripMenuItem.Click += сохранитьБазуДанныхToolStripMenuItem_Click;

            // 
            // удалитьТекущуюБазуДанныхToolStripMenuItem
            // 
            this.удалитьТекущуюБазуДанныхToolStripMenuItem.Name = "удалитьТекущуюБазуДанныхToolStripMenuItem";
            this.удалитьТекущуюБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(517, 40);
            this.удалитьТекущуюБазуДанныхToolStripMenuItem.Text = "Удалить текущую базу данных";
            удалитьТекущуюБазуДанныхToolStripMenuItem.Click += удалитьТекущуюБазуДанныхToolStripMenuItem_Click;

            // 
            // переключитьсяНаИзменениеПользователейToolStripMenuItem
            // 
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem.Name = "переключитьсяНаИзменениеПользователейToolStripMenuItem";
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem.Size = new System.Drawing.Size(517, 40);
            this.переключитьсяНаИзменениеПользователейToolStripMenuItem.Text = "Переключиться на изменение клиентов";
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
            добавитьКнигуToolStripMenuItem.Click += добавитьэлементToolStripMenuItem_Click;

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
            // фильтроватьToolStripMenuItem
            // 
            this.фильтроватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильтроватьToolStripMenuItem1,
            this.очиститьФильтрToolStripMenuItem});
            this.фильтроватьToolStripMenuItem.Name = "фильтроватьToolStripMenuItem";
            this.фильтроватьToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.фильтроватьToolStripMenuItem.Text = "Фильтровать";
            // 
            // фильтроватьToolStripMenuItem1
            // 
            this.фильтроватьToolStripMenuItem1.Name = "фильтроватьToolStripMenuItem1";
            this.фильтроватьToolStripMenuItem1.Size = new System.Drawing.Size(297, 40);
            this.фильтроватьToolStripMenuItem1.Text = "Фильтровать";
            фильтроватьToolStripMenuItem1.Click += фильтроватьToolStripMenuItem1_Click;
            // 
            // очиститьФильтрToolStripMenuItem
            // 
            this.очиститьФильтрToolStripMenuItem.Name = "очиститьФильтрToolStripMenuItem";
            this.очиститьФильтрToolStripMenuItem.Size = new System.Drawing.Size(297, 40);
            this.очиститьФильтрToolStripMenuItem.Text = "Очистить фильтр";
            очиститьФильтрToolStripMenuItem.Click += очиститьФильтрToolStripMenuItem_Click;

            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 3;
            // 
            // DataBaseBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1085, 614);
            this.Name = "DataBaseBookForm";
            this.Text = "База данных \"Библиотека\"";
            FormClosing += this.DataBaseBookForm_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnIdAuthor;
        private DataGridViewTextBoxColumn ColumnDateCreate;
        private DataGridViewTextBoxColumn ColumnJenre;
        private DataGridViewTextBoxColumn ColumnCount;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem элементыToolStripMenuItem;
        private ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private ToolStripMenuItem редактироватьЭлементToolStripMenuItem;
        private ToolStripMenuItem удалитьЭлементToolStripMenuItem;
        private ToolStripMenuItem создатьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem открытьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem сохранитьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem удалитьТекущуюБазуДанныхToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem фильтроватьToolStripMenuItem;
        private ToolStripMenuItem фильтроватьToolStripMenuItem1;
        private ToolStripMenuItem очиститьФильтрToolStripMenuItem;
        private ToolStripMenuItem переключитьсяНаИзменениеПользователейToolStripMenuItem;
        private Label label1;
    }
}