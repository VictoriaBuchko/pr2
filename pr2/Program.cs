using System;

namespace pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyArray arrayWithSize = new MyArray(5);
            arrayWithSize.SetValue(0, 10);
            arrayWithSize.SetValue(1, 20);
            arrayWithSize.SetValue(2, 30);
            arrayWithSize.SetValue(3, 40);
            arrayWithSize.SetValue(4, 50);
            arrayWithSize.Show();

            int[] ar = { 1, 2, 3, 4, 5 };
            MyArray newArr = new MyArray(ar);
            newArr.Show();//Show()
            newArr.Show("Мій масив");//Show(string info)

            //-----------------------------------------------------------------------


            Console.WriteLine("Максимум у масиві: " + newArr.Max());
            Console.WriteLine("Мінімум у масиві: " + newArr.Min());
            Console.WriteLine("Середньоарифметичне у масиві: " + newArr.Avg());
            int value = 3;
            Console.WriteLine("Чи містить масив значення " + value + "? " + (newArr.Search(value) ? "Так" : "Ні"));

            //-----------------------------------------------------------------------

            newArr.SortAsc();
            Console.WriteLine("Масив після сортування за зростанням:");
            newArr.Show();


            newArr.SortDesc();
            Console.WriteLine("Масив після сортування за спаданням:");
            newArr.Show();


            newArr.SortByParam(true);
            Console.WriteLine("Масив після сортування за зростанням:");
            newArr.Show();

            newArr.SortByParam(false);
            Console.WriteLine("Масив після сортування за спаданням:");
            newArr.Show();

            //-----------------------------------------------------------------------
            // Домашнє завдання по фнтерфейсам 
            Console.WriteLine("\nДомашнє завдання\n");

            int valueToCompare = 3;

            Console.WriteLine($"Кількість елементів, менших за {valueToCompare} = {newArr.Less(valueToCompare)}");
            Console.WriteLine($"Кількість елементів, більших за {valueToCompare}= {newArr.Greater(valueToCompare)}");

            //-----------------------------------------------------------------------

            newArr.ShowEven();
            newArr.ShowOdd();


            //-----------------------------------------------------------------------
            int[] numbers = { 3, 7, 2, 3, 7, 2, 8 };
            MyArray myArray = new MyArray(numbers);
            myArray.Show();

            Console.WriteLine($"Кількість унікальних значень: {myArray.CountDistinct()}");
            Console.WriteLine($"Кількість елементів, рівних {valueToCompare}: {myArray.EqualToValue(valueToCompare)}");

        }
    }
}
