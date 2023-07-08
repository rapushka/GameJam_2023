using UnityEngine;

namespace Code
{
	public class SmoothCamera : MonoBehaviour
	{
		[SerializeField] private float _cameraSpeed = 5f;
		[SerializeField] private Size _levelSizes;
		[SerializeField] private Vector3 _offset;

		private Transform _target;

		private Vector3 TargetPosition { get => _target.position; set => _target.position = value; }

		private Vector3 CameraPosition { get => transform.position; set => transform.position = value; }

		public void Construct(Transform target) => _target = target;

		private void FixedUpdate()
		{
			MoveToTarget();
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

		private void MoveToTarget()
		{
			CameraPosition = Vector3.MoveTowards(CameraPosition, TargetPosition + _offset, _cameraSpeed * Time.deltaTime);
		}
	}
}