using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la2
{
    class Classroom
    {
        private string name;
        private Person[] persons;

        public string getName(string name)
        {
            return name;
        }

        public Classroom(string name, Person[] people)
        {
            this.name = name;
            persons = people;
        }

        public override string ToString()
        {
            for (int i = 0; i < persons.Length; i++)
            {
                return $"classroom: {name} \n {persons[i].ToString()}";
            }
            return $"classroom: {name} \n {persons[0].ToString()}";
        }
    }
}
