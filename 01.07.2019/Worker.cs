using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2019
{
    class Worker : Person
    {
        private DateTime employement_date;
        private String position;
        private long salary;

        public Worker(string name, string surname, string patronymic, int BirthYear, long IIN)
            :base(name,surname,patronymic,BirthYear,IIN)
        {
            employement_date = DateTime.Today;
            position = "Неизвестно";
            salary = 0;
        }
        public Worker(DateTime date, String pos, long sal, string name, string surname, string patronymic, int BirthYear, long IIN)
            : base(name, surname, patronymic, BirthYear, IIN)
        {
            employement_date = date;
            position = pos;
            salary = sal;
        }

        public override void GetInfo() 
        {
            Console.WriteLine($"ФИО:\n{Name} {Surname} {Patronymic}\nГод рождения:\n{BirthYear}\nИИН:\n{IIN} ");
            Console.WriteLine($"Должность:\n{position}\nДата принятия на работу:\n{employement_date}\nЗарплата:\n{salary}");
        }


        public DateTime Employement_date
        {
            get
            {
                return employement_date;
            }
            set
            {
                employement_date = value;
            }
        }
        public String Position
        {
            get
            {
                return position;
            }
            set { position = value; }
        }
        public long Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

    }
}
