using System;
using Terraria;
using Terraria.ModLoader;
using ModLibsCore.Libraries.Debug;
using ModLibsCamera.Classes.CameraAnimation;
using ModLibsCamera.Services.Camera;


namespace ModLibsCamera {
	/// @private
	class ModLibsCamera : ModPlayer {
		public override void ModifyScreenPosition() {
			if( !Main.gameMenu ) {
				CameraAnimationManager.Instance?.ApplyAnimations();
				Camera.Instance?.ApplyCameraEffects();
			}
		}
	}
}
