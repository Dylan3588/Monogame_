using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Assigment1;
using System.Collections.Generic;


namespace MonoGame
{
    public class Game1 : Game
    {
        // Graphics
        private GraphicsDeviceManager _graphics;
        // spritebatch
        private SpriteBatch _spriteBatch;
        public List<GameObject> gameObjects = new List<GameObject>();

        
        // all textures used in the game
        protected Texture2D knight;
        protected Texture2D gate;
        protected Texture2D shield;
        protected Texture2D knightShield;
        protected Texture2D knightWeapon;
        protected Texture2D weapon;
        protected Texture2D knightShieldWeapon;

        // Textures used to get it to other classes
        public Texture2D KnightShield
        {
            get { return knightShield; }
            set { knightShield = value; }
        }

        public Texture2D KnightWeapon
        {
            get { return knightWeapon; }
            set { knightWeapon = value; }
        }

        public Texture2D KnightShieldWeapon
        {
            get { return knightShieldWeapon; }
            set { knightShieldWeapon = value; }
        }

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // load all textures
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
            // add all textures to the game 
            Player player = new Player(new Vector2(200, 200), knight, Color.White, this);
            //player.LoadContent(Content);
            
            gameObjects.Add(player);
            gameObjects.Add(new Weapon(new Vector2(100, 100), weapon, Color.White, this, player));
            gameObjects.Add(new Shield(new Vector2(700, 350), shield, Color.White, this, player));
            gameObjects.Add(new Gate(new Vector2(700, 50), gate, Color.White, this, player));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Draw(_spriteBatch);
            }
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}