using UnityEngine;
using SanAndreasUnity.Utilities;
using SanAndreasUnity.Importing.Animation;

namespace SanAndreasUnity.Behaviours.Peds.States
{
	
	public class StandAimState : BaseAimMovementState
	{
		public override AnimId aimWithArm_LowerAnim { get { return m_ped.CurrentWeapon.IdleAnim; } }


		public override void OnBecameActive ()
		{
			base.OnBecameActive ();
		//	m_ped.PlayerModel.PlayAnim (AnimGroup.MyWalkCycle, AnimIndex.GUN_STAND);
		}

	}

}