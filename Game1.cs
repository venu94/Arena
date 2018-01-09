using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace arena_trail
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private PrimitiveBatch primitiveBatch;

        //Textures
        private Texture2D backgroundTexture;
        private Texture2D boxTexture;
        private Texture2D robotTexture;

        private Texture2D image;
        private Rectangle imageRectangle;

        private Texture2D gridMatrix;

        //screen properties
        private int screenWidth = 800;
        private int screenHeight = 800;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = Setting.ReslutionWidth,
                PreferredBackBufferHeight = Setting.ReslutionHeight
            };
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            backgroundTexture = Content.Load<Texture2D>("Images/background1");
            boxTexture = Content.Load<Texture2D>("Images/box");
            robotTexture = Content.Load<Texture2D>("Images/robot");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            try
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                DrawBackground();
                DrawStaticObstacles();
                // DrawDynamicObstacle();
                //DrawRobot();

                spriteBatch.End();

                // TODO: Add your drawing code here

                base.Draw(gameTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("DrawPlayers() Exception : " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void DrawBackground()
        {
            Rectangle screenRectangle = new Rectangle(0, 0, screenHeight, screenWidth);
            spriteBatch.Draw(backgroundTexture, screenRectangle, Color.White);
        }

        private void DrawStaticObstacles()
        {
            // Dummy Two-dimensional array.
            int[,] array2D = {
                {0, 0}, {0, 1}, {0, 2}, {0, 3}, {0, 4}, {0, 5}, {0, 6}, {0, 7}, {0, 8}, {0, 9},
                {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}, {6, 0}, {7, 0}, {8, 0}, {9, 0}
            };

            for (var i = 0; i < array2D.GetLength(0); i++)
            {
                DrawStaticObstacle(array2D[i, 0], array2D[i, 1]);
            }
        }

        private void DrawStaticObstacle(int x, int y)
        {
            Rectangle screenRectangle = new Rectangle(0 + Setting.TileSize * x, 0 + Setting.TileSize * y,
                Setting.TileSize,
                Setting.TileSize);
            spriteBatch.Draw(boxTexture, screenRectangle, Color.White);
        }
    }
}