namespace OOP_Ali
{
    partial class createEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createEditForm));
            this.buttonEditAdd = new System.Windows.Forms.Button();
            this.numericUpDownCountBook = new System.Windows.Forms.NumericUpDown();
            this.textBoxJenre = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxIdAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditAdd
            // 
            this.buttonEditAdd.Location = new System.Drawing.Point(24, 360);
            this.buttonEditAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonEditAdd.Name = "buttonEditAdd";
            this.buttonEditAdd.Size = new System.Drawing.Size(369, 42);
            this.buttonEditAdd.TabIndex = 25;
            this.buttonEditAdd.Text = "button1";
            this.buttonEditAdd.UseVisualStyleBackColor = true;
            buttonEditAdd.Click += buttonEditAdd_Click;

            // 
            // numericUpDownCountBook
            // 
            this.numericUpDownCountBook.Location = new System.Drawing.Point(214, 302);
            this.numericUpDownCountBook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDownCountBook.Name = "numericUpDownCountBook";
            this.numericUpDownCountBook.Size = new System.Drawing.Size(180, 35);
            this.numericUpDownCountBook.TabIndex = 24;
            this.numericUpDownCountBook.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxJenre
            // 
            this.textBoxJenre.Location = new System.Drawing.Point(156, 244);
            this.textBoxJenre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxJenre.Name = "textBoxJenre";
            this.textBoxJenre.Size = new System.Drawing.Size(235, 35);
            this.textBoxJenre.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 186);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 35);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // textBoxIdAuthor
            // 
            this.textBoxIdAuthor.Location = new System.Drawing.Point(149, 128);
            this.textBoxIdAuthor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxIdAuthor.Name = "textBoxIdAuthor";
            this.textBoxIdAuthor.Size = new System.Drawing.Size(241, 35);
            this.textBoxIdAuthor.TabIndex = 21;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(192, 70);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(199, 35);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(137, 12);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(254, 35);
            this.textBoxId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Колличество книг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Жанр книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Год издания книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Код автора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Код книги";
            // 
            // createEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 426);
            this.Controls.Add(this.buttonEditAdd);
            this.Controls.Add(this.numericUpDownCountBook);
            this.Controls.Add(this.textBoxJenre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxIdAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "createEditForm";
            this.Text = "createEditForm";
            Load += createEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditAdd;
        private NumericUpDown numericUpDownCountBook;
        private TextBox textBoxJenre;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxIdAuthor;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}