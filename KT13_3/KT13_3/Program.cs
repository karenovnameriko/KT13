//Напишите обобщенный метод Print<T>(T[] array), который выводит на консоль элементы массива типа T,
//разделенные запятыми. Затем модифицируйте этот метод так, чтобы он мог работать только с типами, которые
//наследуются от класса Object и переопределяют его метод ToString() для возвращения строкового представления
//объекта. Затем напишите пример вызова этого метода для различных типов данных, таких как int, string и Book.
namespace KT13_3;

class Program
{
    public static void Print<T>(T[] array) where T: notnull
    {
        for (int i=0; i<array.Length; i++)
        {
            Console.Write(array[i].ToString());
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} (${Price})";
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4 };
        Print(numbers);

        string[] words = { "apple", "banana", "cherry" };
        Print(words);

        Book[] books =
        {
            new Book("Clean Code", 50),
            new Book("C# in Depth", 40)
        };
        Print(books);
    }
}

