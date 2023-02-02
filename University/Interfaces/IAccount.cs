using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Interfaces
{
    internal interface IAccount
    {
        public int ID { get; set; }

        public string AccountNumber { get; set; }

        public string PaspordSeriaNumber { get; set; }
        public int DiplomaNumber { get; set; }  

        public int Password { get; set; }
    }
}
