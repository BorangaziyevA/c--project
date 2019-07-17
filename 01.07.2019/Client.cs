using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2019
{
    class Client: Person
    {
        private int[] order_id = new int[4];

        public Client(string name, string surname, string patronymic, int BirthYear, long IIN)
            :base(name,surname,patronymic,BirthYear,IIN)
        {

        }

    }
}
