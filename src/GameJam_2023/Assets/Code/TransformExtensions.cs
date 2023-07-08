using UnityEngine;

namespace Code
{
	public static class TransformExtensions
	{
		public static Vector3 Set(this Vector3 @this, Vector3 value)
		{
			@this.x = value.x;
			@this.y = value.y;
			@this.z = value.z;
			return @this;
		}

		public static Vector3 Set(this Vector3 @this, float x = float.NaN, float y = float.NaN, float z = float.NaN)
		{
			if (x is not float.NaN)
			{
				@this.x = x;
			}

			if (y is not float.NaN)
			{
				@this.y = y;
			}

			if (z is not float.NaN)
			{
				@this.z = z;
			}

			return @this;
		}
	}
}