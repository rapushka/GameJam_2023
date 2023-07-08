using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class FarmTask
	{
		[field: SerializeField] public float Duration { get; private set; }
		[SerializeField] private Transform _targetTransform;

		public Vector3 TargetPosition => _targetTransform.position;
	}
}