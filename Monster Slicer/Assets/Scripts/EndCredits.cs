using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
        resetGame();
    }

    // Update is called once per frame
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
        resetGame();
    }

    public void resetGame()
    {
        ScoreCount.scoreCount = 0;
        HumanSlicedCount.humanSlicedCount = 0;
        GameManager.endGame = false;
    }
}
