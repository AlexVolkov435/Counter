using TMPro;
using UnityEngine;

public class Rendering : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void DisplayCountdown(float count)
    {
        _text.text = count.ToString("");
    }

    public int SaveValue()
    {
       return int.Parse(_text.text);
    }
}
