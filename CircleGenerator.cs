public class CircleGenerator
{
    public char[,] GenerateCircle(int radius)
    {
        int diameter = 2 * radius + 1;
        char[,] circle = new char[diameter, diameter];

        for (int i = 0; i < diameter; i++)
        {
            for (int j = 0; j < diameter; j++)
            {
                double distance = Math.Sqrt((i - radius) * (i - radius) + (j - radius) * (j - radius));
                if (distance <= radius)
                {
                    circle[i, j] = '*';
                }
                else
                {
                    circle[i, j] = ' ';
                }
            }
        }
        return circle;
    }
}
