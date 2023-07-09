using System;
using UnityEngine;

namespace Code
{
    [RequireComponent(typeof(Collider))]
    public abstract class TriggerBase : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other) => Do();


        private void OnTriggerExit(Collider other) => Undo();

        protected abstract void Do();

        protected abstract void Undo();

        private void OnDestroy() => Undo();
    }
}
