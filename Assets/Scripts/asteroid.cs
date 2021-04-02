using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asteroid : MonoBehaviour
{
    // Movement speed value
    public float maxThrust;
    // Rotation speed value
    public float maxTorque;

    public Rigidbody2D rb;

    // Camera bounds limit
    public float screenLeft;
    public float screenRight;
    public float screenTop;
    public float screenBottom;

    public GameObject player;
   
    // Score point
    public int point;

    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
         
        Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust)); // Random range of speed value  
        float torque = Random.Range(-maxTorque, maxTorque); // rotation
        rb.AddForce(thrust);
        rb.AddTorque(torque);
    }

    // Update is called once per frame
    void Update()
    {
        // Screen bounds calculation
        Vector2 newPos = transform.position;
        if (transform.position.y > screenTop)
        {
            newPos.y = screenBottom;
        }
        if (transform.position.y < screenBottom)
        {
            newPos.y = screenTop;
        }
        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }
        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }
        transform.position = newPos;
    }

    // trigger collision check
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy();
        }
    }

    // Object destroy and score passing
    void Destroy()
    {
        player.GetComponent<playerFollow>().ScorePoints(point);
        Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
