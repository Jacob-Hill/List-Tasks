using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace List_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testListInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> testListNegativeInt = new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0 };
            Debug.Assert(SumList(testListInt) == testListInt.Sum());
            Debug.Assert(MaxList(testListInt) == testListInt.Max());
            Debug.Assert(MinList(testListInt) == testListInt.Min());
            
        }

        static int SumList(List<int> list)
        {
            int sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        static int MaxList(List<int> list)
        {
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        static int MinList(List<int> list)
        {
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }

        static List<int> NegativeList(List<int> list)
        {
            List<int> result = new List<int> { };
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        static bool ListsContainSameInts(List<int> list1, List<int> list2)
        {
            List<int> list = list1;
            for (int i1 = 0; i1 < list1.Count; i1++)
            {
                for (int i2 = 0; i2 < list2.Count; i2++)
                {
                    if (list1[i1] == list2[i2])
                    {
                        if (list.Contains(list1[i1])) 
                        {
                            list.Remove(list1[i1]);
                        }
                    }
                }
            }
            if(list.Count ==0)
            {
                return true;
            }
            return false;
        }
    }
}
