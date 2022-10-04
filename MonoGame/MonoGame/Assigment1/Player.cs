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
    internal class Player : GameObject
    {
        // speed of the player
        private float speed = 5f;
        protected Rectangle playerCollider;
    

        public override void Update()
        {
            Move();
            base.Update();
        }
        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
        }
        public Player(Vector2 pPosition, Texture2D pTexture, Color pColor) : base(pPosition, pTexture, pColor)
        {
            playerCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
        }       

        public void Move()
        {
            Vector2 direction = Vector2.Zero;
            
            // left movement
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                direction.X -= speed;
            }
            // right movement
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                direction.X += speed;
            }
            // up movement
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                direction.Y -= speed;
            }
            // down movement
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                direction.Y += speed;
            }

            if (direction != Vector2.Zero)
            {
                direction.Normalize();
                _position += direction * speed;
            }
        }
    }
}
