using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    private float leftRightMove;

    private float upDownMove;

    public Rigidbody2D ship;

    private float speed = 2f;

    private float health = 100;

    public HealthBarScript healthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftRightMove = Input.GetAxisRaw("Horizontal");

        upDownMove = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        ship.velocity = new Vector2(leftRightMove * speed, upDownMove * speed);
    }

    public void Damage(float hitpoint)
    {
        Debug.Log(health);
        health -= hitpoint;
        healthBar.SetSize(health / 100.0f);
        Die();
    }

    // Update is called once per frame
    void Die()
    {
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
