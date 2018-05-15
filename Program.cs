using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
           List<object> boxList = new List<object>();
           boxList.Add(7);
            boxList.Add(28);
            boxList.Add(-1);
            boxList.Add(true);
            boxList.Add("chair");

            foreach (var obj in boxList){
                Console.WriteLine(obj);
            }
            int sum = 0;

            foreach (var obj in boxList){
                if (obj is int){
                    int castInt = (int)obj;
                    sum += castInt;
                }
            }
            Console.WriteLine("Sum of Integers: {0}", sum);
        }
    }
}
