using System.Collections.Generic;

namespace Code
{
	public static class IndexExtensions
	{
		public static bool IsInRange<T>(this List<T> @this, int index)
			=> index < @this.Count - 1;
	}
}