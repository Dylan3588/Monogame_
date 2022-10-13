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
    internal class Weapon : GameObject
    {        
        // variable for weapon class
        protected Rectangle weaponCollider;
        Game1 game1;
        Player player;

        // constructor for weapon class
        public Weapon(Vector2 pPosition, Texture2D pTexture, Color pColor, Game1 pGame1, Player pPlayer) : base(pPosition, pTexture, pColor)
        {
            _texture = pTexture;
            weaponCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
            game1 = pGame1;
            player = pPlayer;
        }

        // override method for update
        public override void Update()
        {
            Collider();
            base.Update();           
        }

        
        // collider to check for interecting with weapon 
        public void Collider()
        {

            if (player.PlayerCollider.Intersects(weaponCollider))
            {
                if (player.playerState == Player.PlayerState.Shield)
                {
                    player.playerState = Player.PlayerState.KnightWeaponShield;
                    
                }
                else
                {
                    player.playerState = Player.PlayerState.Weapon;                   
                }                    
                game1.gameObjects.Remove(this);
            }
        }
    }
}
    

