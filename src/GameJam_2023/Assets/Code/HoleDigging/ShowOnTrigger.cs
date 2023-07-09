using UnityEngine;

namespace Code
{
    public class ShowOnTrigger : TriggerBase
    {
        [SerializeField] private GameObject _object;

        private bool ObjectEnabled { set => _object.SetActive(value); }

        protected override void Do() => ObjectEnabled = true;

        protected override void Undo() => ObjectEnabled = false;
    }
}
