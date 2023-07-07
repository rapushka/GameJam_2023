using UnityEngine;

namespace Code
{
	public class GameBootstrap : MonoBehaviour
	{
		[SerializeField] private Transform _pigSpawnPoint;

		private void Start()
		{
			var pigPrefab = Resources.Load("Pig/Pig");

			var pig = Instantiate(pigPrefab, _pigSpawnPoint.position, Quaternion.identity);
		}
	}
}