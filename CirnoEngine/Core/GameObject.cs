using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirnoEngine.Core
{
    class GameObject : GameBasic
    {

        public Vector2 position = Vector2.Zero;
        public Rectangle rect = Rectangle.Empty;

        public virtual int x
        {
            get { return (int)position.X; }
            set { position.X = value; rect.X = value; }
        }

        public virtual int y
        {
            get { return (int)position.Y; }
            set { position.Y = value; rect.X = value; }
        }

        public virtual int width
        {
            get { return rect.Width; }
            set { rect.Width = value; }
        }

        public virtual int height
        {
            get { return rect.Height; }
            set { rect.Height = value; }
        }

        public GameObject(int x, int y, string name, string tag) : base(name, tag)
        {
            this.x = x;
            this.y = y;
        }

        public GameObject(int x, int y, int width, int height, string name, string tag) : base(name, tag)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
