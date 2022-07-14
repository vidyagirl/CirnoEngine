using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirnoEngine.Core
{
    class GameBasic
    {
        public string name;
        public string tag;

        public bool canUpdate = true;
        public bool canDraw = true;

        public GameBasic(string name = "", string tag = "")
        {
            this.name = name;
            this.tag = tag;
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(GameTime gameTime)
        {

        }
    }
}
