using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public void CompleteLevel() 
    {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Game Over");
            
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
