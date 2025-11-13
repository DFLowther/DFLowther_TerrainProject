using UnityEngine;

public class SpeedDamage : MonoBehaviour
{
    public float currentSpeed = 0;
    public float maxHorizontalSpeed = 0;
    public float maxVerticalSpeed = 0;

    public HealthCounter hc;

    Vector3 lastPosition = Vector3.zero;


    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeed = (transform.position - lastPosition).magnitude;

        lastPosition = transform.position;


        Debug.Log("Your speed is: " + currentSpeed);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Health Loss");
        if (other.gameObject.tag == "Damage")
        {
            hc.playerHealth--;
        }
    }

}
