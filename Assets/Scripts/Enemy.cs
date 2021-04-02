using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f; // speed value

    private Rigidbody2D rb;
    private Vector2 movement;

    public int point;
    private GameObject pl;  // Player gameObject
    public ParticleSystem ps; // Particle system gameObject

    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.Find("Player");
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position; // Objective position calculation
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Rotation towards objective
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    // trigger collision check
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy();
        }
    }

    // Object destroy and score passing
    void Destroy()
    {
        pl.GetComponent<playerFollow>().ScorePoints(point);
        Instantiate(ps, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
