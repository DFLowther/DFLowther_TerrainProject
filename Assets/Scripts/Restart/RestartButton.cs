using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public TMP_Text RestartConfirm;
    private bool hasCalledReload = false;



    void FixedUpdate()
    {

        if (Input.GetButton("Restart") && RestartConfirm.text == "Are you sure you want to restart?")
        {
            Debug.Log("Restart 2");

            if (!hasCalledReload)
            {
                hasCalledReload = true;

                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);
            }

            else if (Input.GetButton("Cancel"))
            {
                RestartConfirm.text = "";
            }
        }

        if (Input.GetButton("Restart"))
        {
            RestartConfirm.text = "Are you sure you want to restart?";

            Debug.Log("Restart 1");
            
            
        }
    }
}
