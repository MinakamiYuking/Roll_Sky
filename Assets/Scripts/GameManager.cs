using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject LevelCompleteUI;
    public float restartDelayTime = 2f;


    private bool gameHasEnded = false;

    public void Quit()
    {
        Application.Quit();
    }
    public void CompleteLevel()
    {
        LevelCompleteUI.SetActive(true);
    }
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game over!");
            gameHasEnded = true;
            Invoke("Restart", restartDelayTime);
        }
        
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
