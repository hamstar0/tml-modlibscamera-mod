using System;
using Microsoft.Xna.Framework;
using ModLibsCore.Libraries.Debug;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ModLibsCamera.Commands {
	/// @private
	public class CameraLockCommand : ModCommand {
		/// @private
		public override CommandType Type => CommandType.Chat;

		/// @private
		public override string Command => "ml-cam-lock";
		/// @private
		public override string Usage => $"/{this.Command}";
		/// @private
		public override string Description => "Toggles camera position locking. Locks to the current position upon"
			+" command activation. Must be enabled by settings";


		////////////////

		public bool IsCameraLocked { get; private set; } = false;

		public Vector2 CameraPosition { get; private set; }



		////////////////

		/// @private
		public override void Action( CommandCaller caller, string input, string[] args ) {
			if( Main.netMode == NetmodeID.Server ) {
				LogLibraries.Warn( "Not supposed to run on server." );
				return;
			}

			var myconfig = ModLibsCameraConfig.Instance;
			if( !myconfig.CameraLockCommandEnabled ) {
				caller.Reply( "Camera locking disabled by mod settings.", Color.Yellow );
				return;
			}

			//

			var mycommand = ModContent.GetInstance<CameraLockCommand>();

			mycommand.IsCameraLocked = !mycommand.IsCameraLocked;

			if( mycommand.IsCameraLocked ) {
				this.CameraPosition = Main.screenPosition;
			}

			//

			string onStr = mycommand.IsCameraLocked ? "On" : "Off";
			caller.Reply( $"Camera lock {onStr}", Color.Lime );
		}
	}
}
