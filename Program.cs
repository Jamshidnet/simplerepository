namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operator overlaoding
            //NewClasss namee = new NewClasss(23, 32);
            //NewClasss namee2 = new NewClasss(13, 31);
            //NewClasss namee3 = new NewClasss(11, 11);
            //namee--;
            //namee.Print();
            //namee++;
            //namee.Print();
            //namee3 = namee + namee2;
            //namee3.Print();
            //namee3 = namee >= namee2;
            //namee3.Print();
            //namee3 = namee <= namee2;
            //namee3.Print();
            //namee3 = namee / namee2;
            //namee3.Print();
            //Console.WriteLine(namee.ToString());
            //// Console.WriteLine(namee.Equals());
            //Console.WriteLine(namee.GetHashCode());
            #endregion


            #region nasted classes
            //Creature.Humans.Male creature = new Creature.Humans.Male();
            //Console.WriteLine(creature.AvarageMarriageAge);
            //Creature.Animal.Fishes newFish = new Creature.Animal.Fishes();
            //Console.WriteLine(newFish.MaxDeepScore);
            //Creature.Plants plant1 = new Creature.Plants();
            //Console.WriteLine(plant1.waterCapacity);
            #endregion


            #region partial classes & methods
            IGearBox obj1 = new Car();
            obj1.MyName();
            Car obj2 = new Car();
            obj2.Soul();
            #endregion

        }
    }




}