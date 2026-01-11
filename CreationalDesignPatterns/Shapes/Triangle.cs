using CreationalDesignPatterns.Interfaces;
using System.Drawing;

namespace CreationalDesignPatterns.Shapes;

/// <summary>
/// Треугольник со сторонами A,B,C
/// </summary>
internal class Triangle : Shape, IMyCloneable<Triangle>, ICloneable
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }


    public Triangle(int a, int b, int c, Color color) : base(color)
    {
        A = a;
        B = b;
        C = c;
    }

    // Конструктор для копирования
    public Triangle(Triangle source) : base(source)
    {
        A = source.A;
        B = source.B;
        C = source.C;
    }


    public override void Draw(string name)
    {
        Console.WriteLine("Triangle {0} with sides: {1}, {2}, {3} is drawn.", name, A, B, C);
    }

    public Triangle DeepClone()
    {
        return new Triangle(this);
    }

    public object Clone()
    {
        return DeepClone();
    }
}
