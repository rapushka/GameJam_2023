using UnityEngine;

namespace Code
{
	public class PigMovement : MonoBehaviour
	{
		[SerializeField] private CharacterController _characterController;
		[SerializeField] private float _movementSpeed;
		[SerializeField] private float _rotationSpeed;

		private Vector2 _movingDirection;

		private static float VerticalAxis => Input.GetAxis("Vertical");

		private static float HorizontalAxis => Input.GetAxis("Horizontal");

		private bool IsMoving => _movingDirection.magnitude > 0f;

		private float ScaledSpeed => _movementSpeed * Time.fixedDeltaTime;

		private Vector2 Movement => _movingDirection * ScaledSpeed;

		private Vector3 LookDirection => _movingDirection.ToTopDown().normalized;

		private Quaternion TargetRotation => Quaternion.LookRotation(LookDirection, Vector3.up);

		private float ScaledRotation => Time.fixedDeltaTime * _rotationSpeed;

		private void Update() => _movingDirection = new Vector2(HorizontalAxis, VerticalAxis);

		private void FixedUpdate()
		{
			if (IsMoving)
			{
				Rotate();
				Move();
			}
		}

		private void Rotate() => transform.SlerpRotate(to: TargetRotation, withSpeed: ScaledRotation);

		private void Move() => _characterController.Move(Movement.ToTopDown());
	}
}