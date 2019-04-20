using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainsaw : MonoBehaviour
{
    public float Damage = 100f;
    public string TargetTag = "Enemy";

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == TargetTag)
            collision.gameObject.GetComponent<Health>().Change(-Damage);
    }
}
