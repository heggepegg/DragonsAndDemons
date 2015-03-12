using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary;
using XRpgLibrary.Controls;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DragonsAndDemons.GameScreens
{
    public abstract partial class BaseGameState : GameState
    {
        #region Fields region

        protected Game1 GameRef;

        protected ControlManager ControlManager;

        protected PlayerIndex playerIndexInControl;
                
        #endregion

        #region Properties region
        #endregion

        #region Constructor Region

        public BaseGameState(Game game, GameStateManager manager)
            : base(game, manager)

        {
            GameRef = (Game1)game;

            playerIndexInControl = PlayerIndex.One;
        }

        #endregion

        #region XNA Method Region()

        protected override void LoadContent()
        {
            ContentManager content = Game.Content;

            SpriteFont menuFont = content.Load<SpriteFont>(@"Fonts\ControlFont");
            ContentManager = new ContentManager(menuFont);

 	        base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
 	        base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
 	        base.Draw(gameTime);
        }

        #endregion
    }
}
