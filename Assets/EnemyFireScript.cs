using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireScript : MonoBehaviour
{
    

    public Rigidbody2D rd;

    // Start is called before the first frame update
    public void Fire(Vector2 speed)
    {
        rd.velocity = speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        ShipControl player = hitInfo.GetComponent<ShipControl>();
        if (player != null)
        {
            player.Damage(10);
        }

        Destroy(gameObject);
    }
}
