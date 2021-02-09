using System;
using Raylib_cs;
using System.Numerics;

namespace Asteroids
{
    class Program
    {
        public int windowWidth = 800;
        public int windowHeight = 450;
        public string windowTitle = "ASTEROIDS";

        Player player;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();
        }

        void RunGame()
        {
            Raylib.InitWindow(windowWidth, windowHeight, windowTitle);
            Raylib.SetTargetFPS(60);

            LoadGame();

            while(!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            }



            Raylib.CloseWindow();
        }


        void LoadGame()
        {
            Assets.LoadAssets();

            player = new Player(
                this,
                new Vector2(windowWidth / 2, windowHeight / 2),
                new Vector2(64, 64)
                 );
        }

        void Update()
        {
            player.Update();
        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKBLUE);

            player.Draw();

            Raylib.EndDrawing();
        }
    }
}
 