using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Employee
    {
        private string _fio;
        private int _department;
        private int _salary;
        private int _id;

        public Employee(string fio, int department, int salary, int id)
        {
            string _fio = fio;
            int _department = department;
            int _salary = salary;
            int _id = id;
        }
        
        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }

        public int Department
        { 
            get => _department;
            set => _department = value;
        }

        public int Salary
        { 
            get => _salary;
            set => _salary = value;
        }

        public int Id
        { 
            get => _id;
            set => _id = value;
        }
    }
}
