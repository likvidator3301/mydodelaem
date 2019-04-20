using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public string TargetTag = "Player";
    public int Damage = 1;

    private float time = 1f;
    private float timeout =1f;

    void OnTriggerStay2D(Collider2D collider)
    {
        if (time >= timeout && collider.gameObject.tag == TargetTag)
        {
            collider.gameObject.GetComponent<Health>().Change(-Damage);
            time = 0f;
        }

        time += Time.deltaTime;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        time = timeout;
    }
}
