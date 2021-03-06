﻿using System;
using System.Collections.Generic;

namespace ObjectPrintingTests
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public Person Partner { get; set; }
        public int[] Marks { get; set; }
        public List<string> VisitedCountries { get; set; }
        public Dictionary<string, int> YearsPerJob { get; set; }
        public IEnumerable<int> SomeNumbers { get; set; }
        public int Weight;
        public bool Married;
        public List<List<int>> SomeNumbersLists;
    }
}