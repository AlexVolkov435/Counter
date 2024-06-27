using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private float _pause;

    [SerializeField] private int _startValue;

    private int _countCliked = 0;

    public void StartCounter()
    {
        TaskOnClick();

        StartCoroutine(Countdown(_pause, _startValue));
        _startValue = int.Parse(_text.text);
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

            DisplayCountdown(i);

            yield return wait;
        }
    }

    private void DisplayCountdown(float count)
    {
        _text.text = count.ToString("");
    }
}