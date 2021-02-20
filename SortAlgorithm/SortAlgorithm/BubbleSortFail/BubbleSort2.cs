using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.BubbleSortFail
{
    class BubbleSort2
    {
        public List<int> numList = new List<int>();
        int swapCount = 0;

        public BubbleSort2(List<int> list)
        {
            numList = list;
        }

        public void Sort()
        {
            int endCount = 1;
            int count = 0;//計測用
            int count2 = 0;//計測用
            while (true)
            {
                bool swap = false;
                count2++;//計測用
                for (int i = 0; i<numList.Count() - endCount; i++)
                {
                    count++;//計測用
                    if (numList[i] > numList[i + 1])
                    {
                        Swap(i, i + 1);
                        swap = true;
                    }    
                }

                endCount++;
                if (!swap)
                {
                    break;
                }
            }
            Console.WriteLine("ソート完了：計算した回数：" + count + " :交換した回数：" + swapCount + "回: while回数：" + count2 + "回");
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
