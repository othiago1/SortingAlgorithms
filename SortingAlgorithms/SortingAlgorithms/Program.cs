using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[]{10,2,7,23,42,78,98,54,32,12};

            Console.WriteLine("arr : ", arr);
            BolhaSort(arr);
            Console.WriteLine("arr : ", arr);
        }
    
      public static int[] BolhaSort(int[] name) 
        {
            int size = 0;
            int comparisons = 0;
            int changes = 0;

            for (int i = size; i >= 0; i-- )
            {
                for (int j = 0; j < i; j++) 
                {
                    comparisons++;
                    if (name[j] > name[j + 1])
                    {
                        int aux = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = aux;
                        changes++;
                    }
                }
            }
           
            return name;
               
        }
         
    }
}
