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
        Game1 game1;

        public Rectangle PlayerCollider
        {
            get { return playerCollider; }
        }
        public override void Update()
        {
            Move();
            UpdateCollider();
            base.Update();
        }
        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
        }
        public Player(Vector2 pPosition, Texture2D pTexture, Color pColor, Game1 pGame1) : base(pPosition, pTexture, pColor)
        {
            playerCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
            game1 = pGame1;
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

        public void UpdateCollider()
        {
            playerCollider = new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
        }
    }
}
