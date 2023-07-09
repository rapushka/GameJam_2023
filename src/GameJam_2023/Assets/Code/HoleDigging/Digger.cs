using UnityEngine;

namespace Code
{
    public class Digger : BouncedTrigger
    {
        [SerializeField] private float _durationToDig;
        [SerializeField] private ProgressBar _progressBar;
        [SerializeField] private Transform _positionForHoleOutside;

        private float _holdingDuration = 0;
        private KeyCode Key => KeyCode.E;

        public bool IsHeld => _holdingDuration >= _durationToDig;

        protected override void BouncedUpdate()
        {
            CalculateHoldingDuration();
            if (IsHeld)
            {
                DigHole();
            }
        }

        private void CalculateHoldingDuration()
        {
            if (Input.GetKey(Key))
            {
                _holdingDuration += Time.deltaTime;
                _progressBar.Increment();
            }
            else
            {
                ResetHoldingDuration();
                _progressBar.Reset();
            }
        }

        private void ResetHoldingDuration() => _holdingDuration = 0f;

        private void DigHole()
        {
            var holePrefab = Resources.Load<Hole>("Hole/Hole");
            var holeInner = Instantiate(holePrefab, transform.position, Quaternion.identity);
            var holeOuter = Instantiate(holePrefab, _positionForHoleOutside.position, Quaternion.identity);

            holeInner.Constract(holeOuter);
            holeOuter.Constract(holeInner);

            Destroy(gameObject);
        }
    }
}
