using UnityEngine;
using TMPro;

public class FinishLine : MonoBehaviour
{
    private bool finishLine = false;
    public float timerTime = 0.0f;
    public float finalTime = 0.0f;
    public TMP_Text timerText;

    void Start()
    {
        finishLine = false;
    }

    void Update()
    {
        timerTime += Time.deltaTime;
        if(finishLine = false)
        {
        timerText.text = "Time: " + timerTime;
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {

            finalTime = timerTime;
            timerText.text = finalTime.ToString();

            Debug.Log("You finished");

        }
        
    }

}
