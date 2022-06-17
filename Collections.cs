using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHandsOn
{
    internal class Collections
    {
        private int[] values = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private string[] names = new string[4] { "Aditya", "Akshat", "Ayush", "Prashant" };
        private bool[] TureFalse = new bool[10]
         {
                true,false,true,false,true,false,true,false,true,false
         };
        public void CollectionArray()
        {
            Console.WriteLine("The Value of the array is");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine("The names of the  Array is ");
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.WriteLine(" Ture False option");
            for (int i = 0; i < TureFalse.Length; i++)
            {
                Console.WriteLine(TureFalse[i]);
            }

        }
        public void flowersCategory()
        {
            List<string> flowerType= new List<string>();
            flowerType.Add("Rose");
            flowerType.Add("Sunflower");
            flowerType.Add("Lily");
            flowerType.Add("Tulips");
            flowerType.Add("Marigold");
            flowerType.Add("Daisy");
            flowerType.Add("Aster");
            flowerType.Add("Hibiscus");
            Console.WriteLine("Different types of flowers");
            foreach (string name in flowerType)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("The length of Categories of flowers List: {0}", flowerType.Count);

            Console.WriteLine("Third flower is : {0}", flowerType[2]);
            Console.WriteLine("Remove third flowertype");
            flowerType.RemoveAt(2);
            Console.WriteLine("Length of flowers category list after removing third flower");
            Console.WriteLine("length:{0}", flowerType.Count);



        }

    }
}

