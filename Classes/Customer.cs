﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return "Mrs " + _firstName; }         // düzenledik.
            set { _firstName = value; }                 // set ettik
        }

        public string LastName { get; set; }
        public string City { get; set; }

    }
}
