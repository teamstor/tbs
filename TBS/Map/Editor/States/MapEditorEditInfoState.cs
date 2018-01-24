﻿using Microsoft.Xna.Framework;
using TeamStor.Engine;
using TeamStor.Engine.Graphics;

namespace TeamStor.TBS.Map.Editor.States
{
	public class MapEditorEditInfoState : MapEditorModeState
	{
		public override bool PauseEditor
		{
			get { return true; }
		}

		public override void OnEnter(GameState previousState)
		{
		}

		public override void OnLeave(GameState nextState)
		{
		}

		public override void Update(double deltaTime, double totalTime, long count)
		{
		}

		public override void FixedUpdate(long count)
		{
		}

		public override void Draw(SpriteBatch batch, Vector2 screenSize)
		{
			batch.Rectangle(new Rectangle(0, 0, (int)screenSize.X, (int)screenSize.Y), Color.Black * 0.8f);
		}
	}
}