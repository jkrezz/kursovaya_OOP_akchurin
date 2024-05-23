using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ali
{
    /// <summary>
    ///   <para>Класс хранящий информацио о клиентах</para>
    /// </summary>
    public record Client
    (
        string _name,
        List<GettedBook> _gettedBooks
    );
}
