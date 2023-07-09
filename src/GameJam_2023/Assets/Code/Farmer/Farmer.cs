using UnityEngine;

namespace Code
{
	[SelectionBase]
	public class Farmer : MonoBehaviour
	{
		public bool IsInBarn { get; private set; }

		public void EnterBarn() => IsInBarn = true;
		public void LeaveBarn() => IsInBarn = false;
	}
}