namespace OOP_Ali
{
    partial class AddEditClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddBookToClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnIdBookGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfDeclaim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDateOfDeclaimed = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateOfTaken = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя клиента";
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(168, 24);
            this.textBoxNameClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(414, 35);
            this.textBoxNameClient.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAddBookToClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfDeclaimed);
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfTaken);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(1579, 812);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление книг";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(694, 352);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(295, 48);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить книгу у клиента";
            this.buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddBookToClient
            // 
            this.buttonAddBookToClient.Location = new System.Drawing.Point(694, 290);
            this.buttonAddBookToClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAddBookToClient.Name = "buttonAddBookToClient";
            this.buttonAddBookToClient.Size = new System.Drawing.Size(295, 50);
            this.buttonAddBookToClient.TabIndex = 18;
            this.buttonAddBookToClient.Text = "Добавить пользователю";
            this.buttonAddBookToClient.UseVisualStyleBackColor = true;
            buttonAddBookToClient.Click += buttonAddBookToClient_Click;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1195, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Книги пользователя";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdBookGet,
            this.ColumnDateOfTaken,
            this.ColumnDateOfDeclaim});
            this.dataGridView2.Location = new System.Drawing.Point(1005, 80);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(562, 718);
            this.dataGridView2.TabIndex = 16;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // ColumnIdBookGet
            // 
            this.ColumnIdBookGet.HeaderText = "Код книги";
            this.ColumnIdBookGet.MinimumWidth = 9;
            this.ColumnIdBookGet.Name = "ColumnIdBookGet";
            this.ColumnIdBookGet.ReadOnly = true;
            // 
            // ColumnDateOfTaken
            // 
            this.ColumnDateOfTaken.HeaderText = "Дата взятия книги";
            this.ColumnDateOfTaken.MinimumWidth = 9;
            this.ColumnDateOfTaken.Name = "ColumnDateOfTaken";
            this.ColumnDateOfTaken.ReadOnly = true;
            // 
            // ColumnDateOfDeclaim
            // 
            this.ColumnDateOfDeclaim.HeaderText = "Дата возврата";
            this.ColumnDateOfDeclaim.MinimumWidth = 9;
            this.ColumnDateOfDeclaim.Name = "ColumnDateOfDeclaim";
            this.ColumnDateOfDeclaim.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Книги бибилиотеки";
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
            this.ColumnIdBook,
            this.ColumnNameBook,
            this.ColumnAuthor,
            this.ColumnYear});
            this.dataGridView1.Location = new System.Drawing.Point(10, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 718);
            this.dataGridView1.TabIndex = 14;
            // 
            // ColumnIdBook
            // 
            this.ColumnIdBook.HeaderText = "Код книги";
            this.ColumnIdBook.MinimumWidth = 9;
            this.ColumnIdBook.Name = "ColumnIdBook";
            this.ColumnIdBook.ReadOnly = true;
            // 
            // ColumnNameBook
            // 
            this.ColumnNameBook.HeaderText = "Название";
            this.ColumnNameBook.MinimumWidth = 9;
            this.ColumnNameBook.Name = "ColumnNameBook";
            this.ColumnNameBook.ReadOnly = true;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.HeaderText = "Автор";
            this.ColumnAuthor.MinimumWidth = 9;
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "Год выпуска";
            this.ColumnYear.MinimumWidth = 9;
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.ReadOnly = true;
            // 
            // dateTimePickerDateOfDeclaimed
            // 
            this.dateTimePickerDateOfDeclaimed.Location = new System.Drawing.Point(694, 232);
            this.dateTimePickerDateOfDeclaimed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePickerDateOfDeclaimed.Name = "dateTimePickerDateOfDeclaimed";
            this.dateTimePickerDateOfDeclaimed.Size = new System.Drawing.Size(241, 35);
            this.dateTimePickerDateOfDeclaimed.TabIndex = 13;
            // 
            // dateTimePickerDateOfTaken
            // 
            this.dateTimePickerDateOfTaken.Location = new System.Drawing.Point(694, 136);
            this.dateTimePickerDateOfTaken.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePickerDateOfTaken.Name = "dateTimePickerDateOfTaken";
            this.dateTimePickerDateOfTaken.Size = new System.Drawing.Size(241, 35);
            this.dateTimePickerDateOfTaken.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата до которой надо вернуть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата выдачи книги";
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEdit.Location = new System.Drawing.Point(1114, 10);
            this.buttonAddEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(468, 66);
            this.buttonAddEdit.TabIndex = 3;
            this.buttonAddEdit.Text = "button3";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            buttonAddEdit.Click += buttonAddEdit_Click;

            // 
            // AddEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 900);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1622, 914);
            this.Name = "AddEditClientForm";
            this.Text = "AddEditClientForm";
            Load += AddEditClientForm_Load;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNameClient;
        private GroupBox groupBox1;
        private Label label5;
        private DataGridView dataGridView2;
        private Label label4;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerDateOfDeclaimed;
        private DateTimePicker dateTimePickerDateOfTaken;
        private Label label3;
        private Label label2;
        private Button buttonAddBookToClient;
        private DataGridViewTextBoxColumn ColumnIdBookGet;
        private DataGridViewTextBoxColumn ColumnDateOfTaken;
        private DataGridViewTextBoxColumn ColumnDateOfDeclaim;
        private DataGridViewTextBoxColumn ColumnIdBook;
        private DataGridViewTextBoxColumn ColumnNameBook;
        private DataGridViewTextBoxColumn ColumnAuthor;
        private DataGridViewTextBoxColumn ColumnYear;
        private Button buttonDelete;
        private Button buttonAddEdit;
    }
}