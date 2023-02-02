using JamshidTursunov.University.Interfaces;
using JamshidTursunov.University.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Classes
{
    internal class  University : IUniversity
    {
       public  string[]  Faculties;
        public University(string name, string destination, int rate, string[] faculties,int score)
        {
            Name = name;
            Destination = destination;
            Rate = rate;
           Faculties = faculties;
            DeadLineScore=score;
        }
        public int DeadLineScore { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        public int FacultyNumbers { get; set; }
        public int Rate { get; set; }

        public void GiveCertificate()
        {
            Console.WriteLine("they give certificate. ");
        }

        public void Teach()
        {
            Console.WriteLine(" University teaches. ");
        }


    }
}