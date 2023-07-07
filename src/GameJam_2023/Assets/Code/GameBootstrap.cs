using UnityEngine;

namespace Code
{
	public class GameBootstrap : MonoBehaviour
	{
		[SerializeField] private Transform _pigSpawnPoint;
		[SerializeField] private Camera _camera;

		private void Start()
		{
			var pigPrefab = Resources.Load<GameObject>("Pig/Pig");

			var pig = Instantiate(pigPrefab, _pigSpawnPoint.position, Quaternion.identity);
			_camera.transform.SetParent(pig.transform);
		}
	}
}