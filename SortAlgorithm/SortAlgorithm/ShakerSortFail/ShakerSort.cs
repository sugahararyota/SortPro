using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.ShakerSortFail
{
    class ShakerSort
    {

        public List<int> numList = new List<int>();
        int swapCount = 0;

        public ShakerSort(List<int> list)
        {
            numList = list;

           
        }

        public void Sort()
        {
            int pos = 0;
            int lastCount = 2;
            int startCount = 1;
            int endCount = 0;
            int count = 0;
            bool flag = false;
            bool flag2 = false;
            while (true)
            {
                count++;
                if(count == 143)
                {
                    int gg = 0;
                    gg = 5;
                    flag2 = flag;
                    
                }
                if (!flag)
                {
                    

                    if(pos> numList.Count - lastCount)
                    {
                        lastCount = 2;
                        pos = 0;
                        startCount = 1;
                        endCount = 0;
                        flag = false;
                        continue;
                    }

                    int a = numList[pos];
                    int b = numList[pos + 1];

                    if (a > b)
                        Swap(pos, pos + 1);
                    else
                        endCount++;

                    if (endCount == numList.Count() - 1)
                        break;

                    int nn = numList.Count();
                    if (pos == numList.Count() - lastCount)
                    {
                        pos = numList.Count() - lastCount;
                        endCount = 0;
                        lastCount++;
                        flag = !flag;
                        continue;
                    }
                    else
                    {
                        pos++;
                    }

                    if (lastCount == numList.Count)
                        lastCount = 2;
                }
                else
                {

                    if (pos <startCount)
                    {
                        lastCount = 2;
                        pos = 0;
                        startCount = 1;
                        endCount = 0;
                        flag = false;
                        continue;
                    }
                    int a = numList[pos - 1];
                    int b = numList[pos];

                    if (a > b)
                        Swap(pos - 1, pos);
                    else
                        endCount++;

                    if (endCount == numList.Count - 1)
                        break;

                    if (pos == startCount)
                    {
                        pos = startCount;
                        startCount++;
                        endCount = 0;
                        flag = !flag;
                        continue;
                    }
                    else
                    {
                        pos--;
                    }

                    if (lastCount == numList.Count)
                        lastCount = 2;
                }
                
            }
            Console.WriteLine("ソート完了：計算した回数：" + count +  "回：" + swapCount + "回" );
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

        void Swap(int num ,int num2)//引数はリストの何番目か
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
