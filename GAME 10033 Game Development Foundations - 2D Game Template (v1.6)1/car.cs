using System;
using System.Numerics;

namespace MohawkGame2D;

public class Car
{
    public float x = 200;
    public float y = 500;
    public float speed = 3;

    public void Update()
    {
        // Move the car to the left
        x -= speed;

        // Loop back to the right side
        if (x < -100)
        {
            x = 850;
        }

        // Car body
        Draw.SetFillColor(220, 30, 30);
        Draw.SetLineColor(0, 0, 0);
        Draw.SetLineSize(2);
        Draw.Rectangle(x, y, 100, 35);

        // Car roof
        Draw.Rectangle(x + 20, y - 20, 60, 25);

        // Windows
        Draw.SetFillColor(150, 220, 255);
        Draw.Rectangle(x + 27, y - 16, 20, 17);
        Draw.Rectangle(x + 51, y - 16, 22, 17);

        // Wheels
        Draw.SetFillColor(25, 25, 25);
        Draw.Circle((int)x + 22, (int)y + 35, 12);
        Draw.Circle((int)x + 78, (int)y + 35, 12);

        // Wheel hubs
        Draw.SetFillColor(190, 190, 190);
        Draw.Circle((int)x + 22, (int)y + 35, 5);
        Draw.Circle((int)x + 78, (int)y + 35, 5);
    }
}
