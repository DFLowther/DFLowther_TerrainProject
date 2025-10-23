using UnityEngine;

public class StopWatch : MonoBehaviour
{
    public float timerTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
    }
}
