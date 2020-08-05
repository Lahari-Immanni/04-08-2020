using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListInCollections
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }
        public void DisplayPerson()
        {
            Console.WriteLine("Age is : {0},First name is : {1},Last name is : {2},city is : {3}",age,fname,lname,city);
        }
        static void Main(string[] args)
        {
            List<Person> li = new List<Person>();
            li.Add(new Person(21, "lahari", "Immanni", "ndd"));
            li.Add(new Person(23, "mouni", "Immanni", "ndd"));
            li.Add(new Person(15, "vikas", "Jujjavarapu", "ndd"));
            li.Add(new Person(12, "hema", "Jujjavarapu", "ndd"));
            li.Add(new Person(21, "Rahul", "Jujjavarapu", "ndd"));
            li.ForEach(delegate (Person p1)
            {
                p1.DisplayPerson();
            }
            );
            Console.Read();
        }
    }
}
