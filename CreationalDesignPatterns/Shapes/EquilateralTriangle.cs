using CreationalDesignPatterns.Interfaces;
using System.Drawing;

namespace CreationalDesignPatterns.Shapes;

/// <summary>
/// Равносторонний треугольник. Наследник класса Triangle, у которого все стороны одинаковые.
/// </summary>
internal class EquilateralTriangle : Triangle, IMyCloneable<EquilateralTriangle>
{
    public EquilateralTriangle(int a, Color color) : base(a, a, a, color)
    {
    }

    // Конструктор для копирования
    public EquilateralTriangle(EquilateralTriangle source) : base(source)
    {
    }


    public override void Draw(string name)
    {
        Console.WriteLine("Equilateral triangle {0} with sides: {1} is drawn.", name, A);
    }

    #region IMyCloneable

    public new EquilateralTriangle DeepClone()
    {
        return new EquilateralTriangle(this);
    }

    #endregion IMyCloneable
}
