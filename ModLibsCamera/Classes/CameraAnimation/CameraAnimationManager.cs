﻿using System;
using Terraria.ModLoader;
using ModLibsCore.Classes.Loadable;


namespace ModLibsCamera.Classes.CameraAnimation {
	class CameraAnimationManager : ILoadable {
		public static CameraAnimationManager Instance => ModContent.GetInstance<CameraAnimationManager>();



		////////////////

		internal CameraMover CurrentMover = null;

		internal CameraZoomer CurrentZoomer = null;

		internal CameraShaker CurrentShaker = null;



		////////////////

		void ILoadable.OnModsLoad() { }

		void ILoadable.OnModsUnload() { }

		void ILoadable.OnPostModsLoad() { }


		////////////////

		internal void ApplyAnimations() {
			this.CurrentMover?.Update();
			this.CurrentZoomer?.Update();
			this.CurrentShaker?.Update();
		}
	}
}
