using CirnoEngine.Core;
using CirnoEngine.Graphics;
using CirnoEngine.Input;
using CirnoEngine.System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using System.IO;

namespace CirnoEngine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Sprite cuteImage;
        private GameObjectGroup members;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Engine.game = this;
            Engine.graphics = _graphics;
            members = new GameObjectGroup();
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 2880;
            _graphics.PreferredBackBufferHeight = 1440;

            _graphics.ApplyChanges();

            FileSystem.Exists("cute_image");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Engine.spriteBatch = _spriteBatch;
            Engine.Content = Content;

            cuteImage = new Sprite(20, 20, "cute_image");
            members.Add(cuteImage);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardInput.Update();
            members.Update(gameTime);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            members.Draw(gameTime);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
