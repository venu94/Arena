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
            graphics = new GraphicsDeviceManager(this);
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

            // gridMatrix = GenerateGrid(new Rectangle(0, 0, screenHeight, screenWidth), Setting.GridSize, Setting.GridSize, Color.SandyBrown);

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
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
                DrawStaticObstacle();
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
            // Rectangle screenRectangle = new Rectangle(10, 40, Setting.TileSize, Setting.TileSize);
            //  spriteBatch.Draw(boxTexture, screenRectangle, Color.White);

            for (var i = 0; i < 50; i++)
            { 
            
            }

             private void DrawStaticObstacle()
        {
            Rectangle screenRectangle = new Rectangle(10, 40, Setting.TileSize, Setting.TileSize);
              spriteBatch.Draw(boxTexture, screenRectangle, Color.White);


                 //int x, int y 
            
            /*
            private void DrawGridLines()
            {
                Rectangle screenRectangle = new Rectangle(0, 0, Setting.ReslutionWidth, Setting.ReslutionHeight);
                spriteBatch.Draw(gridMatrix, screenRectangle, Color.White);
            }

            private Texture2D GenerateGrid(Rectangle destRect, int cols, int rows, Color gridColor)
            {
                RenderTarget2D grid = new RenderTarget2D(GraphicsDevice, destRect.Width,
                    destRect.Height);
                try
                {
                    float gridCellWidth = destRect.Width / (float)cols;
                    float gridCellHight = destRect.Height / (float)rows;
                    int w = (int)(cols * gridCellWidth);
                    int h = (int)(rows * gridCellHight);

                    float uselessWidth = destRect.Width - w;
                    float uselessHight = destRect.Height - h;

                    Rectangle bounds = new Rectangle((int)(uselessWidth / 2) + destRect.X, (int)(uselessHight / 2) + destRect.Y, w, h);

                    GraphicsDevice.SetRenderTarget(grid);
                    GraphicsDevice.Clear(Color.Transparent);

                    primitiveBatch.Begin(PrimitiveType.LineList);

                    float x = bounds.X;
                    float y = bounds.Y;

                    for (int col = 0; col < cols + 1; col++)
                    {
                        primitiveBatch.AddVertex(new Vector2(x + (col * gridCellWidth), bounds.Top), gridColor);
                        primitiveBatch.AddVertex(new Vector2(x + (col * gridCellWidth), bounds.Bottom), gridColor);
                    }

                    for (int row = 0; row < rows + 1; row++)
                    {
                        primitiveBatch.AddVertex(new Vector2(bounds.Left, y + (row * gridCellHight)), gridColor);
                        primitiveBatch.AddVertex(new Vector2(bounds.Right, y + (row * gridCellHight)), gridColor);
                    }
                    primitiveBatch.End();

                    GraphicsDevice.SetRenderTarget(null);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("GenerateGrid() Exception : " + ex.Message);
                }
                return grid;
            }*/
        }
    }
}
