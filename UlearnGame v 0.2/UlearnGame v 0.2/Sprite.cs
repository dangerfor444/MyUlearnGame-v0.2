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
    public class Sprite : Component
    {
        protected Texture2D _texture;

        protected float _rotations;

        protected KeyboardState _currentKey;

        protected KeyboardState _previousKey;

        public Vector2 Origin;

        public Vector2 Position;
        

        public List<Sprite> People { get; set; }

        public Color Colour { get; set; }

        public Vector2 Direction;

        public float RotationVelocity = 3f;

        public float LinearVelocity = 4f;

      

        public readonly Color[] TextureData;
       
        public Sprite(Texture2D texture)
        {
            _texture = texture;

            Origin = new Vector2(_texture.Width / 2, _texture.Height / 2);

            People = new List<Sprite>();

            Colour = Color.White;

            TextureData = new Color[_texture.Width * _texture.Height];
            _texture.GetData(TextureData);
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, null, Colour, _rotations, Origin, 1, SpriteEffects.None, 0);
        }

    }
}
