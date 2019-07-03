using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponFire : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    float numShots = 5f;
    float spreadAngle = 2.0f;
    Quaternion qAngle;
    Quaternion qDelta;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 0.5f);

        qAngle = Quaternion.AngleAxis(-numShots / 2.0f * spreadAngle, firepoint.up) * firepoint.rotation;
        qDelta = Quaternion.AngleAxis(spreadAngle, firepoint.up);
    }

    void Fire()
    {
        //Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);

        GameObject tmp = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        EnemyFireScript bullet = tmp.GetComponent<EnemyFireScript>();
        bullet.Fire(new Vector2(Random.Range(-2.0f, 2.0f), -1.5f));
        qAngle = qDelta * qAngle;
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        ShipControl player = hitInfo.GetComponent<ShipControl>();
        if (player != null)
        {
            player.Damage(20);
            Destroy(gameObject);
        }

    }
}
