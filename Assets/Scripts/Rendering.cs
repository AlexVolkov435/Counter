using TMPro;
using UnityEngine;

public class Rendering : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.Changen += DisplayCountdown;
    }

    private void OnDisable()
    {
        _counter.Changen -= DisplayCountdown;
    }

    public void DisplayCountdown(float count)
    {
        _text.text = count.ToString("");
    }
}
