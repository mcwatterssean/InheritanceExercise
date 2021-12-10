using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }

        public string Type { get; set; }

        public bool HasFeathers { get; set; }

        public bool CanFly { get; set; }

        public Bird()
        {

        }

        public Bird (string name, int age, int legs, bool isWarmBlooded, bool hasFeathers, bool canFly, int wings, string type)
        {
            Name = name;
            Age = age;
            Legs = legs;
            IsWarmBlooded = isWarmBlooded;
            HasFeathers = hasFeathers;
            CanFly = canFly;
            Wings = wings;
            Type = type;

        }




    }

}
