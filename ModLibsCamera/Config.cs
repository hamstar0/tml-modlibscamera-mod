using System;
using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using ModLibsCore.Libraries.Debug;


namespace ModLibsCamera {
	/// @private
	class ModLibsCameraConfig : ModConfig {
		public static ModLibsCameraConfig Instance => ModContent.GetInstance<ModLibsCameraConfig>();



		////////////////

		public override ConfigScope Mode => ConfigScope.ServerSide;



		////

		//[DefaultValue( true )]
		public bool CameraLockCommandEnabled { get; set; } = false;
	}
}
