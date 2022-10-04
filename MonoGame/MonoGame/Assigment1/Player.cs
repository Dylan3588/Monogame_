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
    internal class PlayerIndex : GameObject
    {
        // speed of the player
        private float speed = 30f;
        // position of the player
     
        
        public override void Update()
        {
            base.Update();
            Move();
        }
        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
        }
        public player(Vector2 pPosition, Texture2D pTexture, Color pColor)
        {
 
        }
        


        public void Move()
        {
            // left movement
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _position.X -= speed;
            }
            // right movement
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _position.X += speed;
            }
            // up movement
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _position.Y -= speed;
            }
            // down movement
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _position.Y += speed;
            }
        }
    }
}
