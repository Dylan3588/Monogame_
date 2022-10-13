using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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

        //Texturess
        //protected Texture2D knight;
        //protected Texture2D knightShield;
        //protected Texture2D knightWeapon;
        //protected Texture2D knightShieldWeapon;

        // enum for the playerstate
        public enum PlayerState
        { 
            None,
            Shield,
            Weapon,
            KnightWeaponShield
        }

        // rectangle for the player
        public Rectangle PlayerCollider
        {
            get { return playerCollider; }
        }
        // PlayerState for the player to other scripts
        public PlayerState playerState { get; set; } = PlayerState.None;

        // constructor for the player
        public Player(Vector2 pPosition, Texture2D pTexture, Color pColor, Game1 pGame1) : base(pPosition, pTexture, pColor)
        {
            playerCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
            game1 = pGame1;
        }

        //public void LoadContent(ContentManager pContent)
        //{
        //    knight = pContent.Load<Texture2D>("Sprites/knight");
        //    knightShield = pContent.Load<Texture2D>("Sprites/knightShield");
        //    knightWeapon = pContent.Load<Texture2D>("Sprites/knightWeapon");
        //    knightShieldWeapon = pContent.Load<Texture2D>("Sprites/knightWeaponShield");

        //    _texture = knight;

        //    //state switch
        //    _texture = knightShield;
        //}

        // override to update scripts
        public override void Update()
        {
            Move();
            UpdateCollider();
            base.Update();
        }

        // constructor for the player to switch between the different states
        public override void Draw(SpriteBatch batch)
        {
            switch (playerState)
            {
                case PlayerState.None:
                    batch.Draw(_texture, _position, Color.White);
                    break;
                case PlayerState.Shield:
                    batch.Draw(game1.KnightShield, _position, Color.White);
                    break;
                case PlayerState.Weapon:
                    batch.Draw(game1.KnightWeapon, _position, Color.White);
                    break;
                case PlayerState.KnightWeaponShield:
                    batch.Draw(game1.KnightShieldWeapon, _position, Color.White);
                    break;
            }   
            
        }



        // movement script to move the player 
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

        // collider for the player 
        public void UpdateCollider()
        {
            playerCollider = new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
        }
    }
}
