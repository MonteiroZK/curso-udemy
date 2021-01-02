using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinoPooUdamy
{
    public class ListClasseSalary
    {

        public int id { get; set; }
        public string name { get; set; }

        public double salary { get; set; }


        public void increaseSalary(double porcentage)
        {
            salary = salary + ((salary * porcentage) / 100);
        }

    }
}
