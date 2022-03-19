using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la2
{
    class Person
    {
        protected string _name;
        protected int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string getName()
        {
            return _name;
        }

        public int getAge()
        {
            return _age;
        }

        public override string ToString()
        {
            return $"Name: {_name}, age: {_age}";
        }

        public bool Equals(Person other)
        {
            if (other == null)
                return false;

            if (this._name == other._name && this._age == other._age)
                return true;
            else
                return false;
        }
    }
}
