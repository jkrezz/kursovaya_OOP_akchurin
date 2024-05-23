using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ali
{

    /// <summary>Основная форма с которой работает пользователь</summary>
    public partial class DataBaseBookForm : Form
    {

        /// <summary>База данных со всеми книгами</summary>
        private Library? _library;

        /// <summary>Возврвщвет библиотеку если она не равна null</summary>
        /// <returns>объект Librery или null</returns>
        public Library? GetLibrary()
        {
            return _library;
        }

        /// <summary>Инициализирует <see cref="DataBaseBookForm" /> класс.</summary>
        public DataBaseBookForm()
        {
            InitializeComponent();
            if (_library != null) UpdateDate();
            Block(_library == null ? true : false);
        }
        /// <summary>Инициализирует <see cref="DataBaseBookForm" /> класс.</summary>
        public DataBaseBookForm(Library? library)
        {
            InitializeComponent();
            _library = library;
            if (_library != null) UpdateDate();
            Block(_library == null ? true : false);
        }
        /// <summary>Обновляет данные в таблице БД</summary>
        private void UpdateDate()
        {
            if (_library == null) throw new NoNullAllowedException();
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (Book _book in _library._books)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                i++;
            }
        }

        /// <summary>Обновляет данные в таблице с учётом применённых фильтров</summary>
        /// <param name="parametr">Параметр фильтрации</param>
        /// <param name="value">Занчение для выода книг</param>
        private void UpdateDate(string parametr, string value)
        {
            if(_library==null)throw new NoNullAllowedException();
            dataGridView1.Rows.Clear();
            int i = 0;
            if (parametr == "Код книги")
                foreach (Book _book in _library._books)
                    if (_book._Id == value)
                    {

                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                        dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                        dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                        dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                        dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                        dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                        i++;
                    }
            if (parametr == "Название книги")
                foreach (Book _book in _library._books)
                    if (_book._Name == value)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                        dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                        dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                        dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                        dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                        dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                        i++;
                    }
            if (parametr == "Код автора")
                foreach (Book _book in _library._books)
                    if (_book._Author == value)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                        dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                        dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                        dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                        dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                        dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                        i++;
                    }
            if (parametr == "Год издания книги")
                foreach (Book _book in _library._books)
                    if (_book._Year == value)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                        dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                        dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                        dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                        dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                        dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                        i++;
                    }
            if (parametr == "Жанр книги")
                foreach (Book _book in _library._books)
                    if (_book._Jenre == value)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                        dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                        dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                        dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                        dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                        dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                        i++;
                    }
            if (parametr == "Колличесво книг")
                foreach (Book _book in _library._books)
                    if (_book._Count == Convert.ToInt32(value))
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = _book._Id;
                        dataGridView1.Rows[i].Cells[1].Value = _book._Name;
                        dataGridView1.Rows[i].Cells[2].Value = _book._Author;
                        dataGridView1.Rows[i].Cells[3].Value = _book._Year;
                        dataGridView1.Rows[i].Cells[4].Value = _book._Jenre;
                        dataGridView1.Rows[i].Cells[5].Value = _book._Count;
                        i++;
                    }
            if (i != 0)
                label1.Text = "Фильтр применен. Отображено " + i + " из " + _library._books.Count + " книг";
                //MessageBox.Show("Выведено" + i + " из " + _library._books.Count + " книг", "Фильтрация");


        }

        /// <summary>Открывает или закрывает пользователю доступ к интерфейсу</summary>
        /// <param name="value">если true интерфейс будт заблокирован</param>
        private void Block(bool value)
        {

            добавитьКнигуToolStripMenuItem.Enabled = !value;

            //dataGridView1.Rows.Clear();
            dataGridView1.Enabled = !value;
            открытьБазуДанныхToolStripMenuItem.Enabled = value;
            создатьБазуДанныхToolStripMenuItem.Enabled = value;
            удалитьТекущуюБазуДанныхToolStripMenuItem.Enabled = !value;
            сохранитьБазуДанныхToolStripMenuItem.Enabled = !value;
            редактироватьЭлементToolStripMenuItem.Enabled = (dataGridView1.CurrentCell != null) ? true : false;
            удалитьЭлементToolStripMenuItem.Enabled = (dataGridView1.CurrentCell != null) ? true : false;
            элементыToolStripMenuItem.Enabled = !value;
            фильтроватьToolStripMenuItem.Enabled = !value;
            переключитьсяНаИзменениеПользователейToolStripMenuItem.Enabled = !value;

        }



        /// <summary>Обрабатывает загрузку текущей формы</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Form2_Load(object sender, EventArgs e)
        {
            if(_library != null) UpdateDate();
            Block(_library == null ? true : false);

            openFileDialog1.Filter = String.Format(Library.fileName, Library.rash);
            openFileDialog1.DefaultExt = Library.rash;
            saveFileDialog1.Filter = String.Format(Library.fileName, Library.rash);
            saveFileDialog1.DefaultExt = Library.rash;
            очиститьФильтрToolStripMenuItem.Enabled = false;

            
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на добавитьэлементToolStripMenu.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void добавитьэлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            createEditForm createEditForm = new createEditForm(_library);
            createEditForm.FormClosing += (sender1, e1) =>
            {
                //Обновляем текстбокс основной формы
                if (createEditForm.DialogResult != DialogResult.Cancel)
                {

                    _library.Add(createEditForm.newbook);
                    UpdateDate();
                }

            };
            createEditForm.ShowDialog();
        }

        /// <summary>Получаем выбранную в таблице книгу</summary>
        /// <returns>book соответсвующее ввыбранной книги в таблице</returns>
        private Book GetBookFromDatagrid()
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string? Id = Convert.ToString(row.Cells[0].Value);
            string? Name = Convert.ToString(row.Cells[1].Value);
            string? Author = Convert.ToString(row.Cells[2].Value);
            string? Year = Convert.ToString(row.Cells[3].Value);
            string? Jenre = Convert.ToString(row.Cells[4].Value);
            int Count = Convert.ToInt32(row.Cells[5].Value);
            if (Id == null|| Name== null || Author == null || Year == null || Jenre == null) throw new NoNullAllowedException();
            Book book = new Book(Id,Name,Author,Year,Jenre,Count);

            //book._Id  = Convert.ToString(row.Cells[0].Value);
            //book._Name = Convert.ToString(row.Cells[1].Value);
            //book._Author = Convert.ToString(row.Cells[2].Value);
            //book._Year = Convert.ToString(row.Cells[3].Value);
            //book._Jenre = Convert.ToString(row.Cells[4].Value);
            //book._Count = Convert.ToInt32(row.Cells[5].Value);
            return book;
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на редактироватьЭлементToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void редактироватьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            createEditForm createEditForm = new createEditForm(_library, GetBookFromDatagrid());
            createEditForm.FormClosing += (sender1, e1) =>
            {
                //Обновляем текстбокс основной формы
                if (createEditForm.DialogResult == DialogResult.OK)
                {
                    _library.Edit(createEditForm.OldId, createEditForm.newbook);
                    UpdateDate();
                }

            };
            createEditForm.ShowDialog();
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на удалитьЭлементToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void удалитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();

            string? id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            if (id == null) throw new NoNullAllowedException();
            _library.RemoveBook(id);
            UpdateDate();
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на создатьБазуДанныхToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void создатьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _library = new Library();
            Block(false);
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на открытьБазуДанныхToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void открытьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            _library = new Library();
            try
            {
                _library.load(openFileDialog1.FileName);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Открыт неккоректный файл", "Ошибка");
                return;
            }
            Block(false);
            UpdateDate();
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на сохранитьБазуДанныхToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void сохранитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            _library.Save(saveFileDialog1.FileName);
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на удалитьТекущуюБазуДанныхToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void удалитьТекущуюБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Block(true);
        }

        /// <summary>Обрабатывает смену выбранной строки в dataGridView1 .</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            редактироватьЭлементToolStripMenuItem.Enabled = (dataGridView1.CurrentCell != null) ? true : false;
            удалитьЭлементToolStripMenuItem.Enabled = (dataGridView1.CurrentCell != null) ? true : false;
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на фильтроватьToolStripMenuItem1.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void фильтроватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            FiltForm filtForm = new FiltForm(_library);
            filtForm.FormClosing += (sender1, e1) =>
            {
                //Обновляем текстбокс основной формы
                if (filtForm.DialogResult != DialogResult.Cancel)
                {

                    UpdateDate(filtForm.parametr, filtForm.value);
                }

            };
            filtForm.Show();
            очиститьФильтрToolStripMenuItem.Enabled = true;
        }

        /// <summary>Обрабатывает нажатие пользователем нажати пользователем на очиститьФильтрToolStripMenuItem.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void очиститьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDate();
            очиститьФильтрToolStripMenuItem.Enabled = false;
            label1.Text = "";
        }

        private void переключитьсяНаИзменениеПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void DataBaseBookForm_FormClosing(object sender, EventArgs e)
        {
            if(DialogResult!=DialogResult.OK)
                Application.Exit();
        }
    }
}
