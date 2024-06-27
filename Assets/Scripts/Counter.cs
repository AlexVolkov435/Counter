using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _pause;
    [SerializeField] private int _startValue;
    [SerializeField] private Rendering _rendering;

    private int _countCliked = 0;

    public void StartCounter()
    {
        TaskOnClick();

        StartCoroutine(Countdown(_pause, _startValue));
        _startValue = _rendering.SaveValue();
    }

    private void TaskOnClick()
    {
        _countCliked++;
    }

    private IEnumerator Countdown(float delay, int _startValue)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = _startValue; i <= 10; i++)
        {
            if (_countCliked % 2 == 0)
            {
                yield break;
            }

            _rendering.DisplayCountdown(i);

            yield return wait;
        }
    }
}