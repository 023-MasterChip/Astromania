using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerFollow : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
    public void ScorePoints(int pointToAdd)
    {
        Debug.Log("Score added");
        score += pointToAdd;
        scoreText.text = "" + score;
    }
}
