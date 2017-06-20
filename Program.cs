using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string init = "12345678";

            Console.WriteLine("Please input number of operation and number of iteration and put space as seperator");
            string OperandIter = Console.ReadLine();
            string[] OperandIterArr = OperandIter.Split(' ');
            int int1 = Convert.ToInt32(OperandIterArr[0]);
            var int2 = Convert.ToInt64(OperandIterArr[1]);
            var tupleList = new List<Tuple<int, int>>();
            var operationAmt = int1;
            var iterAmt = int2;

            for (int i = 0; i < operationAmt; i++)
            {

                Console.WriteLine("Please input " + (i + 1) + " operation ");
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');
                int[] inputNum = Array.ConvertAll(inputArr, int.Parse);
                tupleList.Add(new Tuple<int, int>(inputNum[0], inputNum[1]));
            }

            var dict = new Dictionary<string, string>();
            string newDictStr;

            // This line of code implemented for redecu number of iteration
            var newIter = (iterAmt % (operationAmt-1));

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int k = 0; k < newIter; k++)
            {
                for (int j = 0; j < operationAmt; j++)
                {
                    var asString1 = init + tupleList[j].Item1+ tupleList[j].Item2;
                    newDictStr = SwapLogic(init, tupleList[j].Item1-1, tupleList[j].Item2-1);
                    dict.Add(asString1, newDictStr);
                    init = newDictStr;
                }
            }

            sw.Stop();
            Console.WriteLine("===================================");
            Console.WriteLine("Elapsed = {0}", sw.Elapsed.ToString(@"hh\:mm\:ss\.f"));
            Console.WriteLine("Answer is " + init.Aggregate(string.Empty, (c, i) => c + i + ' '));
            Console.WriteLine("Press any key to exit program...");
            string choice2 = Console.ReadLine();
        }

        private static string SwapLogic(string src, int index1, int index2)
        {
            char[] chrArr = src.ToCharArray(); 
            char temp = chrArr[index1];
            chrArr[index1] = chrArr[index2];
            chrArr[index2] = temp; 
            return new string(chrArr); 
        }
    }
}
