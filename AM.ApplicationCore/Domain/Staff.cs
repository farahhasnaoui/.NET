﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff: Passenger
    {
        public DateTime EmployementDate { get; set; }
        public String  Function { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Function} {Salary}";
        }
        public override string PassengerType
        {
            get { return "Staff passenger type"; }
        }

    }


}
