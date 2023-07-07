using UnityEngine;

namespace Code
{
	public static class RotationExtensions
	{
		public static void SlerpRotate(this Transform @this, Quaternion to, float withSpeed)
			=> @this.rotation = Quaternion.Slerp(@this.rotation, to, withSpeed);
	}
}