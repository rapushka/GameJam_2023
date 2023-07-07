using UnityEngine;

namespace Code
{
	public class GameBootstrap : MonoBehaviour
	{
		private void Start()
		{
			var pigPrefab = Resources.Load("Pig/Pig");

			var pig = Instantiate(pigPrefab);
		}
	}
}