using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOnThingsLearned
{
    class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }
        public void Info()
        {
            Console.WriteLine($"name: {Name};");
            Console.WriteLine($"age: {age};");
        }
    }
}
