using UnityEngine;

namespace Code
{
    [RequireComponent(typeof(Collider))]
    public class Gate : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Pig pig))
            {
                pig.Escape();
            }
        }
    }
}
