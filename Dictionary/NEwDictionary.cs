namespace JamshidTursunov.Dictionary
{

    internal class NEwDictionary
    {
        public static void Dictionaryy()
        {
            Dictionary<string, string> MyDictionary = new Dictionary<string, string>()
            {
                ["Linguistic"] = "Tilchi",
                ["Priority"] = "Eng muhim narsa",
                ["Desctop"] = "Kompyuter",
                ["Windows"] = "Oynalar",
                ["Temple"] = "Minora",
                ["Life"] = "Hayot",
                ["Station"] = "Vokzal",
                ["Programming"] = "Dasturlash",
            };
            Dictionary<string, string> UzbDictionary = new Dictionary<string, string>()
            {
                ["Tilchi"] = "Linguistic",
                ["Eng muhim narsa"] = "Priority",
                ["Kompyuter"] = "Computer",
                ["Oynalar"] = "Windows",
                ["Minora"] = "Temple",
                ["Hayot"] = "Life",
                ["Vokzal"] = "Station",
                ["Dasturlash"] = "Programming",

            };

        Menyu:
            Console.Clear();
            Console.WriteLine("  ====WELCOME TO MY DICTIONARY===");
            Console.WriteLine("     Here you can find the translation of any word in english and uzbek languages");
            Console.WriteLine("Choose the preferred one. ");
            Console.WriteLine(" 1--> English => Uzbek");
            Console.WriteLine(" 2--> Uzbek => English");
            Console.WriteLine(" 3--> Do you want to add new word to our DIctionary");
          //  Console.WriteLine(" 4--> Want to work with Essential words");
            int number = int.Parse(Console.ReadLine());
            string? input;
            switch (number)
            {
                case 1:
                    Console.Write(" Input the word: ");
                   input = Console.ReadLine();
                    if (!MyDictionary.ContainsKey(input))
                        Console.WriteLine("there is no this word in our Data base. ");
                    else Console.WriteLine("Translation => "+MyDictionary[input]);
                    Console.WriteLine("Press Enter to go to Menyu: ");
                    Console.ReadKey();
                    goto Menyu;
                    break;


                case 2:
                    Console.Write(" Input the word in uzbek language : ");
                    input = Console.ReadLine();
                    if (!UzbDictionary.ContainsKey(input))
                        Console.WriteLine("there is no this word in our Data base. ");
                    else Console.WriteLine("Translation => " + UzbDictionary[input]);
                    Console.WriteLine("Press Enter to go to Menyu: ");
                    Console.ReadKey();
                    goto Menyu;

                    break;

                case 3:
                    string input2;
                    Console.Write("input in english: ");
                    input = Console.ReadLine();
                    Console.Write("input in uzbek: ");
                    input2 = Console.ReadLine();
                    MyDictionary.Add(input, input2);
                    UzbDictionary.Add(input2, input);
                    Console.WriteLine("Press Enter to go to Menyu: ");
                    Console.ReadKey();
                    goto Menyu;

                    break;

                //case 4:
                //    Console.WriteLine("1--> Create");
                //    Console.WriteLine("2--> Update");
                //    Console.WriteLine("3--> Read");
                //    Console.WriteLine("4--> Delete");
                //    number = int.Parse(Console.ReadLine());
                //    switch(number)
                //    {
                //        case 1:


                //            break;



                //    }

            }




        }


    }
}
