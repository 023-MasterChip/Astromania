using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject cam;
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Asteroid")
        {
            cam.GetComponent<screenShake>().TriggerShake();
            Debug.Log("Hit by asteroid");
            health--;
            Debug.Log("Health: " + health);
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
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
