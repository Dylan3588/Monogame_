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
        protected Rectangle weaponCollider;
        public Weapon(Vector2 pPosition, Texture2D pTexture, Color pColor) : base(pPosition, pTexture, pColor)
        {
            _texture = pTexture;
            weaponCollider = new Rectangle((int)pPosition.X, (int)pPosition.Y, _texture.Width, _texture.Height);
        }

        public override void Update()
        {
            base.Update();
        }
        
        public void Collicion()
        {
           
        }
    }
    
}
