﻿using System;
using Terraria;
using Terraria.ModLoader;
using ModLibsCore.Libraries.Debug;


namespace ModLibsCamera {
	/// @private
	partial class ModLibsCameraMod : Mod {
		public static ModLibsCameraMod Instance { get; private set; }



		////////////////

		public override void Load() {
			ModLibsCameraMod.Instance = this;
		}

		////

		public override void Unload() {
			try {
				LogLibraries.Alert( "Unloading mod..." );
			} catch { }

			ModLibsCameraMod.Instance = null;
		}
	}
}
