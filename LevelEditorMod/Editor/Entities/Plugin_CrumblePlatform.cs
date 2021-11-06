﻿using Celeste;
using Microsoft.Xna.Framework;
using Monocle;
using System;

namespace LevelEditorMod.Editor.Entities {
    [Plugin("crumbleBlock")]
    public class Plugin_CrumblePlatform : Entity {

        public override void Render() {
            base.Render();

			// TODO: custom textures
			MTexture mTexture2 = GFX.Game["objects/crumbleBlock/" + AreaData.Get(Room.Map.From).CrumbleBlock];
                

			for(int j = 0; (float)j < Width; j += 8) {
				int num2 = (int)((Math.Abs(X) + (float)j) / 8f) % 4;
				mTexture2.GetSubtexture(num2 * 8, 0, 8, 8).DrawCentered(new Vector2(4 + j + X, 4f + Y));
			}
		}

		public override void ApplyDefaults() {
			base.ChangeDefault();
			SetWidth(16);
			SetHeight(8);
		}
	}
}
