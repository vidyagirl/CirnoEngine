using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirnoEngine.Core
{
    class GameObjectGroup : GameBasic
    {

        List<GameObject> gameObjects;
        public int length
        {
            get { return gameObjects.Count; }
        }

        public GameObject this[int key]
        {
            get => gameObjects[key];
            set => gameObjects[key] = value;
        }
        
        public GameObjectGroup(string name = "", string tag = "") : base(name, tag)
        {
            gameObjects = new List<GameObject>();
        }

        public void Update(GameTime gameTime)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(gameTime);
            } 
        }

        public void Draw(GameTime gameTime)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(gameTime);
            }
        }

        public GameObject Add(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
            return gameObject;
        }

        public GameObject Remove(GameObject gameObject)
        {
            gameObjects.Remove(gameObject);
            return gameObject;
        }

        public void Clear()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjects.Remove(gameObject);
            }
        }
    }
}
