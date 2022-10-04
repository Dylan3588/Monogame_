using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace MonoGame.Assigment1
{
    internal class GameObject
    {
        // texture
        protected Texture2D _texture;
        protected Vector2 _position;
        protected Color _color;

        public virtual void Update()
        {
          
        }


        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
        public GameObject(Vector2 pPosition)
        {

        }
    }
}
