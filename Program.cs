using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Collections collection = new Collections();
            collection.CollectionArray();
            Console.WriteLine("---------");
            collection.flowersCategory();
            Console.ReadKey();
        }
    }
}
