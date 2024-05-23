using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ali
{

    /// <summary>Форма для добавления/редактирования элементов в БД</summary>
    public partial class createEditForm : Form
    {

        /// <summary>Библиотека для проверки наличия такой книги</summary>
        private Library _library;

        /// <summary>Книга для добаления или редактирования в БД</summary>
        public Book newbook;

        /// <summary>Первоначальный код книги для редактировани</summary>
        public string OldId;

        /// <summary>Инициализирует объект данной формы</summary>
        /// <param name="library">Библиотека для проверки значений</param>
        public createEditForm(Library library)
        {
            InitializeComponent();
            OldId = "";
            buttonEditAdd.Text = "Добавить";
            this.Text = "Добавление нового элемента";
            newbook = new Book();
            _library = library;
        }

        /// <summary>Инициализирует объект данной формы для редактирования элемента</summary>
        /// <param name="library">Библиотека для сверения значений кода</param>
        /// <param name="book1">Первоначальная книга которую надо отредактировать</param>
        public createEditForm(Library library, Book book1)
        {
            InitializeComponent();
            newbook = book1;
            OldId = textBoxId.Text = book1._Id;
            textBoxName.Text = book1._Name;
            textBoxIdAuthor.Text = book1._Author;
            dateTimePicker1.Value =new DateTime(Convert.ToInt32( book1._Year),1,1);
            textBoxJenre.Text = book1._Jenre;
            numericUpDownCountBook.Value = book1._Count;
            buttonEditAdd.Text = "Редактировать";
            this.Text = "Редактирование элемента";
            _library = library;
        }

        /// <summary>Обрабока нажатия на конку данной формы</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonEditAdd_Click(object sender, EventArgs e)
        {
            string Id = Regex.Replace(textBoxId.Text, @"\s+", " ");
            string Name = Regex.Replace(textBoxName.Text, @"\s+", " ");
            string Author = Regex.Replace(textBoxIdAuthor.Text, @"\s+", " ");
            string Jenre = Regex.Replace(textBoxJenre.Text, @"\s+", " ");
            int Count = Convert.ToInt32(numericUpDownCountBook.Value);
            string Year = dateTimePicker1.Value.ToString("yyyy");
            if (Id == string.Empty || Name == string.Empty || Author == string.Empty || Jenre == string.Empty)
            {
                MessageBox.Show("Одно из полей не содержит данных", "Ошибка с значением");
                return;

            }
            if (Count < 0)
            {
                MessageBox.Show("Колличество книг не может быть меньше 0", "Ошибка с значением");
                return;
            }
            foreach(Book book in _library._books)
            {
                if(book._Id == Id&&Id!=OldId)
                {
                    MessageBox.Show("Книга с таким кодом уже есть в БД", "Ошибка с значением");
                    return;
                }
            }
            newbook = new Book(Id, Name, Author, Year, Jenre, Count);
            DialogResult = DialogResult.OK;
        }

        /// <summary>Обработка загрузки формы</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void createEditForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy";
            
        }
    }
}
