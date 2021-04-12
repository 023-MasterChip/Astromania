using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public bool gameEnd = false;
    public float delay = 1f;


    void Start()
    {
        GameObject.Find("EndText").GetComponent<Text>().enabled = false;
        GameObject.Find("endScoretxt").GetComponent<Text>().enabled = false;
        GameObject.Find("endScore").GetComponent<Text>().enabled = false;
        GameObject.Find("Highscoretxt").GetComponent<Text>().enabled = false;
        GameObject.Find("endhigh").GetComponent<Text>().enabled = false;
        GameObject.Find("Score").GetComponent<Text>().enabled = true;
        GameObject.Find("highscore").GetComponent<Text>().enabled = true;
    }
    public void EndGame()
    {
        if(gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Game Over");
            GameObject.Find("EndText").GetComponent<Text>().enabled = true;
            GameObject.Find("endScoretxt").GetComponent<Text>().enabled = true;
            GameObject.Find("endScore").GetComponent<Text>().enabled = true;
            GameObject.Find("Highscoretxt").GetComponent<Text>().enabled = true;
            GameObject.Find("endhigh").GetComponent<Text>().enabled = true;
            GameObject.Find("Score").GetComponent<Text>().enabled = false;
            GameObject.Find("highscore").GetComponent<Text>().enabled = false;
        }
    }

    private void Update()
    {
        if(gameEnd == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Invoke("Restart", delay);
            }
        }
        

        //if (Input.GetKey(KeyCode.Escape))
        //{
        //    menu();
        //}
    }

    void Restart()
    {
            SceneManager.LoadScene("GameScreen");
    }

    void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
