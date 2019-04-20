using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulsReaction : MonoBehaviour
{
    public float Count;

    void Start()
    {
        Count = new System.Random().Next(55, 1000);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<SoulsAcumulator>().AddSouls(Count);
            Destroy(gameObject);
        }
    }
}
