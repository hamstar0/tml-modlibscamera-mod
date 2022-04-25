using System;
using Terraria;
using Terraria.ModLoader;
using ModLibsCore.Libraries.Debug;
using ModLibsCamera.Commands;
using ModLibsCamera.Classes.CameraAnimation;
using ModLibsCamera.Services.Camera;


namespace ModLibsCamera {
	/// @private
	class ModLibsCamera : ModPlayer {
		public override void ModifyScreenPosition() {
			if( Main.gameMenu ) {
				return;
			}

			//

			var lockCamCmd = ModContent.GetInstance<CameraLockCommand>();

			if( lockCamCmd.IsCameraLocked ) {
				Main.screenPosition = lockCamCmd.CameraPosition;

				return;
			}

			//

			CameraAnimationManager.Instance?.ApplyAnimations();
			Camera.Instance?.ApplyCameraEffects();
		}
	}
}
