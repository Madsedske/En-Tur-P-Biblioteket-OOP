using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Tur_På_Biblioteket_OOP
{
    class Books
    {
        public Books(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public string Name { get; set; }


        public int Stock { get; set; }

    }
}
