using UnityEngine;

namespace Code
{
	public static class VectorExtensions
	{
		public static Vector3 ToTopDown(this Vector2 @this) => new(x: @this.x, y: 0, z: @this.y);

		public static Vector2 FromTopDown(this Vector3 @this) => new(x: @this.x, y: @this.z);
	}
}