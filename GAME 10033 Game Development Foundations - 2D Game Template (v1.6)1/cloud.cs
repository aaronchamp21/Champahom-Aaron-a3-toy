using System;

namespace MohawkGame2D
{
    public class Cloud
    {
        public float x = 200;
        public float y = 150;
        public float speed = 2;
        public bool visible = true;

        private int respawnTimer = 0;

        public void Update(float planeX, float planeY)
        {
            // If the cloud disappeared, wait before respawning
            if (!visible)
            {
                respawnTimer++;

                if (respawnTimer > 120)
                {
                    visible = true;
                    respawnTimer = 0;
                    x = 850;
                }

                return;
            }

            // Move the cloud to the left
            x -= speed;

            // Respawn if it leaves the screen
            if (x < -60)
            {
                x = 850;
            }

            // Disappear when the airplane touches the cloud
            if (Math.Abs(planeX - x) < 190 &&
                Math.Abs(planeY - y) < 65)
            {
                visible = false;
                respawnTimer = 0;
                return;
            }

            // Draw the cloud
            Draw.SetFillColor(255, 255, 255);
            Draw.SetLineColor(180, 210, 230);
            Draw.SetLineSize(2);

            Draw.Ellipse(x - 50, y - 10, 100, 35);
            Draw.Circle((int)x - 30, (int)y - 10, 20);
            Draw.Circle((int)x, (int)y - 20, 25);
            Draw.Circle((int)x + 28, (int)y - 10, 20);
        }
    }
}
