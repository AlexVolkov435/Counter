using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _pause;

    private int _countCliked = 0;
    private bool _isSecondClick = false;
    private int _counter = 0;

    public event Action<float> Changen;

    public void StartCounter()
    {
        TaskOnClick();

        if (_countCliked % 2 == 0)
        {
            _isSecondClick = true;
        }
        else
        {
            _isSecondClick = false;
            StartCoroutine(Countdown(_pause));
        }
    }

    private void TaskOnClick()
    {
        _countCliked++;
    }

    private IEnumerator Countdown(float delay)
    {
        bool isPlayCounter = true;

        var wait = new WaitForSeconds(delay);

        while (isPlayCounter)
        {
            if (_isSecondClick == true)
            {
                yield break;
            }

            Changen?.Invoke(_counter);
            _counter++;

            yield return wait;
        }
    }
}