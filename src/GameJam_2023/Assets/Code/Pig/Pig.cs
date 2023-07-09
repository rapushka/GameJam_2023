using UnityEngine;

namespace Code
{
	[SelectionBase] 
	public class Pig : MonoBehaviour 
	{
		public bool Escaped { get; private set; }

		public void Escape() => Escaped = true;
	}
}