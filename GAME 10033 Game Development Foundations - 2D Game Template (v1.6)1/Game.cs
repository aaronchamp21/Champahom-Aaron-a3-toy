using System;

namespace MohawkGame2D
{
    public class Game
    {
        Airplane airplane = new Airplane();

        Cloud cloud1 = new Cloud();
        Cloud cloud2 = new Cloud();
        Cloud cloud3 = new Cloud();

        Road road = new Road();
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
        }

        public void Update()
        {
            Window.ClearBackground(200, 230, 255);

            road.Update();
        

            // Clouds move and loop
            cloud1.Update(airplane.x, airplane.y);
            cloud2.Update(airplane.x, airplane.y);
            cloud3.Update(airplane.x, airplane.y);

            // Airplane follows mouse
            airplane.x = Input.GetMouseX();
            airplane.y = Input.GetMouseY();
            airplane.Update();
        }
    }
}

