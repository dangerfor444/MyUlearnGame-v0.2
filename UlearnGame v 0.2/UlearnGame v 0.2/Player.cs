using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace UlearnGame
{
    public class Player : Sprite
    {
        public Player(Texture2D texture)
          : base(texture)
        {

        }

        public override void Update(GameTime gameTime)
        {
            _previousKey = _currentKey;
            _currentKey = Keyboard.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                _rotations -= MathHelper.ToRadians(RotationVelocity);

            else if (Keyboard.GetState().IsKeyDown(Keys.D))
                _rotations += MathHelper.ToRadians(RotationVelocity);

            var Direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - _rotations), -(float)Math.Sin(MathHelper.ToRadians(90) - _rotations));

            if (Keyboard.GetState().IsKeyDown(Keys.W))
                Position += Direction * LinearVelocity;
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
                Position -= Direction * LinearVelocity;
        }



    }
}
