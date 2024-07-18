using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int maxLevel = 0;
    public void LoadNextLevel()
    {
        int level = SceneManager.GetActiveScene().buildIndex;

        if (level< maxLevel)
        {
            SceneManager.LoadScene(level + 1);
        }
        else
        {
            SceneManager.LoadScene(level);
        }
        
    }
}
