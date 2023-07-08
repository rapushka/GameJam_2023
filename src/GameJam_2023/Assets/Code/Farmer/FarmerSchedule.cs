using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code
{
	public class FarmerSchedule : MonoBehaviour
	{
		[SerializeField] private List<FarmTask> _tasks;

		private int _currentTaskIndex;
		private float _remainedDuration;

		public event Action TaskCompleted;

		private bool TasksRemained => _currentTaskIndex >= _tasks.Count;

		private FarmTask CurrentTask => _tasks[_currentTaskIndex];

		private bool IsCurrentTaskCompleted => _remainedDuration <= 0f;

		private void Start() => StartTasksFromBegin();

		private void Update()
		{
			if (IsCurrentTaskCompleted)
			{
				SwitchToNextTask();
			}
			else
			{
				SpendTime();
			}
		}

		private void SpendTime() => _remainedDuration -= Time.deltaTime;

		private void StartTasksFromBegin()
		{
			_currentTaskIndex = 0;
			SwitchTask();
		}

		private void SwitchToNextTask()
		{
			_currentTaskIndex = TasksRemained ? _currentTaskIndex + 1 : 0;
			SwitchTask();
		}

		private void SwitchTask()
		{
			_remainedDuration = CurrentTask.Duration;
			TaskCompleted?.Invoke();
		}
	}
}