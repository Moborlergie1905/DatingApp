﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dating.API.UsefulClasses
{
    public class AgeClass
    {        

        public int getAge(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;
            return age;
        }
    }
}