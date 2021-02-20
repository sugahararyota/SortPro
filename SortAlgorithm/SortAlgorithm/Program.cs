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
            Console.Write("0か1を入力して：");
            int num = int.Parse(Console.ReadLine());
            
            CSVReader reader = new CSVReader();
            List<int> list = reader.GetNumber();
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("これをソートします:");

            switch(num)
            {
                case 1:
                    reader = new CSVReader();
                    Console.WriteLine("バブルソート2");
                    sw = new Stopwatch();
                    // 計測開始
                    sw.Start();
                    BubbleSort2 bubbleSort2 = new BubbleSort2(reader.GetNumber());
                    bubbleSort2.Sort();
                    // 計測停止
                    sw.Stop();
                    DrawTime(sw);
                    break;
                case 2:
                    reader = new CSVReader();
                    sw = new Stopwatch();
                    Console.WriteLine("シェーカーソート2");
                    // 計測開始
                    sw.Start();
                    ShakerSort2 shakerSort2 = new ShakerSort2(reader.GetNumber());
                    shakerSort2.Sort();
                    // 計測停止
                    sw.Stop();
                    DrawTime(sw);
                    break;
                default:
                    break;
                   
            }

            Console.ReadLine();

            void DrawTime(Stopwatch swa)
            {
                Console.WriteLine("■処理Aにかかった時間");
                TimeSpan ts = swa.Elapsed;
                Console.WriteLine($"　{ts}");
                Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
                Console.WriteLine($"　{swa.ElapsedMilliseconds}ミリ秒");
            }
        }   
    }
}
