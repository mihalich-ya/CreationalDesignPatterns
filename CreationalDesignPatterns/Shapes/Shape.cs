using System.Drawing;

namespace CreationalDesignPatterns.Shapes;

/// <summary>
/// Общий класс фигура
/// </summary>
internal abstract class Shape
{
    protected Shape(Color color)
    {
        Color = color;
    }


    // Конструктор для копирования
    protected Shape(Shape source)
    {
        Color = source.Color;
    }

    public Color Color { get; set; }

    public virtual void Draw(string name)
    {
        Console.WriteLine("Shape {0} is drawn.", name);
    }
}
