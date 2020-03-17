using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Book
    {
        private static int nextId = 1;

        private readonly Dictionary<int, Human> humans;

        public Book()
        {
            humans = new Dictionary<int, Human>();
        }

        public void Add(Human human)
        {
            humans.Add(nextId++, human);
        }

        public bool Delete(int id)
        {
            return humans.Remove(id);
        }

        public Human this[int id] => humans[id];

        public void Show()
        {
            if (humans.Count == 0)
            {
                Console.WriteLine("Пусто");
                return;
            }

            foreach (var human in humans)
                Console.WriteLine($"Id: {human.Key}. Фамилия: {human.Value.Surname}. Имя: {human.Value.Name}. Номер телефона: {human.Value.Number}");
        }
    }
}