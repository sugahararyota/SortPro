using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.BubbleSortFail
{
    class BubbleSort
    {
        public List<int> numList = new List<int>();
        int swapCount = 0;

        public BubbleSort(List<int> list)
        {
            numList = list;
        }

        public void Sort()
        {
            int pos = 0;
            int lastCount = 2;
            int endCount = 0;
            int count = 0;
            
            while (true)
            {
                count++;
                int a = numList[pos];
                int b = numList[pos + 1];

                if (a > b)
                {
                    Swap(pos, pos + 1);
                }           
                else
                    endCount++;

                if (endCount == numList.Count - 1)
                    break;

                if (pos == numList.Count - lastCount)
                {
                    pos = 0;
                    endCount = 0;
                    lastCount++;
                    
                }
                else{
                    pos++;
                   
                }

                if (lastCount == numList.Count)
                    lastCount = 2;
            }
            Console.WriteLine("ソート完了：計算した回数：" + count + "回：" + swapCount + "回");
            AnsDraw();
        }

        void AnsDraw()
        {
            for (int i = 0; i < numList.Count; i++)
            {
                Console.Write(numList[i] + ",");
            }
            Console.WriteLine();
        }

        void Swap(int num, int num2)//引数はリストの何番目か
        {
            swapCount++;
            int a = numList[num];
            int b = numList[num2];
            int swap = a;

            a = b;
            b = swap;

            numList[num] = a;
            numList[num2] = b;
        }
    }
}
