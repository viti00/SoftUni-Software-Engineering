﻿using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public class Person
    {
        private const int minValue = 12;
        private const int maxValue = 90;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        [MyRequired]
        public string  Name { get; private set; }
        [MyRange(minValue, maxValue)]
        public int Age { get;private set; }
    }
}
