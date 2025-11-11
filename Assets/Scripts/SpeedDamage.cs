using UnityEngine;

public class SpeedDamage : MonoBehaviour
{
    public float currentSpeed = 0;
    public float lastSpeed = 0;
    Vector3 lastPosition = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeed = (transform.position - lastPosition).magnitude;

        lastPosition = transform.position;



        //Debug.Log("Your speed is: " + currentSpeed);

    }
}
