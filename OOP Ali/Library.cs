using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOP_Ali
{
    /// <summary>
    ///   <para>Класс содержащий Баззу данных библиотеки</para>
    /// </summary>
    public class Library
    {

        /// <summary>Данные базы данных</summary>
        public List<Book> _books;

        /// <summary>Данные о клиентах</summary>
        public List<Client> _clients;

        /// <summary>Расширение сохранённого или загруженного файла</summary>
        public static string rash = ".Books";

        /// <summary>Отображаемое название файла с текущим расширением</summary>
        public static string fileName = "База данных книг|*{0}";

        /// <summary>Инициализирует пустую базу данных в виде объекта класса Library</summary>
        public Library() 
        { 
            _books = new List<Book>();
            _clients = new List<Client>();
        }

        /// <summary>Загружает данные из файла и записывает их  в <see cref="_books" /></summary>
        /// <param name="path">Путь к файлу</param>
        public void load(string path)
        {

            TextReader? reader = null;
            try
            {
                reader = new StreamReader(path);
                if (reader == null) throw new ArgumentNullException();
                string? tmpLineBook = reader.ReadLine();
                string? tmpLineClient = reader.ReadLine();
                if (tmpLineBook == null||tmpLineClient == null) throw new ArgumentNullException();
                List<Book>?  books = JsonSerializer.Deserialize<List<Book>> (tmpLineBook);
                List<Client>? clients = JsonSerializer.Deserialize<List<Client>>(tmpLineClient);
                if (books == null || clients == null) throw new ArgumentNullException();
                _books = books;
                _clients = clients;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <summary>Сохраняет данные из <see cref="_books" /> в файл по заданному пути</summary>
        /// <param name="path">Путь к файлу</param>
        public void Save(string path)
        {
            //var objects = new { Books = _books, Clients = _clients };

            TextWriter? writer = null;
            try
            {

                //var serializer = new XmlSerializer(typeof());
                var books = JsonSerializer.Serialize(_books,Context.Default.ListBook);
                var clients = JsonSerializer.Serialize(_clients, Context.Default.ListClient);
                writer = new StreamWriter(path);
                writer.Write(books + "\n" + clients);
                //serializer.Serialize(writer, _books);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>Добавляет новую книгу в <see cref="_books" /></summary>
        /// <param name="book">книга для добавления</param>
        public void Add(Book book)
        {
            _books.Add(book);
        }
        /// <summary>Добавляет нового клиента в <see cref="_clients" /></summary>
        /// <param name="client">Клиент для добавления</param>
        public void Add(Client client)
        {
            _clients.Add(client);
        }
        /// <summary>Убирает книгу с выбранным кодом книги из <see cref="_books" /></summary>
        /// <param name="id">Код книги которую  надо убрать</param>
        public void RemoveBook(string id) 
        {

            foreach (Book book in _books)
            {
                if (book._Id == id) 
                { 
                    _books.Remove(book);
                    return;
                }

            }
        }
        /// <summary>Убирает книгу с выбранным кодом книги из <see cref="_books" /></summary>
        /// <param name="id">Код книги которую  надо убрать</param>
        public void RemoveClient(string id)
        {

            foreach (Client client in _clients)
            {
                if (client._name == id)
                {
                    _clients.Remove(client);
                    return;
                }

            }
        }

        /// <summary>Редактирует книгу с выбранным кодом книги в <see cref="_books" />, заменяя её данные на данные объекта класса <see cref="Book" /></summary>
        /// <param name="id">Код книги для редактирования</param>
        /// <param name="tmpbook">Новые данные для записи</param>
        public void Edit(string id,Book tmpbook)
        {
            foreach (Book book in _books)
            {
                if (book._Id == id)
                {
                    _books.Remove(book);
                    _books.Add(tmpbook);
                    return;
                }

            }
        }
        /// <summary>Редактирует клиента с выбранным именем в <see cref="_clients" />, заменяя её на  объект класса <see cref="Client" /></summary>
        /// <param name="name">Код книги для редактирования</param>
        /// <param name="tmpbook">Новые данные для записи</param>
        public void Edit(string name, Client tmpbook)
        {
            foreach (Client client in _clients)
            {
                if (client._name == name)
                {
                    _clients.Remove(client);
                    _clients.Add(tmpbook);

                    return;
                }

            }
        }
    }
    [JsonSerializable(typeof(List<Book>))]
    [JsonSerializable(typeof(List<Client>))]
    [JsonSerializable(typeof(List<GettedBook>))]
    internal partial class Context : JsonSerializerContext
    {
    }
}
