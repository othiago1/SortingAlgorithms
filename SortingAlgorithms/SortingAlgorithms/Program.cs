using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        public static int[] BubbleSort(int[] name)
        {
            int size = 0;
            int comparisons = 0;
            int changes = 0;
            int aux = 0;



            for (int write = 0; write < name.Length; write++)
            {
                for (int sort = 0; sort < name.Length - 1; sort++)
                {
                    comparisons++;
                    if (name[sort] > name[sort + 1])
                    {
                        aux = name[sort + 1];
                        name[sort + 1] = name[sort];
                        name[sort] = aux;
                        changes++;
                    }
                }
            }
            
            
           

            Console.WriteLine(" ");
            Console.WriteLine("Comparações: " + comparisons);
            Console.WriteLine("Trocas: " + changes);
            Console.WriteLine("Tamanho: " + name.Count());
            Console.WriteLine(" ");
            
            return name;

        }


        static void Main(string[] args)
        {
            int[] arr = new int[10] { 10, 2, 7, 23, 42, 78, 98, 54, 32, 12 };

            Console.WriteLine("Antes");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine(" ");
            
            BubbleSort(arr);

            Console.WriteLine("Depois");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.ReadLine();

           
        }
    
     
         
    }
}
