using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.Massenger.Interfaces
{
    interface  IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int BirthPlace { get; set; }
        public string  Number { get; set; }

    }
}
