using System;
using System.Numerics;

namespace MohawkGame2D;

public class Road
{
    public void Update()
    {
        // Draw the road
        Draw.SetFillColor(60, 60, 60);
        Draw.SetLineColor(60, 60, 60);
        Draw.Rectangle(0, 480, 800, 120);

        // Draw yellow road markings
        Draw.SetFillColor(255, 220, 0);
        Draw.SetLineColor(255, 220, 0);

        for (int x = 0; x < 800; x += 100)
        {
            Draw.Rectangle(x, 535, 50, 6);
        }
    }
}