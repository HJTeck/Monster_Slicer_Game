using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int scoreCount;
    public Text scoreCountText;

    // Update is called once per frame
    void Update()
    {
        scoreCountText.text = scoreCount.ToString("0");
    }
}
