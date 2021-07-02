using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Musteri
    {
        public Musteri(int id, string name, string lastName, int age, int birthYear)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.birthYear = birthYear;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int birthYear { get; set; }

        public override string ToString()
        {
            string expression = "Musteri Bilgileri:"
                + "\nId:" + id
                + "\nName: " + name
                + "\nLast Name: " + lastName
                + "\nAge: " + age
                + "\nBirth Year: " + birthYear;
            return expression;
        }
    }

}
