using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la2
{
    class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            this._name = name;
            this._age = age;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
