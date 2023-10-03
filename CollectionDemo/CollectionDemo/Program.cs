using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1--> Enter List Demo");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your choice " +
                    "1--> List Demo" +
                    "2--> Array Demoo"+ "3--> TwoDimensionArray"+"4-->ArrayList"
                    +"5--> DictionaryDemo");
                int number =int.Parse(Console.ReadLine());
                switch(number)
                {
                    case 0:
                        flag = false;
                        break;
                        case 1:
                        ListDemo listDemo1 = new ListDemo();
                        listDemo1.Lists();
                        break;
                        case 2:
                        ArrayDemo arrayDemo = new ArrayDemo();
                        arrayDemo.Addlement();
                        break;
                    case 3:
                        TwoDimensionalArray twodiArr = new TwoDimensionalArray();
                        twodiArr.TwoDimensionArray();
                        break;
                        case 4:
                        ArrayLists arrayLists = new ArrayLists();
                        arrayLists.Arraylist();
                        break;
                    case 5:
                        DictionaryDemo dictionaryDemo = new DictionaryDemo();
                        dictionaryDemo.DemoDictionary();
                        break;

                }
            }

            ListDemo listDemo = new ListDemo();
            listDemo.Lists();
            Console.ReadLine();

        }
    }
}
