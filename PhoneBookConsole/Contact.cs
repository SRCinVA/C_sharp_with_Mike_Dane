﻿using System;
namespace PhoneBookConsole
{
    public class Contact
    {
        // constructor
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }

    }
}
