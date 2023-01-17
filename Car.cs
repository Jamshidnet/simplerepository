using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    partial class Car: IGearBox
    {
        public void Name()
        {
            Console.WriteLine("my name is Jamshid. ");
        }
        

        public partial void CreateEngine();

        public partial void TestDrive()
        {
            Console.WriteLine("test drived. ");
        }
        public partial void CreateKuzov();
        public partial void Salon()
        {
            Console.WriteLine(" salon is ready. ");
        }
        public void Paint()
        {
            Console.WriteLine("we are painting car. ");
        }

    }
    partial class Car 
    {
        public void Soul()
        {
            Console.WriteLine(" this is in car. ");
        }
    
        public partial void TestDrive();

        public partial void CreateEngine()
        {
            Console.WriteLine("Engine created. ");
        }

        public partial void CreateKuzov()
        {
            Console.WriteLine("Kuzov created. ");
        }
        public partial void Salon();
        public void Wash()
        {
            Console.WriteLine("we are washing car. ");
        }

    }
    partial interface IGearBox
    {
        void Name();
    }
    partial interface IGearBox
    {
        void MyName()
        {
            Console.WriteLine(" this is interface. ");
        }

    }
    partial interface IAssembly
    {
        void MySoul();

    }
    partial interface IAssembly
    {
        void Soul()
        {
            Console.WriteLine(" this is from interface. ");
        }
    }
}
