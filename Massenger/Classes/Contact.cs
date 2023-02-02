using JamshidTursunov.Massenger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.Massenger.Classes
{
    public class Contact : IContact
    {

        public List<string> chat = new List<string>();

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public int ID { get ; set ; }
        public string Name { get ; set ; }
        public string Number { get ; set ; }


    }
}
