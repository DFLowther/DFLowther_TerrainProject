using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{
    public float timerTime = 0.0f;
    public TMP_Text timerText;

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;

        timerText.text = "Time: " + timerTime;
    }
}
