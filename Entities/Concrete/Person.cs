﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public long NationalityIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
