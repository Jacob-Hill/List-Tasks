using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            try
            {
                if(SumList(testListInt) == testListInt.Sum()) { Console.WriteLine("SumList Test Passed"); }
                else { throw new Exception("SumList Test Failed"); }
                if(MaxList(testListInt) == testListInt.Max()) { Console.WriteLine("MaxList Test Passed"); }
                else { throw new Exception("MaxList Test Failed"); }
                if(MinList(testListInt) == testListInt.Min()) { Console.WriteLine("MinList Test Passed"); }
                else { throw new Exception("MinList Test Failed"); }
                if(ListsContainSameInts(NegativeList(testListNegativeInt), new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1 })) { Console.WriteLine("NegativeList Test Passed"); }
                else { throw new Exception("NegativeList Test Failed"); }
                if(ListsContainSameInts(testListInt, testListInt)) { Console.WriteLine("ListsContainSameInts Test Passed"); }
                else { throw new Exception("ListsContainSameInts Test 1 Failed"); }
                if(ListsContainSameInts(testListInt, new List<int> { 1, 1, 2, 3, 4, 5, 6, 7, 4, 6, 4, 8, 9, 1 })) { Console.WriteLine("ListsContainSameInts Test Passed"); }
                else { throw new Exception("ListsContainSameInts Test 2 Failed"); }
                if(SimpleListSearchInt(testListInt, 5)) { Console.WriteLine("SimpleListSearch Test Passed"); }
                else { throw new Exception("SimpleListSearch Test 1 Failed"); }
                if(SimpleListSearchInt(testListInt, 10) == false) { Console.WriteLine("SimpleListSearch Test Passed"); }
                else { throw new Exception("SimpleListSearch Test 2 Failed"); }
                if(BinaryListSearchInt(testListInt, 5)) { Console.WriteLine("BinaryListSearchInt Test Passed"); }
                else { throw new Exception("BinaryListSearchInt Test 1 Failed"); }
                if(BinaryListSearchInt(testListInt, 10) == false) { Console.WriteLine("BinaryListSearchInt Test Passed"); }
                else { throw new Exception("BinaryListSearchInt Test 1 Failed"); }
                if(ListsContainSameInts(DuplicateIntsList(new List<int> { 1, 1, 2, 1, 3, 6, 2, 8, 6, 4, 2, 9, 8, 9 }), new List<int> { 1, 2, 6, 8, 9 })) { Console.WriteLine("DuplicateIntsList Test Passed"); }
                else { throw new Exception("DuplicateIntsList Test 1 Failed"); }
                if (IsListSubset(testListInt, new List<int> { 1, 2, 3 })) { Console.WriteLine("IsListSubset Test Passed"); }
                else { throw new Exception("IsListSubset Test Failed"); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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

        static List<int> DuplicateIntsList(List<int> list)
        {
            List<int> result = new List<int> { };
            List<int> intsSoFar = new List<int> { };
            for(int i = 0; i<list.Count; i++)
            {
                if (intsSoFar.Contains(list[i]))
                {
                    if(!(result.Contains(list[i])))
                    {
                        result.Add(list[i]);
                    }
                }
                else
                {
                    intsSoFar.Add(list[i]);
                }
            }
            return result;
        }

        static bool IsListSubset(List<int> list1, List<int> list2)
        {
            if (list2.Count > list1.Count)
            {
                List<int> list3 = list1;
                list1 = list2;
                list2 = list3;
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (!list1.Contains(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
