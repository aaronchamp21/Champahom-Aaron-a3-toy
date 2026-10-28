using System;
using System.Numerics;

namespace MohawkGame2D;

public class Tree
{
    public float x = 400;
    public float y = 420;
    public float speed = 3;

    public void Update()
    {
        // Move the tree to the left
        x -= speed;

        // Loop back to the right
        if (x < -60)
        {
            x = 850;
        }

        // Tree trunk touches the ground beside the road
        Draw.SetFillColor(120, 70, 30);
        Draw.SetLineColor(70, 40, 20);
        Draw.SetLineSize(2);
        Draw.Rectangle(x - 10, 420, 20, 60);

        // Green tree leaves
        Draw.SetFillColor(30, 150, 50);
        Draw.SetLineColor(20, 100, 30);
        Draw.Circle((int)x, 390, 30);
        Draw.Circle((int)x - 20, 405, 22);
        Draw.Circle((int)x + 20, 405, 22);
    }
}