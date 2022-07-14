using CirnoEngine.Utils;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirnoEngine.Input
{
    class KeyboardInput
    {
        public static KeyboardState keys;

        public static bool capslock
        {
            get { return keys.CapsLock; }
        }
        public static void Update()
        {
            keys = Keyboard.GetState();
        }

        public static Keys[] GetPressed()
        {
            return keys.GetPressedKeys();
        }

        public static bool IsKeyDown(Keys key)
        {
            return keys.IsKeyDown(key);
        }

        public static bool IsKeyUp(Keys key)
        {
            return keys.IsKeyUp(key);
        }
    }
}
