using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    
    public Text finalScoreText;
    public Text highscoreText;
    
    
    void Start()
    {
        
        UpdateScore();
        highscoreText.text = PlayerPrefs.GetInt("Highscore",0).ToString("0");

    }

    public void UpdateScore()
    {
                
        int finalScore = ScoreCount.scoreCount;
        finalScoreText.text = finalScore.ToString("0");
                
        if (finalScore > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore",finalScore);
            highscoreText.text = finalScore.ToString("0");
        } 
                  
    }

    public void Reset()
    {

        PlayerPrefs.DeleteKey("Highscore");
        highscoreText.text = "0";
        
    }
    
}
