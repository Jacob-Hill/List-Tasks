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
            Console.WriteLine("Test Passed");
            Debug.Assert(MaxList(testListInt) == testListInt.Max());
            Console.WriteLine("Test Passed");
            Debug.Assert(MinList(testListInt) == testListInt.Min());
            Console.WriteLine("Test Passed");
            //Can't test NegativeList function because currently cant compare lists
            Debug.Assert(ListsContainSameInts(testListInt, testListInt));
            Console.WriteLine("Test Passed");
            Debug.Assert(ListsContainSameInts(testListInt, new List<int> { 1, 1, 2, 3, 4, 5, 6, 7, 4, 6, 4, 8, 9, 1 }));
            Console.WriteLine("Test Passed");
            Debug.Assert(SimpleListSearch(testListInt, 5));
            Console.WriteLine("Test Passed");
            Debug.Assert(SimpleListSearch(testListInt, 10) == false);
            Console.WriteLine("Test Passed");
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

        static bool ListsContainSameInts(List<int> list1, List<int> list2) // Doesn't Currently Work. Not too sure why
        {
            foreach(int element in list1)//Iterate through every element in list 1 to check if its in list 2
            {
                if(!list2.Contains(element))
                {
                    return false;
                }
            }
            foreach(int element in list2)//Do the same for list 2
            {
                if(!list1.Contains(element))
                {
                    return false;
                }
            }
            return true;
        }

        static bool SimpleListSearch(List<int> list, int item)
        {
            for(int i = 0; i<list.Count; i++)
            {
                if (list[i] == item)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
