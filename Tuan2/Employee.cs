﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class Employee:UserInformation
    {
      public Employee(string username, int userage, uint useriD, double  baseSalary) : base(username, userage, useriD,baseSalary)
        {

        }
        public override double GetSalary()
        {
            return BaseSalary * 2;
        }

    }
}
