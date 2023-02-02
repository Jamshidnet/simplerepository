using JamshidTursunov.Massenger.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.Massenger
{
    internal class MassangerClass
    {
        public static void MainMassanger()
        {


            User FirstUser = new User(1234, "Abror", "991231212");
            User SecondUser = new User(2345, "Sardor", "991233434");
            

            FirstUser.AddContact(SecondUser);
            SecondUser.AddContact(FirstUser);

            FirstUser.SendMessage(SecondUser, "319 ga keling. ");
            foreach (var item in SecondUser.chat)
            {
                Console.WriteLine(item);
            }
             




        }


    }
}
