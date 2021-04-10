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
    }
    public void EndGame()
    {
        if(gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Game Over");
            GameObject.Find("EndText").GetComponent<Text>().enabled = true;
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
