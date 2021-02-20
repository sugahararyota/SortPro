using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SortAlgorithm
{
    class CSVReader
    {
        public List<int> numList = new List<int>();

        public CSVReader()
        {
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            //ファイルを開く
            StreamReader sr = new StreamReader(@".\Savedata\loto6.txt");
            List<string> list = new List<string>();
            //ファイルの読み込み
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');
                
                list.AddRange(values);
               
                
            }
            //ファイルを閉じる
            sr.Close();

            

            for(int i = 0; i< list.Count;i++)
            {
                numList.Add(int.Parse(list[i]));
            }

          

        }

        public List<int> GetNumber()
        {
            return numList;
        }
    }
}
