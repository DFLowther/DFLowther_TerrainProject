using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{
    public int playerHealth = 0;
    public TMP_Text healthText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerHealth;
    }
}
