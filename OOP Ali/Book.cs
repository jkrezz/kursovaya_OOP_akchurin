using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ali
{

    /// <summary>Класс, хранящий информацию об книге</summary>
    public record Book
    (
        string _Id="",
        string _Name = "",
        string _Author = "",
        string _Year = "",
        string _Jenre = "",
        int _Count=0
    );


}
