using UnityEngine;

namespace Code
{
	[RequireComponent(typeof(Collider))]
	public class BarnFloor : MonoBehaviour
	{
		private void OnTriggerEnter(Collider other)
		{
			if (other.TryGetComponent(out Farmer farmer))
			{
				farmer.EnterBarn();
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (other.TryGetComponent(out Farmer farmer))
			{
				farmer.LeaveBarn();
			}
		}
	}
}