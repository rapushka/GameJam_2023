using UnityEngine;

namespace Code
{
	public class SmoothCamera : MonoBehaviour
	{
		[SerializeField] private float _cameraSpeed;
		[SerializeField] private Vector3 _offset;

		private Transform _target;

		private float ScaledSpeed => _cameraSpeed * Time.deltaTime;

		private Vector3 TargetPosition => _target.position + _offset;

		private Vector3 CameraPosition { get => transform.position; set => transform.position = value; }

		public void Construct(Transform target) => _target = target;

		private void FixedUpdate() => MoveToTarget();

		private void MoveToTarget()
		{
			CameraPosition = Vector3.Lerp(CameraPosition, TargetPosition, ScaledSpeed);
		}
	}
}