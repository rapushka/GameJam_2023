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
		private Vector3 _cameraPosition;
		private Vector3 _targetPosition;

		public void Construct(Transform target) => _target = target;

		private void Start()
		{
			_cameraPosition = transform.position;
			_targetPosition = _cameraPosition;
		}

		private void Update()
		{
			_targetPosition = _target.transform.position + _offset;
			var distanceToTarget = _targetPosition - _cameraPosition;

			MoveToTarget(distanceToTarget);
			LimitInBounces();
			UpdatePosition();
		}

		private void UpdatePosition() { transform.position = _cameraPosition; }

		private void LimitInBounces()
		{
			_cameraPosition.x = Mathf.Clamp(_cameraPosition.x, 0, _levelSizes.Width);
			_cameraPosition.y = Mathf.Clamp(_cameraPosition.y, 0, _levelSizes.Height);
		}

		private void MoveToTarget(Vector3 distanceToTarget)
		{
			if (Mathf.Abs(distanceToTarget.x) > _cameraBorder)
			{
				_cameraPosition.x += _cameraSpeed * Mathf.Sign(distanceToTarget.x);
			}

			if (Mathf.Abs(distanceToTarget.y) > _cameraBorder)
			{
				_cameraPosition.y += _cameraSpeed * Mathf.Sign(distanceToTarget.y);
			}
		}
	}
}