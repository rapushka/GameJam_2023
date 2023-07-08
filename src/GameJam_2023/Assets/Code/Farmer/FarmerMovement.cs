using UnityEngine;
using UnityEngine.AI;

namespace Code
{
	public class FarmerMovement : MonoBehaviour
	{
		[SerializeField] private NavMeshAgent _navMeshAgent;
		[SerializeField] private Vector3 _destination;

		private void Start()
		{
			_navMeshAgent.SetDestination(_destination);
		}
	}
}