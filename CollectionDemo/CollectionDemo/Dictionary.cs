using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class DictionaryDemo
    {
        public void DemoDictionary()
        {
            //dictory have key and value pair data.
            //Key will Be Unique And The Value Can Be Different.
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("key1", "Uday");
            dic.Add("key2", "Sudheer");
            dic.Add("key3", "Jaswanth");
            dic.Add("key4", "Manoj");
            dic.Add("key5", "Amit");
            Dictionary<int, int> dicInt = new Dictionary<int,int>();
            dicInt.Add(10,20);
            dicInt.Add(30,40);
            dicInt.Add(50,60);
            dicInt.Add(70,80);
            dicInt.Add(90,100);
            Dictionary<float, float> dicFloat = new Dictionary<float,float>();
            dicFloat.Add(10.2f, 20.5f);
            dicFloat.Add(30.4f, 40.8f);
            dicFloat.Add(50.62f, 60.7f);
            dicFloat.Add(70.56f, 80.45f);
            dicFloat.Add(90.34f, 100.3f);
            Dictionary<bool , bool> dicBool = new Dictionary<bool , bool>();
            dicBool.Add(true, false);
            dicBool.Add(false, true);
            Dictionary<double,double> dicDouble = new Dictionary<double,double>();
            dicDouble.Add(28904893763, 23457890865);
            dicDouble.Add(237489327, 23674788956);
            dicDouble.Add(45267723788, 4163137883);
            //foreach(KeyValuePair<string,string> pair in dic)
            //{
            //    Console.WriteLine(pair.Key);
            //    Console.WriteLine(pair.Value);

            //}
            //dic["key3"] = "Kumar";
            Console.WriteLine("----------------------");
            foreach(var data in dic)
            { 
                Console.WriteLine(data.Key+ " | "+ data.Value);
            }
            Console.WriteLine("----------------------");
            foreach (var data in dicInt)
            {
                Console.WriteLine(data.Key+ " | "+ data.Value);
            }
            Console.WriteLine("----------------------");
            foreach (var data in dicFloat)
            {
                Console.WriteLine(data.Key+ " | " + data.Value);
            }
            Console.WriteLine("----------------------");
            foreach (var data in dicBool)
            {
                Console.WriteLine(data.Key+ " | " + data.Value);
            }
            Console.WriteLine("----------------------");
            foreach (var data in dicDouble)
            {
                Console.WriteLine(data.Key + " | " + data.Value);
            }

        }
    }
}
