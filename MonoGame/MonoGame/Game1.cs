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
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            gameObjects.Add(new Player(new Vector2(200, 200), Content.Load<Texture2D>("Sprites/Knight"), Color.White));
            gameObjects.Add(new Weapon(new Vector2(100, 100), Content.Load<Texture2D>("Sprites/Weapon"), Color.White));
            gameObjects.Add(new Shield(new Vector2(700, 350), Content.Load<Texture2D>("Sprites/Shield"), Color.White));
            gameObjects.Add(new Gate(new Vector2(700, 50), Content.Load<Texture2D>("Sprites/Gate"), Color.White));
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