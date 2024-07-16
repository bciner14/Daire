using System;

public class CircleDrawer
{
    public void DrawCircle(char[,] circle)
    {
        int rows = circle.GetLength(0);
        int columns = circle.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(circle[i, j]);
            }
            Console.WriteLine();
        }
    }
}
