using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservableCollection
{
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public override string ToString()
        {
            return $"Name = {Name}; Age = {Age}";
        }
    }
}
