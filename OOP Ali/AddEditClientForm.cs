using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ali
{

    /// <summary>Форма для редактирования и добавления клиентов</summary>
    public partial class AddEditClientForm : Form
    {
        private Library _library;
        /// <summary>Клиент созданный или редактированный в данной форме</summary>
        private Client? _newClient;

        private List<GettedBook> _books;

        /// <summary>Возвращет созданного редактированного клиента</summary>
        /// <returns>созданный\ редактированный клиента</returns>
        public Client? GetClients()
        {
            return _newClient;
        }

        /// <summary>Старое имя клиента</summary>
        private string? _oldName;

        /// <summary>Возвразщает старое имя клиента</summary>
        /// <returns>старое имя клиента</returns>
        public string GetOldName()
        {
            if (_oldName == null) return "";
            return _oldName;
        }

        /// <summary> Инициализирует объект <see cref="AddEditClientForm" /> .</summary>
        /// <param name="library">База данных</param>
        public AddEditClientForm(Library library)
        {
            InitializeComponent();
            _library = library;
            int j = 0;
            foreach (Book book1 in _library._books)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[j].Cells[0].Value = book1._Id;
                dataGridView1.Rows[j].Cells[1].Value = book1._Name;
                dataGridView1.Rows[j].Cells[2].Value = book1._Author;
                dataGridView1.Rows[j++].Cells[3].Value = book1._Year;
            }
            _books = new List<GettedBook>();
            Text = "Добавить";
            buttonAddEdit.Text = "Добавить";
        }
        /// <summary> Инициализирует объект <see cref="AddEditClientForm" /> .</summary>
        /// <param name="library">База данных</param>
        /// /// <param name="client">Клиен для редактирования</param>
        public AddEditClientForm(Library library, Client client)
        {

            InitializeComponent();
            _library = library;
            _newClient = client;
            _oldName = client._name;
            _books = client._gettedBooks;
            int j = 0;
            foreach (Book book1 in _library._books)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[j].Cells[0].Value = book1._Id;
                dataGridView1.Rows[j].Cells[1].Value = book1._Name;
                dataGridView1.Rows[j].Cells[2].Value = book1._Author;
                dataGridView1.Rows[j++].Cells[3].Value = book1._Year;
            }
            textBoxNameClient.Text = client._name;
            buttonAddEdit.Text = Text = "Редактировать";
            UpdateDate();

        }
        private void UpdateDate()
        {
            if (_books != null)
            {
                dataGridView2.Rows.Clear();
                int i = 0;
                foreach (var book in _books)
                {
                    dataGridView2.Rows.Add(1);
                    dataGridView2.Rows[i].Cells[0].Value = book._id;
                    dataGridView2.Rows[i].Cells[1].Value = book._dateOfTake;
                    dataGridView2.Rows[i++].Cells[2].Value = book._dateOfDelivered;
                }
            }
        }
        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            string Name = Regex.Replace(textBoxNameClient.Text, @"\s+", " ");
            if (Name != _oldName)
                foreach (Client client in _library._clients)
                {
                    if (Name == client._name)
                    {
                        MessageBox.Show("Клиент с таким именем уже есть в БД", "Ошибка с значением");
                        return;
                    }
                }

            _newClient = new Client(Name, _books);
            DialogResult = DialogResult.OK;
        }

        private void buttonAddBookToClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                string? val = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                if (val == null) throw new NoNullAllowedException();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value.ToString() == val)
                    {
                        MessageBox.Show("Книга с выбранный кодом уже есть в книгах клиента", "Ошибка с значением");
                        return;
                    }
                }
                var dateTaken = dateTimePickerDateOfTaken.Value.ToString("dd-MM-yyyy");
                var dateDeclaim = dateTimePickerDateOfDeclaimed.Value.ToString("dd-MM-yyyy");
                if (dateTimePickerDateOfTaken.Value >= dateTimePickerDateOfDeclaimed.Value)
                {
                    MessageBox.Show("Дата взятия книги позже или равна дате когда надо вернуть", "Ошибка с значением");
                    return;
                }
                _books.Add(new GettedBook(val, dateTaken, dateDeclaim));
                UpdateDate();
            }
            else
            {
                MessageBox.Show("Книга для добавления не выбрана", "Ошибка с значением");
                return;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2 != null)
            {
                foreach (GettedBook book in _books)
                {
                    string? tm = Convert.ToString(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value);
                    if (tm == null) throw new ArgumentNullException();
                    string tmp = Regex.Replace(tm, @"\s+", " ");
                    if (book._id == tmp)
                    {
                        _books.Remove(book);
                        UpdateDate();
                        dataGridView2_SelectionChanged(sender, e);
                        return;
                    }
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = (dataGridView2.CurrentCell == null) ? false : true;
        }

        private void AddEditClientForm_Load(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
        }
    }
}
