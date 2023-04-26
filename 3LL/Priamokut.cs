using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class Priamokut
{
    public int a;
    public int b;
    public string name;
    public int x;
    public int y;
    public int SideA
    {
        get { return a; }
        set { a = value; }
    }
    public int SideB
    {
        get { return b; }
        set { b = value; }
    }
    public int CoordinateX
    {
        get { return x; }
        set { x = value; }
    }
    public int CoordinateY
    {
        get { return y; }
        set { y = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public void Generate(int a, int b, string name)
    {
        Console.WriteLine($"Створено прямокутник з ім'ям {name}, стороною а={a}см та стороною b={b}см");
    }
    public void Coordinete(int x, int y)
    {
        Console.WriteLine($"Координати лівого верхнього кута ({x},{y})");
    }
    public void Move(int x, int y)
    {
        Console.WriteLine("Переміщення вліво(зі знаком мінус), переміщення вправо(без знака мінус)");
        int dx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Переміщення вниз(зі знаком мінус), переміщення вгору(без знака мінус)");
        int dy = Convert.ToInt32(Console.ReadLine());
        int x1 = x + dx;
        int y1 = y + dy;
        Console.WriteLine($"Тепер координати верхнього лівого кута ({x1},{y1})");
    }
    public void Resize(int a, int b)
    {
        Console.WriteLine("Зменшення висоти(зі знаком мінус), збільшення висоти(без знака мінус)");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Зменшення ширини(зі знаком мінус), збільшення ширини(без знака мінус)");
        int b1 = Convert.ToInt32(Console.ReadLine());
        int a_Resize = a + a1;
        int b_Resize = b + b1;
        Console.WriteLine($"Змінена висота прямокутника - {a_Resize}. Змінена ширина прямокутника - {b_Resize}");
    }
    public void Union(int x, int y, int a, int b, int x1, int y1, int a1, int b1)
    {
        int minX = Math.Min(x, x1);
        int minY = Math.Min(y, y1);
        int maxX = Math.Max(y + b, y1 + b1);
        int maxY = Math.Max(x + a, x1 + a1);
        int width = maxX - minX;
        int height = maxY - minY;
        Console.WriteLine("Найменший прямокутник, що охоплює обидва задані прямокутники:");
        Console.WriteLine($"Верхній лівий кут: ({minX}, {minY})");
        Console.WriteLine($"Ширина: {width}");
        Console.WriteLine($"Висота: {height}");
    }
    public void Intersect(int x, int y, int a, int b, int x1, int y1, int a1, int b1)
    {
        int x_min = Math.Max(x, x1);
        int y_min = Math.Max(y, y1);
        int x_max = Math.Min(x + b, x1 + b1);
        int y_max = Math.Min(y + a, y1 + a1);
        if (x_min >= x_max || y_min >= y_max)
        {
            Console.WriteLine("Прямокутники не перетинаються");
        }
        else
        {
            int h = y_max - y_min;
            int w = x_max - x_min;
            Console.WriteLine($"Координати верхнього лівого кута прямокутника-перетину: ({x_min},{y_min})");
            Console.WriteLine($"Розміри прямокутника-перетину: ширина - {w}, висота - {h}");
        }
    }
}