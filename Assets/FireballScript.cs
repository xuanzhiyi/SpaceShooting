using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    float speed = 30f;

    public Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd.velocity = new Vector2(0, speed);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyScript enemy = hitInfo.GetComponent<EnemyScript>();
        if (enemy != null)
        {
            Debug.Log(hitInfo.name);
            enemy.Damage(10);
        }

        Destroy(gameObject);
    }
}
