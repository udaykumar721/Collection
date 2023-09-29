using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ListDemo
    {
        public void Lists()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            //List<string> listString = new List<string>();
            //listString.Add("Uday");
            //listString.Add("jaswanth");
            //listString.Add("Sudheer");
            //listString.Add("Manoj");
            //listString.Add("amit");
            //foreach (string s in listString)
            //{
            //    Console.WriteLine(s);
            //}
            List<double> listDouble = new List<double>();
            listDouble.Add(721.23);
            listDouble.Add(724.34);
            listDouble.Add(092.67);
            listDouble.Add(696.78);
            foreach (double d in listDouble)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("---------------");
            listDouble.Reverse();
            { 
                foreach (double d in listDouble)
                {
                    Console.WriteLine(d);
                }
            }
            Console.WriteLine(listDouble.Count);
        }
    }
}
