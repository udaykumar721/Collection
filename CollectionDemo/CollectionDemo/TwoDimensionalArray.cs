﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class TwoDimensionalArray
    {
        public void TwoDimensionArray()
        {
            int[,] array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, };
            Console.WriteLine(array[0,1]);
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
                
            }
        }
    }
}
