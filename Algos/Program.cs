using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            int[] adad = new int[] { 1, 2, 3, };
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.AddRange(adad);

            for (int i = 0; i < myList.count; i++)
            {
                Console.WriteLine(myList[i] + " ");
            }
        }
        class MyList
        {
            public int[] array { get; set; } = new int[4];
            public int count { get; private set; } = 0;

            public int this[int index]
            {
                get
                {
                    if (index < 0 || index >= array.Length)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    return array[index];
                }

                set
                {
                    if (index < 0 || index >= array.Length)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    array[index] = value;
                }
            }

            public void Add(int value)
            {
                if (count == array.Length)
                {
                    int[] array2 = new int[array.Length * 2];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array2[i] = array[i];
                    }
                    array = array2;
                }
                array[count] = value;
                count++;
            }

            public void Remove(int value)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    if (array[i] == value)
                    {
                        for (int j = i; j < count - 1; j++)
                        {
                            array[j] = array[j + 1]; 
                        }
                        count--;
                    }
                }
            }

            public void RemoveAt(int index)
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                for (int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;
            }

            public void AddRange(int[] values)
            {
                if (count + values.Length > array.Length)
                {
                    int[] array2 = new int[array.Length * 2];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array2[i] = array[i];
                    }
                    array = array2;
                }
                for (int i = count; i < count+values.Length; i++)
                {
                    array[i] = values[i - count];
                }
                count += values.Length;
            }

            public void Clear()
            {
                count = 0;
            }

            public void Insert(int index, int value)
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException();
                }

                if (array.Length < count + 1)
                {
                    int[] array2 = new int[array.Length * 2];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array2[i] = array[i];
                    }
                    array = array2;
                }

                for (int j = count - 1; j >= index ; j--)
                {
                    array[j + 1] = array[j];
                }
                array[index] = value;
                count++;
            }
        }
    }
}
