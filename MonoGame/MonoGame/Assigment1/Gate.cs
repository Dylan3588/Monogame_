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
        // variable for gate class
        Game1 game1;
        Rectangle gateCollider;
        Player player;

        // constructor for gate class
        public Gate(Vector2 pPosition, Texture2D pTexture, Color pColor, Game1 pGame1, Player pPlayer) : base(pPosition, pTexture, pColor)
        {
            gateCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
            game1 = pGame1;
            player = pPlayer;
        }

        // override method for update
        public override void Update()
        {
            Collider();
            base.Update();
        }

        // collider to check for interecting with gatesw
        public void Collider()
        {
            if (player.PlayerCollider.Intersects(gateCollider))
            {
                game1.Exit();
            }
        }
    }   
}
