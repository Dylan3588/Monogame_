using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Assigment1;
using System.Collections.Generic;


namespace MonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        List<GameObject> gameObjects = new List<GameObject>();
        protected Texture2D knight;
        Texture2D gate;
        Texture2D shield;
        Texture2D knightShield;
        Texture2D knightWeapon;
        Texture2D weapon;
        Texture2D knightShieldWeapon;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            knight = Content.Load<Texture2D>("Sprites/knight");
            weapon = Content.Load<Texture2D>("Sprites/weapon");
            shield = Content.Load<Texture2D>("Sprites/shield");
            gate = Content.Load<Texture2D>("Sprites/gate");
            knightShield = Content.Load<Texture2D>("Sprites/knightShield");
            knightWeapon = Content.Load<Texture2D>("Sprites/knightWeapon");
            knightShieldWeapon = Content.Load<Texture2D>("Sprites/knightWeaponShield");
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            gameObjects.Add(new Player(new Vector2(200, 200), knight, Color.White, this));
            gameObjects.Add(new Weapon(new Vector2(100, 100), weapon, Color.White));
            gameObjects.Add(new Shield(new Vector2(700, 350), shield, Color.White));
            gameObjects.Add(new Gate(new Vector2(700, 50), gate, Color.White, this, Rectangle.Empty, (Player)gameObjects[0]));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(_spriteBatch);
            }
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}