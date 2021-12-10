using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string Environment { get; set; }

        public string Defense { get; set; }

        public bool HasScales { get; set; }

        public bool HasTail { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool isWarmBlooded, bool hasScales, bool hasTail, string defense, string environment)
        {
            Name = name;
            Age = age;
            Legs = legs;
            IsWarmBlooded = isWarmBlooded;
            HasScales = hasScales;
            HasTail = hasTail;
            Defense = defense;
            Environment = environment;

        }





    }
}
