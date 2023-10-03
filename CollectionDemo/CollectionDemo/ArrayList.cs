using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ArrayLists
    {
        public void Arraylist()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("uday");
            arrayList.Add(7.9);
            arrayList.Add(true);
            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            for(var i =0; i < arrayList.Count; i++)
            {
               Console.WriteLine(arrayList[i]);
            }
        }
       
        
    }
}
