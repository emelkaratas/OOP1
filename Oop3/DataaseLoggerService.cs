using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DataaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");

        }
    }
}
