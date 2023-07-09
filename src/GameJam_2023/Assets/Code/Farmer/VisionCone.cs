using UnityEngine;

namespace Code
{
	[RequireComponent(typeof(Collider))]
	public class VisionCone : MonoBehaviour
	{
		[SerializeField] private Farmer _farmer;

		private static Game Game => FindObjectOfType<Game>();

		// Colliding with only the pig
		private void OnTriggerEnter(Collider other)
		{
			if (_farmer.IsInBarn == false)
			{
				Game.Lose();
			}
		}
	}
}