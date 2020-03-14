using System;
using System.Linq;

namespace Lab1
{
    public class Human
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value) || value.Count(Char.IsLetter) != value.Length)
                    throw new Exception();
                name = value;
            }
        }

        private string surname;

        public string Surname
        {
            get => surname;
            set
            {
                if (String.IsNullOrEmpty(value) || value.Count(Char.IsLetter) != value.Length)
                    throw new Exception();
                surname = value;
            }
        }


        private string middlename;

        public string Middlename
        {
            get => middlename;
            set
            {
                if (value != null && (value == "" || value.Count(Char.IsLetter) != value.Length))
                    throw new Exception();
                middlename = value;
            }
        }

        private string number;

        public string Number
        {
            get => number;
            set
            {
                if (String.IsNullOrEmpty(value) || value.Count(Char.IsDigit) != value.Length)
                    throw new Exception();
                number = value;
            }
        }

        private string country;

        public string Country
        {
            get => country;
            set
            {
                if (String.IsNullOrEmpty(value) || value.Count(Char.IsLetter) != value.Length)
                    throw new Exception();
                country = value;
            }
        }

        public DateTime BirthDateTime { get; set; }

        private string organisation;

        public string Organisation
        {
            get => organisation;
            set
            {
                if (value == "")
                    throw new Exception();
                organisation = value;
            }
        }

        private string position;

        public string Position
        {
            get => position;
            set
            {
                if (value == "")
                    throw new Exception();
                position = value;
            }
        }

        private string extra;

        public string Extra
        {
            get => extra;
            set
            {
                if (value == "")
                    throw new Exception();
                extra = value;
            }
        }

        public Human(string name, string surname, string number, string country)
        {
            Name = name;
            Surname = surname;
            Number = number;
            Country = country;
            BirthDateTime = DateTime.MinValue;
        }

        public override string ToString()
        {
            return
                $"Фамилия: {surname}\nИмя: {name}\nОтчество: {middlename ?? "отсутствует"}\nНомер телефона: {number}\nСтрана: {country}\nДата рождения: {(BirthDateTime != DateTime.MinValue ? BirthDateTime.ToString("d") : "отсутствует")}\nОрганизация: {organisation ?? "отсутствует"}\nДолжность: {position ?? "отсутствует"}\nЗаметки: {extra ?? "отсутствует"}";
        }
    }
}