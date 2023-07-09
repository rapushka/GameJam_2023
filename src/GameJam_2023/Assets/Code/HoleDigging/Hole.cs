using UnityEngine;

namespace Code
{
    class Hole : BouncedTrigger
    {
        private Hole _other;
        private Pig _pig;

        public void Constract(Hole other) => _other = other;

        private KeyCode Key => KeyCode.E;

        private Pig Pig => _pig ??= FindObjectOfType<Pig>();

        protected override void BouncedUpdate()
        {
            if (Input.GetKeyDown(Key))
            {
                Teleport();
            }
        }

        private void Teleport() => Pig.transform.position = _other.transform.position;
    }
}
