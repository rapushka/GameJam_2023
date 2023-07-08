using UnityEngine;

namespace Code
{
	public class Game : MonoBehaviour
	{
		[SerializeField] private Transform _pigSpawnPoint;
		[SerializeField] private SmoothCamera _camera;
		[SerializeField] private Pig _pigPrefab;

		private void Start()
		{
			var pig = Instantiate(_pigPrefab, _pigSpawnPoint.position, Quaternion.identity);
			_camera.Construct(pig.transform);
		}

		public void Loose()
		{
			Debug.Log("You lose");
			Time.timeScale = 0f;
		}
	}
}