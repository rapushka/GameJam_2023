using UnityEngine;

namespace Code
{
	public class Game : MonoBehaviour
	{
		[SerializeField] private Transform _pigSpawnPoint;
		[SerializeField] private SmoothCamera _camera;

		private void Start()
		{
			var pigPrefab = Resources.Load<GameObject>("Pig/Pig");

			var pig = Instantiate(pigPrefab, _pigSpawnPoint.position, Quaternion.identity);
			_camera.Construct(pig.transform);
		}
	}
}