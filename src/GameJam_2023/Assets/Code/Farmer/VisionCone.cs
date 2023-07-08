using UnityEngine;

namespace Code
{
	[RequireComponent(typeof(Collider))]
	public class VisionCone : MonoBehaviour
	{
		private static Game Game => FindObjectOfType<Game>();
		
		// Colliding with only the pig
		private void OnTriggerEnter(Collider other) => Game.Loose();
	}
}