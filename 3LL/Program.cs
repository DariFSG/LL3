//Скласти опис класу прямокутників зі сторонами, паралельними осям координат.Передбачити можливість переміщення прямокутників на площині, зміна розмірів,
//побудова найменшого прямокутника, що містить два заданих прямокутники, і прямокутника,що є спільною частиною (перетином) двох прямокутників.
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Priamokut priam = new Priamokut();
        Console.WriteLine("Введіть висоту  прямокутника:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть ширину  прямокутника:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть назву прямокутника:");
        string name = Convert.ToString(Console.ReadLine());
        priam.b = b;
        priam.a = a;
        priam.Name = name;
        Console.WriteLine("Введіть координату х верхнього лівого кута прямокутника:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть координату у верхнього лівого кута прямокутника:");
        int y = Convert.ToInt32(Console.ReadLine());
        priam.x = x;
        priam.y = y;
        priam.Generate(a, b, name);
        priam.Coordinete(x, y);
        Priamokut priam1 = new Priamokut();
        Console.WriteLine("Введіть висоту 2 прямокутника:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть ширину 2 прямокутника:");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть назву 2 прямокутника:");
        string name1 = Convert.ToString(Console.ReadLine());
        priam1.b = b1;
        priam1.a = a1;
        priam1.Name = name1;
        Console.WriteLine("Введіть координату х верхнього лівого кута 2 прямокутника:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть координату у верхнього лівого кута 2 прямокутника:");
        int y1 = Convert.ToInt32(Console.ReadLine());
        priam1.x = x1;
        priam1.y = y1;
        priam1.Generate(a1, b1, name1);
        priam1.Coordinete(x1, y1);
        priam.Union(x, y, a, b, x1, y1, a1, b1);
        priam.Intersect(x, y, a, b, x1, y1, a1, b1);
        priam.Move(x, y);
        priam.Resize(a, b);
        using (FileStream fs = new FileStream("C:\\Users\\KEY\\Downloads\\LL3.json", FileMode.OpenOrCreate))
        {
            JsonSerializer.SerializeAsync<Priamokut>(fs, priam);
        }
    }
}