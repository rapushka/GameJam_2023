using UnityEngine;

namespace Code
{
    [RequireComponent(typeof(Collider))]
	public class Escsape : MonoBehaviour
    {
		private Pig _pig;

		private Pig Pig => _pig ??= Object.FindObjectOfType<Pig>();
		private static Game Game => Object.FindObjectOfType<Game>();

		private void OnTriggerEnter(Collider other)
		{
			if (Pig.Escaped)
			{
				Game.Win();
			}
		}
	}
}
