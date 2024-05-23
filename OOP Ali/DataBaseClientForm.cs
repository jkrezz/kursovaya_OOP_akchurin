using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OOP_Ali
{
    public partial class DataBaseClientForm : Form
    {
        Library? _library;
        /// <summary>Инициализирует объект <see cref="DataBaseClientForm" /> .</summary>
        public DataBaseClientForm()
        {
            InitializeComponent();
            Block(true);
        }

        /// <summary>Инициализирует объект <see cref="DataBaseClientForm" /> .</summary>
        /// <param name="library">База данных</param>
        public DataBaseClientForm(Library library)
        {
            InitializeComponent();
            _library = library;
            Block(false);
        }
        /// <summary>Открывает или закрывает пользователю доступ к интерфейсу</summary>
        /// <param name="value">если true интерфейс будт заблокирован</param>
        private void Block(bool value)
        {

            добавитьКнигуToolStripMenuItem.Enabled = !value;

            dataGridView1.Rows.Clear();
            dataGridView1.Enabled = !value;
            открытьБазуДанныхToolStripMenuItem.Enabled = value;
            создатьБазуДанныхToolStripMenuItem.Enabled = value;
            удалитьТекущуюБазуДанныхToolStripMenuItem.Enabled = !value;
            сохранитьБазуДанныхToolStripMenuItem.Enabled = !value;
            редактироватьЭлементToolStripMenuItem.Enabled = (dataGridView1.CurrentCell != null) ? true : false;
            удалитьЭлементToolStripMenuItem.Enabled = (dataGridView1.CurrentCell != null) ? true : false;
            элементыToolStripMenuItem.Enabled = !value;
            переключитьсяНаИзменениеПользователейToolStripMenuItem.Enabled = !value;
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
        /// <summary>Обновляет данные в таблице БД</summary>
        private void UpdateDate()
        {
            if (_library == null) throw new NoNullAllowedException();
            dataGridView1.Rows.Clear();
            foreach (Client client in _library._clients)
            {
                dataGridView1.Rows.Add(client._name);
                //dataGridView1.Rows[i++].Cells[0].Value = client._name;
            }
            //dataGridView1_SelectionChanged(sender, e);
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
            dataGridView2.Rows.Clear();
            Block(true);
        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            AddEditClientForm createEditForm = new AddEditClientForm(_library);
            createEditForm.FormClosing += (sender1, e1) =>
            {
                if (createEditForm.DialogResult != DialogResult.Cancel)
                {
                    Client? client = createEditForm.GetClients();
                    if (client == null) throw new NoNullAllowedException();
                    _library.Add(client);
                    UpdateDate();
                }

            };
            createEditForm.ShowDialog();
        }
        private Client GetSelectedClient()
        {
            if (_library == null) throw new NoNullAllowedException();
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            foreach (Client client in _library._clients)
            {
                if (client._name == Convert.ToString(row.Cells[0].Value))
                {
                    return client;
                }
            }
            throw new Exception("No Find Element");
        }

        private void редактироватьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            AddEditClientForm createEditForm = new AddEditClientForm(_library, GetSelectedClient());
            createEditForm.FormClosing += (sender1, e1) =>
            {
                if (createEditForm.DialogResult == DialogResult.OK)
                {
                    Client? tmpbook = createEditForm.GetClients();
                    if (tmpbook == null) throw new NoNullAllowedException();
                    _library.Edit(createEditForm.GetOldName(), tmpbook);
                    UpdateDate();
                }

            };
            createEditForm.ShowDialog();
        }

        private void удалитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            if (dataGridView1.CurrentCell != null)
            {
                foreach (Client client in _library._clients)
                {
                    string? value = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                    if (value == null) continue;
                    if (client._name != null && client._name == value)
                    {
                        _library.RemoveClient(client._name);
                        UpdateDate();
                        dataGridView1_SelectionChanged(sender, e);
                        return;
                    }

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (_library == null) throw new NoNullAllowedException();
            if (dataGridView1.CurrentCell != null)
            {
                dataGridView2.Rows.Clear();
                редактироватьЭлементToolStripMenuItem.Enabled = true;
                удалитьЭлементToolStripMenuItem.Enabled= true;
                foreach (Client client in _library._clients)
                {
                    string? value = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                    if (value == null) continue;
                    int j = 0;
                    if (client._name != null && client._name == value)
                    {
                        foreach (GettedBook gettedBook in client._gettedBooks)
                        {
                            dataGridView2.Rows.Add(1);
                            var tmp = dataGridView2.Rows[j++].Cells;
                            tmp[0].Value = gettedBook._id;
                            tmp[1].Value = gettedBook._dateOfTake;
                            tmp[2].Value = gettedBook._dateOfDelivered;
                        }
                        return;
                    }

                }
            }
            else
            {
                редактироватьЭлементToolStripMenuItem.Enabled = false;
                удалитьЭлементToolStripMenuItem.Enabled = false;
            }
        }

        private void переключитьсяНаИзменениеПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DataBaseBookForm newForm = new DataBaseBookForm(_library);
            newForm.FormClosing += (sender1, e1) =>
            {
                if (newForm.DialogResult == DialogResult.OK)
                {
                    Library? tmp = newForm.GetLibrary();
                    if (tmp != null)
                    {
                        Block(false);
                    }

                    _library =tmp;
                    UpdateDate();
                }

            };

            newForm.ShowDialog();
            Show();
        }

        private void DataBaseClientForm_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = String.Format(Library.fileName, Library.rash);
            openFileDialog1.DefaultExt = Library.rash;
            saveFileDialog1.Filter = String.Format(Library.fileName, Library.rash);
            saveFileDialog1.DefaultExt = Library.rash;
            var tmpForm = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(10)).ContinueWith((t) => tmpForm.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            MessageBox.Show(tmpForm,"Автор: Акчурин Али\nТема: «Библиотека»", "Курсовой проект");
        }
    }
}
