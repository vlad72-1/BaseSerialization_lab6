using System;

namespace App
{

    [Serializable]
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int Post { get; set; }

        public Person (string name, int age, string city, int post)
        {
            Name = name;
            Age = age;
            City = city;
            Post = post;
        }

        public Person () { }
    }
}
