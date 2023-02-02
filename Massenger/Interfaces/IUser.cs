using JamshidTursunov.Massenger.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.Massenger.Interfaces
{
    interface IUser :IPerson
    {

       
        public int PassWord { get; set; }

        public string Username { get; set; }

        void SendMessage(User contact, string message);


    }
}
