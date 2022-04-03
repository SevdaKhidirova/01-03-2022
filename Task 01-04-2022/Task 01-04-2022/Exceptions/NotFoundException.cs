using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01_04_2022.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException():base("Not Found ex")
        {}
        public NotFoundException(string message):base(message)
        {}
    }
}
