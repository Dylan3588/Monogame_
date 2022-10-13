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
    internal class Shield : GameObject
    {

        //variable for shield class
        Rectangle shieldCollider;
        Game1 game1;
        Player player;

        // constructor for shield class
        public Shield(Vector2 pPosition, Texture2D pTexture, Color pColor, Game1 pGame1, Player pPlayer) : base(pPosition, pTexture, pColor)
        {
            shieldCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
            game1 = pGame1;
            player = pPlayer;
        }

        // override method for update
        public override void Update()
        {
            Collider();
            base.Update();
        }

        // collider to check for interecting with shield
        public void Collider()
        {
            
            
            if (player.PlayerCollider.Intersects(shieldCollider))
            {
                if (player.playerState == Player.PlayerState.Weapon)
                {
                        player.playerState = Player.PlayerState.KnightWeaponShield;
                }
                else
                {
                    player.playerState = Player.PlayerState.Shield;
                }                    
               game1.gameObjects.Remove(this);
            }
                       
        }
    }
}
