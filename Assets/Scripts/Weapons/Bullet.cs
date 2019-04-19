using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Damage = 100f;
    public string TargetTag = "Enemy";

    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.collider.gameObject.tag == TargetTag)
            collision.collider.gameObject.GetComponent<Health>().Change(-Damage);
        Destroy(gameObject);
    }

}
