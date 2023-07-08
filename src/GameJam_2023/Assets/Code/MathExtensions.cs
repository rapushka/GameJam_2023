using UnityEngine;

namespace Code
{
	public static class MathExtensions
	{
		public static float Clamp(this float @this, float min = float.NaN, float max = float.NaN)
		{
			if (min is not float.NaN)
			{
				@this = Mathf.Max(@this, min);
			}

			if (max is not float.NaN)
			{
				@this = Mathf.Min(@this, max);
			}

			return @this;
		}
	}
}