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
            Debug.Assert(ListsContainSameInts(NegativeList(testListNegativeInt), new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1 }));
            Console.WriteLine("Test Passed");
            Debug.Assert(ListsContainSameInts(testListInt, testListInt));
            Console.WriteLine("Test Passed");
            Debug.Assert(ListsContainSameInts(testListInt, new List<int> { 1, 1, 2, 3, 4, 5, 6, 7, 4, 6, 4, 8, 9, 1 }));
            Console.WriteLine("Test Passed");
            Debug.Assert(SimpleListSearchInt(testListInt, 5));
            Console.WriteLine("Test Passed");
            Debug.Assert(SimpleListSearchInt(testListInt, 10) == false);
            Console.WriteLine("Test Passed");
            Debug.Assert(BinaryListSearchInt(testListInt, 5));
            Console.WriteLine("Test Passed");
            Debug.Assert(BinaryListSearchInt(testListInt, 10) == false);
            Console.WriteLine("Test Passed");
            Console.ReadLine();
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
            bool result = true;
            for (int i = 0; i < list1.Count; i++)
            {
                if (! list2.Contains(list1[i])) 
                {
                    result = false;
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (!list1.Contains(list2[i]))
                {
                    result = false;
                }
            }
            return result;
        }

        static bool SimpleListSearchInt(List<int> list, int item)
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

        static bool BinaryListSearchInt(List<int> list, int item)
        {
            int index = list.Count / 2;
            while (true)
            {
                int prevIndex = index;
                if (list[index] == item)
                {
                    return true;
                }
                else if (list[index] > item)
                {
                    index = list.Count / 2 + index / 2;
                }
                else
                {
                    index = list.Count / 2 - index / 2;
                }
                if (prevIndex == index + 1 || prevIndex == index - 1) 
                {
                    break;
                }
            }
            return false;
        }
    }
}
