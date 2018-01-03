using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_trail
{
    class Setting
    {
        //Resolution
        public static int ReslutionWidth = 800;
        public static int ReslutionHeight = 450;

        public static int GridSize = 10;
        public static int TileSize = ReslutionHeight / GridSize;

        internal static void Refresh()
        {
            TileSize = ReslutionHeight / GridSize;
        }

        internal static void SetFullScreen(GraphicsDeviceManager graphics)
        {
            graphics.IsFullScreen = true;
            Setting.ReslutionWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            Setting.ReslutionHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            Setting.Refresh();

        }
    }
}
