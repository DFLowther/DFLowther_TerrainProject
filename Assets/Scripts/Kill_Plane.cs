using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Plane : MonoBehaviour
{
    public Transform player;
    public float heightOffset = 0;
    private bool hasCalledReload = false;

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;

        if (player.position.y < heightOffset + transform.position.y)
        {
            if(!hasCalledReload)
                {
                    hasCalledReload = true;

                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);
                }
        }
    }
}
