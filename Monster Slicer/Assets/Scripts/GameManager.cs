using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static int humanSlicedLimit = 3;
    public static bool endGame = false;
    public GameObject gameOverUI;

    void Update()
    {

        if (HumanSlicedCount.humanSlicedCount >= humanSlicedLimit)
        {
            endGame = true;
            gameOver();
        }
        
    }

    void gameOver()
    {
        gameOverUI.SetActive(true);
    }

}
