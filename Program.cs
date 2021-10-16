using System;
using System.Collections.Generic;
using System.Linq;

namespace _1nsanov_sTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookCollection = new List<Book>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("J - добавить книшку");
                Console.WriteLine("O - показать доступные книшки");
                Console.WriteLine("P - выбросить книшку");
                Console.WriteLine("A - съебаться");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.J:
                        bookCollection.Add(InputData());
                        break;
                    case ConsoleKey.O:
                        Output(bookCollection);
                        break;
                    case ConsoleKey.P:
                        DeleteData(bookCollection);
                        break;
                    case ConsoleKey.A:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Выбери команду из существующих.");
                        break;
                }
            }
            
        }
        private static Book InputData()
        {
            string name, author;
            int year;
            Console.WriteLine("Введите название книги:");
            name = InputValidNull();
            Console.WriteLine("Введите имя автора:");
            author = InputValidNull();
            Console.WriteLine("Введите год написания:");
            year = InputValidInt();
            return new Book(name, author, year);
        }

        private static void DeleteData(List<Book> ebanayaXueta)
        {
            var key = Console.ReadLine();
            var book = ebanayaXueta.FirstOrDefault(b => b.Name == key);
            if (book != null)
            {
                ebanayaXueta.Remove(book);
            }
            else
            {
                Console.WriteLine("Такой книги не существует.");
            }
        }

        private static void Output(List<Book> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static string InputValidNull()
        {
            string text;
            while (true)
            {
                text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Данная строка не может быть пустой. Повторите попытку.");
                }
                else
                {
                    return text;
                }
            }
        }

        private static int InputValidInt()
        {
            string year;
            while (true)
            {
                year = Console.ReadLine();
                if (int.TryParse(year, out int ear))
                {
                    return ear;
                }
                else
                {
                    Console.WriteLine("Не верный формат. Повторите попытку.");
                }
            }
        }
    }
}
