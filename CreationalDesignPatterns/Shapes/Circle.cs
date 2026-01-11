using CreationalDesignPatterns.Interfaces;
using System.Drawing;
using Point = CreationalDesignPatterns.Tools.Point;

namespace CreationalDesignPatterns.Shapes;


/// <summary>
/// Круг радиусом = radius и центром в точке x,y
/// </summary>
internal class Circle : Shape, IMyCloneable<Circle>, ICloneable
{
    public int Radius { get; set; }
    public Point CenterPoint { get; set; }


    public Circle(int radius, int x, int y, Color color) : base(color)
    {
        Radius = radius;
        CenterPoint = new Point(x, y);
    }

    // Конструктор для копирования
    public Circle(Circle source) : base(source)
    {
        Radius = source.Radius;
        // При использовании стандартного интерфейса нужно делать приведение к нужному типу
        CenterPoint = (Point)source.CenterPoint.Clone();
    }

    public override void Draw(string name)
    {
        Console.WriteLine("Circle {0} with radius: {1} and center in point x: {2}, y: {3} is drawn. Color: {4}", name, Radius, CenterPoint.X, CenterPoint.Y, Color);
    }


    #region IMyCloneable

    public Circle DeepClone()
    {
        return new Circle(this);
    }

    #endregion IMyCloneable


    #region ICloneable

    public object Clone()
    {
        return DeepClone();
    }

    #endregion ICloneable
}
