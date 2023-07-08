using System;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private int _maxValue;
    [SerializeField] private int _currentValue;
    [SerializeField] private Image _mask;

    public event Action Filled;

    private float FillAmount => (float)_currentValue / _maxValue;

    public void Increment(int value = 1)
    {
        _currentValue += value;
        UpdateFill();
    }

    public void Reset()
    {
        _currentValue = 0;
        UpdateFill();
    }

    private void Start() => UpdateFill();

    private void UpdateFill()
    {
        _mask.fillAmount = FillAmount;

        if (_currentValue >= _maxValue)
        {
            Filled?.Invoke();
        }
    }
}
