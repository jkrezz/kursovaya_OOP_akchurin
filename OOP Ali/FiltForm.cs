using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ali
{

    /// <summary>Форма для настройки фильтров на главной форме</summary>
    public partial class FiltForm : Form
    {

        /// <summary>Библиотека для получения полей фильтрации</summary>
        private Library _library;

        /// <summary>Параметр по которому будет осуществлена фильтрация</summary>
        public string parametr = "";

        /// <summary>Значение которое должно быть отображено</summary>
        public string value = "";

        /// <summary>Инициализирует форму</summary>
        /// <param name="library">библиотека для получения значений</param>
        public FiltForm(Library library)
        {
            InitializeComponent();
            _library = library;
        }

        /// <summary>Обрабатывет загрузку текущий формы</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FiltForm_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            buttonFilt.Enabled = false;
        }

        /// <summary>Обрабатывает нажатие кнопки на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonFilt_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Одно из полей не содержит данных", "Ошибка с значением");
                return;
            }
            parametr = comboBox1.Text;
            value = comboBox2.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>Обрабтывает смену индекса в comboBox1</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox2.Enabled = true;
            parametr = comboBox1.Text;
            if (parametr == "Код книги")
                foreach (Book _book in _library._books)
                    if (!comboBox2.Items.Contains(_book._Id))
                    {
                        comboBox2.Items.Add(_book._Id);
                    }
            if (parametr == "Название книги")
                foreach (Book _book in _library._books)
                    if (!comboBox2.Items.Contains(_book._Name))
                    {
                        comboBox2.Items.Add(_book._Name);
                    }
            if (parametr == "Код автора")
                foreach (Book _book in _library._books)
                    if (!comboBox2.Items.Contains(_book._Author))
                    {
                        comboBox2.Items.Add(_book._Author);
                    }
            if (parametr == "Год издания книги")
                foreach (Book _book in _library._books)
                    if (!comboBox2.Items.Contains(_book._Year))
                    {
                        comboBox2.Items.Add(_book._Year);

                    }
            if (parametr == "Жанр книги")
                foreach (Book _book in _library._books)
                    if (!comboBox2.Items.Contains(_book._Jenre))
                    {
                        comboBox2.Items.Add(_book._Jenre);

                    }
            if (parametr == "Колличесво книг")
                foreach (Book _book in _library._books)
                    if (!comboBox2.Items.Contains(_book._Count))
                    {
                        comboBox2.Items.Add(_book._Count);
                    }

        }

        /// <summary>Обрабатывает смену индекса в combobox2</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex != -1) { buttonFilt.Enabled=true; }
        }
    }



}
