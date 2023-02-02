using JamshidTursunov.University.Interfaces;
using JamshidTursunov.University.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Classes
{
    internal class Student : IPerson
    {

        public int ID { get; set; }
        public string Name { get ; set ; }
        public int Age { get ; set ; }
        public string BirthPLace { get ; set ; }
        public Gender gender { get ; set ; }

        public University university { get; set; }
        public int Score;

        public Student(string name, University university, Account account)
        {
            Name = name;
            this.university = university;
            this.account = account;
        }

        public Account account { get; set;  }
        public Majors major { get; set; }
        public void Priority(Priorityy priority)
        {
            Console.WriteLine("priority of thi student is" + Priorityy.study);

        }

        public void Study()
        {
            Console.WriteLine("YOU MUST STUDY! ");
        }
    }
}
