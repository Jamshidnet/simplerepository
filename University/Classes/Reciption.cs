using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.University.Classes
{
    internal class Reciption
    {
        public static void ReciptionWindow()
        {
            List<University> universities = new List<University>();

            universities.Add(new University("UzMU", "Olamzor", 3, new string[8] { "fac1", "fac2", "fac3", "fac4", "fac5", "fac6", "fac7", "fac8" },100));
            universities.Add(new University("Word Languages", "Chilonzor", 4, new string[6] { "fac3", "fac4", "fac5", "fac6", "fac7", "fac8" },120));
            universities.Add(new University("TATU", "Yunosobod", 2, new string[8] { "fac1", "fac2", "fac3", "fac4", "fac5", "fac6", "fac7", "fac8" },130));
            universities.Add(new University("Ona-tili va adabiyot", "Chilonzor", 5, new string[7] { "fac2", "fac3", "fac4", "fac5", "fac6", "fac7", "fac8" },90));
            universities.Add(new University("PDP university", "Sergeli", 1, new string[4] { "fac5", "fac6", "fac7", "fac8" },200));
            universities.Add(new University("Narxoz", "Olamzor", 10, new string[9] { "fac", "fac1", "fac2", "fac3", "fac4", "fac5", "fac6", "fac7", "fac8" },140));

            List<Account> accounts = new();
            List<Student> students = new();
            Console.WriteLine("     WELCOME TO ONLINE RECIPTION WEB-SITE FOR UNIVERSITIES");
        Menu:
            Console.Clear();
            Console.WriteLine("       Here are the list of Universities. ");
                int i = 1;
            foreach (var item in universities)
            {
                Console.WriteLine(i+">>  "+item.Name);
                i++;
            } i--;
            Console.Write("choose any preferred one to get information =>");
            int number = int.Parse(Console.ReadLine()); number--;
            Console.WriteLine("University name =>"+universities[number].Name);
            Console.WriteLine("University Rate =>"+universities[number].Rate);
            Console.WriteLine("University Destination =>"+universities[number].Destination);
            Console.WriteLine("University pass sore =>" + universities[number].DeadLineScore);
            foreach (var item in universities[number].Faculties)
            {
                Console.WriteLine("   "+item);
            }
            Console.WriteLine("registrated students' names");
            if (students.Count == 0)
                Console.WriteLine("there is no yet any student registrated. ");
            else
            {
                foreach (var item in students)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine(" \n Do you want to handle your account to this university? ");
            Console.WriteLine("1>> yes");
            Console.WriteLine("2>> no");
            i=int.Parse(Console.ReadLine());
            if (i == 1)
            {
                Console.Write("INput your name =>");
                string name = Console.ReadLine();
                Console.Write("Input Passport seria and NUmber =>");
                string passpord=Console.ReadLine();
                Console.Write("Input your diploma number =>");
                int pass = int.Parse(Console.ReadLine());
                Console.Write("Input your score =>");
                int score=int.Parse(Console.ReadLine());
                if (score >= universities[number].DeadLineScore)
                {
                    accounts.Add(new Account(passpord, pass));
                    students.Add(new Student(name, universities[number], accounts.Last()));
                    Console.WriteLine("You have succesfully registrated. ");
                }
                else Console.WriteLine("your score is not enough. ");
                Console.WriteLine("press enter to go to menyu");
                Console.ReadKey();
                goto Menu;
            }
            else
            {

                Console.WriteLine("press enter to go to menyu");
                Console.ReadKey();
                goto Menu;
            }
        }




    }
}
