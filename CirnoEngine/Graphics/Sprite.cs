using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using CirnoEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CirnoEngine.Graphics
{
    class Sprite : GameObject
    {
        public Texture2D texture;

        public Sprite(int x, int y, string path = null, string name = "", string tag = "") : base (x, y, name, tag)
        {
            LoadImage(path);
        }

        public void LoadImage(string path)
        {
            if (path == null) return;
            try
            {
                texture = Engine.Content.Load<Texture2D>(path);
                width = texture.Width;
                height = texture.Height;
                return;
            } catch (Exception err)
            {
                throw err;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            if (texture != null)
            {
                Engine.spriteBatch.Draw(texture, position, rect, Color.White);
            }
            base.Draw(gameTime);
        }
    }
}
