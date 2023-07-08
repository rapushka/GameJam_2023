using System;
using UnityEngine;

namespace Code
{
	public class SmoothCamera : MonoBehaviour
	{
		[SerializeField] private float _cameraSpeed = 5f;
		[SerializeField] private float _cameraBorder = 150f;
		[SerializeField] private Size _levelSizes;
		[SerializeField] private Vector3 _offset;

		private Transform _target;

		private Vector3 TargetPosition { get => _target.position; set => _target.position = value; }

		private Vector3 CameraPosition { get => transform.position; set => transform.position = value; }

		public void Construct(Transform target) => _target = target;

		private void Update()
		{
			var distanceToTarget = TargetPosition - CameraPosition;

			MoveToTarget(distanceToTarget);
			LimitInBounces();
		}

		private void LimitInBounces()
		{
			CameraPosition.Set
			(
				x: CameraPosition.x.Clamp(max: _levelSizes.Width),
				z: CameraPosition.y.Clamp(max: _levelSizes.Height)
			);
		}

		private void MoveToTarget(Vector3 distanceToTarget)
		{
			if (Mathf.Abs(distanceToTarget.x) > _cameraBorder)
			{
				CameraPosition.Set(x: _cameraSpeed * Mathf.Sign(distanceToTarget.x));
			}

			if (Mathf.Abs(distanceToTarget.y) > _cameraBorder)
			{
				CameraPosition.Set(y: _cameraSpeed * Mathf.Sign(distanceToTarget.y));
			}

			CameraPosition = TargetPosition + _offset;
		}
	}
}