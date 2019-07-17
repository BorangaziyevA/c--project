using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2019
{
    class Person
    {
        private string name;
        private string surname;
        private string patronymic;
        private int birthYear;
        private long iin;

        //public Person()
        //{
        //    name = surname = patronymic = "Неизвестно";
        //    birthYear = 0;
        //    iin = 0;
        //}
        public Person(string name,string surname,string patronymic,int BirthYear, long IIN)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            this.birthYear = BirthYear;
            this.iin = IIN;
        }
        public Person(int BirthYear, long IIN)
        {
            this.birthYear = BirthYear;
            this.iin = IIN;
        }

        virtual public void GetInfo()
        {

            Console.WriteLine( $"ФИО:\n{name} {surname} {patronymic}\nГод рождения:\n{birthYear}\nИИН:\n{iin} ");

        }
        public string GetInitials()
        {
            string str;
            str = surname + " " + name[0] + surname[0] + patronymic[0];
            return str;
        }
        public int GetAge()
        {
            int age = 0;

            age = DateTime.Today.Year - birthYear;

            return age;
        }



        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }

        public long IIN
        {
            get
            {
                return iin;
            }
            set
            {
                iin = value;
            }

        }

    }
}

