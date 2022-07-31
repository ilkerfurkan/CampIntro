using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        //İmzanın aynı olduğu ama içerisinin farklı olduğu durumlarda biz base'de oluşturduğumuz classı interface olarak oluştururuz.
        //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

        void Calculate();
        void DoSomething();

    }
}
