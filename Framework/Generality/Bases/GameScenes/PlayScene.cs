﻿

using Framework.Generality.Managers;
using Framework.Generality.OffSets;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Framework.Generality.Bases.GameScenes
{
    public class PlayScene : Scene
    {
        public PlayScene(ContentManager contents) :
            base(Constants.SCENE_PLAY,contents)
        {
        }

        public override bool Init()
        {
            _isInit = LoadContents();
            return _isInit;
        }
        public override void Shutdown()
        {
            _contents.Unload();
            _isInit = false;
        }
        public override void Draw(SpriteBatch sp)
        {
            sp.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, null);

            sp.End();
        }
        public override GameManager.GameState Update(float deltaTime)
        {
            return GameManager.GameState.None;
        }
        public override bool LoadContents() { return true; }


    }
}
