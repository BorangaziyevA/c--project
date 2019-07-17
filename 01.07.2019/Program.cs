using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker(Convert.ToDateTime("01.12.2019"),"Admin",25000,"Percy","Jackson","Poseidon",2003,000);

            work.GetInfo();

            //Console.WriteLine(work.Employement_date.ToShortDateString());

        }

    }
}

