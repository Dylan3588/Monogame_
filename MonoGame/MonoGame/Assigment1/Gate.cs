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
    internal class Gate : GameObject
    {
        Game1 game1;
        Rectangle collider;
        Player player;
        public Gate(Vector2 pPosition, Texture2D pTexture, Color pColor, Game1 pGame1, Rectangle pCollider, Player pPlayer) : base(pPosition, pTexture, pColor)
        {
            collider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
            game1 = pGame1;
            player = pPlayer;
        }
        public override void Update()
        {
            Collider();
            base.Update();
        }

        public void Collider()
        {
            if (player.PlayerCollider.Intersects(collider))
            {
                game1.Exit();
            }
        }
    }   
}
