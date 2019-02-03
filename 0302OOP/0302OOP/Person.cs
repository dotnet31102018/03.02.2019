using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP
{
    class Person
    {
        public int id;
        public string name;
        public string address;
        public char gender; // 'M' 'F'

        public void foo()
        {

        }

        public Person()
        {

        }

        public Person(int id) : this()
        {
            this.id = id;

            foo();
            this.foo(); // the same as foo()
        }

        public Person(int id, string name, string address) : this(id)
        {
            this.name = name;
            this.address = address;
        }

        public Person(int id, string name, string address, char gender) : this(id, name, address)
        {
            this.gender = gender;
        }
    }
}
