using System;
using System.Linq;

namespace Lab1
{
    internal static class Program
    {
        public static void Main()
        {
            var book = new Book();
            var q = true;
            while (q)
            {
                Console.WriteLine("1 - добавить запись    2 - удалить запись    3 - редактировать запись    4 - показать все записи    5 - запись по id    0 - выход");
                switch (Console.ReadLine())
                {
                    case "0":
                        q = false;
                        break;
                    case "1":
                        Console.WriteLine("\nВведите имя");
                        var name = Console.ReadLine();
                        while (!IsWord(name))
                        {
                            Console.WriteLine("Невалидное значение. Введите заново");
                            name = Console.ReadLine();
                        }

                        Console.WriteLine("\nВведите фамилию");
                        var surname = Console.ReadLine();
                        while (!IsWord(surname))
                        {
                            Console.WriteLine("Невалидное значение. Введите заново");
                            surname = Console.ReadLine();
                        }

                        Console.WriteLine("\nВведите номер");
                        var number = Console.ReadLine();
                        while (!IsNumber(number))
                        {
                            Console.WriteLine("Невалидное значение. Введите заново");
                            number = Console.ReadLine();
                        }

                        Console.WriteLine("\nВведите страну");
                        var country = Console.ReadLine();
                        while (!IsWord(country))
                        {
                            Console.WriteLine("Невалидное значение. Введите заново");
                            country = Console.ReadLine();
                        }

                        book.Add(new Human(name, surname, number, country));

                        break;
                    case "2":
                        Console.WriteLine("Введите id");
                        try
                        {
                            book.Delete(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Нет такого id");
                        }

                        break;
                    case "3":
                        Console.WriteLine("Введите id");
                        try
                        {
                            var human = book[Convert.ToInt32(Console.ReadLine())];
                            var w = true;
                            while (w)
                            {
                                Console.WriteLine(
                                    "\n1 - изменить фамилию    2 - изменить имя    3 - изменить отчество    4 - изменить номер телефона    5 - изменить страну    6 - изменить дату рождения    7 - изменить организацию    8 - изменить должность    9 - изменить заметки    10 - текущая информация    0 - назад");
                                string s;
                                switch (Console.ReadLine())
                                {
                                    case "0":
                                        w = false;
                                        break;
                                    case "1":
                                        Console.WriteLine("\nВведите фамилию");
                                        try
                                        {
                                            human.Surname = Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "2":
                                        Console.WriteLine("\nВведите имя");
                                        try
                                        {
                                            human.Name = Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "3":
                                        Console.WriteLine("\nВведите отчество");
                                        try
                                        {
                                            s = Console.ReadLine();
                                            human.Middlename = s == "" ? null : s;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "4":
                                        Console.WriteLine("\nВведите номер телефона");
                                        try
                                        {
                                            human.Number = Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "5":
                                        Console.WriteLine("\nВведите страну");
                                        try
                                        {
                                            human.Country = Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "6":
                                        Console.WriteLine("\nВведите дату рождения");
                                        try
                                        {
                                            s = Console.ReadLine();
                                            human.BirthDateTime = s == "" ? DateTime.MinValue : DateTime.Parse(s);
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "7":
                                        Console.WriteLine("\nВведите названием организации");
                                        try
                                        {
                                            s = Console.ReadLine();
                                            human.Organisation = s == "" ? null : s;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "8":
                                        Console.WriteLine("\nВведите должность");
                                        try
                                        {
                                            s = Console.ReadLine();
                                            human.Position = s == "" ? null : s;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "9":
                                        Console.WriteLine("\nВведите дополнительную информацию");
                                        try
                                        {
                                            s = Console.ReadLine();
                                            human.Extra = s == "" ? null : s;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Невалидное значение");
                                        }

                                        break;
                                    case "10":
                                        Console.WriteLine("\n" + human);
                                        break;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Нет такого id");
                        }

                        break;
                    case "4":
                        Console.WriteLine();
                        book.Show();
                        break;
                    case "5":
                        Console.WriteLine("Введите id");
                        try
                        {
                            Console.WriteLine("\n" + book[Convert.ToInt32(Console.ReadLine())]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Нет такого id");
                        }

                        break;
                }

                Console.WriteLine();
            }
        }

        private static bool IsWord(string s)
        {
            return s.Count(Char.IsLetter) == s.Length;
        }

        private static bool IsNumber(string s)
        {
            return s.Count(Char.IsDigit) == s.Length;
        }
    }
}