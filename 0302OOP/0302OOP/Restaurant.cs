using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP
{
    class Restaurant
    {
        public string name;
        public string foodType;
        public int capacity;
        public bool parking;

        public Restaurant(string name)
        {
            this.name = name;
        }

        public Restaurant(string name, string foodType) : this(name)
        {
            this.foodType = foodType;
        }

        public Restaurant(string name, string foodType, int capacity) : this(name, foodType)
        {
            this.capacity = capacity;
        }

        public Restaurant(string name, string foodType, int capacity, bool parking) : this(name, foodType, capacity)
        {
            this.parking = parking;
        }
    }
}
