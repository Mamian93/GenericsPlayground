using GenericsPlayground.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPlayground.Modules
{
    public class Collection
    {
        public Employee[] employees = new Employee[]
           {
                new Employee
                {
                    Id = 1,
                    Name = "Damian"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Mateusz"
                }
           };
    }
}
