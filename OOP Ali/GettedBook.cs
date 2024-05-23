using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ali
{
    /// <summary>Класс обозначающий взятую книгу</summary>
    public record GettedBook
    (
        string _id ="",
        string _dateOfTake = "",
         string _dateOfDelivered= ""

    );
}
