using System;

namespace JoinSplit
{
    class Program
    {
        static void DisplayArray(string[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }

        // Перевернем массив.
        static void ChangeArray(string[] arr) 
        { 
            Array.Reverse(arr);
        }

        static void ChangeArrayElements(string[] arr)
        {
            // Изменим значения первых 3 элементов массива.
            arr[0] = "Mon";
            arr[1] = "Wed";
            arr[2] = "Fri";
        }

        static void SplitArray()
        {
            string simpleSplit = "Простой пример использования функции Split";
            string[] words = simpleSplit.Split(new char[] {' '});
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void Main()
        {
            // Обьявляем и инициализируем массив.
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            // Выводим массив.
            DisplayArray(weekDays);
            Console.WriteLine();

            // Переворачиваем массив.
            ChangeArray(weekDays);
            // Отобразим массив еще раз, чтобы убедиться, что он перевернулся.
            Console.WriteLine("Массив дней недели после вызова ChangeArray:");
            DisplayArray(weekDays);
            Console.WriteLine();

            // Присвоим новые значения отдельным элементам массива.
            ChangeArrayElements(weekDays);
            //Выводим массив снова чтобы проверить на изменения
            Console.WriteLine("Массив дней недели после вызова ChangeArrayElements:");
            DisplayArray(weekDays);
            Console.WriteLine("Использование Split:");
            SplitArray();
        }
    }
}

