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
    public class GameObject
    {
        // texture
        protected Texture2D _texture;
        protected Vector2 _position;
        protected Color _color;
     
        // constructor for the gameobject
        public GameObject(Vector2 pPosition, Texture2D pTexture, Color pColor)
        {
            _position = pPosition;
            _texture = pTexture;
            _color = pColor;
        }

        public GameObject(Vector2 pPosition, Texture2D pTexture)
        {
            _position = pPosition;
            _texture = pTexture;
            _color = Color.White;
        }

        public virtual void Update()
        {
        }

        // constructor for drawing the texture
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
