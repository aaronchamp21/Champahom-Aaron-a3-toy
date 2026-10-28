using System;
using System.Numerics;

namespace MohawkGame2D;

public class Airplane
{
    public float x = 400;
    public float y = 300;

    public void Update()
    {
        // Swept-back main wing
        Draw.SetFillColor(40, 100, 180);
        Draw.SetLineColor(0, 0, 0);
        Draw.SetLineSize(2);

        Draw.Triangle(
            new Vector2(x - 35, y + 5),
            new Vector2(x + 35, y - 55),
            new Vector2(x + 55, y + 5)
        );

        // Opposite wing
        Draw.Triangle(
            new Vector2(x - 35, y + 5),
            new Vector2(x + 35, y + 55),
            new Vector2(x + 55, y + 5)
        );

        // Main body
        Draw.SetFillColor(240, 245, 250);
        Draw.Ellipse(x, y, 240, 40);

        // Nose connected to the body
        Draw.SetFillColor(240, 245, 250);
        Draw.SetLineColor(0, 0, 0);
        Draw.SetLineSize(2);

        Draw.Triangle(
            new Vector2(x + 130, y),
            new Vector2(x + 100, y - 20),
            new Vector2(x + 100, y + 20)
        );

        // Cockpit
        Draw.SetFillColor(40, 100, 150);
        Draw.Ellipse(x + 75, y - 12, 18, 10);

        // Passenger windows
        Draw.SetFillColor(40, 100, 150);
        Draw.Circle((int)x - 65, (int)y, 4);
        Draw.Circle((int)x - 43, (int)y, 4);
        Draw.Circle((int)x - 21, (int)y, 4);
        Draw.Circle((int)x + 1, (int)y, 4);
        Draw.Circle((int)x + 23, (int)y, 4);
        Draw.Circle((int)x + 45, (int)y, 4);
    }
}