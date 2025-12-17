//Напишите обобщенный метод Swap<T>(ref T x, ref T y), который меняет местами значения двух переменных типа T.
//Затем модифицируйте этот метод так, чтобы он мог работать только с типами, которые являются ссылочными типами
//(class) или типами значений (struct), но не с указателями (pointer) или динамическими типами (dynamic). Затем
//напишите пример вызова этого метода для различных типов данных, таких как int, string и Person.
namespace KT13_2;

class Program
{
    public static void Swap<T>(ref T x, ref T y) where T: notnull
    {
        T temp = x;
        x = y;
        y = temp;

    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }

    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Swap(ref a, ref b);

        Console.WriteLine($"a = {a}, b = {b}");

        string s1 = "Hello";
        string s2 = "World";
        Swap(ref s1, ref s2);
        Console.WriteLine($"string: s1 = {s1}, s2 = {s2}");

        Person p1 = new Person("Anna", 20);
        Person p2 = new Person("Bob", 25);
        Swap(ref p1, ref p2);
        Console.WriteLine($"Person: {p1}, {p2}");

    }
}

