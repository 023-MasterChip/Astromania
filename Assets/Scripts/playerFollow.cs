using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerFollow : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; // Cursor disabled
        score = 0; // initial score value (!!!Dont change)
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // get mouse position
        transform.position = pos;
    }

    // Adding score 
    public void ScorePoints(int pointToAdd)
    {
        Debug.Log("Score added");
        score += pointToAdd;
        scoreText.text = "" + score;
        scoreText.text = score.ToString();//highscore
        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
            //nthekyo chyth last ayiii,player prf to store
            highscore.text = score.ToString();
        }
    }
}
