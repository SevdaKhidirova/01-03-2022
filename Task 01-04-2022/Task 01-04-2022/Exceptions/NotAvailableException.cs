using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01_04_2022.Exceptions
{
    class NotAvailableException:Exception
    {
        public NotAvailableException():base("Not aviable")
        {}
        public NotAvailableException(string message):base(message)
        {}
    }
}
