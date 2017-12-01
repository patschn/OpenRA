#region Copyright & License Information
/*
<<<<<<< HEAD
 * Copyright 2007-2016 The OpenRA Developers (see AUTHORS)
=======
 * Copyright 2007-2017 The OpenRA Developers (see AUTHORS)
>>>>>>> upstream/master
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using OpenRA.Traits;

namespace OpenRA.Mods.Common.Traits.Render
{
	[Desc("Replaces the building animation when it rearms a unit.")]
<<<<<<< HEAD
	public class WithRearmAnimationInfo : ITraitInfo, Requires<WithSpriteBodyInfo>
=======
	public class WithRearmAnimationInfo : ConditionalTraitInfo, Requires<WithSpriteBodyInfo>
>>>>>>> upstream/master
	{
		[Desc("Sequence name to use")]
		[SequenceReference] public readonly string Sequence = "active";

<<<<<<< HEAD
		public readonly bool PauseOnLowPower = false;

		public object Create(ActorInitializer init) { return new WithRearmAnimation(init.Self, this); }
	}

	public class WithRearmAnimation : INotifyRearm, INotifyBuildComplete, INotifySold
	{
		readonly WithRearmAnimationInfo info;
=======
		public override object Create(ActorInitializer init) { return new WithRearmAnimation(init.Self, this); }
	}

	public class WithRearmAnimation : ConditionalTrait<WithRearmAnimationInfo>, INotifyRearm, INotifyBuildComplete, INotifySold
	{
>>>>>>> upstream/master
		readonly WithSpriteBody spriteBody;
		bool buildComplete;

		public WithRearmAnimation(Actor self, WithRearmAnimationInfo info)
<<<<<<< HEAD
		{
			this.info = info;
=======
			: base(info)
		{
>>>>>>> upstream/master
			spriteBody = self.TraitOrDefault<WithSpriteBody>();
		}

		void INotifyRearm.Rearming(Actor self, Actor target)
		{
<<<<<<< HEAD
			if (buildComplete && spriteBody != null && !(info.PauseOnLowPower && self.IsDisabled()))
				spriteBody.PlayCustomAnimation(self, info.Sequence, () => spriteBody.CancelCustomAnimation(self));
		}

		public void BuildingComplete(Actor self)
=======
			if (buildComplete && spriteBody != null && !IsTraitDisabled)
				spriteBody.PlayCustomAnimation(self, Info.Sequence, () => spriteBody.CancelCustomAnimation(self));
		}

		void INotifyBuildComplete.BuildingComplete(Actor self)
>>>>>>> upstream/master
		{
			buildComplete = true;
		}

<<<<<<< HEAD
		public void Selling(Actor self)
=======
		void INotifySold.Selling(Actor self)
>>>>>>> upstream/master
		{
			buildComplete = false;
		}

<<<<<<< HEAD
		public void Sold(Actor self) { }
=======
		void INotifySold.Sold(Actor self) { }
>>>>>>> upstream/master
	}
}