using CreationalDesignPatterns.Interfaces;
using System.Drawing;

namespace CreationalDesignPatterns.Shapes;


/// <summary>
/// Прямоугольник шириной = width и высотой = height
/// </summary>
internal class Rectangle : Shape, IMyCloneable<Rectangle>, ICloneable
{
    public int Width { get; }
    public int Height { get; }


    public Rectangle(int width, int height, Color color) : base(color)
    {
        Width = width;
        Height = height;
    }

    // Конструктор для копирования
    public Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }

    public override void Draw(string name)
    {
        Console.WriteLine("Rectangle {0} with width: {1} and height: {2} is drawn.", name, Width, Height);
    }

    public Rectangle DeepClone()
    {
        return new Rectangle(this);
    }

    public object Clone()
    {
        return DeepClone();
    }
}
