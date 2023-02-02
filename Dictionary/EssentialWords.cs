using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamshidTursunov.Dictionary
{
    internal class EssentialWords
    {
        Dictionary<string,string> Essential=new Dictionary<string,string>();
        public void Create(string keyy,string valuee)
        {
            Essential.Add(keyy, valuee);

        }
        public void Read(string keyy)
        {
            Console.WriteLine(Essential[keyy]);
        }
        public void Update(string keyy, string valuee)
        {
            Essential[keyy] = valuee;

        }

        public void Delete(string key)
        {
            Essential.Remove(key);

        }

    }
}
