using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject cam;
    private int health;

    public GameObject H1;
    public GameObject H2;
    public GameObject H3;
    // Start is called before the first frame update
    void Start()
    {
        health = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 3)
        {
            Destroy(H3.gameObject);
        }
        if (health == 2)
        {
            Destroy(H2.gameObject);
        }
        if (health == 1)
        {
            Destroy(H1.gameObject);
        }
        if (health == 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }

    // Trigger collision check
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Asteroid collision check
        if(collision.tag=="Asteroid")
        {
            cam.GetComponent<screenShake>().TriggerShake();
            Debug.Log("Hit by asteroid");
            health--;
            Debug.Log("Health: " + health);
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        // Enemy collision check
        else if(collision.tag == "Enemy")
        {
            cam.GetComponent<screenShake>().TriggerShake();
            Debug.Log("Hit by Enemy");
            health--;
            Debug.Log("Health: " + health);
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
