using TMPro;
using UnityEngine;

public class Rendering : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.TextChangen += DisplayCountdown;
    }

    private void OnDisable()
    {
        _counter.TextChangen -= DisplayCountdown;
    }

    public void DisplayCountdown(float count)
    {
        _text.text = count.ToString("");
    }
}
