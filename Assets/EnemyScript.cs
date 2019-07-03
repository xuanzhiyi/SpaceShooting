using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float health = 100;

    public HealthBarScript healthBar;

    // Start is called before the first frame update
    public void Damage(float hitpoint)
    {
        health -= hitpoint;
        healthBar.SetSize(health / 100.0f);
        Die();
    }

    // Update is called once per frame
    void Die()
    {
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
}
