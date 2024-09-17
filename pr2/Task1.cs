using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pr2
{
    public class MyArray : IOutput, IMath, ICalc, IOutput2, ICalc2
    {
        private int[] array;

        public MyArray()
        {
            array = new int[0];
        }

        public MyArray(int size)
        {
            array = new int[size];
        }

        public MyArray(int[] initialArray)
        {
            array = new int[initialArray.Length];
            Array.Copy(initialArray, array, initialArray.Length);
        }

        public void SetValue(int index, int value)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
            else
            {
                Console.WriteLine("Неправильний індекс!");
                return;
            }
        }

        public int GetValue(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                Console.WriteLine("Неправильний індекс!");
                return -1;
            }
        }

        // реалізація інтерфейсів з 1 завдання Less, Greater
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int value in array)
            {
                if (value < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int value in array)
            {
                if (value > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        public void ShowEven()
        {
            Console.Write("Парні значення: ");
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    Console.Write(value + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Непарні значення: ");
            foreach (int value in array)
            {
                if (value % 2 != 0)
                {
                    Console.Write(value + " ");
                }
            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            return array.Distinct().Count();//Distinct() повертає тільки унікальні значення масиву, а Count() підраховує їх кулькість 
        }

        public int EqualToValue(int valueToCompare)
        {
            return array.Count(x => x == valueToCompare);
        }

        public int Size()
        {
            return array.Length;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", array) + "]";
        }

        public void Show()
        {
            Console.WriteLine(ToString());
        }

        public void Show(string info)
        {
            Console.WriteLine(info + ": " + ToString());
        }
        public int Max()
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній");
                return -1;
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i]; 
                }
            }

            return max;
        }

        public int Min()
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній");
                return -1;
            }

            int min = array[0];  

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];  
                }
            }

            return min;
        }
        public double Avg()
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній");
                return -1;
            }

            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }
        public bool Search(int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true; 
                }
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortDesc()
        {
            Array.Sort(array, (a, b) => b.CompareTo(a));
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }

}
