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
        public Gate(Vector2 pPosition, Texture2D pTexture, Color pColor) : base(pPosition, pTexture, pColor)
        {
        }
        public override void Update()
        {
            base.Update();
        }
    }   
}
