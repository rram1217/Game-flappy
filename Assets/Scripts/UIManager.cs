using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text pointText;
    public int points;
    public Text maxScoreText;
    private int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        maxScore = PlayerPrefs.GetInt("maxscore", 0);
        if(maxScoreText){
            maxScoreText.text = "Max Score: " + maxScore;
        }
        if(pointText)
            pointText.text = "0";
    }

    public void AddPoint()
    {
        points += 1;
        pointText.text = "" + points;
        if(maxScore < points)
        {
            maxScore = points;
            PlayerPrefs.SetInt("maxscore", points);        
            maxScoreText.text = "Max Score: " + maxScore;
        }

    }
}
