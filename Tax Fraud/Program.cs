using System;
using System.Numerics;
using Raylib_cs;

// Do anything with this code, I don't fucking care lmfao
// I use C# and Raylib fyi

/* Who changed the code so far (don't forget to sign):
 PetrTech,

 */

namespace Tax_Fraud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tax Fraud is fun, right?\nYes it is");

            Program mainClass = new Program();
            mainClass.Render();
        }

        void Render()
        {
            Raylib.InitWindow(1280, 720, "Tax Fraud");

            Texture2D fraud = Raylib.LoadTexture("Tax fraud.png");
            Texture2D emoji = Raylib.LoadTexture("istockphoto-1015429508-1024x1024.jpg");

            Raylib.SetTargetFPS(10);

            float rotation = 0;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                rotation += 1 / 10;

                Raylib.DrawTexture(fraud, 0, 0, Color.WHITE);
                Raylib.DrawTextureEx(emoji, new Vector2(30, 50), rotation, 0.5f, Color.WHITE);

                Raylib.EndDrawing();
            }

            Raylib.UnloadTexture(fraud);

            Raylib.CloseWindow();
        }
    }
}
