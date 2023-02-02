using JamshidTursunov.Massenger.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.Massenger.Classes
{
    internal class User : IUser
    {
        public List<User> contacts= new List<User>();
        // public Dictionary<User,string> chat = new Dictionary<User,string>();

*        public User(int passWord, string name, string number)
        {
            PassWord = passWord;
            Name = name;
            Number = number;
        }

        public int PassWord { get ; set ; }
        public string Username { get ; set ; }
        public int ID { get; set ; }
        public string Name { get ; set ; }
        public int Age { get; set ; }
        public int BirthPlace { get ; set ; }
        public string Number { get ; set ; }

        public void AddContact(User contact)
        {
            if (!contacts.Contains(contact))
            contacts.Add(contact);
            else Console.WriteLine("there is contact with already. ");
        }
        public void SendMessage(User contact, string message)
        {
            
             
            
        }

          
    }
}
