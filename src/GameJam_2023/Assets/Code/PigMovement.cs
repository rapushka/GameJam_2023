using UnityEngine;

namespace Code
{
	public class PigMovement : MonoBehaviour
	{
		[SerializeField] private CharacterController _characterController;
		[SerializeField] private float _movementSpeed;

		private Vector2 _movingDirection;

		private static float VerticalAxis => Input.GetAxis("Vertical");

		private static float HorizontalAxis => Input.GetAxis("Horizontal");

		private bool IsMoving => _movingDirection.magnitude > 0f;

		private float ScaledSpeed => _movementSpeed * Time.fixedDeltaTime;

		private Vector2 Movement => _movingDirection * ScaledSpeed;

		private void Update()
		{
			_movingDirection = new Vector2(HorizontalAxis, VerticalAxis);
		}

		private void FixedUpdate()
		{
			if (IsMoving)
			{
				Rotate();
				Move();
			}
		}

		private void Rotate() => transform.rotation = Quaternion.LookRotation(_movingDirection.ToTopDown());

		private void Move() => _characterController.Move(Movement.ToTopDown());
	}
}