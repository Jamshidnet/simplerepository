using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
     class NewClasss
    {
        public  int x;
        public  int y;

        public NewClasss(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public NewClasss()
        {

        }
        public static NewClasss operator --(NewClasss obj1)
        {

            obj1.x--;
            obj1.y--;
            return obj1;
        }
        public static NewClasss operator ++(NewClasss obj1)
        {
            obj1.x++;
            obj1.y++;
            return obj1;
        }
        public static NewClasss operator +(NewClasss obj1, NewClasss obj2)
        {
            NewClasss newclass = new NewClasss()
            {
                y = obj1.y + obj2.y,
                x = obj1.x + obj2.x,

        };
            return newclass; 
        }
        
        public static NewClasss operator /(NewClasss obj1,NewClasss obj2)
        {
            NewClasss newclass = new NewClasss()
            {
                x = obj1.x / obj1.x,
                y = obj2.y / obj2.y

            };
            return newclass;

        }
        
        public static NewClasss operator <=(NewClasss obj1, NewClasss obj2)
        {
            NewClasss newclass = new NewClasss();
            if (obj1.x <= obj2.x) newclass.x = obj1.x;
            else newclass.x=obj2.x;
            if (obj1.y <= obj2.y) newclass.y = obj1.y;
            else newclass.y=obj2.y;
            return newclass;
        }
        public static NewClasss operator >=(NewClasss obj1, NewClasss obj2)
        {
            NewClasss newclass = new NewClasss();
            if (obj1.x >= obj2.x) newclass.x = obj1.x;
            else newclass.x=obj2.x;
            if (obj1.y >= obj2.y) newclass.y = obj1.y;
            else newclass.y=obj2.y;
            return newclass; 
        }
        public override string ToString()
        {
            return $" x= {x}, y={y}";
        }
        
        
        
        public override int GetHashCode()
        {
            return GetHashCode();
        }
        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

    }
}
