using UnityEngine;
using UnityEngine.AI;

namespace Code
{
	public class FarmerMovement : MonoBehaviour
	{
		[SerializeField] private NavMeshAgent _navMeshAgent;
		[SerializeField] private FarmerSchedule _schedule;

		private void OnEnable()  => _schedule.TaskCompleted += GoToNextTask;
		private void OnDisable() => _schedule.TaskCompleted -= GoToNextTask;

		private void GoToNextTask()
		{
			_navMeshAgent.SetDestination(_schedule.CurrentTask.TargetPosition);
		}
	}
}