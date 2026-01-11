using CreationalDesignPatterns.Interfaces;

namespace CreationalDesignPatterns.Tools;


/// <summary>
/// Класс точки с координатами x и y
/// </summary>
internal class Point : IMyCloneable<Point>, ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }


    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(Point source)
    {
        X = source.X;
        Y = source.Y;
    }



    #region IMyCloneable

    public Point DeepClone()
    {
        return new Point(this);
    }

    #endregion IMyCloneable



    #region ICloneable

    public object Clone()
    {
        return DeepClone();
    }

    #endregion ICloneable
}
