using System;

namespace Code
{
    public abstract class BouncedTrigger : TriggerBase
    {
        private bool InBounces;

        protected override void Do() => InBounces = true;

        protected override void Undo() => InBounces = false;

        private void Update()
        {
            if (InBounces)
            {
                BouncedUpdate();
            }
        }

        protected abstract void BouncedUpdate();
    }
}