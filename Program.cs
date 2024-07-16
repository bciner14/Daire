using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Lütfen dairenin yarıçapını giriniz: ");
        int radius;
        while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0)
        {
            Console.Write("Geçerli bir pozitif tamsayı giriniz: ");
        }

        CircleGenerator generator = new CircleGenerator();
        char[,] circle = generator.GenerateCircle(radius);

        CircleDrawer drawer = new CircleDrawer();
        drawer.DrawCircle(circle);
    }
}
