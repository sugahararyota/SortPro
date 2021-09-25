using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithm.ShakerSortFail;
using SortAlgorithm.BubbleSortFail;
using System.Diagnostics;

namespace SortAlgorithm
{  
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("0か1を入力して：");
            //int num = int.Parse(Console.ReadLine());
            
            CSVReader reader = new CSVReader();
            List<int> list = reader.GetNumber();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("これをソートします:");

            reader = new CSVReader();
            Console.WriteLine("バブルソート2");

            BubbleSort2 bubbleSort2 = new BubbleSort2(reader.GetNumber());
            bubbleSort2.Sort();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("これをソートします:");
            reader = new CSVReader();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("シェーカーソート2");
            ShakerSort2 shakerSort2 = new ShakerSort2(reader.GetNumber());
            shakerSort2.Sort();

            Console.ReadLine();

        }   
    }
}
