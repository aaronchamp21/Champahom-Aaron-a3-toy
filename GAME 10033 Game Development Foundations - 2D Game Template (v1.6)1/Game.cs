using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    Airplane airplane = new Airplane();

    Cloud cloud1 = new Cloud();
    Cloud cloud2 = new Cloud();
    Cloud cloud3 = new Cloud();

    Road road = new Road();

    Car car1 = new Car();


    Tree tree1 = new Tree();
    Tree tree2 = new Tree();
    Tree tree3 = new Tree();
    Tree tree4 = new Tree();
    Tree tree5 = new Tree();
    public void Setup()
    {
        Window.SetTitle("Airplane");
        Window.SetSize(800, 600);

        cloud1.x = 200;
        cloud1.y = 100;
        cloud1.speed = 1;

        cloud2.x = 500;
        cloud2.y = 180;
        cloud2.speed = 2;

        cloud3.x = 750;
        cloud3.y = 80;
        cloud3.speed = 1.5f;

        tree1.x = 100;
        tree2.x = 260;
        tree3.x = 420;
        tree4.x = 580;
        tree5.x = 740;

        tree1.speed = 3;
        tree2.speed = 3;
        tree3.speed = 3;
        tree4.speed = 3;
        tree5.speed = 3;

        car1.x = 100;


        car1.speed = 3;

    }

    public void Update()
    {
        Window.ClearBackground(200, 230, 255);

        road.Update();

        car1.Update();


        tree1.Update();
        tree2.Update();
        tree3.Update();
        tree4.Update();
        tree5.Update();


        // Clouds move and loop
        cloud1.Update(airplane.x, airplane.y);
        cloud2.Update(airplane.x, airplane.y);
        cloud3.Update(airplane.x, airplane.y);

        // Airplane follows mouse
        airplane.x = Input.GetMouseX();
        airplane.y = Input.GetMouseY();

        // Stop the airplane from going too low
        if (airplane.y > 300)
        {
            airplane.y = 300;
        }
        airplane.Update();
    }
}

