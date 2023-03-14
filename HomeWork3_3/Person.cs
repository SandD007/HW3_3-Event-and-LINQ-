using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3
{
    public class Person
    {
        public Person(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        private string Name { get; set; }

        private int ID { get; set; }

        public override string ToString()
        {
            return $"{this.Name} his ID: {this.ID}";
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetID()
        {
            return this.ID;
        }
    }
}
