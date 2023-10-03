using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    //It Is A Colection Of \homogeneous Items.
    //it can has fiixed size
    internal class ArrayDemo
    {
        public void Addlement()
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            int[] arrOne = new int[10];
            int[] arrTwo = new int[] { 1, 2, 3, 4, 5, 6, };
            int[] arrThree = {1,2, 3, 4,5, 6, 7, 8, 9, 10};
            string[] stringArray = new string[5];
            stringArray[0] = "Uday";
            string[] stringArrayOne = { "One", "Two", "Three" };
            string[] stringArrayTwo = new string[] { "Four", "Five" };
            double[] doubleArray = {2.1 ,5.6, 9.7,8.45,7.62};
            double[] doubleArrayOne =new double [5] { 34.2, 56.7, 16.18, 98.2, 10.9 };
            bool[] boolArray ={ true,false, false, false };
            float[] floatArray = { 72.1f, 10.92f, 72.4f };
            short[] shortArray = { 100, 151, 167, 280 };
            byte[] byteArray = { 0, 1, 2, 3, 4, 5, 6, };
            long[] longArray = { 2390000000, 3478290123, 554332167 };
            foreach (int i in arrThree)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------");
            foreach (string s in stringArrayOne)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------");
            foreach (double d in doubleArrayOne)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("------------");
            foreach (bool b in boolArray)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("------------");
            foreach (float f in floatArray)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("------------");
            foreach (byte b in byteArray)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("------------");
            foreach (short s in shortArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------");
            foreach (byte by  in byteArray)
            {
                Console.WriteLine(by);
            }
            Console.WriteLine("------------");
            foreach (long l in longArray)
            {
                Console.WriteLine(l);
            }
        }
    }
}
