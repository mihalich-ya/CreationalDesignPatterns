using CreationalDesignPatterns.Shapes;
using System.Drawing;

namespace CreationalDesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        // Создаём прототип круга
        var circle1 = new Circle(20, 50, 50, Color.Red);

        // Копируем круг
        var circle2 = circle1.DeepClone();

        // Отобразим информацию о первом круге
        circle1.Draw(nameof(circle1));

        // Поменяем у первого круга например точку по оси Х и сменим цвет
        circle1.CenterPoint.X = 70;
        circle1.Color = Color.Aqua;

        // Снова отобразим информацию о первом круге
        circle1.Draw(nameof(circle1));

        // Отобразим информацию о втором круге. 
        // Увидим, что это два независимых объекта и второй (клонированный) круг имеет значения первого до изменений.
        circle2.Draw(nameof(circle2));
    }
}
