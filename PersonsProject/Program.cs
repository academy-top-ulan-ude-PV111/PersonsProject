using System;

namespace PersonsProject
{
    enum Departament
    {
        Managers,
        Developers,
        Seo,
    }
    class Pasport
    {
        public string Seria { set; get; }
        public string Number { set; get; }
    }
    class Person<T>
    {
        public static T? SCode;
        public T Id { set; get; }
        public string? Name { set; get; }

        public Person(T id, string? name)
        {
            Id = id;
            Name = name;
        }   
    }

    class MyClass<T1, T2>
    {
        public T1 Prop1 { set; get; }
        public T2 Prop2 { set; get; }
    }

    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void InitVar(out int obj)
        {
            obj = 100;
        }
        static void Main(string[] args)
        {
            Person<int> person = new Person<int>(123, "Bob");
            Person<int>.SCode = 1234;

            Person<string> sperson = new Person<string>("XI-AD 0065467", "Joe");
            Person<string>.SCode = "12234";

            Person<Pasport> pperson = new Person<Pasport>(new Pasport { Seria = "OAW", Number = "1233456" }, "Tim");
            Person<Departament> dperson = new Person<Departament>(Departament.Managers, "Nick");

            MyClass<int, Person<int>> myClass = new MyClass<int, Person<int>>();
            MyClass<float, bool> obj = new MyClass<float, bool>();


            int v1 = 10;
            int v2 = 20;

            Swap<int>(ref v1, ref v2);

            Console.WriteLine($"{v1} {v2}");

            int v3;

            InitVar(out v3);

        }
    }
}