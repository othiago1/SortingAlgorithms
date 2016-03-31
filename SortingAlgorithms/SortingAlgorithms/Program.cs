using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;    


namespace SortingAlgorithms
{
    class Program
    {
        public static Stopwatch time;
        public static int comparisons;
        
              
        public static int[] BubbleSort(int[] name)
        {
            

            comparisons = 0;
            int changes = 0;
            int aux = 0;

            time = new Stopwatch();

            time.Start();
            
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
            
            time.Stop();
            
            Console.WriteLine(" ");
            Console.WriteLine("Comparações: " + comparisons);
            Console.WriteLine("Trocas: " + changes);
            Console.WriteLine("Tamanho: " + name.Count());
            Console.WriteLine("Tempo: " + time.Elapsed);
            Console.WriteLine(" ");
            
            return name;
        }

        public static int a = 10;

        static void Main(string[] args)
        {
            while (a < 2000)
            {
            
            Random random = new Random();
            
            int[] arr = new int[a];

            

                for (int i = 0; i < a; i++)
                {
                    arr[i] = random.Next(0, 2001);
                }


                Console.WriteLine("Antes");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");

                Console.WriteLine(" ");

                BubbleSort(arr);

                Console.WriteLine("Depois");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");


                //txt things
                string path = @"C:\Users\matheus.barros\Desktop\GitHub\SortingAlgorithms\Numbers.txt";
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                    using (TextWriter tw = new StreamWriter(path))
                    {
                        tw.WriteLine(arr.Length + "; " + time.Elapsed + "; " + comparisons + ";");
                        tw.Close();
                    }

                }

                else if (File.Exists(path))
                {
                    TextWriter tw = new StreamWriter(path, true);
                    tw.WriteLine(arr.Length + "; " + time.Elapsed + "; " + comparisons + ";");
                    tw.Close();
                }

                a += 5;

                Console.ReadLine();
                
            }
        }
    
     
         
    }
}
