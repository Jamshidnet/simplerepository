using JamshidTursunov.University.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Classes
{
    internal class Account : IAccount
    {
        public int ID { get ; set ; }
        public string AccountNumber { get ; set ; }
        public string PaspordSeriaNumber { get ; set ; }
        public int DiplomaNumber { get ; set ; }
        public int Password { get ; set ; }

        public Account(string paspordSeriaNumber, int diplomaNumber)
        {
            PaspordSeriaNumber = paspordSeriaNumber;
            DiplomaNumber = diplomaNumber;
        }
    }
}
