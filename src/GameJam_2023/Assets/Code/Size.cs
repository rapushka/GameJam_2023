using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public struct Size
	{
		[field: SerializeField] public float Width  { get; private set; }
		[field: SerializeField] public float Height { get; private set; }
	}
}