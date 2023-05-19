using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    //bir tane işlem mesajı olsun, bir tane kullanıcıyı bilgilendirmek için bir mesaj olsun
    public interface IResullt
    {
        bool Success { get; }//get: sadece okunabilir.
        string Message { get; }
    }
}
