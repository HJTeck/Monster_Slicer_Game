using UnityEngine;
using UnityEngine.UI;

public class HumanSlicedCount : MonoBehaviour
{
    public static int humanSlicedCount;
    public Text humanCountText;

    // Update is called once per frame
    void Update()
    {
        humanCountText.text = humanSlicedCount.ToString("0");
    }
}
