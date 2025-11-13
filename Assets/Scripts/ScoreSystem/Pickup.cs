using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [HideInInspector]
    public ScoreManager scoreManager;
    [HideInInspector]
    public GameObject player;

    public int value;

    public AudioClip collect;
    AudioSource audioSource;

    public HealthCounter hc;

    void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreManager = player.GetComponent<ScoreManager>();

        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(collect, 0.7f);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "SpeedBoost")
        {
            scoreManager.AddPoints(value);
            Destroy(col.gameObject);
            hc.playerHealth += 1;
        }

        else if (col.gameObject.tag == "Damage")
        {
            hc.playerHealth--;
        }
    }
}
