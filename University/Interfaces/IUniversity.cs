using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Interfaces
{
    internal interface IUniversity
    {
        public int ID { get; set; }
        
        public string Name { get; set; }

        public string Destination { get; set; }

        public int FacultyNumbers { get; set; }


        public int Rate { get; set; }

        public void Teach();

        public void GiveCertificate();
    }
}
