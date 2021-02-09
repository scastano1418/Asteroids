using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Text;

namespace Asteroids
{
    class Assets
    {

        public static Texture2D shipTexture;

        public static void LoadAssets()
        {
            shipTexture = Raylib.LoadTexture("./Assets/ship.png");
        }

    }
}
