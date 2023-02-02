using JamshidTursunov.University.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Interfaces
{
    internal interface IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthPLace { get; set; }

        public Gender gender { get; set; }

        public void Priority(Priorityy priority);


    }
}
